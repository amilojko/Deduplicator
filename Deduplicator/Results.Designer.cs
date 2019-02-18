namespace Deduplicator
{
   partial class Results
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.treeViewResults = new System.Windows.Forms.TreeView();
         this.RightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.openDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.copyDirectoryLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.excludeFromViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.deleteFileInstanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.btnExcludeFileTypes = new System.Windows.Forms.Button();
         this.label6 = new System.Windows.Forms.Label();
         this.cboFileTypes = new System.Windows.Forms.ComboBox();
         this.RightClickMenu.SuspendLayout();
         this.SuspendLayout();
         // 
         // treeViewResults
         // 
         this.treeViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.treeViewResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.treeViewResults.Location = new System.Drawing.Point(12, 94);
         this.treeViewResults.Name = "treeViewResults";
         this.treeViewResults.Size = new System.Drawing.Size(1049, 618);
         this.treeViewResults.TabIndex = 0;
         this.treeViewResults.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeViewResults_MouseUp);
         // 
         // RightClickMenu
         // 
         this.RightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDirectoryToolStripMenuItem,
            this.copyDirectoryLocationToolStripMenuItem,
            this.excludeFromViewToolStripMenuItem,
            this.deleteFileInstanceToolStripMenuItem});
         this.RightClickMenu.Name = "RightClickMenu";
         this.RightClickMenu.Size = new System.Drawing.Size(190, 92);
         // 
         // openDirectoryToolStripMenuItem
         // 
         this.openDirectoryToolStripMenuItem.Name = "openDirectoryToolStripMenuItem";
         this.openDirectoryToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
         this.openDirectoryToolStripMenuItem.Text = "Open Directory";
         this.openDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openDirectoryToolStripMenuItem_Click);
         // 
         // copyDirectoryLocationToolStripMenuItem
         // 
         this.copyDirectoryLocationToolStripMenuItem.Name = "copyDirectoryLocationToolStripMenuItem";
         this.copyDirectoryLocationToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
         this.copyDirectoryLocationToolStripMenuItem.Text = "Copy Directory Location";
         this.copyDirectoryLocationToolStripMenuItem.Click += new System.EventHandler(this.copyDirectoryLocationToolStripMenuItem_Click);
         // 
         // excludeFromViewToolStripMenuItem
         // 
         this.excludeFromViewToolStripMenuItem.Name = "excludeFromViewToolStripMenuItem";
         this.excludeFromViewToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
         this.excludeFromViewToolStripMenuItem.Text = "Exclude From View";
         this.excludeFromViewToolStripMenuItem.Click += new System.EventHandler(this.excludeFromViewToolStripMenuItem_Click);
         // 
         // deleteFileInstanceToolStripMenuItem
         // 
         this.deleteFileInstanceToolStripMenuItem.Name = "deleteFileInstanceToolStripMenuItem";
         this.deleteFileInstanceToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
         this.deleteFileInstanceToolStripMenuItem.Text = "Delete File Instance";
         this.deleteFileInstanceToolStripMenuItem.Visible = false;
         this.deleteFileInstanceToolStripMenuItem.Click += new System.EventHandler(this.deleteFileInstanceToolStripMenuItem_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(15, 31);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(169, 16);
         this.label1.TabIndex = 1;
         this.label1.Text = "Right Click For Action Items";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(767, 31);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(294, 16);
         this.label2.TabIndex = 2;
         this.label2.Text = "Directory Display - Directory * File Size (in bytes)";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(767, 10);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(244, 16);
         this.label3.TabIndex = 3;
         this.label3.Text = "File Display - File Name  : # of Instances";
         // 
         // btnExcludeFileTypes
         // 
         this.btnExcludeFileTypes.Location = new System.Drawing.Point(613, 26);
         this.btnExcludeFileTypes.Name = "btnExcludeFileTypes";
         this.btnExcludeFileTypes.Size = new System.Drawing.Size(51, 23);
         this.btnExcludeFileTypes.TabIndex = 21;
         this.btnExcludeFileTypes.Text = "Go";
         this.btnExcludeFileTypes.UseVisualStyleBackColor = true;
         this.btnExcludeFileTypes.Click += new System.EventHandler(this.btnExcludeFileTypes_Click);
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(259, 29);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(127, 13);
         this.label6.TabIndex = 20;
         this.label6.Text = "Exclude All Files Of Type:";
         // 
         // cboFileTypes
         // 
         this.cboFileTypes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
         this.cboFileTypes.FormattingEnabled = true;
         this.cboFileTypes.Items.AddRange(new object[] {
            "MP3 Files (*.mp3)",
            "JPEG Files (*.jpg)",
            "JPEG Files (*.jpeg)",
            "GIF Files (*.gif)",
            "AVI Files (*.avi)",
            "WMV Files (*.wmv)",
            "MP4 Files (*.mp4)",
            "Bitmap Files (*.bmp)",
            "INI Files (*.ini)",
            "DB Files (*.db)"});
         this.cboFileTypes.Location = new System.Drawing.Point(388, 26);
         this.cboFileTypes.Name = "cboFileTypes";
         this.cboFileTypes.Size = new System.Drawing.Size(219, 21);
         this.cboFileTypes.TabIndex = 19;
         // 
         // Results
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1073, 724);
         this.Controls.Add(this.btnExcludeFileTypes);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.cboFileTypes);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.treeViewResults);
         this.Name = "Results";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Results";
         this.Load += new System.EventHandler(this.Results_Load);
         this.RightClickMenu.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TreeView treeViewResults;
      private System.Windows.Forms.ContextMenuStrip RightClickMenu;
      private System.Windows.Forms.ToolStripMenuItem openDirectoryToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem copyDirectoryLocationToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem excludeFromViewToolStripMenuItem;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ToolStripMenuItem deleteFileInstanceToolStripMenuItem;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button btnExcludeFileTypes;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.ComboBox cboFileTypes;
   }
}