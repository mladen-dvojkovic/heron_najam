namespace heron_najam
{
    partial class Automobili
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
            this.btn_Spremi = new System.Windows.Forms.Button();
            this.inputNaziv = new System.Windows.Forms.TextBox();
            this.cijena_sat = new System.Windows.Forms.Label();
            this.dgAutomobil = new System.Windows.Forms.DataGridView();
            this.naziv_text = new System.Windows.Forms.Label();
            this.numCijenaPoSatu = new System.Windows.Forms.NumericUpDown();
            this.btn_Odustani = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaSatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.automobilVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgAutomobil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCijenaPoSatu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Spremi
            // 
            this.btn_Spremi.Location = new System.Drawing.Point(338, 246);
            this.btn_Spremi.Name = "btn_Spremi";
            this.btn_Spremi.Size = new System.Drawing.Size(75, 23);
            this.btn_Spremi.TabIndex = 1;
            this.btn_Spremi.Text = "Dodaj";
            this.btn_Spremi.UseVisualStyleBackColor = true;
            this.btn_Spremi.Click += new System.EventHandler(this.btn_Spremi_Click);
            // 
            // inputNaziv
            // 
            this.inputNaziv.Location = new System.Drawing.Point(53, 248);
            this.inputNaziv.Name = "inputNaziv";
            this.inputNaziv.Size = new System.Drawing.Size(135, 20);
            this.inputNaziv.TabIndex = 2;
            // 
            // cijena_sat
            // 
            this.cijena_sat.AutoSize = true;
            this.cijena_sat.Location = new System.Drawing.Point(194, 250);
            this.cijena_sat.Name = "cijena_sat";
            this.cijena_sat.Size = new System.Drawing.Size(55, 13);
            this.cijena_sat.TabIndex = 5;
            this.cijena_sat.Text = "Cijena/sat";
            // 
            // dgAutomobil
            // 
            this.dgAutomobil.AutoGenerateColumns = false;
            this.dgAutomobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAutomobil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaSatDataGridViewTextBoxColumn});
            this.dgAutomobil.DataSource = this.automobilVMBindingSource;
            this.dgAutomobil.Location = new System.Drawing.Point(12, 12);
            this.dgAutomobil.Name = "dgAutomobil";
            this.dgAutomobil.Size = new System.Drawing.Size(401, 186);
            this.dgAutomobil.TabIndex = 6;
            // 
            // naziv_text
            // 
            this.naziv_text.AutoSize = true;
            this.naziv_text.Location = new System.Drawing.Point(13, 251);
            this.naziv_text.Name = "naziv_text";
            this.naziv_text.Size = new System.Drawing.Size(34, 13);
            this.naziv_text.TabIndex = 7;
            this.naziv_text.Text = "Naziv";
            // 
            // numCijenaPoSatu
            // 
            this.numCijenaPoSatu.Location = new System.Drawing.Point(255, 248);
            this.numCijenaPoSatu.Name = "numCijenaPoSatu";
            this.numCijenaPoSatu.Size = new System.Drawing.Size(58, 20);
            this.numCijenaPoSatu.TabIndex = 8;
            // 
            // btn_Odustani
            // 
            this.btn_Odustani.Location = new System.Drawing.Point(338, 276);
            this.btn_Odustani.Name = "btn_Odustani";
            this.btn_Odustani.Size = new System.Drawing.Size(75, 23);
            this.btn_Odustani.TabIndex = 9;
            this.btn_Odustani.Text = "Zatvori";
            this.btn_Odustani.UseVisualStyleBackColor = true;
            this.btn_Odustani.Click += new System.EventHandler(this.btn_Odustani_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 205;
            // 
            // cijenaSatDataGridViewTextBoxColumn
            // 
            this.cijenaSatDataGridViewTextBoxColumn.DataPropertyName = "CijenaSat";
            this.cijenaSatDataGridViewTextBoxColumn.HeaderText = "CijenaSat";
            this.cijenaSatDataGridViewTextBoxColumn.Name = "cijenaSatDataGridViewTextBoxColumn";
            // 
            // automobilVMBindingSource
            // 
            this.automobilVMBindingSource.DataSource = typeof(heron_najam.ViewModel.AutomobilVM);
            // 
            // Automobili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 387);
            this.Controls.Add(this.btn_Odustani);
            this.Controls.Add(this.numCijenaPoSatu);
            this.Controls.Add(this.naziv_text);
            this.Controls.Add(this.dgAutomobil);
            this.Controls.Add(this.cijena_sat);
            this.Controls.Add(this.inputNaziv);
            this.Controls.Add(this.btn_Spremi);
            this.Name = "Automobili";
            this.Text = "Automobili";
            this.Load += new System.EventHandler(this.Automobili_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAutomobil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCijenaPoSatu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automobilVMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Spremi;
        private System.Windows.Forms.TextBox inputNaziv;
        private System.Windows.Forms.TextBox @Cijena;
        private System.Windows.Forms.Label naziv;
        private System.Windows.Forms.Label cijena_sat;
        private System.Windows.Forms.DataGridView dgAutomobil;
        private System.Windows.Forms.Label naziv_text;
        private System.Windows.Forms.BindingSource automobilVMBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaSatDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown numCijenaPoSatu;
        private System.Windows.Forms.Button btn_Odustani;
    }
}