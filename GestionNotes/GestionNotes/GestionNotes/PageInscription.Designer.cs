namespace GestionNotes
{
    partial class PageInscription
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
            panel1 = new Panel();
            tbxMdp = new TextBox();
            lblMdp = new Label();
            btnConfirmerInscription = new Button();
            lblTitreInscription = new Label();
            tbxEmail = new TextBox();
            lblEmail = new Label();
            tbxNom = new TextBox();
            lblNom = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tbxNom);
            panel1.Controls.Add(lblNom);
            panel1.Controls.Add(tbxEmail);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(tbxMdp);
            panel1.Controls.Add(lblMdp);
            panel1.Controls.Add(btnConfirmerInscription);
            panel1.Location = new Point(12, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 334);
            panel1.TabIndex = 4;
            // 
            // tbxMdp
            // 
            tbxMdp.Font = new Font("Segoe UI", 14.25F);
            tbxMdp.Location = new Point(3, 217);
            tbxMdp.Multiline = true;
            tbxMdp.Name = "tbxMdp";
            tbxMdp.Size = new Size(301, 35);
            tbxMdp.TabIndex = 4;
            // 
            // lblMdp
            // 
            lblMdp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMdp.Location = new Point(3, 182);
            lblMdp.Name = "lblMdp";
            lblMdp.Size = new Size(301, 23);
            lblMdp.TabIndex = 3;
            lblMdp.Text = "Mot de passe";
            // 
            // btnConfirmerInscription
            // 
            btnConfirmerInscription.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmerInscription.Location = new Point(13, 265);
            btnConfirmerInscription.Name = "btnConfirmerInscription";
            btnConfirmerInscription.Size = new Size(281, 50);
            btnConfirmerInscription.TabIndex = 1;
            btnConfirmerInscription.Text = "Confirmer";
            btnConfirmerInscription.UseVisualStyleBackColor = true;
            btnConfirmerInscription.Click += btnConfirmerInscription_Click;
            // 
            // lblTitreInscription
            // 
            lblTitreInscription.BorderStyle = BorderStyle.FixedSingle;
            lblTitreInscription.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitreInscription.Location = new Point(12, 8);
            lblTitreInscription.Name = "lblTitreInscription";
            lblTitreInscription.Size = new Size(309, 48);
            lblTitreInscription.TabIndex = 3;
            lblTitreInscription.Text = "Inscription";
            lblTitreInscription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Segoe UI", 14.25F);
            tbxEmail.Location = new Point(3, 135);
            tbxEmail.Multiline = true;
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(301, 35);
            tbxEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(3, 99);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(301, 23);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // tbxNom
            // 
            tbxNom.Font = new Font("Segoe UI", 14.25F);
            tbxNom.Location = new Point(3, 50);
            tbxNom.Multiline = true;
            tbxNom.Name = "tbxNom";
            tbxNom.Size = new Size(301, 35);
            tbxNom.TabIndex = 8;
            // 
            // lblNom
            // 
            lblNom.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNom.Location = new Point(-1, 14);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(301, 23);
            lblNom.TabIndex = 7;
            lblNom.Text = "Nom";
            // 
            // PageInscription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 449);
            Controls.Add(panel1);
            Controls.Add(lblTitreInscription);
            Name = "PageInscription";
            Text = "PageInscription";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInscription;
        private Panel panel1;
        private TextBox tbxNom;
        private Label lblNom;
        private TextBox tbxEmail;
        private Label lblEmail;
        private TextBox tbxMdp;
        private Label lblMdp;
        private Button btnConfirmerInscription;
        private Label lblTitreInscription;
    }
}