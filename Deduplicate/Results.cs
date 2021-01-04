using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;

namespace Deduplicate
{
   public partial class Results : Form
   {
      public static string ConnectionString = @$"Data Source={Environment.CurrentDirectory}\{DB_NAME}";
      const string DB_NAME = "Deduplicator.db";      
      const string PROGRAM_NAME = "Deduplicator";
      private string _SessionID;
      public string strPattern;

      public Results(string SessionID)
      {
         InitializeComponent();
         this.Text = PROGRAM_NAME + " " + "Results";
         _SessionID = SessionID;
      }

      private void Results_Load(object sender, EventArgs e)
      {
         if (_SessionID.Length != 36)
         {
            MessageBox.Show("Invalid SessionID", PROGRAM_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         
         SQLiteConnection conn = new SQLiteConnection(ConnectionString);
         conn.Open();
         SQLiteCommand cmd = conn.CreateCommand();
         SQLiteCommand subcmd = conn.CreateCommand();
         cmd.CommandText = "SELECT Count(FileID) As Instances, FileName FROM FileInfo WHERE Exclude=0 AND SessionID = '" + _SessionID + "' GROUP BY FileName HAVING (COUNT(FileID) > 1) ORDER BY Instances DESC";
         SQLiteDataReader dr = cmd.ExecuteReader();
         while (dr.Read())
         {
            TreeNode node = new TreeNode(dr["FileName"].ToString() + " : " + dr["Instances"].ToString() + " Instances");
            subcmd.CommandText = "SELECT FileLocation FROM FileInfo WHERE FileName = '" + dr["FileName"].ToString().Replace("'", "''") + "' AND SessionID = '" + _SessionID + "' ORDER BY FileLocation";
            SQLiteDataReader subdr = subcmd.ExecuteReader();
            while (subdr.Read())
            {
               try
               {
                  FileInfo finfo = new FileInfo(subdr["FileLocation"].ToString() + "\\" + dr["FileName"].ToString());
                  node.Nodes.Add(subdr["FileLocation"].ToString() + "\\ * " + finfo.Length.ToString());
               }
               catch { }
            }
            subdr.Dispose();
            treeViewResults.Nodes.Add(node);
         }

         subcmd.Dispose();
         conn.Close();
         cmd.Dispose();
         dr.Dispose();
      }

      private void btnGo_Click(object sender, EventArgs e)
      {
         if (cboFileTypes.Text.Length > 2)
         {
            Cursor.Current = Cursors.WaitCursor;
            int FirstBrace = cboFileTypes.Text.IndexOf("*");
            int SecondBrace = cboFileTypes.Text.LastIndexOf(")") - 1;
            string fileType = cboFileTypes.Text.Substring(FirstBrace + 1, SecondBrace - FirstBrace);
            strPattern = fileType;
            SQLiteConnection conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            SQLiteTransaction transaction = conn.BeginTransaction();
            cmd.CommandText = "UPDATE FileInfo SET Exclude=1 WHERE FileName LIKE '%" + fileType + "' AND SessionID = '" + _SessionID + "';";
            cmd.ExecuteNonQuery();
            transaction.Commit();
            conn.Close();
            cmd.Dispose();
            Cursor.Current = Cursors.Default;
         }
         else
         {
            MessageBox.Show("Please select file type");
            return;
         }
      }

      private void toolStripMenuItemCOPY_Click(object sender, EventArgs e)
      {
         try
         {
            string nodeText = treeViewResults.SelectedNode.Text.ToString();
            nodeText = nodeText.Substring(0, nodeText.LastIndexOf("*")).Trim();
            Clipboard.SetText(nodeText);
         }
         catch { }
      }

      private void toolStripMenuItemDELETE_Click(object sender, EventArgs e)
      {
         try
         {
            string nodeText = treeViewResults.SelectedNode.Text.ToString();
            string noteParentText = treeViewResults.SelectedNode.Parent.Text.ToString();

            nodeText = nodeText.Substring(0, nodeText.LastIndexOf("*")).Trim();
            noteParentText = noteParentText.Substring(0, noteParentText.LastIndexOf(":")).Trim();
            string PathOnly = nodeText.Substring(0, nodeText.Length - 1);

            File.Delete(nodeText);

            // We need to delete the file instance from the database

            SQLiteConnection conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            SQLiteTransaction transaction = conn.BeginTransaction();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM FileInfo WHERE FileName = '" + noteParentText.Replace("'", "''") + "' AND FileLocation = '" + PathOnly.Replace("'", "''") + "'AND SessionID = '" + _SessionID + "'";
            cmd.ExecuteNonQuery();
            transaction.Commit();
            cmd.Dispose();
            conn.Close();

            // We need to decremend the first node with instane count of files.
            string nodeFull = treeViewResults.SelectedNode.Parent.Text.ToString();
            string[] nodeParts = nodeFull.Split(':');
            // MessageBox.Show(nodeParts[1]);
            string[] Instances = nodeParts[1].Trim().Split(' ');
            int FileCount = Convert.ToInt32(Instances[0].Trim());
            FileCount--;
            treeViewResults.SelectedNode.Parent.Text = nodeParts[0].Trim() + " * " + FileCount.ToString() + " Instances";
            // We need to remove the node from the treeview
            treeViewResults.SelectedNode.Remove();
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void toolStripMenuItemEXCLUDE_Click(object sender, EventArgs e)
      {
         if (treeViewResults.SelectedNode.Text.IndexOf(":") > 0)
         {
            // Now we know this is a file.
            string nodeFull = treeViewResults.SelectedNode.Text.ToString();
            string[] nodeParts = nodeFull.Split(':');
            string FileName = nodeParts[0].Trim();

            SQLiteConnection conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            SQLiteTransaction transaction = conn.BeginTransaction();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE FileInfo SET Exclude=1 WHERE FileName = '" + FileName.Replace("'", "''") + "' AND SessionID = '" + _SessionID + "';";
            cmd.ExecuteNonQuery();
            transaction.Commit();
            cmd.Dispose();
            treeViewResults.SelectedNode.Remove();
            conn.Close();

         }
      }

      private void toolStripMenuItemOPENDIR_Click(object sender, EventArgs e)
      {
         try
         {
            string nodeText = treeViewResults.SelectedNode.Text.ToString();
            nodeText = nodeText.Substring(0, nodeText.LastIndexOf("*")).Trim();
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = "explorer.exe";
            proc.StartInfo.Arguments = nodeText;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            proc.Start();
         }
         catch { }
      }
   }
}
