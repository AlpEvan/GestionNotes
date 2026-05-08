namespace GestionNotes
{
    partial class PageAjoutNotes
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
            lblNote = new Label();
            numNote = new NumericUpDown();
            lblCoefficient = new Label();
            numCoefficient = new NumericUpDown();
            btnAjouter = new Button();
            ((System.ComponentModel.ISupportInitialize)numNote).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCoefficient).BeginInit();
            SuspendLayout();
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNote.Location = new Point(9, 28);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(85, 20);
            lblNote.TabIndex = 0;
            lblNote.Text = "Note (1-6) :";
            // 
            // numNote
            // 
            numNote.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numNote.Location = new Point(106, 28);
            numNote.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numNote.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numNote.Name = "numNote";
            numNote.Size = new Size(31, 23);
            numNote.TabIndex = 1;
            numNote.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCoefficient
            // 
            lblCoefficient.AutoSize = true;
            lblCoefficient.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCoefficient.Location = new Point(9, 82);
            lblCoefficient.Name = "lblCoefficient";
            lblCoefficient.Size = new Size(88, 20);
            lblCoefficient.TabIndex = 2;
            lblCoefficient.Text = "Coefficient :";
            // 
            // numCoefficient
            // 
            numCoefficient.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numCoefficient.Location = new Point(106, 84);
            numCoefficient.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            numCoefficient.Name = "numCoefficient";
            numCoefficient.Size = new Size(31, 23);
            numCoefficient.TabIndex = 3;
            numCoefficient.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAjouter
            // 
            btnAjouter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAjouter.Location = new Point(14, 129);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(150, 30);
            btnAjouter.TabIndex = 4;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // PageAjoutNotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(176, 162);
            Controls.Add(btnAjouter);
            Controls.Add(numCoefficient);
            Controls.Add(lblCoefficient);
            Controls.Add(numNote);
            Controls.Add(lblNote);
            Name = "PageAjoutNotes";
            Text = "PageAjoutNotes";
            ((System.ComponentModel.ISupportInitialize)numNote).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCoefficient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNote;
        private NumericUpDown numNote;
        private Label lblCoefficient;
        private NumericUpDown numCoefficient;
        private Button btnAjouter;
    }
}