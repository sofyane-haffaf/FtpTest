namespace FTPTest
{
    partial class Acceuil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.Testerconnexion = new System.Windows.Forms.MenuItem();
            this.Pinguer = new System.Windows.Forms.MenuItem();
            this.Connecter = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.listefichier = new System.Windows.Forms.MenuItem();
            this.uploaderfichier = new System.Windows.Forms.MenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.TextBox();
            this.tab = new System.Windows.Forms.TabControl();
            this.Etat = new System.Windows.Forms.TabPage();
            this.status = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.Listefich = new System.Windows.Forms.TabPage();
            this.fileList = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.tab.SuspendLayout();
            this.Etat.SuspendLayout();
            this.Listefich.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.Testerconnexion);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // Testerconnexion
            // 
            this.Testerconnexion.MenuItems.Add(this.Pinguer);
            this.Testerconnexion.MenuItems.Add(this.Connecter);
            this.Testerconnexion.Text = "Test connexion";
            // 
            // Pinguer
            // 
            this.Pinguer.Text = "Ping";
            this.Pinguer.Click += new System.EventHandler(this.Pinguer_Click);
            // 
            // Connecter
            // 
            this.Connecter.Text = "Connecter";
            this.Connecter.Click += new System.EventHandler(this.Connecter_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.MenuItems.Add(this.listefichier);
            this.menuItem2.MenuItems.Add(this.uploaderfichier);
            this.menuItem2.Text = "Commande";
            // 
            // listefichier
            // 
            this.listefichier.Text = "Liste des fichiers";
            this.listefichier.Click += new System.EventHandler(this.listefichier_Click);
            // 
            // uploaderfichier
            // 
            this.uploaderfichier.Text = "Uploader un fichier";
            this.uploaderfichier.Click += new System.EventHandler(this.uploaderfichier_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.Text = "pwd";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(59, 62);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(174, 21);
            this.password.TabIndex = 13;
            this.password.Text = "Serveur#2006";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.Text = "user";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(59, 35);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(174, 21);
            this.user.TabIndex = 12;
            this.user.Text = "eurequat";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.Text = "ftp://";
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(59, 8);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(174, 21);
            this.server.TabIndex = 10;
            this.server.Text = "www.eurequat-algerie.com";
            // 
            // tab
            // 
            this.tab.Controls.Add(this.Etat);
            this.tab.Controls.Add(this.Listefich);
            this.tab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tab.Location = new System.Drawing.Point(0, 87);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(240, 181);
            this.tab.TabIndex = 20;
            // 
            // Etat
            // 
            this.Etat.Controls.Add(this.status);
            this.Etat.Location = new System.Drawing.Point(0, 0);
            this.Etat.Name = "Etat";
            this.Etat.Size = new System.Drawing.Size(240, 158);
            this.Etat.Text = "Etat";
            // 
            // status
            // 
            this.status.Columns.Add(this.columnHeader1);
            this.status.Columns.Add(this.columnHeader2);
            this.status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.status.Location = new System.Drawing.Point(0, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(240, 158);
            this.status.TabIndex = 1;
            this.status.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Temps";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Réponse";
            this.columnHeader2.Width = 160;
            // 
            // Listefich
            // 
            this.Listefich.Controls.Add(this.fileList);
            this.Listefich.Location = new System.Drawing.Point(0, 0);
            this.Listefich.Name = "Listefich";
            this.Listefich.Size = new System.Drawing.Size(232, 155);
            this.Listefich.Text = "Liste des fichiers";
            // 
            // fileList
            // 
            this.fileList.Columns.Add(this.columnHeader3);
            this.fileList.Columns.Add(this.columnHeader4);
            this.fileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileList.Location = new System.Drawing.Point(0, 0);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(232, 155);
            this.fileList.TabIndex = 2;
            this.fileList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nom fichier";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Taille";
            this.columnHeader4.Width = 160;
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.server);
            this.Menu = this.mainMenu1;
            this.Name = "Acceuil";
            this.Text = "Acceuil";
            this.tab.ResumeLayout(false);
            this.Etat.ResumeLayout(false);
            this.Listefich.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage Etat;
        private System.Windows.Forms.TabPage Listefich;
        private System.Windows.Forms.ListView status;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView fileList;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.MenuItem Testerconnexion;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem listefichier;
        private System.Windows.Forms.MenuItem uploaderfichier;
        private System.Windows.Forms.MenuItem Pinguer;
        private System.Windows.Forms.MenuItem Connecter;
    }
}

