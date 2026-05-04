namespace proj_pharmacell
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nom_utilisateur_UtilisateursLabel;
            System.Windows.Forms.Label mot_de_passe_UtilisateursLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pharmacellDataSet = new proj_pharmacell.PharmacellDataSet();
            this.utilisateurs_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurs_TableAdapter = new proj_pharmacell.PharmacellDataSetTableAdapters.Utilisateurs_TableAdapter();
            this.tableAdapterManager = new proj_pharmacell.PharmacellDataSetTableAdapters.TableAdapterManager();
            this.rdAdministrateur = new System.Windows.Forms.RadioButton();
            this.rdVendeur = new System.Windows.Forms.RadioButton();
            this.rdGestionnaire = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.afficher_les_caractéres = new System.Windows.Forms.CheckBox();
            this.bt_Quitter = new Guna.UI2.WinForms.Guna2Button();
            this.button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            nom_utilisateur_UtilisateursLabel = new System.Windows.Forms.Label();
            mot_de_passe_UtilisateursLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacellDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurs_BindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nom_utilisateur_UtilisateursLabel
            // 
            nom_utilisateur_UtilisateursLabel.AutoSize = true;
            nom_utilisateur_UtilisateursLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            nom_utilisateur_UtilisateursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nom_utilisateur_UtilisateursLabel.ForeColor = System.Drawing.Color.White;
            nom_utilisateur_UtilisateursLabel.Location = new System.Drawing.Point(33, 102);
            nom_utilisateur_UtilisateursLabel.Name = "nom_utilisateur_UtilisateursLabel";
            nom_utilisateur_UtilisateursLabel.Size = new System.Drawing.Size(156, 20);
            nom_utilisateur_UtilisateursLabel.TabIndex = 3;
            nom_utilisateur_UtilisateursLabel.Text = "Nom d\'Utilisateur :";
            // 
            // mot_de_passe_UtilisateursLabel
            // 
            mot_de_passe_UtilisateursLabel.AutoSize = true;
            mot_de_passe_UtilisateursLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            mot_de_passe_UtilisateursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mot_de_passe_UtilisateursLabel.ForeColor = System.Drawing.Color.White;
            mot_de_passe_UtilisateursLabel.Location = new System.Drawing.Point(38, 142);
            mot_de_passe_UtilisateursLabel.Name = "mot_de_passe_UtilisateursLabel";
            mot_de_passe_UtilisateursLabel.Size = new System.Drawing.Size(152, 20);
            mot_de_passe_UtilisateursLabel.TabIndex = 5;
            mot_de_passe_UtilisateursLabel.Text = "Mot de passe      :";
            // 
            // pharmacellDataSet
            // 
            this.pharmacellDataSet.DataSetName = "PharmacellDataSet";
            this.pharmacellDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateurs_BindingSource
            // 
            this.utilisateurs_BindingSource.DataMember = "Utilisateurs_";
            this.utilisateurs_BindingSource.DataSource = this.pharmacellDataSet;
            // 
            // utilisateurs_TableAdapter
            // 
            this.utilisateurs_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.Commandes_d_approvisionnementTableAdapter = null;
            this.tableAdapterManager.FournisseursTableAdapter = null;
            this.tableAdapterManager.MedicamentTableAdapter = null;
            this.tableAdapterManager.Mouvements_stockTableAdapter = null;
            this.tableAdapterManager.Ordonnances_TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proj_pharmacell.PharmacellDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Utilisateurs_TableAdapter = this.utilisateurs_TableAdapter;
            this.tableAdapterManager.Ventes_TableAdapter = null;
            // 
            // rdAdministrateur
            // 
            this.rdAdministrateur.AutoSize = true;
            this.rdAdministrateur.ForeColor = System.Drawing.Color.White;
            this.rdAdministrateur.Location = new System.Drawing.Point(44, 246);
            this.rdAdministrateur.Name = "rdAdministrateur";
            this.rdAdministrateur.Size = new System.Drawing.Size(137, 24);
            this.rdAdministrateur.TabIndex = 3;
            this.rdAdministrateur.TabStop = true;
            this.rdAdministrateur.Text = "Administrateur";
            this.rdAdministrateur.UseVisualStyleBackColor = true;
            // 
            // rdVendeur
            // 
            this.rdVendeur.AutoSize = true;
            this.rdVendeur.ForeColor = System.Drawing.Color.White;
            this.rdVendeur.Location = new System.Drawing.Point(244, 246);
            this.rdVendeur.Name = "rdVendeur";
            this.rdVendeur.Size = new System.Drawing.Size(95, 24);
            this.rdVendeur.TabIndex = 4;
            this.rdVendeur.TabStop = true;
            this.rdVendeur.Text = "Vendeur";
            this.rdVendeur.UseVisualStyleBackColor = true;
            // 
            // rdGestionnaire
            // 
            this.rdGestionnaire.AutoSize = true;
            this.rdGestionnaire.ForeColor = System.Drawing.Color.White;
            this.rdGestionnaire.Location = new System.Drawing.Point(388, 246);
            this.rdGestionnaire.Name = "rdGestionnaire";
            this.rdGestionnaire.Size = new System.Drawing.Size(125, 24);
            this.rdGestionnaire.TabIndex = 5;
            this.rdGestionnaire.TabStop = true;
            this.rdGestionnaire.Text = "Gestionnaire";
            this.rdGestionnaire.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(388, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(388, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(228, 26);
            this.textBox2.TabIndex = 1;
            // 
            // afficher_les_caractéres
            // 
            this.afficher_les_caractéres.AutoSize = true;
            this.afficher_les_caractéres.ForeColor = System.Drawing.Color.White;
            this.afficher_les_caractéres.Location = new System.Drawing.Point(388, 195);
            this.afficher_les_caractéres.Name = "afficher_les_caractéres";
            this.afficher_les_caractéres.Size = new System.Drawing.Size(193, 24);
            this.afficher_les_caractéres.TabIndex = 2;
            this.afficher_les_caractéres.Text = "Afficher les caractéres";
            this.afficher_les_caractéres.UseVisualStyleBackColor = true;
            this.afficher_les_caractéres.CheckedChanged += new System.EventHandler(this.afficher_les_caractéres_CheckedChanged);
            // 
            // bt_Quitter
            // 
            this.bt_Quitter.AutoRoundedCorners = true;
            this.bt_Quitter.BackColor = System.Drawing.Color.Transparent;
            this.bt_Quitter.BorderColor = System.Drawing.Color.White;
            this.bt_Quitter.BorderRadius = 21;
            this.bt_Quitter.BorderThickness = 2;
            this.bt_Quitter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Quitter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Quitter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Quitter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Quitter.FillColor = System.Drawing.Color.LightSlateGray;
            this.bt_Quitter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_Quitter.ForeColor = System.Drawing.Color.White;
            this.bt_Quitter.HoverState.BorderColor = System.Drawing.Color.Black;
            this.bt_Quitter.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.bt_Quitter.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.bt_Quitter.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Quitter.HoverState.ForeColor = System.Drawing.Color.Black;
            this.bt_Quitter.Location = new System.Drawing.Point(336, 322);
            this.bt_Quitter.Name = "bt_Quitter";
            this.bt_Quitter.ShadowDecoration.BorderRadius = 26;
            this.bt_Quitter.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.bt_Quitter.ShadowDecoration.Enabled = true;
            this.bt_Quitter.Size = new System.Drawing.Size(180, 45);
            this.bt_Quitter.TabIndex = 7;
            this.bt_Quitter.Text = "Quitter";
            this.bt_Quitter.Click += new System.EventHandler(this.bt_Quitter_Click_1);
            // 
            // button2
            // 
            this.button2.AutoRoundedCorners = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BorderColor = System.Drawing.Color.White;
            this.button2.BorderRadius = 21;
            this.button2.BorderThickness = 2;
            this.button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button2.FillColor = System.Drawing.Color.LightSlateGray;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.HoverState.BorderColor = System.Drawing.Color.Black;
            this.button2.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.button2.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.button2.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.HoverState.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(105, 322);
            this.button2.Name = "button2";
            this.button2.ShadowDecoration.BorderRadius = 26;
            this.button2.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.button2.ShadowDecoration.Enabled = true;
            this.button2.Size = new System.Drawing.Size(180, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Connecter";
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(nom_utilisateur_UtilisateursLabel);
            this.panel1.Controls.Add(this.bt_Quitter);
            this.panel1.Controls.Add(mot_de_passe_UtilisateursLabel);
            this.panel1.Controls.Add(this.afficher_les_caractéres);
            this.panel1.Controls.Add(this.rdAdministrateur);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.rdVendeur);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.rdGestionnaire);
            this.panel1.Location = new System.Drawing.Point(18, 178);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 538);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1540, 932);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1540, 932);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacellDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurs_BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PharmacellDataSet pharmacellDataSet;
        private System.Windows.Forms.BindingSource utilisateurs_BindingSource;
        private PharmacellDataSetTableAdapters.Utilisateurs_TableAdapter utilisateurs_TableAdapter;
        private PharmacellDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.RadioButton rdAdministrateur;
        private System.Windows.Forms.RadioButton rdVendeur;
        private System.Windows.Forms.RadioButton rdGestionnaire;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox afficher_les_caractéres;
        private Guna.UI2.WinForms.Guna2Button bt_Quitter;
        private Guna.UI2.WinForms.Guna2Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

