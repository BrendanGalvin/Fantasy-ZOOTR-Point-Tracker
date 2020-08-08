namespace FantasyZOOTR
{
    partial class Form1
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
            this.fool = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPlayersDraftsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.draftLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.playerLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fool
            // 
            this.fool.AutoSize = true;
            this.fool.Location = new System.Drawing.Point(406, 66);
            this.fool.Name = "fool";
            this.fool.Size = new System.Drawing.Size(115, 17);
            this.fool.TabIndex = 82;
            this.fool.Text = "YOU ARE A FOOL";
            this.fool.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 24);
            this.menuStrip1.TabIndex = 88;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.loadPlayersDraftsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.loadToolStripMenuItem.Text = "Load Items";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // loadPlayersDraftsToolStripMenuItem
            // 
            this.loadPlayersDraftsToolStripMenuItem.Name = "loadPlayersDraftsToolStripMenuItem";
            this.loadPlayersDraftsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.loadPlayersDraftsToolStripMenuItem.Text = "Load Players and Drafts";
            this.loadPlayersDraftsToolStripMenuItem.Click += new System.EventHandler(this.loadPlayersDraftsToolStripMenuItem_Click);
            // 
            // itemLayoutPanel
            // 
            this.itemLayoutPanel.AutoScroll = true;
            this.itemLayoutPanel.Location = new System.Drawing.Point(639, 117);
            this.itemLayoutPanel.Name = "itemLayoutPanel";
            this.itemLayoutPanel.Size = new System.Drawing.Size(348, 413);
            this.itemLayoutPanel.TabIndex = 89;
            this.itemLayoutPanel.Visible = false;
            // 
            // draftLayoutPanel
            // 
            this.draftLayoutPanel.AutoScroll = true;
            this.draftLayoutPanel.Location = new System.Drawing.Point(289, 117);
            this.draftLayoutPanel.Name = "draftLayoutPanel";
            this.draftLayoutPanel.Size = new System.Drawing.Size(344, 413);
            this.draftLayoutPanel.TabIndex = 90;
            // 
            // playerLayoutPanel
            // 
            this.playerLayoutPanel.AutoScroll = true;
            this.playerLayoutPanel.Location = new System.Drawing.Point(25, 117);
            this.playerLayoutPanel.Name = "playerLayoutPanel";
            this.playerLayoutPanel.Size = new System.Drawing.Size(258, 413);
            this.playerLayoutPanel.TabIndex = 91;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 542);
            this.Controls.Add(this.playerLayoutPanel);
            this.Controls.Add(this.draftLayoutPanel);
            this.Controls.Add(this.itemLayoutPanel);
            this.Controls.Add(this.fool);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox fool;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel itemLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel draftLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem loadPlayersDraftsToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel playerLayoutPanel;
    }
}

