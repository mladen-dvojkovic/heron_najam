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
            this.button1 = new System.Windows.Forms.Button();
            this.inputNaziv = new System.Windows.Forms.TextBox();
            this.cijena_sat = new System.Windows.Forms.Label();
            this.dgAutomobil = new System.Windows.Forms.DataGridView();
            this.naziv_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAutomobil)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputNaziv
            // 
            this.inputNaziv.Location = new System.Drawing.Point(65, 251);
            this.inputNaziv.Name = "inputNaziv";
            this.inputNaziv.Size = new System.Drawing.Size(135, 20);
            this.inputNaziv.TabIndex = 2;
            // 
            // cijena_sat
            // 
            this.cijena_sat.AutoSize = true;
            this.cijena_sat.Location = new System.Drawing.Point(206, 254);
            this.cijena_sat.Name = "cijena_sat";
            this.cijena_sat.Size = new System.Drawing.Size(55, 13);
            this.cijena_sat.TabIndex = 5;
            this.cijena_sat.Text = "Cijena/sat";
            // 
            // dgAutomobil
            // 
            this.dgAutomobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAutomobil.Location = new System.Drawing.Point(13, 13);
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
            // Automobili
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 387);
            this.Controls.Add(this.naziv_text);
            this.Controls.Add(this.dgAutomobil);
            this.Controls.Add(this.cijena_sat);
            this.Controls.Add(this.inputNaziv);
            this.Controls.Add(this.button1);
            this.Name = "Automobili";
            this.Text = "Automobili";
            this.Load += new System.EventHandler(this.Automobili_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAutomobil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputNaziv;
        private System.Windows.Forms.TextBox @Cijena;
        private System.Windows.Forms.Label naziv;
        private System.Windows.Forms.Label cijena_sat;
        private System.Windows.Forms.DataGridView dgAutomobil;
        private System.Windows.Forms.Label naziv_text;
    }
}