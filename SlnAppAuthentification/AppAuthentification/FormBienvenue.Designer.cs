
namespace AppAuthentification
{
    partial class FormBienvenue 
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
            this.msgLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msgLb
            // 
            this.msgLb.AutoSize = true;
            this.msgLb.Location = new System.Drawing.Point(333, 124);
            this.msgLb.Name = "msgLb";
            this.msgLb.Size = new System.Drawing.Size(35, 13);
            this.msgLb.TabIndex = 0;
            this.msgLb.Text = "label1";
            // 
            // FormBienvenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msgLb);
            this.Name = "FormBienvenue";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgLb;
    }
}