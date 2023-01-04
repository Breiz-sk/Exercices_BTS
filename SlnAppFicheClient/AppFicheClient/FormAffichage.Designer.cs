
namespace AppFicheClient
{
    partial class FormAffichage
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
            this.fermerBtn = new System.Windows.Forms.Button();
            this.affichageLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fermerBtn
            // 
            this.fermerBtn.Location = new System.Drawing.Point(259, 364);
            this.fermerBtn.Name = "fermerBtn";
            this.fermerBtn.Size = new System.Drawing.Size(231, 36);
            this.fermerBtn.TabIndex = 0;
            this.fermerBtn.Text = "Fermer";
            this.fermerBtn.UseVisualStyleBackColor = true;
            this.fermerBtn.UseWaitCursor = true;
            this.fermerBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // affichageLb
            // 
            this.affichageLb.AutoSize = true;
            this.affichageLb.Location = new System.Drawing.Point(334, 83);
            this.affichageLb.Name = "affichageLb";
            this.affichageLb.Size = new System.Drawing.Size(47, 13);
            this.affichageLb.TabIndex = 1;
            this.affichageLb.Text = "template";
            // 
            // FormAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.affichageLb);
            this.Controls.Add(this.fermerBtn);
            this.Name = "FormAffichage";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormAffichage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fermerBtn;
        private System.Windows.Forms.Label affichageLb;
    }
}