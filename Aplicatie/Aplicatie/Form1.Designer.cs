namespace Aplicatie
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaDomeniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaFilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afisareFilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprumutaFilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restituieFilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.modificareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmeToolStripMenuItem,
            this.clientiToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(341, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filmeToolStripMenuItem
            // 
            this.filmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaDomeniiToolStripMenuItem,
            this.adaugaFilmeToolStripMenuItem,
            this.modificareToolStripMenuItem});
            this.filmeToolStripMenuItem.Name = "filmeToolStripMenuItem";
            this.filmeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.filmeToolStripMenuItem.Text = "Filme";
            // 
            // adaugaDomeniiToolStripMenuItem
            // 
            this.adaugaDomeniiToolStripMenuItem.Name = "adaugaDomeniiToolStripMenuItem";
            this.adaugaDomeniiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaugaDomeniiToolStripMenuItem.Text = "Adauga domenii";
            this.adaugaDomeniiToolStripMenuItem.Click += new System.EventHandler(this.adaugaDomeniiToolStripMenuItem_Click);
            // 
            // adaugaFilmeToolStripMenuItem
            // 
            this.adaugaFilmeToolStripMenuItem.Name = "adaugaFilmeToolStripMenuItem";
            this.adaugaFilmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaugaFilmeToolStripMenuItem.Text = "Adauga filme";
            this.adaugaFilmeToolStripMenuItem.Click += new System.EventHandler(this.adaugaFilmeToolStripMenuItem_Click);
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afisareFilmeToolStripMenuItem,
            this.imprumutaFilmeToolStripMenuItem,
            this.restituieFilmeToolStripMenuItem});
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.clientiToolStripMenuItem.Text = "Clienti";
            // 
            // afisareFilmeToolStripMenuItem
            // 
            this.afisareFilmeToolStripMenuItem.Name = "afisareFilmeToolStripMenuItem";
            this.afisareFilmeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.afisareFilmeToolStripMenuItem.Text = "Afisare filme";
            this.afisareFilmeToolStripMenuItem.Click += new System.EventHandler(this.afisareFilmeToolStripMenuItem_Click);
            // 
            // imprumutaFilmeToolStripMenuItem
            // 
            this.imprumutaFilmeToolStripMenuItem.Name = "imprumutaFilmeToolStripMenuItem";
            this.imprumutaFilmeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.imprumutaFilmeToolStripMenuItem.Text = "Imprumuta filme";
            this.imprumutaFilmeToolStripMenuItem.Click += new System.EventHandler(this.imprumutaFilmeToolStripMenuItem_Click);
            // 
            // restituieFilmeToolStripMenuItem
            // 
            this.restituieFilmeToolStripMenuItem.Name = "restituieFilmeToolStripMenuItem";
            this.restituieFilmeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.restituieFilmeToolStripMenuItem.Text = "Restituie filme";
            this.restituieFilmeToolStripMenuItem.Click += new System.EventHandler(this.restituieFilmeToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(141, 56);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(117, 20);
            this.textBoxUser.TabIndex = 1;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(141, 94);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(117, 20);
            this.textBoxParola.TabIndex = 2;
            this.textBoxParola.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parola";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Acces aplicatie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modificareToolStripMenuItem
            // 
            this.modificareToolStripMenuItem.Name = "modificareToolStripMenuItem";
            this.modificareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificareToolStripMenuItem.Text = "Modificare";
            this.modificareToolStripMenuItem.Click += new System.EventHandler(this.modificareToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 212);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Inchirieri filme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem adaugaDomeniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaFilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afisareFilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprumutaFilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restituieFilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareToolStripMenuItem;
    }
}

