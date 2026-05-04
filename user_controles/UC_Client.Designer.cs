namespace proj_pharmacell.user_controles
{
    partial class UC_Client
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
            System.Windows.Forms.Label lbl_ClientID;
            System.Windows.Forms.Label lbNumero_TEL;
            System.Windows.Forms.Label lbl_UtilisateurID;
            System.Windows.Forms.Label lbl_Adresse;
            System.Windows.Forms.Label lbl_nom;
            System.Windows.Forms.Label lbl_prenom;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Client));
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.List = new System.Windows.Forms.TabPage();
            this.dgv_client = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.to_pdf = new Guna.UI2.WinForms.Guna2ImageButton();
            this.bt_toexcel = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_supprimer_client = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Modifier_client = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Vider_client = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ajouter_client = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.combo_utilisateurid = new System.Windows.Forms.ComboBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_adrr = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_clientid = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            lbl_ClientID = new System.Windows.Forms.Label();
            lbNumero_TEL = new System.Windows.Forms.Label();
            lbl_UtilisateurID = new System.Windows.Forms.Label();
            lbl_Adresse = new System.Windows.Forms.Label();
            lbl_nom = new System.Windows.Forms.Label();
            lbl_prenom = new System.Windows.Forms.Label();
            this.guna2TabControl1.SuspendLayout();
            this.List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ClientID
            // 
            lbl_ClientID.AutoSize = true;
            lbl_ClientID.Location = new System.Drawing.Point(281, 37);
            lbl_ClientID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_ClientID.Name = "lbl_ClientID";
            lbl_ClientID.Size = new System.Drawing.Size(70, 20);
            lbl_ClientID.TabIndex = 2;
            lbl_ClientID.Text = "ClientID:";
            // 
            // lbNumero_TEL
            // 
            lbNumero_TEL.AutoSize = true;
            lbNumero_TEL.Location = new System.Drawing.Point(285, 213);
            lbNumero_TEL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbNumero_TEL.Name = "lbNumero_TEL";
            lbNumero_TEL.Size = new System.Drawing.Size(92, 20);
            lbNumero_TEL.TabIndex = 12;
            lbNumero_TEL.Text = "Téléphone :";
            lbNumero_TEL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_UtilisateurID
            // 
            lbl_UtilisateurID.AutoSize = true;
            lbl_UtilisateurID.Location = new System.Drawing.Point(281, 256);
            lbl_UtilisateurID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_UtilisateurID.Name = "lbl_UtilisateurID";
            lbl_UtilisateurID.Size = new System.Drawing.Size(101, 20);
            lbl_UtilisateurID.TabIndex = 4;
            lbl_UtilisateurID.Text = "UtilisateurID:\r\n";
            // 
            // lbl_Adresse
            // 
            lbl_Adresse.AutoSize = true;
            lbl_Adresse.Location = new System.Drawing.Point(285, 165);
            lbl_Adresse.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_Adresse.Name = "lbl_Adresse";
            lbl_Adresse.Size = new System.Drawing.Size(76, 20);
            lbl_Adresse.TabIndex = 10;
            lbl_Adresse.Text = "Adresse :";
            // 
            // lbl_nom
            // 
            lbl_nom.AutoSize = true;
            lbl_nom.Location = new System.Drawing.Point(285, 79);
            lbl_nom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_nom.Name = "lbl_nom";
            lbl_nom.Size = new System.Drawing.Size(50, 20);
            lbl_nom.TabIndex = 6;
            lbl_nom.Text = "Nom :";
            // 
            // lbl_prenom
            // 
            lbl_prenom.AutoSize = true;
            lbl_prenom.Location = new System.Drawing.Point(285, 125);
            lbl_prenom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_prenom.Name = "lbl_prenom";
            lbl_prenom.Size = new System.Drawing.Size(72, 20);
            lbl_prenom.TabIndex = 8;
            lbl_prenom.Text = "Prénom :";
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
            this.guna2TabControl1.Size = new System.Drawing.Size(1298, 561);
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
            this.guna2TabControl1.TabIndex = 20;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // List
            // 
            this.List.Controls.Add(this.dgv_client);
            this.List.Controls.Add(this.panel2);
            this.List.Controls.Add(this.panel1);
            this.List.Location = new System.Drawing.Point(104, 4);
            this.List.Name = "List";
            this.List.Padding = new System.Windows.Forms.Padding(3);
            this.List.Size = new System.Drawing.Size(1190, 553);
            this.List.TabIndex = 0;
            this.List.Text = "List";
            this.List.UseVisualStyleBackColor = true;
            // 
            // dgv_client
            // 
            this.dgv_client.AllowUserToAddRows = false;
            this.dgv_client.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_client.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_client.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_client.ColumnHeadersHeight = 25;
            this.dgv_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_client.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_client.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_client.Location = new System.Drawing.Point(3, 313);
            this.dgv_client.Name = "dgv_client";
            this.dgv_client.ReadOnly = true;
            this.dgv_client.RowHeadersVisible = false;
            this.dgv_client.RowHeadersWidth = 62;
            this.dgv_client.RowTemplate.Height = 28;
            this.dgv_client.Size = new System.Drawing.Size(1184, 123);
            this.dgv_client.TabIndex = 20;
            this.dgv_client.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_client.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_client.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_client.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_client.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_client.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_client.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_client.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_client.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_client.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_client.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_client.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_client.ThemeStyle.HeaderStyle.Height = 25;
            this.dgv_client.ThemeStyle.ReadOnly = true;
            this.dgv_client.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_client.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_client.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_client.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_client.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_client.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_client.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_client.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_client_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.to_pdf);
            this.panel2.Controls.Add(this.bt_toexcel);
            this.panel2.Controls.Add(this.btn_supprimer_client);
            this.panel2.Controls.Add(this.btn_Modifier_client);
            this.panel2.Controls.Add(this.btn_Vider_client);
            this.panel2.Controls.Add(this.btn_ajouter_client);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 114);
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
            this.bt_toexcel.TabIndex = 42;
            this.bt_toexcel.Click += new System.EventHandler(this.bt_toexcel_Click);
            // 
            // btn_supprimer_client
            // 
            this.btn_supprimer_client.AutoRoundedCorners = true;
            this.btn_supprimer_client.BackColor = System.Drawing.Color.Transparent;
            this.btn_supprimer_client.BorderColor = System.Drawing.Color.White;
            this.btn_supprimer_client.BorderRadius = 21;
            this.btn_supprimer_client.BorderThickness = 2;
            this.btn_supprimer_client.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_supprimer_client.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_supprimer_client.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_supprimer_client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_supprimer_client.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_supprimer_client.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_supprimer_client.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer_client.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_supprimer_client.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_supprimer_client.HoverState.FillColor = System.Drawing.Color.Red;
            this.btn_supprimer_client.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer_client.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_supprimer_client.Location = new System.Drawing.Point(298, 51);
            this.btn_supprimer_client.Name = "btn_supprimer_client";
            this.btn_supprimer_client.ShadowDecoration.BorderRadius = 26;
            this.btn_supprimer_client.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_supprimer_client.ShadowDecoration.Enabled = true;
            this.btn_supprimer_client.Size = new System.Drawing.Size(180, 45);
            this.btn_supprimer_client.TabIndex = 47;
            this.btn_supprimer_client.Text = "Supprimer";
            this.btn_supprimer_client.Click += new System.EventHandler(this.btn_supprimer_client_Click);
            // 
            // btn_Modifier_client
            // 
            this.btn_Modifier_client.AutoRoundedCorners = true;
            this.btn_Modifier_client.BackColor = System.Drawing.Color.Transparent;
            this.btn_Modifier_client.BorderColor = System.Drawing.Color.White;
            this.btn_Modifier_client.BorderRadius = 21;
            this.btn_Modifier_client.BorderThickness = 2;
            this.btn_Modifier_client.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Modifier_client.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Modifier_client.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Modifier_client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Modifier_client.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_Modifier_client.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Modifier_client.ForeColor = System.Drawing.Color.White;
            this.btn_Modifier_client.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_Modifier_client.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_Modifier_client.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.btn_Modifier_client.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modifier_client.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_Modifier_client.Location = new System.Drawing.Point(496, 51);
            this.btn_Modifier_client.Name = "btn_Modifier_client";
            this.btn_Modifier_client.ShadowDecoration.BorderRadius = 26;
            this.btn_Modifier_client.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_Modifier_client.ShadowDecoration.Enabled = true;
            this.btn_Modifier_client.Size = new System.Drawing.Size(180, 45);
            this.btn_Modifier_client.TabIndex = 46;
            this.btn_Modifier_client.Text = "Modifier";
            this.btn_Modifier_client.Click += new System.EventHandler(this.btn_Modifier_client_Click);
            // 
            // btn_Vider_client
            // 
            this.btn_Vider_client.AutoRoundedCorners = true;
            this.btn_Vider_client.BackColor = System.Drawing.Color.Transparent;
            this.btn_Vider_client.BorderColor = System.Drawing.Color.White;
            this.btn_Vider_client.BorderRadius = 21;
            this.btn_Vider_client.BorderThickness = 2;
            this.btn_Vider_client.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Vider_client.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Vider_client.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Vider_client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Vider_client.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_Vider_client.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Vider_client.ForeColor = System.Drawing.Color.White;
            this.btn_Vider_client.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_Vider_client.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_Vider_client.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.btn_Vider_client.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vider_client.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_Vider_client.Location = new System.Drawing.Point(713, 51);
            this.btn_Vider_client.Name = "btn_Vider_client";
            this.btn_Vider_client.ShadowDecoration.BorderRadius = 26;
            this.btn_Vider_client.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_Vider_client.ShadowDecoration.Enabled = true;
            this.btn_Vider_client.Size = new System.Drawing.Size(180, 45);
            this.btn_Vider_client.TabIndex = 45;
            this.btn_Vider_client.Text = "Vider";
            this.btn_Vider_client.Click += new System.EventHandler(this.btn_Vider_client_Click);
            // 
            // btn_ajouter_client
            // 
            this.btn_ajouter_client.AutoRoundedCorners = true;
            this.btn_ajouter_client.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajouter_client.BorderColor = System.Drawing.Color.White;
            this.btn_ajouter_client.BorderRadius = 21;
            this.btn_ajouter_client.BorderThickness = 2;
            this.btn_ajouter_client.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajouter_client.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajouter_client.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ajouter_client.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ajouter_client.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_ajouter_client.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ajouter_client.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter_client.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_ajouter_client.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_ajouter_client.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ajouter_client.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter_client.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_ajouter_client.Location = new System.Drawing.Point(92, 51);
            this.btn_ajouter_client.Name = "btn_ajouter_client";
            this.btn_ajouter_client.ShadowDecoration.BorderRadius = 26;
            this.btn_ajouter_client.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_ajouter_client.ShadowDecoration.Enabled = true;
            this.btn_ajouter_client.Size = new System.Drawing.Size(180, 45);
            this.btn_ajouter_client.TabIndex = 44;
            this.btn_ajouter_client.Text = "Ajouter";
            this.btn_ajouter_client.Click += new System.EventHandler(this.btn_ajouter_client_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.combo_utilisateurid);
            this.panel1.Controls.Add(this.txt_tel);
            this.panel1.Controls.Add(this.txt_adrr);
            this.panel1.Controls.Add(this.txt_prenom);
            this.panel1.Controls.Add(this.txt_nom);
            this.panel1.Controls.Add(this.txt_clientid);
            this.panel1.Controls.Add(lbl_ClientID);
            this.panel1.Controls.Add(lbNumero_TEL);
            this.panel1.Controls.Add(lbl_UtilisateurID);
            this.panel1.Controls.Add(lbl_Adresse);
            this.panel1.Controls.Add(lbl_nom);
            this.panel1.Controls.Add(lbl_prenom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 310);
            this.panel1.TabIndex = 18;
            // 
            // combo_utilisateurid
            // 
            this.combo_utilisateurid.FormattingEnabled = true;
            this.combo_utilisateurid.Location = new System.Drawing.Point(480, 256);
            this.combo_utilisateurid.Name = "combo_utilisateurid";
            this.combo_utilisateurid.Size = new System.Drawing.Size(310, 28);
            this.combo_utilisateurid.TabIndex = 19;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(480, 213);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_tel.Size = new System.Drawing.Size(310, 26);
            this.txt_tel.TabIndex = 18;
            // 
            // txt_adrr
            // 
            this.txt_adrr.Location = new System.Drawing.Point(480, 167);
            this.txt_adrr.Name = "txt_adrr";
            this.txt_adrr.Size = new System.Drawing.Size(310, 26);
            this.txt_adrr.TabIndex = 18;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(480, 125);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(310, 26);
            this.txt_prenom.TabIndex = 18;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(480, 79);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(310, 26);
            this.txt_nom.TabIndex = 18;
            // 
            // txt_clientid
            // 
            this.txt_clientid.Location = new System.Drawing.Point(480, 37);
            this.txt_clientid.Name = "txt_clientid";
            this.txt_clientid.Size = new System.Drawing.Size(310, 26);
            this.txt_clientid.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(942, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // UC_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2TabControl1);
            this.Name = "UC_Client";
            this.Size = new System.Drawing.Size(1298, 561);
            this.Load += new System.EventHandler(this.UC_Client_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage List;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_client;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ImageButton to_pdf;
        private Guna.UI2.WinForms.Guna2ImageButton bt_toexcel;
        private Guna.UI2.WinForms.Guna2Button btn_supprimer_client;
        private Guna.UI2.WinForms.Guna2Button btn_Modifier_client;
        private Guna.UI2.WinForms.Guna2Button btn_Vider_client;
        private Guna.UI2.WinForms.Guna2Button btn_ajouter_client;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_clientid;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_adrr;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.ComboBox combo_utilisateurid;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
