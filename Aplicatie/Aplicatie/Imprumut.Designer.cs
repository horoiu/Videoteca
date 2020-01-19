namespace Aplicatie
{
    partial class Imprumut
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
            this.comboBoxClienti = new System.Windows.Forms.ComboBox();
            this.comboBoxDomenii = new System.Windows.Forms.ComboBox();
            this.checkedListBoxFilme = new System.Windows.Forms.CheckedListBox();
            this.dateTimePickerDataRest = new System.Windows.Forms.DateTimePicker();
            this.buttonInregistreaza = new System.Windows.Forms.Button();
            this.buttonRenunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Domeniul";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selecteaza filme pentru imprumut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 563);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data restituirii";
            // 
            // comboBoxClienti
            // 
            this.comboBoxClienti.FormattingEnabled = true;
            this.comboBoxClienti.Location = new System.Drawing.Point(208, 70);
            this.comboBoxClienti.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxClienti.Name = "comboBoxClienti";
            this.comboBoxClienti.Size = new System.Drawing.Size(554, 33);
            this.comboBoxClienti.TabIndex = 4;
            // 
            // comboBoxDomenii
            // 
            this.comboBoxDomenii.FormattingEnabled = true;
            this.comboBoxDomenii.Location = new System.Drawing.Point(264, 160);
            this.comboBoxDomenii.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxDomenii.Name = "comboBoxDomenii";
            this.comboBoxDomenii.Size = new System.Drawing.Size(498, 33);
            this.comboBoxDomenii.TabIndex = 5;
            this.comboBoxDomenii.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDomenii_SelectionChangeCommitted);
            // 
            // checkedListBoxFilme
            // 
            this.checkedListBoxFilme.CheckOnClick = true;
            this.checkedListBoxFilme.FormattingEnabled = true;
            this.checkedListBoxFilme.HorizontalScrollbar = true;
            this.checkedListBoxFilme.Location = new System.Drawing.Point(117, 300);
            this.checkedListBoxFilme.Margin = new System.Windows.Forms.Padding(6);
            this.checkedListBoxFilme.Name = "checkedListBoxFilme";
            this.checkedListBoxFilme.Size = new System.Drawing.Size(645, 212);
            this.checkedListBoxFilme.TabIndex = 6;
            // 
            // dateTimePickerDataRest
            // 
            this.dateTimePickerDataRest.Location = new System.Drawing.Point(358, 558);
            this.dateTimePickerDataRest.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePickerDataRest.Name = "dateTimePickerDataRest";
            this.dateTimePickerDataRest.Size = new System.Drawing.Size(404, 31);
            this.dateTimePickerDataRest.TabIndex = 7;
            // 
            // buttonInregistreaza
            // 
            this.buttonInregistreaza.Location = new System.Drawing.Point(117, 662);
            this.buttonInregistreaza.Margin = new System.Windows.Forms.Padding(6);
            this.buttonInregistreaza.Name = "buttonInregistreaza";
            this.buttonInregistreaza.Size = new System.Drawing.Size(326, 44);
            this.buttonInregistreaza.TabIndex = 8;
            this.buttonInregistreaza.Text = "Inregistreaza imprumutul";
            this.buttonInregistreaza.UseVisualStyleBackColor = true;
            this.buttonInregistreaza.Click += new System.EventHandler(this.buttonInregistreaza_Click);
            // 
            // buttonRenunta
            // 
            this.buttonRenunta.Location = new System.Drawing.Point(584, 662);
            this.buttonRenunta.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRenunta.Name = "buttonRenunta";
            this.buttonRenunta.Size = new System.Drawing.Size(178, 44);
            this.buttonRenunta.TabIndex = 9;
            this.buttonRenunta.Text = "Renunta";
            this.buttonRenunta.UseVisualStyleBackColor = true;
            this.buttonRenunta.Click += new System.EventHandler(this.buttonRenunta_Click);
            // 
            // Imprumut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 769);
            this.Controls.Add(this.buttonRenunta);
            this.Controls.Add(this.buttonInregistreaza);
            this.Controls.Add(this.dateTimePickerDataRest);
            this.Controls.Add(this.checkedListBoxFilme);
            this.Controls.Add(this.comboBoxDomenii);
            this.Controls.Add(this.comboBoxClienti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Imprumut";
            this.Text = "Imprumut";
            this.Load += new System.EventHandler(this.Imprumut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxClienti;
        private System.Windows.Forms.ComboBox comboBoxDomenii;
        private System.Windows.Forms.CheckedListBox checkedListBoxFilme;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataRest;
        private System.Windows.Forms.Button buttonInregistreaza;
        private System.Windows.Forms.Button buttonRenunta;
    }
}