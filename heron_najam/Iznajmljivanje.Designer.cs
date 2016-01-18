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
            this.components = new System.ComponentModel.Container();
            this.autoDataSet = new heron_najam.autoDataSet();
            this.Pregled = new System.Windows.Forms.Label();
            this.listaNajam = new System.Windows.Forms.ListBox();
            this.dataGridNajam = new System.Windows.Forms.DataGridView();
            this.najamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.najamTableAdapter = new heron_najam.autoDataSetTableAdapters.najamTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAutomobilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOsobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznajmljenodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznajmljendoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumnajmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinanajmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automobilMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.najamMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNajam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.najamBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoDataSet
            // 
            this.autoDataSet.DataSetName = "autoDataSet";
            this.autoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // listaNajam
            // 
            this.listaNajam.FormattingEnabled = true;
            this.listaNajam.Location = new System.Drawing.Point(28, 268);
            this.listaNajam.Name = "listaNajam";
            this.listaNajam.Size = new System.Drawing.Size(521, 108);
            this.listaNajam.TabIndex = 1;
            // 
            // dataGridNajam
            // 
            this.dataGridNajam.AutoGenerateColumns = false;
            this.dataGridNajam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNajam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idAutomobilDataGridViewTextBoxColumn,
            this.idOsobaDataGridViewTextBoxColumn,
            this.iznajmljenodDataGridViewTextBoxColumn,
            this.iznajmljendoDataGridViewTextBoxColumn,
            this.datumnajmaDataGridViewTextBoxColumn,
            this.godinanajmaDataGridViewTextBoxColumn});
            this.dataGridNajam.DataSource = this.najamBindingSource;
            this.dataGridNajam.Location = new System.Drawing.Point(27, 56);
            this.dataGridNajam.Name = "dataGridNajam";
            this.dataGridNajam.Size = new System.Drawing.Size(747, 153);
            this.dataGridNajam.TabIndex = 2;
            // 
            // najamBindingSource
            // 
            this.najamBindingSource.DataMember = "najam";
            this.najamBindingSource.DataSource = this.autoDataSet;
            // 
            // najamTableAdapter
            // 
            this.najamTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idAutomobilDataGridViewTextBoxColumn
            // 
            this.idAutomobilDataGridViewTextBoxColumn.DataPropertyName = "IdAutomobil";
            this.idAutomobilDataGridViewTextBoxColumn.HeaderText = "IdAutomobil";
            this.idAutomobilDataGridViewTextBoxColumn.Name = "idAutomobilDataGridViewTextBoxColumn";
            // 
            // idOsobaDataGridViewTextBoxColumn
            // 
            this.idOsobaDataGridViewTextBoxColumn.DataPropertyName = "IdOsoba";
            this.idOsobaDataGridViewTextBoxColumn.HeaderText = "IdOsoba";
            this.idOsobaDataGridViewTextBoxColumn.Name = "idOsobaDataGridViewTextBoxColumn";
            // 
            // iznajmljenodDataGridViewTextBoxColumn
            // 
            this.iznajmljenodDataGridViewTextBoxColumn.DataPropertyName = "iznajmljen_od";
            this.iznajmljenodDataGridViewTextBoxColumn.HeaderText = "iznajmljen_od";
            this.iznajmljenodDataGridViewTextBoxColumn.Name = "iznajmljenodDataGridViewTextBoxColumn";
            // 
            // iznajmljendoDataGridViewTextBoxColumn
            // 
            this.iznajmljendoDataGridViewTextBoxColumn.DataPropertyName = "iznajmljen_do";
            this.iznajmljendoDataGridViewTextBoxColumn.HeaderText = "iznajmljen_do";
            this.iznajmljendoDataGridViewTextBoxColumn.Name = "iznajmljendoDataGridViewTextBoxColumn";
            // 
            // datumnajmaDataGridViewTextBoxColumn
            // 
            this.datumnajmaDataGridViewTextBoxColumn.DataPropertyName = "datum_najma";
            this.datumnajmaDataGridViewTextBoxColumn.HeaderText = "datum_najma";
            this.datumnajmaDataGridViewTextBoxColumn.Name = "datumnajmaDataGridViewTextBoxColumn";
            // 
            // godinanajmaDataGridViewTextBoxColumn
            // 
            this.godinanajmaDataGridViewTextBoxColumn.DataPropertyName = "godina_najma";
            this.godinanajmaDataGridViewTextBoxColumn.HeaderText = "godina_najma";
            this.godinanajmaDataGridViewTextBoxColumn.Name = "godinanajmaDataGridViewTextBoxColumn";
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
            this.ClientSize = new System.Drawing.Size(786, 433);
            this.Controls.Add(this.dataGridNajam);
            this.Controls.Add(this.listaNajam);
            this.Controls.Add(this.Pregled);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Iznajmljivanje";
            this.Text = "Najam";
            this.Load += new System.EventHandler(this.Iznajmljivanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNajam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.najamBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private autoDataSet autoDataSet;
        private System.Windows.Forms.Label Pregled;
        private System.Windows.Forms.ListBox listaNajam;
        private System.Windows.Forms.DataGridView dataGridNajam;
        private System.Windows.Forms.BindingSource najamBindingSource;
        private autoDataSetTableAdapters.najamTableAdapter najamTableAdapter;
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

