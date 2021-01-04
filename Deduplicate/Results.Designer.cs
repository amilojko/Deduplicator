
namespace Deduplicate
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
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.toolStripMenuItemOPENDIR = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItemCOPY = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItemEXCLUDE = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItemDELETE = new System.Windows.Forms.ToolStripMenuItem();
         this.cboFileTypes = new System.Windows.Forms.ComboBox();
         this.btnGo = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.contextMenuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // treeViewResults
         // 
         this.treeViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.treeViewResults.ContextMenuStrip = this.contextMenuStrip1;
         this.treeViewResults.Location = new System.Drawing.Point(12, 94);
         this.treeViewResults.Name = "treeViewResults";
         this.treeViewResults.Size = new System.Drawing.Size(776, 344);
         this.treeViewResults.TabIndex = 0;
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOPENDIR,
            this.toolStripMenuItemCOPY,
            this.toolStripMenuItemEXCLUDE,
            this.toolStripMenuItemDELETE});
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(203, 92);
         // 
         // toolStripMenuItemOPENDIR
         // 
         this.toolStripMenuItemOPENDIR.Name = "toolStripMenuItemOPENDIR";
         this.toolStripMenuItemOPENDIR.Size = new System.Drawing.Size(202, 22);
         this.toolStripMenuItemOPENDIR.Text = "Open Directory";
         this.toolStripMenuItemOPENDIR.Click += new System.EventHandler(this.toolStripMenuItemOPENDIR_Click);
         // 
         // toolStripMenuItemCOPY
         // 
         this.toolStripMenuItemCOPY.Name = "toolStripMenuItemCOPY";
         this.toolStripMenuItemCOPY.Size = new System.Drawing.Size(202, 22);
         this.toolStripMenuItemCOPY.Text = "Copy Directory Location";
         this.toolStripMenuItemCOPY.Click += new System.EventHandler(this.toolStripMenuItemCOPY_Click);
         // 
         // toolStripMenuItemEXCLUDE
         // 
         this.toolStripMenuItemEXCLUDE.Name = "toolStripMenuItemEXCLUDE";
         this.toolStripMenuItemEXCLUDE.Size = new System.Drawing.Size(202, 22);
         this.toolStripMenuItemEXCLUDE.Text = "Exclude From View";
         this.toolStripMenuItemEXCLUDE.Click += new System.EventHandler(this.toolStripMenuItemEXCLUDE_Click);
         // 
         // toolStripMenuItemDELETE
         // 
         this.toolStripMenuItemDELETE.Name = "toolStripMenuItemDELETE";
         this.toolStripMenuItemDELETE.Size = new System.Drawing.Size(202, 22);
         this.toolStripMenuItemDELETE.Text = "Delete File Instance";
         this.toolStripMenuItemDELETE.Click += new System.EventHandler(this.toolStripMenuItemDELETE_Click);
         // 
         // cboFileTypes
         // 
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
         this.cboFileTypes.Location = new System.Drawing.Point(12, 65);
         this.cboFileTypes.Name = "cboFileTypes";
         this.cboFileTypes.Size = new System.Drawing.Size(182, 23);
         this.cboFileTypes.TabIndex = 1;
         // 
         // btnGo
         // 
         this.btnGo.Location = new System.Drawing.Point(200, 64);
         this.btnGo.Name = "btnGo";
         this.btnGo.Size = new System.Drawing.Size(58, 23);
         this.btnGo.TabIndex = 2;
         this.btnGo.Text = "Go";
         this.btnGo.UseVisualStyleBackColor = true;
         this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 47);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(118, 15);
         this.label1.TabIndex = 3;
         this.label1.Text = "Exclude Files of Type:";
         // 
         // label2
         // 
         this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
         this.label2.Location = new System.Drawing.Point(626, 76);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(157, 15);
         this.label2.TabIndex = 4;
         this.label2.Text = "Right click a node for options";
         // 
         // Results
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnGo);
         this.Controls.Add(this.cboFileTypes);
         this.Controls.Add(this.treeViewResults);
         this.Name = "Results";
         this.Text = "Results";
         this.Load += new System.EventHandler(this.Results_Load);
         this.contextMenuStrip1.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TreeView treeViewResults;
      private System.Windows.Forms.ComboBox cboFileTypes;
      private System.Windows.Forms.Button btnGo;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOPENDIR;
      private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCOPY;
      private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEXCLUDE;
      private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDELETE;
      private System.Windows.Forms.Label label2;
   }
}