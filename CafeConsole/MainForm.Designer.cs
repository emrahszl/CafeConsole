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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            productsTsmi = new ToolStripMenuItem();
            lastOrderTsmi = new ToolStripMenuItem();
            lvTables = new ListView();
            ilTables = new ImageList(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { productsTsmi, lastOrderTsmi });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // productsTsmi
            // 
            productsTsmi.Name = "productsTsmi";
            productsTsmi.Size = new Size(58, 20);
            productsTsmi.Text = "Ürünler";
            productsTsmi.Click += productsTsmi_Click;
            // 
            // lastOrderTsmi
            // 
            lastOrderTsmi.Name = "lastOrderTsmi";
            lastOrderTsmi.Size = new Size(108, 20);
            lastOrderTsmi.Text = "Geçmiş Siparişler";
            lastOrderTsmi.Click += lastOrderTsmi_Click;
            // 
            // lvTables
            // 
            lvTables.Dock = DockStyle.Fill;
            lvTables.LargeImageList = ilTables;
            lvTables.Location = new Point(0, 24);
            lvTables.Name = "lvTables";
            lvTables.Size = new Size(800, 426);
            lvTables.TabIndex = 1;
            lvTables.UseCompatibleStateImageBehavior = false;
            lvTables.DoubleClick += lvTables_DoubleClick;
            // 
            // ilTables
            // 
            ilTables.ColorDepth = ColorDepth.Depth8Bit;
            ilTables.ImageStream = (ImageListStreamer)resources.GetObject("ilTables.ImageStream");
            ilTables.TransparentColor = Color.Transparent;
            ilTables.Images.SetKeyName(0, "bos");
            ilTables.Images.SetKeyName(1, "dolu");
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvTables);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kafe Konsol";
            FormClosing += MainForm_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem productsTsmi;
        private ToolStripMenuItem lastOrderTsmi;
        private ListView lvTables;
        private ImageList ilTables;
    }
}