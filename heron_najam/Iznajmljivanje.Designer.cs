namespace heron_najam
{
    partial class Iznajmljivanje
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
            this.Pregled = new System.Windows.Forms.Label();
            this.dataGridNajam = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automobilMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.najamMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNajam)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pregled
            // 
            this.Pregled.AutoSize = true;
            this.Pregled.Location = new System.Drawing.Point(25, 40);
            this.Pregled.Name = "Pregled";
            this.Pregled.Size = new System.Drawing.Size(153, 13);
            this.Pregled.TabIndex = 0;
            this.Pregled.Text = "Pregled iznajmljenih automobila";
            // 
            // dataGridNajam
            // 
            this.dataGridNajam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNajam.Location = new System.Drawing.Point(27, 56);
            this.dataGridNajam.Name = "dataGridNajam";
            this.dataGridNajam.Size = new System.Drawing.Size(747, 153);
            this.dataGridNajam.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem,
            this.automobilMenuItem,
            this.najamMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.pregledToolStripMenuItem.Text = "Pregled";
            // 
            // automobilMenuItem
            // 
            this.automobilMenuItem.Name = "automobilMenuItem";
            this.automobilMenuItem.Size = new System.Drawing.Size(79, 20);
            this.automobilMenuItem.Text = "Automobili";
            this.automobilMenuItem.Click += new System.EventHandler(this.PregledAuto);
            // 
            // najamMenuItem
            // 
            this.najamMenuItem.Name = "najamMenuItem";
            this.najamMenuItem.Size = new System.Drawing.Size(54, 20);
            this.najamMenuItem.Text = "Najam";
            this.najamMenuItem.Click += new System.EventHandler(this.NoviNajam);
            // 
            // Iznajmljivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 324);
            this.Controls.Add(this.dataGridNajam);
            this.Controls.Add(this.Pregled);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Iznajmljivanje";
            this.Text = "Najam";
            this.Load += new System.EventHandler(this.Iznajmljivanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNajam)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Label Pregled;
        private System.Windows.Forms.DataGridView dataGridNajam;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAutomobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOsobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznajmljenodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznajmljendoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumnajmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinanajmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automobilMenuItem;
        private System.Windows.Forms.ToolStripMenuItem najamMenuItem;
    }
}

