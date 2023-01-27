namespace ScreamShot
{
    partial class Editor
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TopSelectorPanel = new System.Windows.Forms.Panel();
            this.SelectorPanel = new System.Windows.Forms.Panel();
            this.BotSelectorPanel = new System.Windows.Forms.Panel();
            this.SelectorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.TopSelectorPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.TopSelectorPanel.Location = new System.Drawing.Point(3, 3);
            this.TopSelectorPanel.Name = "TopSelectorPanel";
            this.TopSelectorPanel.Size = new System.Drawing.Size(15, 15);
            this.TopSelectorPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.SelectorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectorPanel.Controls.Add(this.BotSelectorPanel);
            this.SelectorPanel.Controls.Add(this.TopSelectorPanel);
            this.SelectorPanel.Location = new System.Drawing.Point(1, 0);
            this.SelectorPanel.Name = "SelectorPanel";
            this.SelectorPanel.Size = new System.Drawing.Size(1919, 1082);
            this.SelectorPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.BotSelectorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BotSelectorPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.BotSelectorPanel.Location = new System.Drawing.Point(1899, 1062);
            this.BotSelectorPanel.Name = "BotSelectorPanel";
            this.BotSelectorPanel.Size = new System.Drawing.Size(15, 15);
            this.BotSelectorPanel.TabIndex = 1;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.SelectorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Editor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screengrab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Editor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Editor_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Editor_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Editor_MouseUp);
            this.SelectorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ImageList imageList1;
        private Panel TopSelectorPanel;
        private Panel SelectorPanel;
        private Panel BotSelectorPanel;
    }
}