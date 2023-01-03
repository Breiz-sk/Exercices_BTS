
namespace AppAuthentification
{
    partial class Form1
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
            this.msgLb = new System.Windows.Forms.Button();
            this.fermerToutBt = new System.Windows.Forms.Button();
            this.LABEL1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msgLb
            // 
            this.msgLb.Location = new System.Drawing.Point(234, 308);
            this.msgLb.Name = "msgLb";
            this.msgLb.Size = new System.Drawing.Size(150, 23);
            this.msgLb.TabIndex = 0;
            this.msgLb.Text = "Fermer";
            this.msgLb.UseVisualStyleBackColor = true;
            this.msgLb.Click += new System.EventHandler(this.button1_Click);
            // 
            // fermerToutBt
            // 
            this.fermerToutBt.Location = new System.Drawing.Point(234, 359);
            this.fermerToutBt.Name = "fermerToutBt";
            this.fermerToutBt.Size = new System.Drawing.Size(150, 23);
            this.fermerToutBt.TabIndex = 1;
            this.fermerToutBt.Text = "Fermer todo fenetras";
            this.fermerToutBt.UseVisualStyleBackColor = true;
            this.fermerToutBt.Click += new System.EventHandler(this.button2_Click);
            // 
            // LABEL1
            // 
            this.LABEL1.AutoSize = true;
            this.LABEL1.Location = new System.Drawing.Point(290, 174);
            this.LABEL1.Name = "LABEL1";
            this.LABEL1.Size = new System.Drawing.Size(35, 13);
            this.LABEL1.TabIndex = 2;
            this.LABEL1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 409);
            this.Controls.Add(this.LABEL1);
            this.Controls.Add(this.fermerToutBt);
            this.Controls.Add(this.msgLb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button msgLb;
        private System.Windows.Forms.Button fermerToutBt;
        private System.Windows.Forms.Label LABEL1;
    }
}