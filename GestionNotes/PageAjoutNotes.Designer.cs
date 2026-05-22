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
            components = new System.ComponentModel.Container();
            lblNote = new Label();
            numNote = new NumericUpDown();
            lblCoefficient = new Label();
            numCoefficient = new NumericUpDown();
            btnAjouter = new Button();
            cmbBranches = new ComboBox();
            label1 = new Label();
            databaseManagerBindingSource = new BindingSource(components);
            databaseManagerBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)numNote).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCoefficient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseManagerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseManagerBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNote.Location = new Point(9, 31);
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
            numNote.Size = new Size(56, 23);
            numNote.TabIndex = 1;
            numNote.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCoefficient
            // 
            lblCoefficient.AutoSize = true;
            lblCoefficient.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCoefficient.Location = new Point(9, 67);
            lblCoefficient.Name = "lblCoefficient";
            lblCoefficient.Size = new Size(88, 20);
            lblCoefficient.TabIndex = 2;
            lblCoefficient.Text = "Coefficient :";
            // 
            // numCoefficient
            // 
            numCoefficient.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numCoefficient.Location = new Point(106, 69);
            numCoefficient.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            numCoefficient.Name = "numCoefficient";
            numCoefficient.Size = new Size(56, 23);
            numCoefficient.TabIndex = 3;
            numCoefficient.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAjouter
            // 
            btnAjouter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAjouter.Location = new Point(51, 152);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(150, 30);
            btnAjouter.TabIndex = 6;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // cmbBranches
            // 
            cmbBranches.FormattingEnabled = true;
            cmbBranches.Location = new Point(106, 110);
            cmbBranches.Name = "cmbBranches";
            cmbBranches.Size = new Size(121, 23);
            cmbBranches.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 109);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 4;
            label1.Text = "Branche :";
            // 
            // databaseManagerBindingSource
            // 
            databaseManagerBindingSource.DataSource = typeof(DatabaseManager);
            // 
            // databaseManagerBindingSource1
            // 
            databaseManagerBindingSource1.DataSource = typeof(DatabaseManager);
            // 
            // PageAjoutNotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 196);
            Controls.Add(label1);
            Controls.Add(cmbBranches);
            Controls.Add(btnAjouter);
            Controls.Add(numCoefficient);
            Controls.Add(lblCoefficient);
            Controls.Add(numNote);
            Controls.Add(lblNote);
            Name = "PageAjoutNotes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PageAjoutNotes";
            ((System.ComponentModel.ISupportInitialize)numNote).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCoefficient).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseManagerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseManagerBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNote;
        private NumericUpDown numNote;
        private Label lblCoefficient;
        private NumericUpDown numCoefficient;
        private Button btnAjouter;
        private ComboBox cmbBranches;
        private Label label1;
        private BindingSource databaseManagerBindingSource;
        private BindingSource databaseManagerBindingSource1;
    }
}