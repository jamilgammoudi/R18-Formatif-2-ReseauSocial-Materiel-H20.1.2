namespace AppReseauSocial
{
    partial class FrmPrincipal
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
            this.lsvAmis = new System.Windows.Forms.ListView();
            this.lblMembres = new System.Windows.Forms.Label();
            this.lblAmis = new System.Windows.Forms.Label();
            this.lsvNonAmi = new System.Windows.Forms.ListView();
            this.lblNonAmis = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMembreCourant = new System.Windows.Forms.PictureBox();
            this.cboMembres = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnSupprimerAmi = new System.Windows.Forms.Button();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdministrateur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdminGestionGroupes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionsQ1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionsQ2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionsQ3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionsQ4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionsQ5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionsQ6 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionsQ7 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionsQ8 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionsQ9 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionsQ10 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionsQ11 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuestionsQ12 = new System.Windows.Forms.ToolStripMenuItem();
            this.clbGroupes = new System.Windows.Forms.CheckedListBox();
            this.lblGroupes = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picMembreCourant)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.mnuPrincipal.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvAmis
            // 
            this.lsvAmis.FullRowSelect = true;
            this.lsvAmis.HideSelection = false;
            this.lsvAmis.Location = new System.Drawing.Point(344, 35);
            this.lsvAmis.MultiSelect = false;
            this.lsvAmis.Name = "lsvAmis";
            this.lsvAmis.Size = new System.Drawing.Size(278, 567);
            this.lsvAmis.TabIndex = 1;
            this.lsvAmis.TileSize = new System.Drawing.Size(128, 128);
            this.lsvAmis.UseCompatibleStateImageBehavior = false;
            this.lsvAmis.SelectedIndexChanged += new System.EventHandler(this.lsvAmis_SelectedIndexChanged);
            this.lsvAmis.DoubleClick += new System.EventHandler(this.lsvAmis_DoubleClick);
            // 
            // lblMembres
            // 
            this.lblMembres.AutoSize = true;
            this.lblMembres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembres.Location = new System.Drawing.Point(9, 19);
            this.lblMembres.Name = "lblMembres";
            this.lblMembres.Size = new System.Drawing.Size(119, 13);
            this.lblMembres.TabIndex = 2;
            this.lblMembres.Text = "Liste des membres :";
            // 
            // lblAmis
            // 
            this.lblAmis.AutoSize = true;
            this.lblAmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmis.Location = new System.Drawing.Point(341, 19);
            this.lblAmis.Name = "lblAmis";
            this.lblAmis.Size = new System.Drawing.Size(80, 13);
            this.lblAmis.TabIndex = 3;
            this.lblAmis.Text = "Amis/Amies :";
            // 
            // lsvNonAmi
            // 
            this.lsvNonAmi.FullRowSelect = true;
            this.lsvNonAmi.HideSelection = false;
            this.lsvNonAmi.Location = new System.Drawing.Point(685, 61);
            this.lsvNonAmi.MultiSelect = false;
            this.lsvNonAmi.Name = "lsvNonAmi";
            this.lsvNonAmi.Size = new System.Drawing.Size(537, 567);
            this.lsvNonAmi.TabIndex = 4;
            this.lsvNonAmi.TileSize = new System.Drawing.Size(128, 128);
            this.lsvNonAmi.UseCompatibleStateImageBehavior = false;
            this.lsvNonAmi.DoubleClick += new System.EventHandler(this.lsvNonAmis_DoubleClick);
            // 
            // lblNonAmis
            // 
            this.lblNonAmis.AutoSize = true;
            this.lblNonAmis.Location = new System.Drawing.Point(682, 45);
            this.lblNonAmis.Name = "lblNonAmis";
            this.lblNonAmis.Size = new System.Drawing.Size(91, 13);
            this.lblNonAmis.TabIndex = 5;
            this.lblNonAmis.Text = "Non Amis/Amies :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(654, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 662);
            this.panel1.TabIndex = 8;
            // 
            // picMembreCourant
            // 
            this.picMembreCourant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMembreCourant.Location = new System.Drawing.Point(20, 14);
            this.picMembreCourant.Name = "picMembreCourant";
            this.picMembreCourant.Size = new System.Drawing.Size(218, 319);
            this.picMembreCourant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMembreCourant.TabIndex = 9;
            this.picMembreCourant.TabStop = false;
            // 
            // cboMembres
            // 
            this.cboMembres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMembres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMembres.FormattingEnabled = true;
            this.cboMembres.Location = new System.Drawing.Point(12, 35);
            this.cboMembres.Name = "cboMembres";
            this.cboMembres.Size = new System.Drawing.Size(306, 33);
            this.cboMembres.TabIndex = 10;
            this.cboMembres.SelectedIndexChanged += new System.EventHandler(this.cboMembres_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 389);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.lblAge);
            this.panel3.Controls.Add(this.picMembreCourant);
            this.panel3.Location = new System.Drawing.Point(23, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 353);
            this.panel3.TabIndex = 0;
            // 
            // lblAge
            // 
            this.lblAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(215, 319);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(45, 34);
            this.lblAge.TabIndex = 13;
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSupprimerAmi
            // 
            this.btnSupprimerAmi.Enabled = false;
            this.btnSupprimerAmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerAmi.Location = new System.Drawing.Point(344, 608);
            this.btnSupprimerAmi.Name = "btnSupprimerAmi";
            this.btnSupprimerAmi.Size = new System.Drawing.Size(278, 29);
            this.btnSupprimerAmi.TabIndex = 12;
            this.btnSupprimerAmi.Text = "Supprimer un ami";
            this.btnSupprimerAmi.UseVisualStyleBackColor = true;
            this.btnSupprimerAmi.Click += new System.EventHandler(this.btnSupprimerAmi_Click);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichier,
            this.mnuAdministrateur,
            this.mnuQuestions});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(1238, 24);
            this.mnuPrincipal.TabIndex = 13;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuFichier
            // 
            this.mnuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFichierQuitter});
            this.mnuFichier.Name = "mnuFichier";
            this.mnuFichier.Size = new System.Drawing.Size(54, 20);
            this.mnuFichier.Tag = "H17PCSDLS";
            this.mnuFichier.Text = "&Fichier";
            // 
            // mnuFichierQuitter
            // 
            this.mnuFichierQuitter.Name = "mnuFichierQuitter";
            this.mnuFichierQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFichierQuitter.Size = new System.Drawing.Size(154, 22);
            this.mnuFichierQuitter.Text = "&Quitter";
            this.mnuFichierQuitter.Click += new System.EventHandler(this.mnuFichierQuitter_Click);
            // 
            // mnuAdministrateur
            // 
            this.mnuAdministrateur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdminGestionGroupes});
            this.mnuAdministrateur.Name = "mnuAdministrateur";
            this.mnuAdministrateur.Size = new System.Drawing.Size(98, 20);
            this.mnuAdministrateur.Text = "&Administrateur";
            // 
            // mnuAdminGestionGroupes
            // 
            this.mnuAdminGestionGroupes.Name = "mnuAdminGestionGroupes";
            this.mnuAdminGestionGroupes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.mnuAdminGestionGroupes.Size = new System.Drawing.Size(228, 22);
            this.mnuAdminGestionGroupes.Text = "Gestion des groupes...";
            this.mnuAdminGestionGroupes.Click += new System.EventHandler(this.mnuAdminGestionGroupes_Click);
            // 
            // mnuQuestions
            // 
            this.mnuQuestions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuestionsQ1,
            this.mnuQuestionsQ2,
            this.mnuQuestionsQ3,
            this.mnuQuestionsQ4,
            this.mnuQuestionsQ5,
            this.mnuQuestionsQ6,
            this.mnuQuestionsQ7,
            this.mnuQuestionsQ8,
            this.mnuQuestionsQ9,
            this.mnuQuestionsQ10,
            this.mnuQuestionsQ11,
            this.mnuQuestionsQ12});
            this.mnuQuestions.Name = "mnuQuestions";
            this.mnuQuestions.Size = new System.Drawing.Size(72, 20);
            this.mnuQuestions.Text = "&Questions";
            // 
            // mnuQuestionsQ1
            // 
            this.mnuQuestionsQ1.Name = "mnuQuestionsQ1";
            this.mnuQuestionsQ1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.mnuQuestionsQ1.Size = new System.Drawing.Size(576, 22);
            this.mnuQuestionsQ1.Text = "Q1) Afficher le nombre de membres dans le réseau social";
            this.mnuQuestionsQ1.Click += new System.EventHandler(this.mnuQuestionsQ1_Click);
            // 
            // mnuQuestionsQ2
            // 
            this.mnuQuestionsQ2.Name = "mnuQuestionsQ2";
            this.mnuQuestionsQ2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.mnuQuestionsQ2.Size = new System.Drawing.Size(576, 22);
            this.mnuQuestionsQ2.Text = "Q2) Afficher le nombre de groupes dans le réseau social";
            this.mnuQuestionsQ2.Click += new System.EventHandler(this.mnuQuestionsQ2_Click);
            // 
            // mnuQuestionsQ3
            // 
            this.mnuQuestionsQ3.Name = "mnuQuestionsQ3";
            this.mnuQuestionsQ3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.mnuQuestionsQ3.Size = new System.Drawing.Size(576, 22);
            this.mnuQuestionsQ3.Text = "Q3) Afficher le nombre de membres femme dans le réseau social";
            this.mnuQuestionsQ3.Click += new System.EventHandler(this.mnuQuestionsQ3_Click);
            // 
            // mnuQuestionsQ4
            // 
            this.mnuQuestionsQ4.Name = "mnuQuestionsQ4";
            this.mnuQuestionsQ4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuQuestionsQ4.Size = new System.Drawing.Size(576, 22);
            this.mnuQuestionsQ4.Text = "Q4) Afficher le nombre de membres nés entre 1980 et 1990 inclusivement";
            this.mnuQuestionsQ4.Click += new System.EventHandler(this.mnuQuestionsQ4_Click);
            // 
            // mnuQuestionsQ5
            // 
            this.mnuQuestionsQ5.Name = "mnuQuestionsQ5";
            this.mnuQuestionsQ5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F5)));
            this.mnuQuestionsQ5.Size = new System.Drawing.Size(576, 22);
            this.mnuQuestionsQ5.Text = "Q5) Afficher les noms des groupes du réseau social";
            this.mnuQuestionsQ5.Click += new System.EventHandler(this.mnuQuestionsQ5_Click);
            // 
            // mnuQuestionsQ6
            // 
            this.mnuQuestionsQ6.Name = "mnuQuestionsQ6";
            this.mnuQuestionsQ6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F6)));
            this.mnuQuestionsQ6.Size = new System.Drawing.Size(576, 22);
            this.mnuQuestionsQ6.Text = "Q6) Afficher le nom de tous les membres du groupe \"Hockey\"";
            this.mnuQuestionsQ6.Click += new System.EventHandler(this.mnuQuestionsQ6_Click);
            // 
            // mnuQuestionsQ7
            // 
            this.mnuQuestionsQ7.Name = "mnuQuestionsQ7";
            this.mnuQuestionsQ7.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F7)));
            this.mnuQuestionsQ7.Size = new System.Drawing.Size(576, 22);
            this.mnuQuestionsQ7.Text = "Q7) Afficher le nom des 5 premières femmes membres du réseau social";
            this.mnuQuestionsQ7.Click += new System.EventHandler(this.mnuQuestionsQ7_Click);
            // 
            // mnuQuestionsQ8
            // 
            this.mnuQuestionsQ8.Name = "mnuQuestionsQ8";
            this.mnuQuestionsQ8.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F8)));
            this.mnuQuestionsQ8.Size = new System.Drawing.Size(576, 22);
            this.mnuQuestionsQ8.Text = "Q8) Afficher le nom et la date de naissance du membre le plus agé du groupe \"Hock" +
    "ey\"";
            this.mnuQuestionsQ8.Click += new System.EventHandler(this.mnuQuestionsQ8_Click);
            // 
            // mnuQuestionsQ9
            // 
            this.mnuQuestionsQ9.Name = "mnuQuestionsQ9";
            this.mnuQuestionsQ9.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F9)));
            this.mnuQuestionsQ9.Size = new System.Drawing.Size(576, 22);
            this.mnuQuestionsQ9.Text = "Q9) Afficher les noms des amis du dernier membre du réseau social";
            this.mnuQuestionsQ9.Click += new System.EventHandler(this.mnuQuestionsQ9_Click);
            // 
            // mnuQuestionsQ10
            // 
            this.mnuQuestionsQ10.Name = "mnuQuestionsQ10";
            this.mnuQuestionsQ10.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F10)));
            this.mnuQuestionsQ10.Size = new System.Drawing.Size(576, 22);
            this.mnuQuestionsQ10.Text = "Q10) Afficher les noms des amis du premier membre du groupe \"Hockey\"";
            this.mnuQuestionsQ10.Click += new System.EventHandler(this.mnuQuestionsQ10_Click);
            // 
            // mnuQuestionsQ11
            // 
            this.mnuQuestionsQ11.Name = "mnuQuestionsQ11";
            this.mnuQuestionsQ11.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F11)));
            this.mnuQuestionsQ11.Size = new System.Drawing.Size(576, 22);
            this.mnuQuestionsQ11.Text = "Q11) Afficher les noms des groupes auquel appartient le membre courant";
            this.mnuQuestionsQ11.Click += new System.EventHandler(this.mnuQuestionsQ11_Click);
            // 
            // mnuQuestionsQ12
            // 
            this.mnuQuestionsQ12.Name = "mnuQuestionsQ12";
            this.mnuQuestionsQ12.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F12)));
            this.mnuQuestionsQ12.Size = new System.Drawing.Size(576, 22);
            this.mnuQuestionsQ12.Text = "Q12) Afficher les noms des amis communs de \"Brad Pitt\" et \"Ali Astin\"";
            this.mnuQuestionsQ12.Click += new System.EventHandler(this.mnuQuestionsQ12_Click);
            // 
            // clbGroupes
            // 
            this.clbGroupes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbGroupes.FormattingEnabled = true;
            this.clbGroupes.Location = new System.Drawing.Point(35, 489);
            this.clbGroupes.Name = "clbGroupes";
            this.clbGroupes.Size = new System.Drawing.Size(260, 148);
            this.clbGroupes.TabIndex = 14;
            this.clbGroupes.SelectedIndexChanged += new System.EventHandler(this.clbGroupes_SelectedIndexChanged);
            // 
            // lblGroupes
            // 
            this.lblGroupes.AutoSize = true;
            this.lblGroupes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupes.Location = new System.Drawing.Point(32, 473);
            this.lblGroupes.Name = "lblGroupes";
            this.lblGroupes.Size = new System.Drawing.Size(62, 13);
            this.lblGroupes.TabIndex = 15;
            this.lblGroupes.Text = "Groupes :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.lblGroupes);
            this.panel4.Controls.Add(this.clbGroupes);
            this.panel4.Controls.Add(this.btnSupprimerAmi);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.cboMembres);
            this.panel4.Controls.Add(this.lblAmis);
            this.panel4.Controls.Add(this.lblMembres);
            this.panel4.Controls.Add(this.lsvAmis);
            this.panel4.Location = new System.Drawing.Point(7, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(641, 651);
            this.panel4.TabIndex = 16;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 682);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNonAmis);
            this.Controls.Add(this.lsvNonAmi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RéseauSocial avec des Groupes - ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picMembreCourant)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsvAmis;
        private System.Windows.Forms.Label lblMembres;
        private System.Windows.Forms.Label lblAmis;
        private System.Windows.Forms.ListView lsvNonAmi;
        private System.Windows.Forms.Label lblNonAmis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picMembreCourant;
        private System.Windows.Forms.ComboBox cboMembres;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSupprimerAmi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFichier;
        private System.Windows.Forms.ToolStripMenuItem mnuFichierQuitter;
        private System.Windows.Forms.ToolStripMenuItem mnuAdministrateur;
        private System.Windows.Forms.ToolStripMenuItem mnuAdminGestionGroupes;
        private System.Windows.Forms.CheckedListBox clbGroupes;
        private System.Windows.Forms.Label lblGroupes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestions;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionsQ3;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionsQ1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionsQ2;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionsQ4;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionsQ5;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionsQ6;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionsQ7;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionsQ8;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionsQ9;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionsQ10;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionsQ11;
        private System.Windows.Forms.ToolStripMenuItem mnuQuestionsQ12;
    }
}

