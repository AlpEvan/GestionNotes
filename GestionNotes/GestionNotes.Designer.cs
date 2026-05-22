namespace GestionNotes
{
    partial class GestionNotes
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
            lblTitreConnexion = new Label();
            panel1 = new Panel();
            tbxMdp = new TextBox();
            lblMdp = new Label();
            tbxEmail = new TextBox();
            btnConnexion = new Button();
            lblEmail = new Label();
            btnInscription = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitreConnexion
            // 
            lblTitreConnexion.BorderStyle = BorderStyle.FixedSingle;
            lblTitreConnexion.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitreConnexion.Location = new Point(12, 9);
            lblTitreConnexion.Name = "lblTitreConnexion";
            lblTitreConnexion.Size = new Size(309, 48);
            lblTitreConnexion.TabIndex = 0;
            lblTitreConnexion.Text = "Connexion";
            lblTitreConnexion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tbxMdp);
            panel1.Controls.Add(lblMdp);
            panel1.Controls.Add(tbxEmail);
            panel1.Controls.Add(btnConnexion);
            panel1.Controls.Add(lblEmail);
            panel1.Location = new Point(12, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 334);
            panel1.TabIndex = 1;
            // 
            // tbxMdp
            // 
            tbxMdp.Font = new Font("Segoe UI", 14.25F);
            tbxMdp.Location = new Point(3, 162);
            tbxMdp.Multiline = true;
            tbxMdp.Name = "tbxMdp";
            tbxMdp.Size = new Size(301, 35);
            tbxMdp.TabIndex = 3;
            tbxMdp.Text = "Super";
            // 
            // lblMdp
            // 
            lblMdp.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMdp.Location = new Point(3, 127);
            lblMdp.Name = "lblMdp";
            lblMdp.Size = new Size(301, 23);
            lblMdp.TabIndex = 2;
            lblMdp.Text = "Mot de passe";
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Segoe UI", 14.25F);
            tbxEmail.Location = new Point(3, 45);
            tbxEmail.Multiline = true;
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(301, 35);
            tbxEmail.TabIndex = 1;
            tbxEmail.Text = "evan@gmail.com";
            // 
            // btnConnexion
            // 
            btnConnexion.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConnexion.Location = new Point(13, 265);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(281, 50);
            btnConnexion.TabIndex = 4;
            btnConnexion.Text = "Se connecter";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(3, 10);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(301, 23);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // btnInscription
            // 
            btnInscription.ForeColor = SystemColors.HotTrack;
            btnInscription.Location = new Point(128, 418);
            btnInscription.Name = "btnInscription";
            btnInscription.Size = new Size(75, 23);
            btnInscription.TabIndex = 2;
            btnInscription.Text = "S'inscrire ?";
            btnInscription.UseVisualStyleBackColor = true;
            btnInscription.Click += btnInscription_Click;
            // 
            // GestionNotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(333, 449);
            Controls.Add(btnInscription);
            Controls.Add(panel1);
            Controls.Add(lblTitreConnexion);
            Name = "GestionNotes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion des notes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitreConnexion;
        private Panel panel1;
        private TextBox tbxEmail;
        private Button btnConnexion;
        private Label lblEmail;
        private TextBox tbxMdp;
        private Label lblMdp;
        private Button btnInscription;
    }
}
