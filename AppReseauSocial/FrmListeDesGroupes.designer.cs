namespace AppReseauSocial
{
    partial class FrmListeDesGroupes
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
            this.lsvMembres = new System.Windows.Forms.ListView();
            this.lsvMembresDuGroupe = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblListeDeTousLesMembres = new System.Windows.Forms.Label();
            this.lblMembresGroupeCourant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGroupes = new System.Windows.Forms.ComboBox();
            this.lblGroupeCourant = new System.Windows.Forms.Label();
            this.lblDateCréation = new System.Windows.Forms.Label();
            this.lblDateCréationInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsvMembres
            // 
            this.lsvMembres.FullRowSelect = true;
            this.lsvMembres.Location = new System.Drawing.Point(496, 34);
            this.lsvMembres.MultiSelect = false;
            this.lsvMembres.Name = "lsvMembres";
            this.lsvMembres.Size = new System.Drawing.Size(410, 553);
            this.lsvMembres.TabIndex = 0;
            this.lsvMembres.TileSize = new System.Drawing.Size(128, 128);
            this.lsvMembres.UseCompatibleStateImageBehavior = false;
            this.lsvMembres.DoubleClick += new System.EventHandler(this.lsvMembres_DoubleClick);
            // 
            // lsvMembresDuGroupe
            // 
            this.lsvMembresDuGroupe.FullRowSelect = true;
            this.lsvMembresDuGroupe.Location = new System.Drawing.Point(22, 160);
            this.lsvMembresDuGroupe.MultiSelect = false;
            this.lsvMembresDuGroupe.Name = "lsvMembresDuGroupe";
            this.lsvMembresDuGroupe.Size = new System.Drawing.Size(408, 427);
            this.lsvMembresDuGroupe.TabIndex = 5;
            this.lsvMembresDuGroupe.TileSize = new System.Drawing.Size(128, 128);
            this.lsvMembresDuGroupe.UseCompatibleStateImageBehavior = false;
            this.lsvMembresDuGroupe.DoubleClick += new System.EventHandler(this.lsvMembresDuGroupe_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(459, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 619);
            this.panel1.TabIndex = 7;
            // 
            // lblListeDeTousLesMembres
            // 
            this.lblListeDeTousLesMembres.AutoSize = true;
            this.lblListeDeTousLesMembres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeDeTousLesMembres.Location = new System.Drawing.Point(493, 15);
            this.lblListeDeTousLesMembres.Name = "lblListeDeTousLesMembres";
            this.lblListeDeTousLesMembres.Size = new System.Drawing.Size(314, 16);
            this.lblListeDeTousLesMembres.TabIndex = 8;
            this.lblListeDeTousLesMembres.Text = "Liste des membres qui ne sont pas dans le groupe :";
            // 
            // lblMembresGroupeCourant
            // 
            this.lblMembresGroupeCourant.AutoSize = true;
            this.lblMembresGroupeCourant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembresGroupeCourant.Location = new System.Drawing.Point(19, 141);
            this.lblMembresGroupeCourant.Name = "lblMembresGroupeCourant";
            this.lblMembresGroupeCourant.Size = new System.Drawing.Size(154, 16);
            this.lblMembresGroupeCourant.TabIndex = 9;
            this.lblMembresGroupeCourant.Text = "Membres de ce groupe :";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(485, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Double cliquer sur un membre pour l\'ajouter dans la liste des membres du groupe c" +
    "ourant";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 590);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Double cliquer pour retirer un membre du gourpe";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboGroupes
            // 
            this.cboGroupes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroupes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGroupes.FormattingEnabled = true;
            this.cboGroupes.Location = new System.Drawing.Point(22, 34);
            this.cboGroupes.Name = "cboGroupes";
            this.cboGroupes.Size = new System.Drawing.Size(188, 28);
            this.cboGroupes.TabIndex = 12;
            this.cboGroupes.SelectedIndexChanged += new System.EventHandler(this.cboGroupes_SelectedIndexChanged);
            // 
            // lblGroupeCourant
            // 
            this.lblGroupeCourant.AutoSize = true;
            this.lblGroupeCourant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupeCourant.Location = new System.Drawing.Point(22, 15);
            this.lblGroupeCourant.Name = "lblGroupeCourant";
            this.lblGroupeCourant.Size = new System.Drawing.Size(106, 16);
            this.lblGroupeCourant.TabIndex = 13;
            this.lblGroupeCourant.Text = "Groupe courant :";
            // 
            // lblDateCréation
            // 
            this.lblDateCréation.AutoSize = true;
            this.lblDateCréation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCréation.Location = new System.Drawing.Point(224, 15);
            this.lblDateCréation.Name = "lblDateCréation";
            this.lblDateCréation.Size = new System.Drawing.Size(89, 16);
            this.lblDateCréation.TabIndex = 14;
            this.lblDateCréation.Text = "Groupe créé :";
            // 
            // lblDateCréationInfo
            // 
            this.lblDateCréationInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDateCréationInfo.Location = new System.Drawing.Point(224, 34);
            this.lblDateCréationInfo.Name = "lblDateCréationInfo";
            this.lblDateCréationInfo.Size = new System.Drawing.Size(206, 28);
            this.lblDateCréationInfo.TabIndex = 16;
            this.lblDateCréationInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmListeDesGroupes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 623);
            this.Controls.Add(this.lblDateCréationInfo);
            this.Controls.Add(this.lblDateCréation);
            this.Controls.Add(this.lblGroupeCourant);
            this.Controls.Add(this.cboGroupes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMembresGroupeCourant);
            this.Controls.Add(this.lblListeDeTousLesMembres);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsvMembresDuGroupe);
            this.Controls.Add(this.lsvMembres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmListeDesGroupes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de plusieurs groupes de membres - ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvMembres;
        private System.Windows.Forms.ListView lsvMembresDuGroupe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblListeDeTousLesMembres;
        private System.Windows.Forms.Label lblMembresGroupeCourant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboGroupes;
        private System.Windows.Forms.Label lblGroupeCourant;
        private System.Windows.Forms.Label lblDateCréation;
        private System.Windows.Forms.Label lblDateCréationInfo;
    }
}

