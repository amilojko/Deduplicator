using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Data.Sql;


namespace Deduplicator
{
   public partial class Main : Form
   {
      const string DB_NAME = "Deduplicator.sdf";
      const string DB_PASSWORD = "duplications";
      const string PROGRAM_NAME = "Deduplicator";
      Guid guidSession = Guid.NewGuid();
      public string strPattern;

      public Main()
      {
         InitializeComponent();
         this.Text = PROGRAM_NAME;
      }

      private void btnLocation_Click(object sender, EventArgs e)
      {
         FolderBrowserDialog folder = new FolderBrowserDialog();
         folder.Description = "Selection Starting Location";
         folder.ShowNewFolderButton = false;         
         folder.ShowDialog();
         if ((folder.SelectedPath != null) && (folder.SelectedPath.Length > 1))
         {
            txtLocation.Text = folder.SelectedPath;
         }
      }

      private void btnList_Click(object sender, EventArgs e)
      {
         Cursor.Current = Cursors.WaitCursor;
         //if (cboFileTypes.Text.Length > 2)
         //{
         //   int FirstBrace = cboFileTypes.Text.IndexOf("(");
         //   int SecondBrace = cboFileTypes.Text.LastIndexOf(")") - 1;
         //   string fileType = cboFileTypes.Text.Substring(FirstBrace+1, SecondBrace - FirstBrace);
         //   strPattern = fileType;
         //  // MessageBox.Show(fileType);
         //   //return;
         //}
         //else
         //{
         //   MessageBox.Show("Please select file type");
         //   return;
         //}

         StatusUpdate("Please Wait...");
         string strLocation = txtLocation.Text.Trim();

         if (strLocation.Length <= 3)
         {
            MessageBox.Show("Invalid Starting Location!", PROGRAM_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            StatusUpdate("Invalid Starting Location!");
            return;
         }
         if (txtDescription.Text.Length <= 2)
         {
            MessageBox.Show("Invalid Short Description!", PROGRAM_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            StatusUpdate("Invalid Short Description!");
            return;
         }

         string connStr = "Data Source=" + DB_NAME + ";Password=" + DB_PASSWORD;
         SqlCeConnection conn = new SqlCeConnection(connStr);
         conn.Open();
         

         // Lets add information for this Session into the session table
         guidSession = Guid.NewGuid();
         SqlCeCommand cmd = conn.CreateCommand();
         cmd.CommandText = "INSERT INTO Sessions (SessionDate, SessionID, Location, Description) VALUES ('" + DateTime.Today.ToShortDateString() + "','" + guidSession + "','" + strLocation + "','" + txtDescription.Text.Trim() + "')";
         cmd.ExecuteNonQuery();
         GetAllFiles(strLocation, conn);
         conn.Close();
         cmd.Dispose();
         StatusUpdate("Complete");
         Cursor.Current = Cursors.Default;
         
         
      }


      private void CreateDatabase()
      {
         string connStr = "Data Source=" + DB_NAME + ";Password="+DB_PASSWORD;
         try
         {
            SqlCeEngine engine = new SqlCeEngine(connStr);
            engine.CreateDatabase();
            SqlCeConnection conn = new SqlCeConnection(connStr);
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "CREATE TABLE FileInfo(FileID int identity PRIMARY KEY, Exclude bit not null default '0', FileName nvarchar(2000), FileLocation nvarchar(2000), SessionID nchar(36), SessionDate datetime, DateAdded datetime default GetDate())";            
            cmd.ExecuteNonQuery();
            cmd.CommandText = "CREATE TABLE Exclusions(ExclusionID int identity PRIMARY KEY, FileName nvarchar(300), SessionID nchar(36), SessionDate datetime, DateAdded datetime default GetDate())";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "CREATE TABLE ErrorLog(ErrorID int identity PRIMARY KEY, ErrorMessage nvarchar(1000), SessionID nchar(36), SessionDate datetime, DateAdded datetime default GetDate())";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "CREATE TABLE Sessions(ID int identity PRIMARY KEY, SessionID nchar(36), Location nvarchar(1000), Description nvarchar(200), SessionDate datetime, DateAdded datetime default GetDate())";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
         }
         catch (SqlCeException ex)
         {
            MessageBox.Show(ex.Message);
         }         
      }

      private void Main_Load(object sender, EventArgs e)
      {
         StatusUpdate("Welcome To Deduplicator");
         if (!File.Exists(DB_NAME))
         {
            CreateDatabase();
         }
      }

      private void StatusUpdate(string strMessage)
      {
         if (strMessage.Length > 0)
         {
            StatusLabel.Text = strMessage;
         }
      }

      private void GetAllFiles(string strLocation, SqlCeConnection objConn)
      {
         SqlCeCommand cmd = objConn.CreateCommand();

         try
         {
            string[] files = Directory.GetFileSystemEntries(strLocation, "*", SearchOption.TopDirectoryOnly);


            foreach (string file in files)
            {
               if (Directory.Exists(file))
               {
                  GetAllFiles(file, objConn);
               }
               else
               {
                  try
                  {
                     cmd.CommandText = "INSERT INTO FileInfo ([FileName], [FileLocation], [SessionID], [SessionDate]) VALUES ('" + Path.GetFileName(file).Replace("'", "''") + "','" + Path.GetDirectoryName(file).Replace("'", "''") + "','" + guidSession + "','" + DateTime.Today.ToShortDateString() + "')";
                     cmd.ExecuteNonQuery();                     
                     // StatusUpdate("Added " + file + "\\" + strLocation);
                  }
                  catch (Exception ex)
                  {
                     cmd.CommandText = "INSERT INTO ErrorLog (ErrorMessage, SessionID, SessionDate) VALUES ('" + ex.Message + " " + Path.GetFileName(file).Replace("'", "''") + "','" + guidSession + "','" + DateTime.Today.ToShortDateString() + "')";
                     cmd.ExecuteNonQuery();                     
                     continue;
                  }
               }
            }
            cmd.Dispose();
         }
         catch (System.Security.SecurityException ex)
         {
            cmd.CommandText = "INSERT INTO ErrorLog (ErrorMessage, SessionID, SessionDate) VALUES ('" + ex.Message.Replace("'", "''") + "','" + guidSession + "','" + DateTime.Today.ToShortDateString() + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
         }

         catch (UnauthorizedAccessException ex)
         {
            cmd.CommandText = "INSERT INTO ErrorLog (ErrorMessage, SessionID, SessionDate) VALUES ('" + ex.Message.Replace("'", "''") + strLocation.Replace("'","''") + "','" + guidSession + "','" + DateTime.Today.ToShortDateString() + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();

         }

      }
      
      private void clearPreviousResultsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         DialogResult result = MessageBox.Show("Are you sure you want to clear all previous searches?", PROGRAM_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
         if (result == DialogResult.Yes)
         {
            string connStr = "Data Source=" + DB_NAME + ";Password=" + DB_PASSWORD;
            SqlCeConnection conn = new SqlCeConnection(connStr);
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM FileInfo";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE FROM Sessions";
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
            cboResults.DataSource = null ;
            StatusUpdate("Cleared All Previous Results");
         }
      }

      private void clearExclusionFileToolStripMenuItem_Click(object sender, EventArgs e)
      {
         DialogResult result = MessageBox.Show("Are you sure you want to clear all previous searches?", PROGRAM_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
         if (result == DialogResult.Yes)
         {
            string connStr = "Data Source=" + DB_NAME + ";Password=" + DB_PASSWORD;
            SqlCeConnection conn = new SqlCeConnection(connStr);
            conn.Open();
            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Exclusions";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
         }


      }

      
      private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
      {
         About frm = new About();
         frm.ShowDialog();
      }

      private void exitToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Environment.Exit(Environment.ExitCode);
      }

      private void Main_FormClosing(object sender, FormClosingEventArgs e)
      {
         //Environment.Exit(Environment.ExitCode);
         Application.Exit();
      }

   

      private void cboResults_Enter(object sender, EventArgs e)
      {


         //string connStr = "Data Source=" + DB_NAME + ";Password=" + DB_PASSWORD;
         //SqlCeConnection conn = new SqlCeConnection(connStr);
         //conn.Open();
         //SqlCeCommand cmd = conn.CreateCommand();
         //cmd.CommandText = "SELECT SessionID, Description + ' : ' + SessionDate As Session FROM Sessions ORDER BY Description";
         //SqlCeDataReader dr = cmd.ExecuteReader();
         //while (dr.Read())
         //{

         //   string[] items = { dr["SessionID"].ToString(), dr["Session"].ToString()};
         //   cboResults.Items.Add(items);
         //}

         //conn.Close();
         //cmd.Dispose();
         //dr.Dispose();

      }

      private void cboResults_MouseDown(object sender, MouseEventArgs e)
      {
         string connStr = "Data Source=" + DB_NAME + ";Password=" + DB_PASSWORD;
         SqlCeConnection conn = new SqlCeConnection(connStr);
         conn.Open();
         SqlCeCommand cmd = conn.CreateCommand();
         cmd.CommandText = "SELECT SessionID, Description FROM Sessions ORDER BY Description";
         SqlCeDataReader dr = cmd.ExecuteReader();
         //cboResults.Items.Clear();
         DataColumn col1 = new DataColumn("SessionID");
         DataColumn col2 = new DataColumn("Description");
         DataTable dt = new DataTable();
         dt.Columns.Add(col1);
         dt.Columns.Add(col2);
         while (dr.Read())
         {

            dt.Rows.Add(dr["SessionID"].ToString(), dr["Description"].ToString());
           // string[] items = new string[] { Value = dr["SessionID"].ToString(), Text = dr["Description"].ToString() };
           //  cboResults.Items.Add(dr["SessionID"].ToString(), dr["Description"].ToString());
         }
         cboResults.DataSource = dt;
         cboResults.DisplayMember = "Description";
         cboResults.ValueMember = "SessionID";

         conn.Close();
         cmd.Dispose();
         dr.Dispose();


      }

      private void btnResults_Click(object sender, EventArgs e)
      {
         if (cboResults.Text.Trim().Length <= 2) 
         {
            MessageBox.Show("Please select result", PROGRAM_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

         }
         Cursor.Current = Cursors.WaitCursor;
         Results frm = new Results(cboResults.SelectedValue.ToString().Trim());
         frm.ShowDialog();         
         Cursor.Current = Cursors.Default;        
      }

      private void newToolStripMenuItem_Click(object sender, EventArgs e)
      {
         txtDescription.Text = "";
         txtLocation.Text = "";

      }

    

   }
}
