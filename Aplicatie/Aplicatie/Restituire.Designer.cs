namespace Aplicatie
{
    partial class Restituire
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
            this.comboBoxClienti = new System.Windows.Forms.ComboBox();
            this.checkedListBoxFilme = new System.Windows.Forms.CheckedListBox();
            this.buttonInregistreaza = new System.Windows.Forms.Button();
            this.buttonRenunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ce restituie";
            // 
            // comboBoxClienti
            // 
            this.comboBoxClienti.FormattingEnabled = true;
            this.comboBoxClienti.Location = new System.Drawing.Point(122, 28);
            this.comboBoxClienti.Name = "comboBoxClienti";
            this.comboBoxClienti.Size = new System.Drawing.Size(171, 21);
            this.comboBoxClienti.TabIndex = 2;
            // 
            // checkedListBoxFilme
            // 
            this.checkedListBoxFilme.CheckOnClick = true;
            this.checkedListBoxFilme.FormattingEnabled = true;
            this.checkedListBoxFilme.HorizontalScrollbar = true;
            this.checkedListBoxFilme.Location = new System.Drawing.Point(43, 98);
            this.checkedListBoxFilme.Name = "checkedListBoxFilme";
            this.checkedListBoxFilme.Size = new System.Drawing.Size(250, 94);
            this.checkedListBoxFilme.TabIndex = 3;
            // 
            // buttonInregistreaza
            // 
            this.buttonInregistreaza.Location = new System.Drawing.Point(55, 230);
            this.buttonInregistreaza.Name = "buttonInregistreaza";
            this.buttonInregistreaza.Size = new System.Drawing.Size(75, 23);
            this.buttonInregistreaza.TabIndex = 4;
            this.buttonInregistreaza.Text = "Confirma restituirea";
            this.buttonInregistreaza.UseVisualStyleBackColor = true;
            // 
            // buttonRenunta
            // 
            this.buttonRenunta.Location = new System.Drawing.Point(204, 229);
            this.buttonRenunta.Name = "buttonRenunta";
            this.buttonRenunta.Size = new System.Drawing.Size(75, 23);
            this.buttonRenunta.TabIndex = 5;
            this.buttonRenunta.Text = "Renunta";
            this.buttonRenunta.UseVisualStyleBackColor = true;
            // 
            // Restituire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 299);
            this.Controls.Add(this.buttonRenunta);
            this.Controls.Add(this.buttonInregistreaza);
            this.Controls.Add(this.checkedListBoxFilme);
            this.Controls.Add(this.comboBoxClienti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Restituire";
            this.Text = "Restituire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxClienti;
        private System.Windows.Forms.CheckedListBox checkedListBoxFilme;
        private System.Windows.Forms.Button buttonInregistreaza;
        private System.Windows.Forms.Button buttonRenunta;
    }
}