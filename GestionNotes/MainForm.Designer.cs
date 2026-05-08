namespace GestionNotes
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
            lblTitre = new Label();
            btnAjouter = new Button();
            btnGraphiques = new Button();
            btnConsulter = new Button();
            btnSauvegarder = new Button();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.BorderStyle = BorderStyle.FixedSingle;
            lblTitre.Font = new Font("Cambria", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(-7, -5);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(751, 48);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Gestionnaire 2 Notes";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAjouter
            // 
            btnAjouter.Font = new Font("MV Boli", 20.25F);
            btnAjouter.Location = new Point(12, 64);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(334, 183);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "Ajouter une note";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnGraphiques
            // 
            btnGraphiques.Font = new Font("MV Boli", 20.25F);
            btnGraphiques.Location = new Point(12, 255);
            btnGraphiques.Name = "btnGraphiques";
            btnGraphiques.Size = new Size(334, 183);
            btnGraphiques.TabIndex = 2;
            btnGraphiques.Text = "Graphiques";
            btnGraphiques.UseVisualStyleBackColor = true;
            // 
            // btnConsulter
            // 
            btnConsulter.Font = new Font("MV Boli", 20.25F);
            btnConsulter.Location = new Point(388, 64);
            btnConsulter.Name = "btnConsulter";
            btnConsulter.Size = new Size(334, 183);
            btnConsulter.TabIndex = 3;
            btnConsulter.Text = "Consulter les notes";
            btnConsulter.UseVisualStyleBackColor = true;
            // 
            // btnSauvegarder
            // 
            btnSauvegarder.Font = new Font("MV Boli", 20.25F);
            btnSauvegarder.Location = new Point(388, 255);
            btnSauvegarder.Name = "btnSauvegarder";
            btnSauvegarder.Size = new Size(334, 183);
            btnSauvegarder.TabIndex = 4;
            btnSauvegarder.Text = "Sauvegarder";
            btnSauvegarder.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 450);
            Controls.Add(btnSauvegarder);
            Controls.Add(btnConsulter);
            Controls.Add(btnGraphiques);
            Controls.Add(btnAjouter);
            Controls.Add(lblTitre);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitre;
        private Button btnAjouter;
        private Button btnGraphiques;
        private Button btnConsulter;
        private Button btnSauvegarder;
    }
}