namespace Aplicatie
{
    partial class Confirmare
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
            this.labelConfirmare = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelConfirmare
            // 
            this.labelConfirmare.AutoSize = true;
            this.labelConfirmare.Location = new System.Drawing.Point(132, 67);
            this.labelConfirmare.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelConfirmare.Name = "labelConfirmare";
            this.labelConfirmare.Size = new System.Drawing.Size(180, 25);
            this.labelConfirmare.TabIndex = 0;
            this.labelConfirmare.Text = "- text confirmare -";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button1.Location = new System.Drawing.Point(48, 144);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "DA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.No;
            this.button2.Location = new System.Drawing.Point(264, 144);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "NU";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Confirmare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 250);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelConfirmare);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Confirmare";
            this.Text = "Confirmare";
            this.Load += new System.EventHandler(this.Confirmare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConfirmare;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}