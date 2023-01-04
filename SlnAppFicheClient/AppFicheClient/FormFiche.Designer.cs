
namespace AppFicheClient
{
    partial class FormFiche
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
            this.Civilite = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.Label();
            this.CodePost = new System.Windows.Forms.Label();
            this.Ville = new System.Windows.Forms.Label();
            this.Addr = new System.Windows.Forms.Label();
            this.ValiderBtn = new System.Windows.Forms.Button();
            this.FermerBtn = new System.Windows.Forms.Button();
            this.CiviliteTB = new System.Windows.Forms.TextBox();
            this.prenomTB = new System.Windows.Forms.TextBox();
            this.nomTB = new System.Windows.Forms.TextBox();
            this.adresseTB = new System.Windows.Forms.TextBox();
            this.codePostalT = new System.Windows.Forms.TextBox();
            this.villeTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Civilite
            // 
            this.Civilite.AutoSize = true;
            this.Civilite.Location = new System.Drawing.Point(66, 39);
            this.Civilite.Name = "Civilite";
            this.Civilite.Size = new System.Drawing.Size(37, 13);
            this.Civilite.TabIndex = 0;
            this.Civilite.Text = "Civilité";
            this.Civilite.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(66, 80);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 1;
            this.Nom.Text = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(66, 134);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(43, 13);
            this.Prenom.TabIndex = 2;
            this.Prenom.Text = "Prénom";
            // 
            // CodePost
            // 
            this.CodePost.AutoSize = true;
            this.CodePost.Location = new System.Drawing.Point(66, 237);
            this.CodePost.Name = "CodePost";
            this.CodePost.Size = new System.Drawing.Size(64, 13);
            this.CodePost.TabIndex = 3;
            this.CodePost.Text = "Code Postal";
            // 
            // Ville
            // 
            this.Ville.AutoSize = true;
            this.Ville.Location = new System.Drawing.Point(66, 286);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(26, 13);
            this.Ville.TabIndex = 4;
            this.Ville.Text = "Ville";
            this.Ville.Click += new System.EventHandler(this.Ville_Click);
            // 
            // Addr
            // 
            this.Addr.AutoSize = true;
            this.Addr.Location = new System.Drawing.Point(66, 182);
            this.Addr.Name = "Addr";
            this.Addr.Size = new System.Drawing.Size(45, 13);
            this.Addr.TabIndex = 6;
            this.Addr.Text = "Adresse";
            // 
            // ValiderBtn
            // 
            this.ValiderBtn.Location = new System.Drawing.Point(141, 378);
            this.ValiderBtn.Name = "ValiderBtn";
            this.ValiderBtn.Size = new System.Drawing.Size(75, 23);
            this.ValiderBtn.TabIndex = 7;
            this.ValiderBtn.Text = "Valider";
            this.ValiderBtn.UseVisualStyleBackColor = true;
            this.ValiderBtn.Click += new System.EventHandler(this.Valider_Click);
            // 
            // FermerBtn
            // 
            this.FermerBtn.Location = new System.Drawing.Point(369, 378);
            this.FermerBtn.Name = "FermerBtn";
            this.FermerBtn.Size = new System.Drawing.Size(75, 23);
            this.FermerBtn.TabIndex = 8;
            this.FermerBtn.Text = "Fermer";
            this.FermerBtn.UseVisualStyleBackColor = true;
            this.FermerBtn.Click += new System.EventHandler(this.Fermer_Click);
            // 
            // CiviliteTB
            // 
            this.CiviliteTB.Location = new System.Drawing.Point(238, 49);
            this.CiviliteTB.Name = "CiviliteTB";
            this.CiviliteTB.Size = new System.Drawing.Size(100, 20);
            this.CiviliteTB.TabIndex = 9;
            this.CiviliteTB.TextChanged += new System.EventHandler(this.CiviliteTB_TextChanged);
            // 
            // prenomTB
            // 
            this.prenomTB.Location = new System.Drawing.Point(238, 131);
            this.prenomTB.Name = "prenomTB";
            this.prenomTB.Size = new System.Drawing.Size(100, 20);
            this.prenomTB.TabIndex = 10;
            // 
            // nomTB
            // 
            this.nomTB.Location = new System.Drawing.Point(238, 91);
            this.nomTB.Name = "nomTB";
            this.nomTB.Size = new System.Drawing.Size(100, 20);
            this.nomTB.TabIndex = 11;
            // 
            // adresseTB
            // 
            this.adresseTB.Location = new System.Drawing.Point(238, 179);
            this.adresseTB.Name = "adresseTB";
            this.adresseTB.Size = new System.Drawing.Size(100, 20);
            this.adresseTB.TabIndex = 12;
            // 
            // codePostalT
            // 
            this.codePostalT.Location = new System.Drawing.Point(238, 234);
            this.codePostalT.Name = "codePostalT";
            this.codePostalT.Size = new System.Drawing.Size(100, 20);
            this.codePostalT.TabIndex = 13;
            // 
            // villeTB
            // 
            this.villeTB.Location = new System.Drawing.Point(238, 283);
            this.villeTB.Name = "villeTB";
            this.villeTB.Size = new System.Drawing.Size(100, 20);
            this.villeTB.TabIndex = 14;
            // 
            // FormFiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.villeTB);
            this.Controls.Add(this.codePostalT);
            this.Controls.Add(this.adresseTB);
            this.Controls.Add(this.nomTB);
            this.Controls.Add(this.prenomTB);
            this.Controls.Add(this.CiviliteTB);
            this.Controls.Add(this.FermerBtn);
            this.Controls.Add(this.ValiderBtn);
            this.Controls.Add(this.Addr);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.CodePost);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Civilite);
            this.Name = "FormFiche";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormFiche_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Civilite;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label CodePost;
        private System.Windows.Forms.Label Ville;
        private System.Windows.Forms.Label Addr;
        private System.Windows.Forms.Button ValiderBtn;
        private System.Windows.Forms.Button FermerBtn;
        private System.Windows.Forms.TextBox CiviliteTB;
        private System.Windows.Forms.TextBox prenomTB;
        private System.Windows.Forms.TextBox nomTB;
        private System.Windows.Forms.TextBox adresseTB;
        private System.Windows.Forms.TextBox codePostalT;
        private System.Windows.Forms.TextBox villeTB;
    }
}