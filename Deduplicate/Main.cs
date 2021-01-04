using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Deduplicate
{
   public partial class Main : Form
   {
      public static string ConnectionString = @$"Data Source={Environment.CurrentDirectory}\{DB_NAME}";
      const string DB_NAME = "Deduplicator.db";
      const string PROGRAM_NAME = "Deduplicator";
      Guid guidSession = Guid.NewGuid();
      public string strPattern;

      public Main()
      {
         InitializeComponent();
         this.Text = PROGRAM_NAME;
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

      private void CreateDatabase()
      {
         SQLiteConnection.CreateFile(DB_NAME);
         try
         {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
               connection.Open();

               SQLiteCommand command = connection.CreateCommand();
               command.CommandText = "CREATE TABLE FileInfo(FileID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, Exclude INTEGER not null default '0', FileName TEXT, FileLocation TEXT, SessionID TEXT, SessionDate TEXT, DateAdded DATETIME DEFAULT CURRENT_TIMESTAMP)";
               command.ExecuteNonQuery();
               command.CommandText = "CREATE TABLE Exclusions(ExclusionID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, FileName TEXT, SessionID TEXT, SessionDate TEXT, DateAdded DATETIME DEFAULT CURRENT_TIMESTAMP)";
               command.ExecuteNonQuery();
               command.CommandText = "CREATE TABLE ErrorLog(ErrorID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, ErrorMessage TEXT, SessionID TEXT, SessionDate TEXT, DateAdded DATETIME DEFAULT CURRENT_TIMESTAMP)";
               command.ExecuteNonQuery();
               command.CommandText = "CREATE TABLE Sessions(ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, SessionID TEXT, Location TEXT, Description TEXT, SessionDate TEXT, DateAdded DATETIME DEFAULT CURRENT_TIMESTAMP)";
               command.ExecuteNonQuery();
               command.Dispose();
            }
           
         }
         catch (SQLiteException ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void btnBrowse_Click(object sender, EventArgs e)
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

      private void btnGo_Click(object sender, EventArgs e)
      {
         Cursor.Current = Cursors.WaitCursor;
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

         // Lets add information for this Session into the session table    
         using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
         {
            SQLiteCommand command = connection.CreateCommand();
            SQLiteTransaction tranny = null;          

            try
            {
               connection.Open();
               tranny = connection.BeginTransaction();
               guidSession = Guid.NewGuid();
               command.CommandText = "INSERT INTO Sessions (SessionDate, SessionID, Location, Description) VALUES ('" + DateTime.Today.ToShortDateString() + "','" + guidSession + "','" + strLocation + "','" + txtDescription.Text.Trim() + "')";
               command.ExecuteNonQuery();
               tranny.Commit();
            }
            catch (SQLiteException ex)
            {
               MessageBox.Show(ex.Message);
            }

            finally
            {
               command.Dispose();
            }            
         }  
         
         using (SQLiteConnection connection1 = new SQLiteConnection(ConnectionString))
         {
            connection1.Open();
            GetAllFiles(strLocation, connection1);
         }
         
         
         StatusUpdate("Complete");
         Cursor.Current = Cursors.Default;

      }

      private void GetAllFiles(string strLocation, SQLiteConnection objConn)
      {
         SQLiteCommand cmd = objConn.CreateCommand();

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
                     SQLiteTransaction tranny = null;
                     tranny = objConn.BeginTransaction();
                     cmd.CommandText = "INSERT INTO FileInfo ([FileName], [FileLocation], [SessionID], [SessionDate]) VALUES ('" + Path.GetFileName(file).Replace("'", "''") + "','" + Path.GetDirectoryName(file).Replace("'", "''") + "','" + guidSession + "','" + DateTime.Today.ToShortDateString() + "')";
                     cmd.ExecuteNonQuery();
                     tranny.Commit();
                  }
                  catch (Exception ex)
                  {
                     SQLiteTransaction err_tranny = null;
                     err_tranny = objConn.BeginTransaction();
                     cmd.CommandText = "INSERT INTO ErrorLog (ErrorMessage, SessionID, SessionDate) VALUES ('" + ex.Message + " " + Path.GetFileName(file).Replace("'", "''") + "','" + guidSession + "','" + DateTime.Today.ToShortDateString() + "')";
                     cmd.ExecuteNonQuery();
                     err_tranny.Commit();
                     continue;
                  }
               }
            }
            cmd.Dispose();
         }
         catch (Exception ex)
         {
            SQLiteTransaction err_tranny = null;
            err_tranny = objConn.BeginTransaction();
            cmd.CommandText = "INSERT INTO ErrorLog (ErrorMessage, SessionID, SessionDate) VALUES ('" + ex.Message.Replace("'", "''") + "','" + guidSession + "','" + DateTime.Today.ToShortDateString() + "')";
            cmd.ExecuteNonQuery();
            err_tranny.Commit();
            cmd.Dispose();
         }
      }

      private void cboResult_MouseDown(object sender, MouseEventArgs e)
      {

         using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
         {
            connection.Open();
            SQLiteCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT SessionID, Description FROM Sessions ORDER BY Description";
            SQLiteDataReader dr = cmd.ExecuteReader();
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
            cboResult.DataSource = dt;
            cboResult.DisplayMember = "Description";
            cboResult.ValueMember = "SessionID";
         }
      }

      private void btnOpen_Click(object sender, EventArgs e)
      {
         if (cboResult.Text.Trim().Length <= 2)
         {
            MessageBox.Show("Please select result", PROGRAM_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;

         }
         Cursor.Current = Cursors.WaitCursor;
         Results frm = new Results(cboResult.SelectedValue.ToString().Trim());
         frm.ShowDialog();
         Cursor.Current = Cursors.Default;
      }

      private void toolStripMenuItemEXIT_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void toolStripMenuItemCLEAREX_Click(object sender, EventArgs e)
      {
         DialogResult result = MessageBox.Show("Are you sure you want to clear all previous searches?", PROGRAM_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
         if (result == DialogResult.Yes)
         {
            SQLiteConnection conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            SQLiteTransaction transaction = conn.BeginTransaction();
            //cmd.CommandText = "DELETE FROM Exclusions";
            cmd.CommandText = "UPDATE FileInfo SET Exclude=0";
            cmd.ExecuteNonQuery();
            transaction.Commit();
            cmd.Dispose();
            conn.Close();
         }
      }

      private void toolStripMenuItemCLEARPREVIOUS_Click(object sender, EventArgs e)
      {
         DialogResult result = MessageBox.Show("Are you sure you want to clear all previous searches?", PROGRAM_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
         if (result == DialogResult.Yes)
         {            
            SQLiteConnection conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            SQLiteTransaction transaction = conn.BeginTransaction();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM FileInfo";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE FROM Sessions";
            cmd.ExecuteNonQuery();
            transaction.Commit();
            conn.Close();
            cmd.Dispose();
            cboResult.DataSource = null;
            StatusUpdate("Cleared All Previous Results");
         }
      }

      private void toolStripMenuItemNEW_Click(object sender, EventArgs e)
      {
         txtDescription.Text = "";
         txtLocation.Text = "";
      }
   }
}
