
namespace Deduplicate
{
   partial class Main
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
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
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.btnGo = new System.Windows.Forms.Button();
         this.txtLocation = new System.Windows.Forms.TextBox();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItemNEW = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItemCLEARPREVIOUS = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItemCLEAREX = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItemEXIT = new System.Windows.Forms.ToolStripMenuItem();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.btnBrowse = new System.Windows.Forms.Button();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.txtDescription = new System.Windows.Forms.TextBox();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.btnOpen = new System.Windows.Forms.Button();
         this.cboResult = new System.Windows.Forms.ComboBox();
         this.statusStrip1.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox3.SuspendLayout();
         this.SuspendLayout();
         // 
         // btnGo
         // 
         this.btnGo.Location = new System.Drawing.Point(128, 94);
         this.btnGo.Name = "btnGo";
         this.btnGo.Size = new System.Drawing.Size(75, 23);
         this.btnGo.TabIndex = 1;
         this.btnGo.Text = "Go";
         this.btnGo.UseVisualStyleBackColor = true;
         this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
         // 
         // txtLocation
         // 
         this.txtLocation.Location = new System.Drawing.Point(6, 39);
         this.txtLocation.Name = "txtLocation";
         this.txtLocation.Size = new System.Drawing.Size(351, 23);
         this.txtLocation.TabIndex = 3;
         // 
         // statusStrip1
         // 
         this.statusStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
         this.statusStrip1.Location = new System.Drawing.Point(0, 451);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(442, 22);
         this.statusStrip1.TabIndex = 4;
         // 
         // StatusLabel
         // 
         this.StatusLabel.Name = "StatusLabel";
         this.StatusLabel.Size = new System.Drawing.Size(0, 17);
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(442, 24);
         this.menuStrip1.TabIndex = 5;
         // 
         // toolStripMenuItem1
         // 
         this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNEW,
            this.toolStripMenuItemCLEARPREVIOUS,
            this.toolStripMenuItemCLEAREX,
            this.toolStripMenuItemEXIT});
         this.toolStripMenuItem1.Name = "toolStripMenuItem1";
         this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
         this.toolStripMenuItem1.Text = "&File";
         // 
         // toolStripMenuItemNEW
         // 
         this.toolStripMenuItemNEW.Name = "toolStripMenuItemNEW";
         this.toolStripMenuItemNEW.Size = new System.Drawing.Size(189, 22);
         this.toolStripMenuItemNEW.Text = "&New";
         // 
         // toolStripMenuItemCLEARPREVIOUS
         // 
         this.toolStripMenuItemCLEARPREVIOUS.Name = "toolStripMenuItemCLEARPREVIOUS";
         this.toolStripMenuItemCLEARPREVIOUS.Size = new System.Drawing.Size(189, 22);
         this.toolStripMenuItemCLEARPREVIOUS.Text = "Clear Previous Results";
         // 
         // toolStripMenuItemCLEAREX
         // 
         this.toolStripMenuItemCLEAREX.Name = "toolStripMenuItemCLEAREX";
         this.toolStripMenuItemCLEAREX.Size = new System.Drawing.Size(189, 22);
         this.toolStripMenuItemCLEAREX.Text = "Clear Exclusions";
         // 
         // toolStripMenuItemEXIT
         // 
         this.toolStripMenuItemEXIT.Name = "toolStripMenuItemEXIT";
         this.toolStripMenuItemEXIT.Size = new System.Drawing.Size(189, 22);
         this.toolStripMenuItemEXIT.Text = "E&xit";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.btnBrowse);
         this.groupBox1.Controls.Add(this.txtLocation);
         this.groupBox1.Location = new System.Drawing.Point(38, 43);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(363, 109);
         this.groupBox1.TabIndex = 7;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "1. Select Start Location";
         // 
         // btnBrowse
         // 
         this.btnBrowse.Location = new System.Drawing.Point(6, 68);
         this.btnBrowse.Name = "btnBrowse";
         this.btnBrowse.Size = new System.Drawing.Size(75, 23);
         this.btnBrowse.TabIndex = 1;
         this.btnBrowse.Text = "Browse";
         this.btnBrowse.UseVisualStyleBackColor = true;
         this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.txtDescription);
         this.groupBox2.Controls.Add(this.btnGo);
         this.groupBox2.Location = new System.Drawing.Point(38, 158);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(363, 141);
         this.groupBox2.TabIndex = 8;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "2. Enter Description and create the list";
         // 
         // txtDescription
         // 
         this.txtDescription.Location = new System.Drawing.Point(6, 37);
         this.txtDescription.Name = "txtDescription";
         this.txtDescription.Size = new System.Drawing.Size(351, 23);
         this.txtDescription.TabIndex = 4;
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.btnOpen);
         this.groupBox3.Controls.Add(this.cboResult);
         this.groupBox3.Location = new System.Drawing.Point(38, 318);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(363, 100);
         this.groupBox3.TabIndex = 9;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "3. View Results";
         // 
         // btnOpen
         // 
         this.btnOpen.Location = new System.Drawing.Point(6, 64);
         this.btnOpen.Name = "btnOpen";
         this.btnOpen.Size = new System.Drawing.Size(75, 23);
         this.btnOpen.TabIndex = 2;
         this.btnOpen.Text = "Open";
         this.btnOpen.UseVisualStyleBackColor = true;
         this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
         // 
         // cboResult
         // 
         this.cboResult.FormattingEnabled = true;
         this.cboResult.Location = new System.Drawing.Point(6, 35);
         this.cboResult.Name = "cboResult";
         this.cboResult.Size = new System.Drawing.Size(351, 23);
         this.cboResult.TabIndex = 0;
         this.cboResult.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cboResult_MouseDown);
         // 
         // Main
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(442, 473);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "Main";
         this.Text = "Deduplicator";
         this.Load += new System.EventHandler(this.Main_Load);
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.groupBox3.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Button btnGo;
      private System.Windows.Forms.TextBox txtLocation;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
      private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNEW;
      private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCLEARPREVIOUS;
      private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCLEAREX;
      private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEXIT;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button btnBrowse;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.Button btnOpen;
      private System.Windows.Forms.ComboBox cboResult;
      private System.Windows.Forms.TextBox txtDescription;
   }
}

