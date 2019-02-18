namespace Deduplicator
{
   partial class Main
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
         this.btnLocation = new System.Windows.Forms.Button();
         this.txtLocation = new System.Windows.Forms.TextBox();
         this.openFileDialog_Location = new System.Windows.Forms.OpenFileDialog();
         this.label1 = new System.Windows.Forms.Label();
         this.folderBrowserDialog_Location = new System.Windows.Forms.FolderBrowserDialog();
         this.label2 = new System.Windows.Forms.Label();
         this.btnList = new System.Windows.Forms.Button();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.clearPreviousResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.clearExclusionFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.label3 = new System.Windows.Forms.Label();
         this.txtDescription = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.btnResults = new System.Windows.Forms.Button();
         this.cboResults = new System.Windows.Forms.ComboBox();
         this.statusStrip1.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // btnLocation
         // 
         this.btnLocation.Location = new System.Drawing.Point(167, 118);
         this.btnLocation.Name = "btnLocation";
         this.btnLocation.Size = new System.Drawing.Size(75, 23);
         this.btnLocation.TabIndex = 0;
         this.btnLocation.Text = "Select";
         this.btnLocation.UseVisualStyleBackColor = true;
         this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
         // 
         // txtLocation
         // 
         this.txtLocation.Location = new System.Drawing.Point(22, 279);
         this.txtLocation.Name = "txtLocation";
         this.txtLocation.Size = new System.Drawing.Size(419, 20);
         this.txtLocation.TabIndex = 1;
         // 
         // openFileDialog_Location
         // 
         this.openFileDialog_Location.FileName = "openFileDialog1";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(18, 123);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(132, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "1. Select Starting Location";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(18, 164);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(69, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "2. Create List";
         // 
         // btnList
         // 
         this.btnList.Location = new System.Drawing.Point(167, 159);
         this.btnList.Name = "btnList";
         this.btnList.Size = new System.Drawing.Size(75, 23);
         this.btnList.TabIndex = 3;
         this.btnList.Text = "Go";
         this.btnList.UseVisualStyleBackColor = true;
         this.btnList.Click += new System.EventHandler(this.btnList_Click);
         // 
         // statusStrip1
         // 
         this.statusStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
         this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
         this.statusStrip1.Location = new System.Drawing.Point(0, 440);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(464, 5);
         this.statusStrip1.SizingGrip = false;
         this.statusStrip1.TabIndex = 7;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // StatusLabel
         // 
         this.StatusLabel.Name = "StatusLabel";
         this.StatusLabel.Size = new System.Drawing.Size(0, 0);
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(464, 24);
         this.menuStrip1.TabIndex = 10;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.clearPreviousResultsToolStripMenuItem,
            this.clearExclusionFileToolStripMenuItem,
            this.exitToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
         this.fileToolStripMenuItem.Text = "&File";
         // 
         // newToolStripMenuItem
         // 
         this.newToolStripMenuItem.Name = "newToolStripMenuItem";
         this.newToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
         this.newToolStripMenuItem.Text = "&New";
         this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
         // 
         // clearPreviousResultsToolStripMenuItem
         // 
         this.clearPreviousResultsToolStripMenuItem.Name = "clearPreviousResultsToolStripMenuItem";
         this.clearPreviousResultsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
         this.clearPreviousResultsToolStripMenuItem.Text = "Clear Previous Results";
         this.clearPreviousResultsToolStripMenuItem.Click += new System.EventHandler(this.clearPreviousResultsToolStripMenuItem_Click);
         // 
         // clearExclusionFileToolStripMenuItem
         // 
         this.clearExclusionFileToolStripMenuItem.Name = "clearExclusionFileToolStripMenuItem";
         this.clearExclusionFileToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
         this.clearExclusionFileToolStripMenuItem.Text = "Clear Exclusion File";
         this.clearExclusionFileToolStripMenuItem.Click += new System.EventHandler(this.clearExclusionFileToolStripMenuItem_Click);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
         this.exitToolStripMenuItem.Text = "E&xit";
         this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
         // 
         // helpToolStripMenuItem
         // 
         this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
         this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
         this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
         this.helpToolStripMenuItem.Text = "&Help";
         // 
         // aboutToolStripMenuItem
         // 
         this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
         this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.aboutToolStripMenuItem.Text = "&About";
         this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(18, 204);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(80, 13);
         this.label3.TabIndex = 12;
         this.label3.Text = "3. View Results";
         // 
         // txtDescription
         // 
         this.txtDescription.Location = new System.Drawing.Point(12, 63);
         this.txtDescription.MaxLength = 200;
         this.txtDescription.Name = "txtDescription";
         this.txtDescription.Size = new System.Drawing.Size(427, 20);
         this.txtDescription.TabIndex = 13;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(8, 47);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(88, 13);
         this.label4.TabIndex = 14;
         this.label4.Text = "Short Description";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(19, 263);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(132, 13);
         this.label5.TabIndex = 15;
         this.label5.Text = "Selected Starting Location";
         // 
         // btnResults
         // 
         this.btnResults.Location = new System.Drawing.Point(374, 202);
         this.btnResults.Name = "btnResults";
         this.btnResults.Size = new System.Drawing.Size(51, 23);
         this.btnResults.TabIndex = 21;
         this.btnResults.Text = "View";
         this.btnResults.UseVisualStyleBackColor = true;
         this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
         // 
         // cboResults
         // 
         this.cboResults.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
         this.cboResults.FormattingEnabled = true;
         this.cboResults.Location = new System.Drawing.Point(101, 202);
         this.cboResults.Name = "cboResults";
         this.cboResults.Size = new System.Drawing.Size(267, 21);
         this.cboResults.TabIndex = 19;
         this.cboResults.Enter += new System.EventHandler(this.cboResults_Enter);
         this.cboResults.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cboResults_MouseDown);
         // 
         // Main
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(464, 445);
         this.Controls.Add(this.btnResults);
         this.Controls.Add(this.cboResults);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.txtDescription);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.menuStrip1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.btnList);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtLocation);
         this.Controls.Add(this.btnLocation);
         this.MainMenuStrip = this.menuStrip1;
         this.MaximizeBox = false;
         this.MaximumSize = new System.Drawing.Size(472, 472);
         this.Name = "Main";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
         this.Load += new System.EventHandler(this.Main_Load);
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnLocation;
      private System.Windows.Forms.TextBox txtLocation;
      private System.Windows.Forms.OpenFileDialog openFileDialog_Location;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Location;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btnList;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem clearPreviousResultsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem clearExclusionFileToolStripMenuItem;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.TextBox txtDescription;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Button btnResults;
      private System.Windows.Forms.ComboBox cboResults;
      private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
   }
}

