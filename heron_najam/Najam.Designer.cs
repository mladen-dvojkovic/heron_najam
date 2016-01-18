namespace heron_najam
{
    partial class Najam
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
            this.comboListaAuta = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.odabirAuto = new System.Windows.Forms.Label();
            this.najamOd = new System.Windows.Forms.Label();
            this.najamDo = new System.Windows.Forms.Label();
            this.nositeljNajma = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NoviPutnik = new System.Windows.Forms.Label();
            this.Putnik_1 = new System.Windows.Forms.TextBox();
            this.dodajPutnik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboListaAuta
            // 
            this.comboListaAuta.FormattingEnabled = true;
            this.comboListaAuta.Location = new System.Drawing.Point(23, 29);
            this.comboListaAuta.Name = "comboListaAuta";
            this.comboListaAuta.Size = new System.Drawing.Size(195, 21);
            this.comboListaAuta.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(26, 151);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // odabirAuto
            // 
            this.odabirAuto.AutoSize = true;
            this.odabirAuto.Location = new System.Drawing.Point(23, 13);
            this.odabirAuto.Name = "odabirAuto";
            this.odabirAuto.Size = new System.Drawing.Size(104, 13);
            this.odabirAuto.TabIndex = 3;
            this.odabirAuto.Text = "Odaberite automobil:";
            // 
            // najamOd
            // 
            this.najamOd.AutoSize = true;
            this.najamOd.Location = new System.Drawing.Point(23, 77);
            this.najamOd.Name = "najamOd";
            this.najamOd.Size = new System.Drawing.Size(81, 13);
            this.najamOd.TabIndex = 4;
            this.najamOd.Text = "Početak najma:";
            // 
            // najamDo
            // 
            this.najamDo.AutoSize = true;
            this.najamDo.Location = new System.Drawing.Point(23, 135);
            this.najamDo.Name = "najamDo";
            this.najamDo.Size = new System.Drawing.Size(86, 13);
            this.najamDo.TabIndex = 5;
            this.najamDo.Text = "Završetak najma";
            // 
            // nositeljNajma
            // 
            this.nositeljNajma.AutoSize = true;
            this.nositeljNajma.Location = new System.Drawing.Point(23, 199);
            this.nositeljNajma.Name = "nositeljNajma";
            this.nositeljNajma.Size = new System.Drawing.Size(72, 13);
            this.nositeljNajma.TabIndex = 6;
            this.nositeljNajma.Text = "Nositelj najma";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 7;
            // 
            // NoviPutnik
            // 
            this.NoviPutnik.AutoSize = true;
            this.NoviPutnik.Location = new System.Drawing.Point(26, 257);
            this.NoviPutnik.Name = "NoviPutnik";
            this.NoviPutnik.Size = new System.Drawing.Size(61, 13);
            this.NoviPutnik.TabIndex = 8;
            this.NoviPutnik.Text = "Novi putnik";
            // 
            // Putnik_1
            // 
            this.Putnik_1.Location = new System.Drawing.Point(26, 280);
            this.Putnik_1.Name = "Putnik_1";
            this.Putnik_1.Size = new System.Drawing.Size(186, 20);
            this.Putnik_1.TabIndex = 9;
            // 
            // dodajPutnik
            // 
            this.dodajPutnik.Location = new System.Drawing.Point(88, 251);
            this.dodajPutnik.Name = "dodajPutnik";
            this.dodajPutnik.Size = new System.Drawing.Size(39, 23);
            this.dodajPutnik.TabIndex = 10;
            this.dodajPutnik.Text = "+";
            this.dodajPutnik.UseVisualStyleBackColor = true;
            // 
            // Najam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 381);
            this.Controls.Add(this.dodajPutnik);
            this.Controls.Add(this.Putnik_1);
            this.Controls.Add(this.NoviPutnik);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nositeljNajma);
            this.Controls.Add(this.najamDo);
            this.Controls.Add(this.najamOd);
            this.Controls.Add(this.odabirAuto);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboListaAuta);
            this.Name = "Najam";
            this.Text = "Najam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboListaAuta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label odabirAuto;
        private System.Windows.Forms.Label najamOd;
        private System.Windows.Forms.Label najamDo;
        private System.Windows.Forms.Label nositeljNajma;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NoviPutnik;
        private System.Windows.Forms.TextBox Putnik_1;
        private System.Windows.Forms.Button dodajPutnik;
    }
}