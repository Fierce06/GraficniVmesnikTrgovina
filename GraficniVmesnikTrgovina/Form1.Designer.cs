namespace GraficniVmesnikTrgovina
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxTelefon = new System.Windows.Forms.GroupBox();
            this.txtBaterija = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chk5G = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.groupBoxIzdelek = new System.Windows.Forms.GroupBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.groupBoxLaptop = new System.Windows.Forms.GroupBox();
            this.txtTeza = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProcesor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbRam = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnCena = new System.Windows.Forms.Button();
            this.lstIzdelki = new System.Windows.Forms.ListBox();
            this.txtKamera = new System.Windows.Forms.TextBox();
            this.lblCena = new System.Windows.Forms.Label();
            this.groupBoxTelefon.SuspendLayout();
            this.groupBoxIzdelek.SuspendLayout();
            this.groupBoxLaptop.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTelefon
            // 
            this.groupBoxTelefon.Controls.Add(this.txtKamera);
            this.groupBoxTelefon.Controls.Add(this.txtBaterija);
            this.groupBoxTelefon.Controls.Add(this.label6);
            this.groupBoxTelefon.Controls.Add(this.label5);
            this.groupBoxTelefon.Controls.Add(this.chk5G);
            this.groupBoxTelefon.Controls.Add(this.label4);
            this.groupBoxTelefon.Location = new System.Drawing.Point(350, 20);
            this.groupBoxTelefon.Name = "groupBoxTelefon";
            this.groupBoxTelefon.Size = new System.Drawing.Size(309, 170);
            this.groupBoxTelefon.TabIndex = 1;
            this.groupBoxTelefon.TabStop = false;
            this.groupBoxTelefon.Text = "Telefon";
            this.groupBoxTelefon.Visible = false;
            // 
            // txtBaterija
            // 
            this.txtBaterija.Location = new System.Drawing.Point(121, 118);
            this.txtBaterija.Name = "txtBaterija";
            this.txtBaterija.Size = new System.Drawing.Size(144, 22);
            this.txtBaterija.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Baterija (mah)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Podpora 5G";
            // 
            // chk5G
            // 
            this.chk5G.AutoSize = true;
            this.chk5G.Location = new System.Drawing.Point(121, 74);
            this.chk5G.Name = "chk5G";
            this.chk5G.Size = new System.Drawing.Size(18, 17);
            this.chk5G.TabIndex = 2;
            this.chk5G.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kamera (MP)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(82, 32);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(182, 22);
            this.txtNaziv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "cena (€)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "tip izdelka";
            // 
            // cmbTip
            // 
            this.cmbTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(106, 118);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(121, 24);
            this.cmbTip.TabIndex = 5;
            this.cmbTip.SelectedIndexChanged += new System.EventHandler(this.cmbTip_SelectedIndexChanged);
            // 
            // groupBoxIzdelek
            // 
            this.groupBoxIzdelek.Controls.Add(this.txtCena);
            this.groupBoxIzdelek.Controls.Add(this.cmbTip);
            this.groupBoxIzdelek.Controls.Add(this.label3);
            this.groupBoxIzdelek.Controls.Add(this.label2);
            this.groupBoxIzdelek.Controls.Add(this.txtNaziv);
            this.groupBoxIzdelek.Controls.Add(this.label1);
            this.groupBoxIzdelek.Location = new System.Drawing.Point(20, 20);
            this.groupBoxIzdelek.Name = "groupBoxIzdelek";
            this.groupBoxIzdelek.Size = new System.Drawing.Size(295, 170);
            this.groupBoxIzdelek.TabIndex = 0;
            this.groupBoxIzdelek.TabStop = false;
            this.groupBoxIzdelek.Text = "Izdelek";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(106, 74);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 22);
            this.txtCena.TabIndex = 6;
            // 
            // groupBoxLaptop
            // 
            this.groupBoxLaptop.Controls.Add(this.txtTeza);
            this.groupBoxLaptop.Controls.Add(this.label9);
            this.groupBoxLaptop.Controls.Add(this.txtProcesor);
            this.groupBoxLaptop.Controls.Add(this.label8);
            this.groupBoxLaptop.Controls.Add(this.cmbRam);
            this.groupBoxLaptop.Controls.Add(this.label7);
            this.groupBoxLaptop.Location = new System.Drawing.Point(350, 20);
            this.groupBoxLaptop.Name = "groupBoxLaptop";
            this.groupBoxLaptop.Size = new System.Drawing.Size(309, 170);
            this.groupBoxLaptop.TabIndex = 2;
            this.groupBoxLaptop.TabStop = false;
            this.groupBoxLaptop.Text = "Laptop";
            this.groupBoxLaptop.Visible = false;
            // 
            // txtTeza
            // 
            this.txtTeza.Location = new System.Drawing.Point(117, 130);
            this.txtTeza.Name = "txtTeza";
            this.txtTeza.Size = new System.Drawing.Size(133, 22);
            this.txtTeza.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Teža (kg)";
            // 
            // txtProcesor
            // 
            this.txtProcesor.Location = new System.Drawing.Point(117, 82);
            this.txtProcesor.Name = "txtProcesor";
            this.txtProcesor.Size = new System.Drawing.Size(175, 22);
            this.txtProcesor.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Procesor";
            // 
            // cmbRam
            // 
            this.cmbRam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRam.FormattingEnabled = true;
            this.cmbRam.Items.AddRange(new object[] {
            "8",
            "16",
            "32"});
            this.cmbRam.Location = new System.Drawing.Point(119, 37);
            this.cmbRam.Name = "cmbRam";
            this.cmbRam.Size = new System.Drawing.Size(121, 24);
            this.cmbRam.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "RAM (gb)";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(20, 205);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(144, 40);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj izdelek";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnCena
            // 
            this.btnCena.Location = new System.Drawing.Point(191, 205);
            this.btnCena.Name = "btnCena";
            this.btnCena.Size = new System.Drawing.Size(124, 40);
            this.btnCena.TabIndex = 4;
            this.btnCena.Text = "Izračunaj ceno";
            this.btnCena.UseVisualStyleBackColor = true;
            this.btnCena.Click += new System.EventHandler(this.btnCena_Click);
            // 
            // lstIzdelki
            // 
            this.lstIzdelki.FormattingEnabled = true;
            this.lstIzdelki.ItemHeight = 16;
            this.lstIzdelki.Location = new System.Drawing.Point(20, 291);
            this.lstIzdelki.Name = "lstIzdelki";
            this.lstIzdelki.Size = new System.Drawing.Size(570, 116);
            this.lstIzdelki.TabIndex = 5;
            // 
            // txtKamera
            // 
            this.txtKamera.Location = new System.Drawing.Point(130, 32);
            this.txtKamera.Name = "txtKamera";
            this.txtKamera.Size = new System.Drawing.Size(100, 22);
            this.txtKamera.TabIndex = 6;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(370, 217);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(95, 16);
            this.lblCena.TabIndex = 6;
            this.lblCena.Text = "Končna cena: /";
            this.lblCena.Click += new System.EventHandler(this.btnCena_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 458);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lstIzdelki);
            this.Controls.Add(this.btnCena);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBoxLaptop);
            this.Controls.Add(this.groupBoxTelefon);
            this.Controls.Add(this.groupBoxIzdelek);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trgovina";
            this.groupBoxTelefon.ResumeLayout(false);
            this.groupBoxTelefon.PerformLayout();
            this.groupBoxIzdelek.ResumeLayout(false);
            this.groupBoxIzdelek.PerformLayout();
            this.groupBoxLaptop.ResumeLayout(false);
            this.groupBoxLaptop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk5G;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.GroupBox groupBoxIzdelek;
        private System.Windows.Forms.GroupBox groupBoxLaptop;
        private System.Windows.Forms.ComboBox cmbRam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProcesor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtTeza;
        private System.Windows.Forms.TextBox txtBaterija;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnCena;
        private System.Windows.Forms.ListBox lstIzdelki;
        private System.Windows.Forms.TextBox txtKamera;
        private System.Windows.Forms.Label lblCena;
    }
}

