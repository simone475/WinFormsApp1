namespace WinFormsApp1
{
    partial class Form1
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
            btnGeneraCoppie = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            btnAggiungiStudente = new Button();
            lblCognome = new Label();
            lblAnnoNascita = new Label();
            lblAbilita = new Label();
            txtCognome = new TextBox();
            txtAnnoNascita = new TextBox();
            txtAbilita = new TextBox();
            lblStudentiPesenti = new Label();
            txtStudentiPresenti = new TextBox();
            btnGiallo = new Button();
            btnRosso = new Button();
            btnVerde = new Button();
            btnCerca_1 = new Button();
            btnCerca_2 = new Button();
            btnCerca_3 = new Button();
            btnCerca_4 = new Button();
            SuspendLayout();
            // 
            // btnGeneraCoppie
            // 
            btnGeneraCoppie.AutoSize = true;
            btnGeneraCoppie.Font = new Font("Segoe UI", 12F);
            btnGeneraCoppie.ForeColor = SystemColors.Highlight;
            btnGeneraCoppie.Location = new Point(407, 385);
            btnGeneraCoppie.Name = "btnGeneraCoppie";
            btnGeneraCoppie.Size = new Size(194, 31);
            btnGeneraCoppie.TabIndex = 0;
            btnGeneraCoppie.Text = "Genera Coppie studenti";
            btnGeneraCoppie.UseVisualStyleBackColor = true;
            btnGeneraCoppie.Click += btnGeneraCoppie_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNome.ForeColor = SystemColors.HotTrack;
            lblNome.Location = new Point(66, 17);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(52, 20);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(124, 14);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(377, 23);
            txtNome.TabIndex = 2;
            // 
            // btnAggiungiStudente
            // 
            btnAggiungiStudente.AutoSize = true;
            btnAggiungiStudente.Font = new Font("Segoe UI", 12F);
            btnAggiungiStudente.ForeColor = Color.OrangeRed;
            btnAggiungiStudente.Location = new Point(232, 385);
            btnAggiungiStudente.Name = "btnAggiungiStudente";
            btnAggiungiStudente.Size = new Size(157, 31);
            btnAggiungiStudente.TabIndex = 3;
            btnAggiungiStudente.Text = "Aggiungi Studente";
            btnAggiungiStudente.UseVisualStyleBackColor = true;
            btnAggiungiStudente.Click += btnAggiungiStudente_Click;
            // 
            // lblCognome
            // 
            lblCognome.AutoSize = true;
            lblCognome.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCognome.ForeColor = SystemColors.HotTrack;
            lblCognome.Location = new Point(42, 70);
            lblCognome.Name = "lblCognome";
            lblCognome.Size = new Size(76, 20);
            lblCognome.TabIndex = 4;
            lblCognome.Text = "Cognome";
            // 
            // lblAnnoNascita
            // 
            lblAnnoNascita.AutoSize = true;
            lblAnnoNascita.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAnnoNascita.ForeColor = SystemColors.HotTrack;
            lblAnnoNascita.Location = new Point(-2, 124);
            lblAnnoNascita.Name = "lblAnnoNascita";
            lblAnnoNascita.Size = new Size(120, 20);
            lblAnnoNascita.TabIndex = 5;
            lblAnnoNascita.Text = "Anno di Nascita";
            // 
            // lblAbilita
            // 
            lblAbilita.AutoSize = true;
            lblAbilita.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAbilita.ForeColor = SystemColors.HotTrack;
            lblAbilita.Location = new Point(63, 177);
            lblAbilita.Name = "lblAbilita";
            lblAbilita.Size = new Size(55, 20);
            lblAbilita.TabIndex = 6;
            lblAbilita.Text = "Abilità";
            // 
            // txtCognome
            // 
            txtCognome.BackColor = SystemColors.Window;
            txtCognome.ForeColor = SystemColors.MenuText;
            txtCognome.Location = new Point(124, 67);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(377, 23);
            txtCognome.TabIndex = 7;
            // 
            // txtAnnoNascita
            // 
            txtAnnoNascita.Location = new Point(124, 121);
            txtAnnoNascita.Name = "txtAnnoNascita";
            txtAnnoNascita.Size = new Size(377, 23);
            txtAnnoNascita.TabIndex = 8;
            // 
            // txtAbilita
            // 
            txtAbilita.Location = new Point(124, 174);
            txtAbilita.Name = "txtAbilita";
            txtAbilita.Size = new Size(377, 23);
            txtAbilita.TabIndex = 9;
            // 
            // lblStudentiPesenti
            // 
            lblStudentiPesenti.AutoSize = true;
            lblStudentiPesenti.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStudentiPesenti.Location = new Point(18, 333);
            lblStudentiPesenti.Name = "lblStudentiPesenti";
            lblStudentiPesenti.Size = new Size(145, 21);
            lblStudentiPesenti.TabIndex = 10;
            lblStudentiPesenti.Text = "Studenti presenti:";
            // 
            // txtStudentiPresenti
            // 
            txtStudentiPresenti.Location = new Point(174, 335);
            txtStudentiPresenti.Name = "txtStudentiPresenti";
            txtStudentiPresenti.Size = new Size(100, 23);
            txtStudentiPresenti.TabIndex = 11;
            // 
            // btnGiallo
            // 
            btnGiallo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGiallo.ForeColor = Color.Gold;
            btnGiallo.Location = new Point(240, 261);
            btnGiallo.Margin = new Padding(2);
            btnGiallo.Name = "btnGiallo";
            btnGiallo.Size = new Size(78, 38);
            btnGiallo.TabIndex = 12;
            btnGiallo.Text = "Giallo";
            btnGiallo.UseVisualStyleBackColor = true;
            btnGiallo.Click += CambiaSfondoForm;
            // 
            // btnRosso
            // 
            btnRosso.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRosso.ForeColor = Color.Red;
            btnRosso.Location = new Point(352, 260);
            btnRosso.Margin = new Padding(2);
            btnRosso.Name = "btnRosso";
            btnRosso.Size = new Size(78, 39);
            btnRosso.TabIndex = 13;
            btnRosso.Text = "Rosso";
            btnRosso.UseVisualStyleBackColor = true;
            btnRosso.Click += CambiaSfondoForm;
            // 
            // btnVerde
            // 
            btnVerde.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVerde.ForeColor = Color.Green;
            btnVerde.Location = new Point(463, 259);
            btnVerde.Margin = new Padding(2);
            btnVerde.Name = "btnVerde";
            btnVerde.Size = new Size(90, 40);
            btnVerde.TabIndex = 14;
            btnVerde.Text = "Verde";
            btnVerde.UseVisualStyleBackColor = true;
            btnVerde.Click += CambiaSfondoForm;
            // 
            // btnCerca_1
            // 
            btnCerca_1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCerca_1.Location = new Point(515, 14);
            btnCerca_1.Margin = new Padding(2);
            btnCerca_1.Name = "btnCerca_1";
            btnCerca_1.Size = new Size(63, 26);
            btnCerca_1.TabIndex = 15;
            btnCerca_1.Text = "Cerca";
            btnCerca_1.UseVisualStyleBackColor = true;
            btnCerca_1.Click += btnCerca_1_Click;
            // 
            // btnCerca_2
            // 
            btnCerca_2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerca_2.Location = new Point(515, 66);
            btnCerca_2.Margin = new Padding(2);
            btnCerca_2.Name = "btnCerca_2";
            btnCerca_2.Size = new Size(63, 26);
            btnCerca_2.TabIndex = 16;
            btnCerca_2.Text = "Cerca";
            btnCerca_2.UseVisualStyleBackColor = true;
            btnCerca_2.Click += btnCerca_2_Click;
            // 
            // btnCerca_3
            // 
            btnCerca_3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCerca_3.Location = new Point(515, 121);
            btnCerca_3.Margin = new Padding(2);
            btnCerca_3.Name = "btnCerca_3";
            btnCerca_3.Size = new Size(63, 25);
            btnCerca_3.TabIndex = 17;
            btnCerca_3.Text = "Cerca";
            btnCerca_3.UseVisualStyleBackColor = true;
            btnCerca_3.Click += btnCerca_3_Click;
            // 
            // btnCerca_4
            // 
            btnCerca_4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCerca_4.Location = new Point(515, 174);
            btnCerca_4.Margin = new Padding(2);
            btnCerca_4.Name = "btnCerca_4";
            btnCerca_4.Size = new Size(63, 25);
            btnCerca_4.TabIndex = 18;
            btnCerca_4.Text = "Cerca";
            btnCerca_4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 610);
            Controls.Add(btnCerca_4);
            Controls.Add(btnCerca_3);
            Controls.Add(btnCerca_2);
            Controls.Add(btnCerca_1);
            Controls.Add(btnVerde);
            Controls.Add(btnRosso);
            Controls.Add(btnGiallo);
            Controls.Add(txtStudentiPresenti);
            Controls.Add(lblStudentiPesenti);
            Controls.Add(txtAbilita);
            Controls.Add(txtAnnoNascita);
            Controls.Add(txtCognome);
            Controls.Add(lblAbilita);
            Controls.Add(lblAnnoNascita);
            Controls.Add(lblCognome);
            Controls.Add(btnAggiungiStudente);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnGeneraCoppie);
            Name = "Form1";
            Text = "FormMain";
            Click += CambiaSfondoForm;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGeneraCoppie;
        private Label lblNome;
        private TextBox txtNome;
        private Button btnAggiungiStudente;
        private Label lblCognome;
        private Label lblAnnoNascita;
        private Label lblAbilita;
        private TextBox txtCognome;
        private TextBox txtAnnoNascita;
        private TextBox txtAbilita;
        private Label lblStudentiPesenti;
        private TextBox txtStudentiPresenti;
        private Button btnGiallo;
        private Button btnRosso;
        private Button btnVerde;
        private Button btnCerca_1;
        private Button btnCerca_2;
        private Button btnCerca_3;
        private Button btnCerca_4;
    }
}
