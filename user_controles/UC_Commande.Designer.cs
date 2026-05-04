namespace proj_pharmacell.user_controles
{
    partial class UC_Commande
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Commande));
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.List = new System.Windows.Forms.TabPage();
            this.dgv_commande = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.to_pdf = new Guna.UI2.WinForms.Guna2ImageButton();
            this.bt_toexcel = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_supprimer_cmnd = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Modifier_cmnd = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Vider_cmnd = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ajouter_cmnd = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_DAte = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.combo_utilisateurid = new System.Windows.Forms.ComboBox();
            this.combo_medicament = new System.Windows.Forms.ComboBox();
            this.combo_fourniseeur = new System.Windows.Forms.ComboBox();
            this.txt_statue = new System.Windows.Forms.TextBox();
            this.txt_cout = new System.Windows.Forms.TextBox();
            this.txt_quantite = new System.Windows.Forms.TextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            lbl_Numero_Cmd = new System.Windows.Forms.Label();
            lbNumero_TEL = new System.Windows.Forms.Label();
            lbl_UtilisateurID = new System.Windows.Forms.Label();
            lbl_Adresse = new System.Windows.Forms.Label();
            lbl_nom = new System.Windows.Forms.Label();
            lbl_prenom = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.guna2TabControl1.SuspendLayout();
            this.List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commande)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Numero_Cmd
            // 
            lbl_Numero_Cmd.AutoSize = true;
            lbl_Numero_Cmd.Location = new System.Drawing.Point(281, 37);
            lbl_Numero_Cmd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_Numero_Cmd.Name = "lbl_Numero_Cmd";
            lbl_Numero_Cmd.Size = new System.Drawing.Size(174, 20);
            lbl_Numero_Cmd.TabIndex = 2;
            lbl_Numero_Cmd.Text = "Numéro de commande:";
            // 
            // lbNumero_TEL
            // 
            lbNumero_TEL.AutoSize = true;
            lbNumero_TEL.Location = new System.Drawing.Point(281, 213);
            lbNumero_TEL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbNumero_TEL.Name = "lbNumero_TEL";
            lbNumero_TEL.Size = new System.Drawing.Size(170, 20);
            lbNumero_TEL.TabIndex = 12;
            lbNumero_TEL.Text = "Statue de commande :";
            lbNumero_TEL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_UtilisateurID
            // 
            lbl_UtilisateurID.AutoSize = true;
            lbl_UtilisateurID.Location = new System.Drawing.Point(285, 256);
            lbl_UtilisateurID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_UtilisateurID.Name = "lbl_UtilisateurID";
            lbl_UtilisateurID.Size = new System.Drawing.Size(118, 20);
            lbl_UtilisateurID.TabIndex = 4;
            lbl_UtilisateurID.Text = "Fournisseur ID:\r\n";
            // 
            // lbl_Adresse
            // 
            lbl_Adresse.AutoSize = true;
            lbl_Adresse.Location = new System.Drawing.Point(281, 167);
            lbl_Adresse.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_Adresse.Name = "lbl_Adresse";
            lbl_Adresse.Size = new System.Drawing.Size(87, 20);
            lbl_Adresse.TabIndex = 10;
            lbl_Adresse.Text = "coût Total :";
            // 
            // lbl_nom
            // 
            lbl_nom.AutoSize = true;
            lbl_nom.Location = new System.Drawing.Point(281, 85);
            lbl_nom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_nom.Name = "lbl_nom";
            lbl_nom.Size = new System.Drawing.Size(52, 20);
            lbl_nom.TabIndex = 6;
            lbl_nom.Text = "Date :";
            // 
            // lbl_prenom
            // 
            lbl_prenom.AutoSize = true;
            lbl_prenom.Location = new System.Drawing.Point(281, 128);
            lbl_prenom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_prenom.Name = "lbl_prenom";
            lbl_prenom.Size = new System.Drawing.Size(78, 20);
            lbl_prenom.TabIndex = 8;
            lbl_prenom.Text = "Quantité :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(281, 290);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 20);
            label1.TabIndex = 4;
            label1.Text = "Médicament:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(281, 324);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 20);
            label2.TabIndex = 4;
            label2.Text = "UtilisateurID:\r\n";
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
            this.guna2TabControl1.Size = new System.Drawing.Size(1175, 619);
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
            this.guna2TabControl1.TabIndex = 21;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // List
            // 
            this.List.Controls.Add(this.dgv_commande);
            this.List.Controls.Add(this.panel2);
            this.List.Controls.Add(this.panel1);
            this.List.Location = new System.Drawing.Point(104, 4);
            this.List.Name = "List";
            this.List.Padding = new System.Windows.Forms.Padding(3);
            this.List.Size = new System.Drawing.Size(1067, 611);
            this.List.TabIndex = 0;
            this.List.Text = "List";
            this.List.UseVisualStyleBackColor = true;
            // 
            // dgv_commande
            // 
            this.dgv_commande.AllowUserToAddRows = false;
            this.dgv_commande.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_commande.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_commande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_commande.ColumnHeadersHeight = 25;
            this.dgv_commande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_commande.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_commande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_commande.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_commande.Location = new System.Drawing.Point(3, 376);
            this.dgv_commande.Name = "dgv_commande";
            this.dgv_commande.ReadOnly = true;
            this.dgv_commande.RowHeadersVisible = false;
            this.dgv_commande.RowHeadersWidth = 62;
            this.dgv_commande.RowTemplate.Height = 28;
            this.dgv_commande.Size = new System.Drawing.Size(1061, 118);
            this.dgv_commande.TabIndex = 20;
            this.dgv_commande.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_commande.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_commande.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_commande.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_commande.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_commande.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_commande.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_commande.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_commande.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_commande.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_commande.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_commande.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_commande.ThemeStyle.HeaderStyle.Height = 25;
            this.dgv_commande.ThemeStyle.ReadOnly = true;
            this.dgv_commande.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_commande.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_commande.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_commande.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_commande.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_commande.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_commande.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_commande.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_client_CellClick);
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
            this.panel2.Location = new System.Drawing.Point(3, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 114);
            this.panel2.TabIndex = 19;
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
            this.to_pdf.TabIndex = 43;
            this.to_pdf.Click += new System.EventHandler(this.to_pdf_Click_1);
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
            this.bt_toexcel.TabIndex = 42;
            this.bt_toexcel.Click += new System.EventHandler(this.bt_toexcel_Click_1);
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
            this.btn_supprimer_cmnd.TabIndex = 47;
            this.btn_supprimer_cmnd.Text = "Supprimer";
            this.btn_supprimer_cmnd.Click += new System.EventHandler(this.btn_supprimer_client_Click);
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
            this.btn_Modifier_cmnd.TabIndex = 46;
            this.btn_Modifier_cmnd.Text = "Modifier";
            this.btn_Modifier_cmnd.Click += new System.EventHandler(this.btn_Modifier_client_Click);
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
            this.btn_Vider_cmnd.TabIndex = 45;
            this.btn_Vider_cmnd.Text = "Vider";
            this.btn_Vider_cmnd.Click += new System.EventHandler(this.btn_Vider_client_Click);
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
            this.btn_ajouter_cmnd.TabIndex = 44;
            this.btn_ajouter_cmnd.Text = "Ajouter";
            this.btn_ajouter_cmnd.Click += new System.EventHandler(this.btn_ajouter_client_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_DAte);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.combo_utilisateurid);
            this.panel1.Controls.Add(this.combo_medicament);
            this.panel1.Controls.Add(this.combo_fourniseeur);
            this.panel1.Controls.Add(this.txt_statue);
            this.panel1.Controls.Add(this.txt_cout);
            this.panel1.Controls.Add(this.txt_quantite);
            this.panel1.Controls.Add(this.txt_num);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(lbl_Numero_Cmd);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(lbNumero_TEL);
            this.panel1.Controls.Add(lbl_UtilisateurID);
            this.panel1.Controls.Add(lbl_Adresse);
            this.panel1.Controls.Add(lbl_nom);
            this.panel1.Controls.Add(lbl_prenom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 373);
            this.panel1.TabIndex = 18;
            // 
            // dtp_DAte
            // 
            this.dtp_DAte.Location = new System.Drawing.Point(480, 79);
            this.dtp_DAte.Name = "dtp_DAte";
            this.dtp_DAte.Size = new System.Drawing.Size(310, 26);
            this.dtp_DAte.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(819, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // combo_utilisateurid
            // 
            this.combo_utilisateurid.FormattingEnabled = true;
            this.combo_utilisateurid.Location = new System.Drawing.Point(480, 324);
            this.combo_utilisateurid.Name = "combo_utilisateurid";
            this.combo_utilisateurid.Size = new System.Drawing.Size(310, 28);
            this.combo_utilisateurid.TabIndex = 19;
            // 
            // combo_medicament
            // 
            this.combo_medicament.FormattingEnabled = true;
            this.combo_medicament.Location = new System.Drawing.Point(480, 290);
            this.combo_medicament.Name = "combo_medicament";
            this.combo_medicament.Size = new System.Drawing.Size(310, 28);
            this.combo_medicament.TabIndex = 19;
            // 
            // combo_fourniseeur
            // 
            this.combo_fourniseeur.FormattingEnabled = true;
            this.combo_fourniseeur.Location = new System.Drawing.Point(480, 256);
            this.combo_fourniseeur.Name = "combo_fourniseeur";
            this.combo_fourniseeur.Size = new System.Drawing.Size(310, 28);
            this.combo_fourniseeur.TabIndex = 19;
            // 
            // txt_statue
            // 
            this.txt_statue.Location = new System.Drawing.Point(480, 209);
            this.txt_statue.Name = "txt_statue";
            this.txt_statue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_statue.Size = new System.Drawing.Size(310, 26);
            this.txt_statue.TabIndex = 18;
            // 
            // txt_cout
            // 
            this.txt_cout.Location = new System.Drawing.Point(480, 167);
            this.txt_cout.Name = "txt_cout";
            this.txt_cout.Size = new System.Drawing.Size(310, 26);
            this.txt_cout.TabIndex = 18;
            // 
            // txt_quantite
            // 
            this.txt_quantite.Location = new System.Drawing.Point(480, 125);
            this.txt_quantite.Name = "txt_quantite";
            this.txt_quantite.Size = new System.Drawing.Size(310, 26);
            this.txt_quantite.TabIndex = 18;
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(480, 37);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(310, 26);
            this.txt_num.TabIndex = 18;
            // 
            // UC_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2TabControl1);
            this.Name = "UC_Commande";
            this.Size = new System.Drawing.Size(1175, 619);
            this.Load += new System.EventHandler(this.UC_Commande_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_commande)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage List;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_commande;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ImageButton to_pdf;
        private Guna.UI2.WinForms.Guna2ImageButton bt_toexcel;
        private Guna.UI2.WinForms.Guna2Button btn_supprimer_cmnd;
        private Guna.UI2.WinForms.Guna2Button btn_Modifier_cmnd;
        private Guna.UI2.WinForms.Guna2Button btn_Vider_cmnd;
        private Guna.UI2.WinForms.Guna2Button btn_ajouter_cmnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_statue;
        private System.Windows.Forms.TextBox txt_cout;
        private System.Windows.Forms.TextBox txt_quantite;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.ComboBox combo_utilisateurid;
        private System.Windows.Forms.ComboBox combo_medicament;
        private System.Windows.Forms.ComboBox combo_fourniseeur;
        private System.Windows.Forms.DateTimePicker dtp_DAte;
    }
}
