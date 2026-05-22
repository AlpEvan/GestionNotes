namespace GestionNotes
{
    partial class PageVoirNotes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.Button btnRetour;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvNotes = new System.Windows.Forms.DataGridView();
            btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvNotes).BeginInit();
            SuspendLayout();
            // 
            // dgvNotes
            // 
            dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotes.Location = new System.Drawing.Point(12, 12);
            dgvNotes.Name = "dgvNotes";
            dgvNotes.ReadOnly = true;
            dgvNotes.Size = new System.Drawing.Size(560, 300);
            dgvNotes.TabIndex = 0;
            // 
            // btnRetour
            // 
            btnRetour.Location = new System.Drawing.Point(12, 320);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new System.Drawing.Size(100, 30);
            btnRetour.TabIndex = 1;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // PageVoirNotes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(584, 361);
            Controls.Add(btnRetour);
            Controls.Add(dgvNotes);
            Name = "PageVoirNotes";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Voir mes notes";
            ((System.ComponentModel.ISupportInitialize)dgvNotes).EndInit();
            ResumeLayout(false);
        }
    }
}
