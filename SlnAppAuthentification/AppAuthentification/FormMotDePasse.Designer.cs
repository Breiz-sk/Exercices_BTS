
namespace AppAuthentification
{
    partial class FormMotDePasse
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomTB = new System.Windows.Forms.TextBox();
            this.mdpTB = new System.Windows.Forms.TextBox();
            this.validerBTn = new System.Windows.Forms.Button();
            this.fermerBtn = new System.Windows.Forms.Button();
            this.Popup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mot de passe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // nomTB
            // 
            this.nomTB.AccessibleName = "nomTB";
            this.nomTB.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.nomTB.Location = new System.Drawing.Point(263, 117);
            this.nomTB.MaxLength = 255;
            this.nomTB.Name = "nomTB";
            this.nomTB.Size = new System.Drawing.Size(200, 20);
            this.nomTB.TabIndex = 2;
            // 
            // mdpTB
            // 
            this.mdpTB.Location = new System.Drawing.Point(263, 160);
            this.mdpTB.Name = "mdpTB";
            this.mdpTB.PasswordChar = '*';
            this.mdpTB.Size = new System.Drawing.Size(200, 20);
            this.mdpTB.TabIndex = 3;
            // 
            // validerBTn
            // 
            this.validerBTn.Location = new System.Drawing.Point(220, 308);
            this.validerBTn.Name = "validerBTn";
            this.validerBTn.Size = new System.Drawing.Size(75, 23);
            this.validerBTn.TabIndex = 4;
            this.validerBTn.Text = "Valider";
            this.validerBTn.UseVisualStyleBackColor = true;
            this.validerBTn.Click += new System.EventHandler(this.validerBTn_Click);
            // 
            // fermerBtn
            // 
            this.fermerBtn.Location = new System.Drawing.Point(371, 307);
            this.fermerBtn.Name = "fermerBtn";
            this.fermerBtn.Size = new System.Drawing.Size(75, 23);
            this.fermerBtn.TabIndex = 5;
            this.fermerBtn.Text = "Fermer";
            this.fermerBtn.UseVisualStyleBackColor = true;
            this.fermerBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Popup
            // 
            this.Popup.Location = new System.Drawing.Point(263, 63);
            this.Popup.Name = "Popup";
            this.Popup.Size = new System.Drawing.Size(75, 23);
            this.Popup.TabIndex = 6;
            this.Popup.Text = "button1";
            this.Popup.UseVisualStyleBackColor = true;
            this.Popup.Click += new System.EventHandler(this.Popup_Click);
            // 
            // FormMotDePasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 377);
            this.Controls.Add(this.Popup);
            this.Controls.Add(this.fermerBtn);
            this.Controls.Add(this.validerBTn);
            this.Controls.Add(this.mdpTB);
            this.Controls.Add(this.nomTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMotDePasse";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomTB;
        private System.Windows.Forms.TextBox mdpTB;
        private System.Windows.Forms.Button validerBTn;
        private System.Windows.Forms.Button fermerBtn;
        private System.Windows.Forms.Button Popup;
    }
}

