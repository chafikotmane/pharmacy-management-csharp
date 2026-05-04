namespace proj_pharmacell.user_controles
{
    partial class UC_Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label lbl_Numero_Cmd;
            System.Windows.Forms.Label lbNumero_TEL;
            System.Windows.Forms.Label lbl_UtilisateurID;
            System.Windows.Forms.Label lbl_Adresse;
            System.Windows.Forms.Label lbl_nom;
            System.Windows.Forms.Label lbl_prenom;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Stock));
            this.btn_supprimerStock = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ModifierStock = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ajouterStock = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ViderStock = new Guna.UI2.WinForms.Guna2Button();
            this.List = new System.Windows.Forms.TabPage();
            this.dgvStock = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboUtilisateurID = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtTypeStock = new System.Windows.Forms.TextBox();
            this.txtQunatiteStock = new System.Windows.Forms.TextBox();
            this.txtStockID = new System.Windows.Forms.TextBox();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.to_pdf = new Guna.UI2.WinForms.Guna2ImageButton();
            this.bt_toexcel = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PbStock = new System.Windows.Forms.PictureBox();
            this.dtpDateStock = new System.Windows.Forms.DateTimePicker();
            lbl_Numero_Cmd = new System.Windows.Forms.Label();
            lbNumero_TEL = new System.Windows.Forms.Label();
            lbl_UtilisateurID = new System.Windows.Forms.Label();
            lbl_Adresse = new System.Windows.Forms.Label();
            lbl_nom = new System.Windows.Forms.Label();
            lbl_prenom = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panel1.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_supprimerStock
            // 
            this.btn_supprimerStock.AutoRoundedCorners = true;
            this.btn_supprimerStock.BackColor = System.Drawing.Color.Transparent;
            this.btn_supprimerStock.BorderColor = System.Drawing.Color.White;
            this.btn_supprimerStock.BorderRadius = 21;
            this.btn_supprimerStock.BorderThickness = 2;
            this.btn_supprimerStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_supprimerStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_supprimerStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_supprimerStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_supprimerStock.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_supprimerStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_supprimerStock.ForeColor = System.Drawing.Color.White;
            this.btn_supprimerStock.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_supprimerStock.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_supprimerStock.HoverState.FillColor = System.Drawing.Color.Red;
            this.btn_supprimerStock.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimerStock.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_supprimerStock.Location = new System.Drawing.Point(298, 51);
            this.btn_supprimerStock.Name = "btn_supprimerStock";
            this.btn_supprimerStock.ShadowDecoration.BorderRadius = 26;
            this.btn_supprimerStock.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_supprimerStock.ShadowDecoration.Enabled = true;
            this.btn_supprimerStock.Size = new System.Drawing.Size(180, 45);
            this.btn_supprimerStock.TabIndex = 1;
            this.btn_supprimerStock.Text = "Supprimer";
            this.btn_supprimerStock.Click += new System.EventHandler(this.btn_supprimerStock_Click);
            // 
            // btn_ModifierStock
            // 
            this.btn_ModifierStock.AutoRoundedCorners = true;
            this.btn_ModifierStock.BackColor = System.Drawing.Color.Transparent;
            this.btn_ModifierStock.BorderColor = System.Drawing.Color.White;
            this.btn_ModifierStock.BorderRadius = 21;
            this.btn_ModifierStock.BorderThickness = 2;
            this.btn_ModifierStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ModifierStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ModifierStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ModifierStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ModifierStock.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_ModifierStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ModifierStock.ForeColor = System.Drawing.Color.White;
            this.btn_ModifierStock.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_ModifierStock.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_ModifierStock.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.btn_ModifierStock.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModifierStock.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_ModifierStock.Location = new System.Drawing.Point(502, 51);
            this.btn_ModifierStock.Name = "btn_ModifierStock";
            this.btn_ModifierStock.ShadowDecoration.BorderRadius = 26;
            this.btn_ModifierStock.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_ModifierStock.ShadowDecoration.Enabled = true;
            this.btn_ModifierStock.Size = new System.Drawing.Size(180, 45);
            this.btn_ModifierStock.TabIndex = 2;
            this.btn_ModifierStock.Text = "Modifier";
            this.btn_ModifierStock.Click += new System.EventHandler(this.btn_ModifierStock_Click);
            // 
            // btn_ajouterStock
            // 
            this.btn_ajouterStock.AutoRoundedCorners = true;
            this.btn_ajouterStock.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajouterStock.BorderColor = System.Drawing.Color.White;
            this.btn_ajouterStock.BorderRadius = 21;
            this.btn_ajouterStock.BorderThickness = 2;
            this.btn_ajouterStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajouterStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajouterStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ajouterStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ajouterStock.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_ajouterStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ajouterStock.ForeColor = System.Drawing.Color.White;
            this.btn_ajouterStock.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_ajouterStock.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_ajouterStock.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ajouterStock.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouterStock.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_ajouterStock.Location = new System.Drawing.Point(92, 51);
            this.btn_ajouterStock.Name = "btn_ajouterStock";
            this.btn_ajouterStock.ShadowDecoration.BorderRadius = 26;
            this.btn_ajouterStock.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_ajouterStock.ShadowDecoration.Enabled = true;
            this.btn_ajouterStock.Size = new System.Drawing.Size(180, 45);
            this.btn_ajouterStock.TabIndex = 0;
            this.btn_ajouterStock.Text = "Ajouter";
            this.btn_ajouterStock.Click += new System.EventHandler(this.btn_ajouterStock_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.to_pdf);
            this.panel2.Controls.Add(this.bt_toexcel);
            this.panel2.Controls.Add(this.btn_supprimerStock);
            this.panel2.Controls.Add(this.btn_ModifierStock);
            this.panel2.Controls.Add(this.btn_ViderStock);
            this.panel2.Controls.Add(this.btn_ajouterStock);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 601);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 114);
            this.panel2.TabIndex = 19;
            // 
            // btn_ViderStock
            // 
            this.btn_ViderStock.AutoRoundedCorners = true;
            this.btn_ViderStock.BackColor = System.Drawing.Color.Transparent;
            this.btn_ViderStock.BorderColor = System.Drawing.Color.White;
            this.btn_ViderStock.BorderRadius = 21;
            this.btn_ViderStock.BorderThickness = 2;
            this.btn_ViderStock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ViderStock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ViderStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ViderStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ViderStock.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_ViderStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ViderStock.ForeColor = System.Drawing.Color.White;
            this.btn_ViderStock.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_ViderStock.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_ViderStock.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.btn_ViderStock.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViderStock.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_ViderStock.Location = new System.Drawing.Point(713, 51);
            this.btn_ViderStock.Name = "btn_ViderStock";
            this.btn_ViderStock.ShadowDecoration.BorderRadius = 26;
            this.btn_ViderStock.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_ViderStock.ShadowDecoration.Enabled = true;
            this.btn_ViderStock.Size = new System.Drawing.Size(180, 45);
            this.btn_ViderStock.TabIndex = 3;
            this.btn_ViderStock.Text = "Vider";
            this.btn_ViderStock.Click += new System.EventHandler(this.btn_ViderStock_Click);
            // 
            // List
            // 
            this.List.Controls.Add(this.dgvStock);
            this.List.Controls.Add(this.panel2);
            this.List.Controls.Add(this.panel1);
            this.List.Location = new System.Drawing.Point(104, 4);
            this.List.Name = "List";
            this.List.Padding = new System.Windows.Forms.Padding(3);
            this.List.Size = new System.Drawing.Size(1267, 718);
            this.List.TabIndex = 0;
            this.List.Text = "List";
            this.List.UseVisualStyleBackColor = true;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStock.ColumnHeadersHeight = 25;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStock.Location = new System.Drawing.Point(3, 376);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 62;
            this.dgvStock.RowTemplate.Height = 28;
            this.dgvStock.Size = new System.Drawing.Size(1261, 225);
            this.dgvStock.TabIndex = 20;
            this.dgvStock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStock.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStock.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStock.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStock.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStock.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvStock.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStock.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvStock.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStock.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStock.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStock.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvStock.ThemeStyle.ReadOnly = true;
            this.dgvStock.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStock.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStock.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStock.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStock.ThemeStyle.RowsStyle.Height = 28;
            this.dgvStock.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStock.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpDateStock);
            this.panel1.Controls.Add(this.PbStock);
            this.panel1.Controls.Add(this.comboUtilisateurID);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.txtTypeStock);
            this.panel1.Controls.Add(this.txtQunatiteStock);
            this.panel1.Controls.Add(this.txtStockID);
            this.panel1.Controls.Add(lbl_Numero_Cmd);
            this.panel1.Controls.Add(lbNumero_TEL);
            this.panel1.Controls.Add(lbl_UtilisateurID);
            this.panel1.Controls.Add(lbl_Adresse);
            this.panel1.Controls.Add(lbl_nom);
            this.panel1.Controls.Add(lbl_prenom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 373);
            this.panel1.TabIndex = 18;
            // 
            // comboUtilisateurID
            // 
            this.comboUtilisateurID.FormattingEnabled = true;
            this.comboUtilisateurID.Location = new System.Drawing.Point(480, 256);
            this.comboUtilisateurID.Name = "comboUtilisateurID";
            this.comboUtilisateurID.Size = new System.Drawing.Size(310, 28);
            this.comboUtilisateurID.TabIndex = 5;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(480, 209);
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNote.Size = new System.Drawing.Size(310, 26);
            this.txtNote.TabIndex = 4;
            // 
            // txtTypeStock
            // 
            this.txtTypeStock.Location = new System.Drawing.Point(480, 125);
            this.txtTypeStock.Name = "txtTypeStock";
            this.txtTypeStock.Size = new System.Drawing.Size(310, 26);
            this.txtTypeStock.TabIndex = 2;
            // 
            // txtQunatiteStock
            // 
            this.txtQunatiteStock.Location = new System.Drawing.Point(480, 79);
            this.txtQunatiteStock.Name = "txtQunatiteStock";
            this.txtQunatiteStock.Size = new System.Drawing.Size(310, 26);
            this.txtQunatiteStock.TabIndex = 1;
            // 
            // txtStockID
            // 
            this.txtStockID.Location = new System.Drawing.Point(480, 37);
            this.txtStockID.Name = "txtStockID";
            this.txtStockID.Size = new System.Drawing.Size(310, 26);
            this.txtStockID.TabIndex = 0;
            // 
            // lbl_Numero_Cmd
            // 
            lbl_Numero_Cmd.AutoSize = true;
            lbl_Numero_Cmd.Location = new System.Drawing.Point(281, 37);
            lbl_Numero_Cmd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_Numero_Cmd.Name = "lbl_Numero_Cmd";
            lbl_Numero_Cmd.Size = new System.Drawing.Size(79, 20);
            lbl_Numero_Cmd.TabIndex = 2;
            lbl_Numero_Cmd.Text = "Stock ID :";
            // 
            // lbNumero_TEL
            // 
            lbNumero_TEL.AutoSize = true;
            lbNumero_TEL.Location = new System.Drawing.Point(281, 213);
            lbNumero_TEL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbNumero_TEL.Name = "lbNumero_TEL";
            lbNumero_TEL.Size = new System.Drawing.Size(59, 20);
            lbNumero_TEL.TabIndex = 12;
            lbNumero_TEL.Text = "Notes :";
            lbNumero_TEL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_UtilisateurID
            // 
            lbl_UtilisateurID.AutoSize = true;
            lbl_UtilisateurID.Location = new System.Drawing.Point(281, 256);
            lbl_UtilisateurID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_UtilisateurID.Name = "lbl_UtilisateurID";
            lbl_UtilisateurID.Size = new System.Drawing.Size(109, 20);
            lbl_UtilisateurID.TabIndex = 4;
            lbl_UtilisateurID.Text = "Utilisateur ID :";
            // 
            // lbl_Adresse
            // 
            lbl_Adresse.AutoSize = true;
            lbl_Adresse.Location = new System.Drawing.Point(281, 167);
            lbl_Adresse.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_Adresse.Name = "lbl_Adresse";
            lbl_Adresse.Size = new System.Drawing.Size(116, 20);
            lbl_Adresse.TabIndex = 10;
            lbl_Adresse.Text = "Date de stock :";
            // 
            // lbl_nom
            // 
            lbl_nom.AutoSize = true;
            lbl_nom.Location = new System.Drawing.Point(281, 85);
            lbl_nom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_nom.Name = "lbl_nom";
            lbl_nom.Size = new System.Drawing.Size(150, 20);
            lbl_nom.TabIndex = 6;
            lbl_nom.Text = "Quantite Deplacee :";
            // 
            // lbl_prenom
            // 
            lbl_prenom.AutoSize = true;
            lbl_prenom.Location = new System.Drawing.Point(281, 128);
            lbl_prenom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_prenom.Name = "lbl_prenom";
            lbl_prenom.Size = new System.Drawing.Size(118, 20);
            lbl_prenom.TabIndex = 8;
            lbl_prenom.Text = "Type de Stock :";
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
            this.guna2TabControl1.Size = new System.Drawing.Size(1375, 726);
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
            this.guna2TabControl1.TabIndex = 23;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
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
            this.bt_toexcel.Click += new System.EventHandler(this.bt_toexcel_Click);
            // 
            // PbStock
            // 
            this.PbStock.Dock = System.Windows.Forms.DockStyle.Right;
            this.PbStock.Image = global::proj_pharmacell.Properties.Resources.entrepot;
            this.PbStock.Location = new System.Drawing.Point(1019, 0);
            this.PbStock.Name = "PbStock";
            this.PbStock.Size = new System.Drawing.Size(242, 373);
            this.PbStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbStock.TabIndex = 20;
            this.PbStock.TabStop = false;
            // 
            // dtpDateStock
            // 
            this.dtpDateStock.Location = new System.Drawing.Point(480, 167);
            this.dtpDateStock.Name = "dtpDateStock";
            this.dtpDateStock.Size = new System.Drawing.Size(310, 26);
            this.dtpDateStock.TabIndex = 21;
            // 
            // UC_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2TabControl1);
            this.Name = "UC_Stock";
            this.Size = new System.Drawing.Size(1375, 726);
            this.Load += new System.EventHandler(this.UC_Stock_Load);
            this.panel2.ResumeLayout(false);
            this.List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2TabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_supprimerStock;
        private Guna.UI2.WinForms.Guna2Button btn_ModifierStock;
        private Guna.UI2.WinForms.Guna2Button btn_ajouterStock;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ImageButton to_pdf;
        private Guna.UI2.WinForms.Guna2ImageButton bt_toexcel;
        private Guna.UI2.WinForms.Guna2Button btn_ViderStock;
        private System.Windows.Forms.TabPage List;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbStock;
        private System.Windows.Forms.ComboBox comboUtilisateurID;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtTypeStock;
        private System.Windows.Forms.TextBox txtQunatiteStock;
        private System.Windows.Forms.TextBox txtStockID;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.DateTimePicker dtpDateStock;
    }
}
