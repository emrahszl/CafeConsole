namespace CafeConsole
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            listView1 = new ListView();
            ürünlerToolStripMenuItem = new ToolStripMenuItem();
            geçmişSiparişlerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ürünlerToolStripMenuItem, geçmişSiparişlerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.Location = new Point(0, 24);
            listView1.Name = "listView1";
            listView1.Size = new Size(800, 426);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ürünlerToolStripMenuItem
            // 
            ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            ürünlerToolStripMenuItem.Size = new Size(58, 20);
            ürünlerToolStripMenuItem.Text = "Ürünler";
            // 
            // geçmişSiparişlerToolStripMenuItem
            // 
            geçmişSiparişlerToolStripMenuItem.Name = "geçmişSiparişlerToolStripMenuItem";
            geçmişSiparişlerToolStripMenuItem.Size = new Size(108, 20);
            geçmişSiparişlerToolStripMenuItem.Text = "Geçmiş Siparişler";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Cafe Consol";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ürünlerToolStripMenuItem;
        private ToolStripMenuItem geçmişSiparişlerToolStripMenuItem;
        private ListView listView1;
    }
}