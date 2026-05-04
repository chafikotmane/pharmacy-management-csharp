namespace proj_pharmacell.user_controles
{
    partial class UC_Fournisseur
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lbl_Numero_Cmd;
            System.Windows.Forms.Label lbNumero_TEL;
            System.Windows.Forms.Label lbl_UtilisateurID;
            System.Windows.Forms.Label lbl_Adresse;
            System.Windows.Forms.Label lbl_nom;
            System.Windows.Forms.Label lbl_prenom;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Fournisseur));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.combo_fourniseeur = new System.Windows.Forms.ComboBox();
            this.txt_Telf = new System.Windows.Forms.TextBox();
            this.txt_addressef = new System.Windows.Forms.TextBox();
            this.txt_prenomf = new System.Windows.Forms.TextBox();
            this.txt_fournisseurId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_nomf = new System.Windows.Forms.TextBox();
            this.to_pdf = new Guna.UI2.WinForms.Guna2ImageButton();
            this.bt_toexcel = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dgv_Fournisseur = new Guna.UI2.WinForms.Guna2DataGridView();
            this.List = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_supprimer_cmnd = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Modifier_cmnd = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Vider_cmnd = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ajouter_cmnd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            lbl_Numero_Cmd = new System.Windows.Forms.Label();
            lbNumero_TEL = new System.Windows.Forms.Label();
            lbl_UtilisateurID = new System.Windows.Forms.Label();
            lbl_Adresse = new System.Windows.Forms.Label();
            lbl_nom = new System.Windows.Forms.Label();
            lbl_prenom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fournisseur)).BeginInit();
            this.List.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Numero_Cmd
            // 
            lbl_Numero_Cmd.AutoSize = true;
            lbl_Numero_Cmd.Location = new System.Drawing.Point(281, 37);
            lbl_Numero_Cmd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_Numero_Cmd.Name = "lbl_Numero_Cmd";
            lbl_Numero_Cmd.Size = new System.Drawing.Size(118, 20);
            lbl_Numero_Cmd.TabIndex = 2;
            lbl_Numero_Cmd.Text = "Fournisseur ID:";
            // 
            // lbNumero_TEL
            // 
            lbNumero_TEL.AutoSize = true;
            lbNumero_TEL.Location = new System.Drawing.Point(281, 213);
            lbNumero_TEL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbNumero_TEL.Name = "lbNumero_TEL";
            lbNumero_TEL.Size = new System.Drawing.Size(88, 20);
            lbNumero_TEL.TabIndex = 12;
            lbNumero_TEL.Text = "Téléphone:";
            lbNumero_TEL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_UtilisateurID
            // 
            lbl_UtilisateurID.AutoSize = true;
            lbl_UtilisateurID.Location = new System.Drawing.Point(285, 256);
            lbl_UtilisateurID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_UtilisateurID.Name = "lbl_UtilisateurID";
            lbl_UtilisateurID.Size = new System.Drawing.Size(101, 20);
            lbl_UtilisateurID.TabIndex = 4;
            lbl_UtilisateurID.Text = "Utilisateur ID";
            // 
            // lbl_Adresse
            // 
            lbl_Adresse.AutoSize = true;
            lbl_Adresse.Location = new System.Drawing.Point(281, 167);
            lbl_Adresse.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_Adresse.Name = "lbl_Adresse";
            lbl_Adresse.Size = new System.Drawing.Size(72, 20);
            lbl_Adresse.TabIndex = 10;
            lbl_Adresse.Text = "Adresse:";
            // 
            // lbl_nom
            // 
            lbl_nom.AutoSize = true;
            lbl_nom.Location = new System.Drawing.Point(281, 85);
            lbl_nom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_nom.Name = "lbl_nom";
            lbl_nom.Size = new System.Drawing.Size(46, 20);
            lbl_nom.TabIndex = 6;
            lbl_nom.Text = "Nom:";
            // 
            // lbl_prenom
            // 
            lbl_prenom.AutoSize = true;
            lbl_prenom.Location = new System.Drawing.Point(281, 128);
            lbl_prenom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_prenom.Name = "lbl_prenom";
            lbl_prenom.Size = new System.Drawing.Size(68, 20);
            lbl_prenom.TabIndex = 8;
            lbl_prenom.Text = "Prénom:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(925, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // combo_fourniseeur
            // 
            this.combo_fourniseeur.FormattingEnabled = true;
            this.combo_fourniseeur.Location = new System.Drawing.Point(480, 256);
            this.combo_fourniseeur.Name = "combo_fourniseeur";
            this.combo_fourniseeur.Size = new System.Drawing.Size(310, 28);
            this.combo_fourniseeur.TabIndex = 5;
            // 
            // txt_Telf
            // 
            this.txt_Telf.Location = new System.Drawing.Point(480, 209);
            this.txt_Telf.Name = "txt_Telf";
            this.txt_Telf.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Telf.Size = new System.Drawing.Size(310, 26);
            this.txt_Telf.TabIndex = 4;
            // 
            // txt_addressef
            // 
            this.txt_addressef.Location = new System.Drawing.Point(480, 167);
            this.txt_addressef.Name = "txt_addressef";
            this.txt_addressef.Size = new System.Drawing.Size(310, 26);
            this.txt_addressef.TabIndex = 3;
            // 
            // txt_prenomf
            // 
            this.txt_prenomf.Location = new System.Drawing.Point(480, 125);
            this.txt_prenomf.Name = "txt_prenomf";
            this.txt_prenomf.Size = new System.Drawing.Size(310, 26);
            this.txt_prenomf.TabIndex = 2;
            // 
            // txt_fournisseurId
            // 
            this.txt_fournisseurId.Location = new System.Drawing.Point(480, 37);
            this.txt_fournisseurId.Name = "txt_fournisseurId";
            this.txt_fournisseurId.Size = new System.Drawing.Size(310, 26);
            this.txt_fournisseurId.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.combo_fourniseeur);
            this.panel1.Controls.Add(this.txt_Telf);
            this.panel1.Controls.Add(this.txt_addressef);
            this.panel1.Controls.Add(this.txt_prenomf);
            this.panel1.Controls.Add(this.txt_nomf);
            this.panel1.Controls.Add(this.txt_fournisseurId);
            this.panel1.Controls.Add(lbl_Numero_Cmd);
            this.panel1.Controls.Add(lbNumero_TEL);
            this.panel1.Controls.Add(lbl_UtilisateurID);
            this.panel1.Controls.Add(lbl_Adresse);
            this.panel1.Controls.Add(lbl_nom);
            this.panel1.Controls.Add(lbl_prenom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 373);
            this.panel1.TabIndex = 18;
            // 
            // txt_nomf
            // 
            this.txt_nomf.Location = new System.Drawing.Point(480, 79);
            this.txt_nomf.Name = "txt_nomf";
            this.txt_nomf.Size = new System.Drawing.Size(310, 26);
            this.txt_nomf.TabIndex = 1;
            // 
            // to_pdf
            // 
            this.to_pdf.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.to_pdf.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.to_pdf.Image = ((System.Drawing.Image)(resources.GetObject("to_pdf.Image")));
            this.to_pdf.ImageOffset = new System.Drawing.Point(0, 0);
            this.to_pdf.ImageRotate = 0F;
            this.to_pdf.Location = new System.Drawing.Point(991, 42);
            this.to_pdf.Name = "to_pdf";
            this.to_pdf.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.to_pdf.Size = new System.Drawing.Size(76, 64);
            this.to_pdf.TabIndex = 5;
            this.to_pdf.Click += new System.EventHandler(this.to_pdf_Click);
            // 
            // bt_toexcel
            // 
            this.bt_toexcel.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.bt_toexcel.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.bt_toexcel.Image = ((System.Drawing.Image)(resources.GetObject("bt_toexcel.Image")));
            this.bt_toexcel.ImageOffset = new System.Drawing.Point(0, 0);
            this.bt_toexcel.ImageRotate = 0F;
            this.bt_toexcel.IndicateFocus = true;
            this.bt_toexcel.Location = new System.Drawing.Point(904, 44);
            this.bt_toexcel.Name = "bt_toexcel";
            this.bt_toexcel.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.bt_toexcel.Size = new System.Drawing.Size(64, 54);
            this.bt_toexcel.TabIndex = 4;
            this.bt_toexcel.Click += new System.EventHandler(this.bt_toexcel_Click_1);
            // 
            // dgv_Fournisseur
            // 
            this.dgv_Fournisseur.AllowUserToAddRows = false;
            this.dgv_Fournisseur.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dgv_Fournisseur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Fournisseur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_Fournisseur.ColumnHeadersHeight = 25;
            this.dgv_Fournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Fournisseur.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_Fournisseur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Fournisseur.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Fournisseur.Location = new System.Drawing.Point(3, 376);
            this.dgv_Fournisseur.Name = "dgv_Fournisseur";
            this.dgv_Fournisseur.ReadOnly = true;
            this.dgv_Fournisseur.RowHeadersVisible = false;
            this.dgv_Fournisseur.RowHeadersWidth = 62;
            this.dgv_Fournisseur.RowTemplate.Height = 28;
            this.dgv_Fournisseur.Size = new System.Drawing.Size(1167, 365);
            this.dgv_Fournisseur.TabIndex = 20;
            this.dgv_Fournisseur.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Fournisseur.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Fournisseur.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Fournisseur.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Fournisseur.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Fournisseur.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Fournisseur.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Fournisseur.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Fournisseur.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Fournisseur.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Fournisseur.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Fournisseur.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Fournisseur.ThemeStyle.HeaderStyle.Height = 25;
            this.dgv_Fournisseur.ThemeStyle.ReadOnly = true;
            this.dgv_Fournisseur.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Fournisseur.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Fournisseur.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Fournisseur.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Fournisseur.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_Fournisseur.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Fournisseur.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Fournisseur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Fournisseur_CellClick);
            // 
            // List
            // 
            this.List.Controls.Add(this.dgv_Fournisseur);
            this.List.Controls.Add(this.panel2);
            this.List.Controls.Add(this.panel1);
            this.List.Location = new System.Drawing.Point(104, 4);
            this.List.Name = "List";
            this.List.Padding = new System.Windows.Forms.Padding(3);
            this.List.Size = new System.Drawing.Size(1173, 858);
            this.List.TabIndex = 0;
            this.List.Text = "List";
            this.List.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.to_pdf);
            this.panel2.Controls.Add(this.bt_toexcel);
            this.panel2.Controls.Add(this.btn_supprimer_cmnd);
            this.panel2.Controls.Add(this.btn_Modifier_cmnd);
            this.panel2.Controls.Add(this.btn_Vider_cmnd);
            this.panel2.Controls.Add(this.btn_ajouter_cmnd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 741);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1167, 114);
            this.panel2.TabIndex = 19;
            // 
            // btn_supprimer_cmnd
            // 
            this.btn_supprimer_cmnd.AutoRoundedCorners = true;
            this.btn_supprimer_cmnd.BackColor = System.Drawing.Color.Transparent;
            this.btn_supprimer_cmnd.BorderColor = System.Drawing.Color.White;
            this.btn_supprimer_cmnd.BorderRadius = 21;
            this.btn_supprimer_cmnd.BorderThickness = 2;
            this.btn_supprimer_cmnd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_supprimer_cmnd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_supprimer_cmnd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_supprimer_cmnd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_supprimer_cmnd.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_supprimer_cmnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_supprimer_cmnd.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer_cmnd.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_supprimer_cmnd.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_supprimer_cmnd.HoverState.FillColor = System.Drawing.Color.Red;
            this.btn_supprimer_cmnd.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer_cmnd.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_supprimer_cmnd.Location = new System.Drawing.Point(298, 51);
            this.btn_supprimer_cmnd.Name = "btn_supprimer_cmnd";
            this.btn_supprimer_cmnd.ShadowDecoration.BorderRadius = 26;
            this.btn_supprimer_cmnd.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_supprimer_cmnd.ShadowDecoration.Enabled = true;
            this.btn_supprimer_cmnd.Size = new System.Drawing.Size(180, 45);
            this.btn_supprimer_cmnd.TabIndex = 1;
            this.btn_supprimer_cmnd.Text = "Supprimer";
            this.btn_supprimer_cmnd.Click += new System.EventHandler(this.btn_supprimer_cmnd_Click);
            // 
            // btn_Modifier_cmnd
            // 
            this.btn_Modifier_cmnd.AutoRoundedCorners = true;
            this.btn_Modifier_cmnd.BackColor = System.Drawing.Color.Transparent;
            this.btn_Modifier_cmnd.BorderColor = System.Drawing.Color.White;
            this.btn_Modifier_cmnd.BorderRadius = 21;
            this.btn_Modifier_cmnd.BorderThickness = 2;
            this.btn_Modifier_cmnd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Modifier_cmnd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Modifier_cmnd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Modifier_cmnd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Modifier_cmnd.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_Modifier_cmnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Modifier_cmnd.ForeColor = System.Drawing.Color.White;
            this.btn_Modifier_cmnd.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_Modifier_cmnd.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_Modifier_cmnd.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.btn_Modifier_cmnd.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modifier_cmnd.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_Modifier_cmnd.Location = new System.Drawing.Point(496, 51);
            this.btn_Modifier_cmnd.Name = "btn_Modifier_cmnd";
            this.btn_Modifier_cmnd.ShadowDecoration.BorderRadius = 26;
            this.btn_Modifier_cmnd.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_Modifier_cmnd.ShadowDecoration.Enabled = true;
            this.btn_Modifier_cmnd.Size = new System.Drawing.Size(180, 45);
            this.btn_Modifier_cmnd.TabIndex = 2;
            this.btn_Modifier_cmnd.Text = "Modifier";
            this.btn_Modifier_cmnd.Click += new System.EventHandler(this.btn_Modifier_cmnd_Click);
            // 
            // btn_Vider_cmnd
            // 
            this.btn_Vider_cmnd.AutoRoundedCorners = true;
            this.btn_Vider_cmnd.BackColor = System.Drawing.Color.Transparent;
            this.btn_Vider_cmnd.BorderColor = System.Drawing.Color.White;
            this.btn_Vider_cmnd.BorderRadius = 21;
            this.btn_Vider_cmnd.BorderThickness = 2;
            this.btn_Vider_cmnd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Vider_cmnd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Vider_cmnd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Vider_cmnd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Vider_cmnd.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_Vider_cmnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Vider_cmnd.ForeColor = System.Drawing.Color.White;
            this.btn_Vider_cmnd.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_Vider_cmnd.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_Vider_cmnd.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.btn_Vider_cmnd.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vider_cmnd.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_Vider_cmnd.Location = new System.Drawing.Point(713, 51);
            this.btn_Vider_cmnd.Name = "btn_Vider_cmnd";
            this.btn_Vider_cmnd.ShadowDecoration.BorderRadius = 26;
            this.btn_Vider_cmnd.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_Vider_cmnd.ShadowDecoration.Enabled = true;
            this.btn_Vider_cmnd.Size = new System.Drawing.Size(180, 45);
            this.btn_Vider_cmnd.TabIndex = 3;
            this.btn_Vider_cmnd.Text = "Vider";
            this.btn_Vider_cmnd.Click += new System.EventHandler(this.btn_Vider_cmnd_Click);
            // 
            // btn_ajouter_cmnd
            // 
            this.btn_ajouter_cmnd.AutoRoundedCorners = true;
            this.btn_ajouter_cmnd.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajouter_cmnd.BorderColor = System.Drawing.Color.White;
            this.btn_ajouter_cmnd.BorderRadius = 21;
            this.btn_ajouter_cmnd.BorderThickness = 2;
            this.btn_ajouter_cmnd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajouter_cmnd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajouter_cmnd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ajouter_cmnd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ajouter_cmnd.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_ajouter_cmnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ajouter_cmnd.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter_cmnd.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_ajouter_cmnd.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_ajouter_cmnd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ajouter_cmnd.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter_cmnd.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_ajouter_cmnd.Location = new System.Drawing.Point(92, 51);
            this.btn_ajouter_cmnd.Name = "btn_ajouter_cmnd";
            this.btn_ajouter_cmnd.ShadowDecoration.BorderRadius = 26;
            this.btn_ajouter_cmnd.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_ajouter_cmnd.ShadowDecoration.Enabled = true;
            this.btn_ajouter_cmnd.Size = new System.Drawing.Size(180, 45);
            this.btn_ajouter_cmnd.TabIndex = 0;
            this.btn_ajouter_cmnd.Text = "Ajouter";
            this.btn_ajouter_cmnd.Click += new System.EventHandler(this.btn_ajouter_cmnd_Click);
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.List);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(100, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1281, 866);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(100, 40);
            this.guna2TabControl1.TabIndex = 22;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // UC_Fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2TabControl1);
            this.Name = "UC_Fournisseur";
            this.Size = new System.Drawing.Size(1281, 866);
            this.Load += new System.EventHandler(this.UC_Fournisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fournisseur)).EndInit();
            this.List.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.guna2TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox combo_fourniseeur;
        private System.Windows.Forms.TextBox txt_Telf;
        private System.Windows.Forms.TextBox txt_addressef;
        private System.Windows.Forms.TextBox txt_prenomf;
        private System.Windows.Forms.TextBox txt_fournisseurId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_nomf;
        private Guna.UI2.WinForms.Guna2ImageButton to_pdf;
        private Guna.UI2.WinForms.Guna2ImageButton bt_toexcel;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Fournisseur;
        private System.Windows.Forms.TabPage List;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_supprimer_cmnd;
        private Guna.UI2.WinForms.Guna2Button btn_Modifier_cmnd;
        private Guna.UI2.WinForms.Guna2Button btn_Vider_cmnd;
        private Guna.UI2.WinForms.Guna2Button btn_ajouter_cmnd;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
    }
}
