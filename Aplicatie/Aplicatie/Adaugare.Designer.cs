namespace Aplicatie
{
    partial class Adaugare
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDomeniul = new System.Windows.Forms.ComboBox();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.textBoxAnul = new System.Windows.Forms.TextBox();
            this.textBoxNrTotal = new System.Windows.Forms.TextBox();
            this.textBoxImagine = new System.Windows.Forms.TextBox();
            this.buttonSelectImg = new System.Windows.Forms.Button();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.buttonRenunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denumirea";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Domeniul";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Anul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numar total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Imaginea";
            // 
            // comboBoxDomeniul
            // 
            this.comboBoxDomeniul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDomeniul.FormattingEnabled = true;
            this.comboBoxDomeniul.Location = new System.Drawing.Point(144, 77);
            this.comboBoxDomeniul.Name = "comboBoxDomeniul";
            this.comboBoxDomeniul.Size = new System.Drawing.Size(139, 21);
            this.comboBoxDomeniul.TabIndex = 5;
            // 
            // textBoxDenumire
            // 
            this.textBoxDenumire.Location = new System.Drawing.Point(144, 36);
            this.textBoxDenumire.Name = "textBoxDenumire";
            this.textBoxDenumire.Size = new System.Drawing.Size(139, 20);
            this.textBoxDenumire.TabIndex = 6;
            // 
            // textBoxAnul
            // 
            this.textBoxAnul.Location = new System.Drawing.Point(144, 124);
            this.textBoxAnul.Name = "textBoxAnul";
            this.textBoxAnul.Size = new System.Drawing.Size(139, 20);
            this.textBoxAnul.TabIndex = 7;
            // 
            // textBoxNrTotal
            // 
            this.textBoxNrTotal.Location = new System.Drawing.Point(144, 169);
            this.textBoxNrTotal.Name = "textBoxNrTotal";
            this.textBoxNrTotal.Size = new System.Drawing.Size(139, 20);
            this.textBoxNrTotal.TabIndex = 8;
            // 
            // textBoxImagine
            // 
            this.textBoxImagine.Location = new System.Drawing.Point(144, 260);
            this.textBoxImagine.Name = "textBoxImagine";
            this.textBoxImagine.Size = new System.Drawing.Size(139, 20);
            this.textBoxImagine.TabIndex = 9;
            // 
            // buttonSelectImg
            // 
            this.buttonSelectImg.Location = new System.Drawing.Point(112, 217);
            this.buttonSelectImg.Name = "buttonSelectImg";
            this.buttonSelectImg.Size = new System.Drawing.Size(128, 23);
            this.buttonSelectImg.TabIndex = 10;
            this.buttonSelectImg.Text = "Selecteaza imaginea";
            this.buttonSelectImg.UseVisualStyleBackColor = true;
            this.buttonSelectImg.Click += new System.EventHandler(this.buttonSelectImg_Click);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(67, 326);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(75, 23);
            this.buttonAdauga.TabIndex = 11;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // buttonRenunta
            // 
            this.buttonRenunta.Location = new System.Drawing.Point(186, 326);
            this.buttonRenunta.Name = "buttonRenunta";
            this.buttonRenunta.Size = new System.Drawing.Size(75, 23);
            this.buttonRenunta.TabIndex = 12;
            this.buttonRenunta.Text = "Renunta";
            this.buttonRenunta.UseVisualStyleBackColor = true;
            this.buttonRenunta.Click += new System.EventHandler(this.buttonRenunta_Click);
            // 
            // Adaugare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 389);
            this.Controls.Add(this.buttonRenunta);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.buttonSelectImg);
            this.Controls.Add(this.textBoxImagine);
            this.Controls.Add(this.textBoxNrTotal);
            this.Controls.Add(this.textBoxAnul);
            this.Controls.Add(this.textBoxDenumire);
            this.Controls.Add(this.comboBoxDomeniul);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Adaugare";
            this.Text = "Adaugare";
            this.Load += new System.EventHandler(this.Adaugare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDomeniul;
        private System.Windows.Forms.TextBox textBoxDenumire;
        private System.Windows.Forms.TextBox textBoxAnul;
        private System.Windows.Forms.TextBox textBoxNrTotal;
        private System.Windows.Forms.TextBox textBoxImagine;
        private System.Windows.Forms.Button buttonSelectImg;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Button buttonRenunta;
    }
}