namespace proj_pharmacell.user_controles
{
    partial class UC_Ordonnance
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
            System.Windows.Forms.Label Statut_Ordonnances;
            System.Windows.Forms.Label lbl_Adresse;
            System.Windows.Forms.Label lbl_nom;
            System.Windows.Forms.Label DatePersp;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Ordonnance));
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.List = new System.Windows.Forms.TabPage();
            this.dgv_orodonnance = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_supprimer_ordo = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Modifier_ordo = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Vider_ordo = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ajouter_ordo = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboUtilisateurID = new System.Windows.Forms.ComboBox();
            this.ComboMedicamentID = new System.Windows.Forms.ComboBox();
            this.comboClientID = new System.Windows.Forms.ComboBox();
            this.txtStatueOrdo = new System.Windows.Forms.TextBox();
            this.txt_QuantiteOrd = new System.Windows.Forms.TextBox();
            this.txtMedcinPers = new System.Windows.Forms.TextBox();
            this.txtOrdonnanceID = new System.Windows.Forms.TextBox();
            this.dtpDatePersp = new System.Windows.Forms.DateTimePicker();
            this.to_pdf = new Guna.UI2.WinForms.Guna2ImageButton();
            this.bt_toexcel = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            lbl_Numero_Cmd = new System.Windows.Forms.Label();
            lbNumero_TEL = new System.Windows.Forms.Label();
            Statut_Ordonnances = new System.Windows.Forms.Label();
            lbl_Adresse = new System.Windows.Forms.Label();
            lbl_nom = new System.Windows.Forms.Label();
            DatePersp = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.guna2TabControl1.SuspendLayout();
            this.List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orodonnance)).BeginInit();
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
            lbl_Numero_Cmd.Size = new System.Drawing.Size(113, 20);
            lbl_Numero_Cmd.TabIndex = 2;
            lbl_Numero_Cmd.Text = "Ordenance ID:";
            // 
            // lbNumero_TEL
            // 
            lbNumero_TEL.AutoSize = true;
            lbNumero_TEL.Location = new System.Drawing.Point(281, 213);
            lbNumero_TEL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbNumero_TEL.Name = "lbNumero_TEL";
            lbNumero_TEL.Size = new System.Drawing.Size(157, 20);
            lbNumero_TEL.TabIndex = 12;
            lbNumero_TEL.Text = "Statut Ordonnances:";
            lbNumero_TEL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Statut_Ordonnances
            // 
            Statut_Ordonnances.AutoSize = true;
            Statut_Ordonnances.Location = new System.Drawing.Point(285, 256);
            Statut_Ordonnances.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            Statut_Ordonnances.Name = "Statut_Ordonnances";
            Statut_Ordonnances.Size = new System.Drawing.Size(78, 20);
            Statut_Ordonnances.TabIndex = 4;
            Statut_Ordonnances.Text = "Client ID :";
            // 
            // lbl_Adresse
            // 
            lbl_Adresse.AutoSize = true;
            lbl_Adresse.Location = new System.Drawing.Point(281, 167);
            lbl_Adresse.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_Adresse.Name = "lbl_Adresse";
            lbl_Adresse.Size = new System.Drawing.Size(174, 20);
            lbl_Adresse.TabIndex = 10;
            lbl_Adresse.Text = "Quantite Ordonnances:";
            // 
            // lbl_nom
            // 
            lbl_nom.AutoSize = true;
            lbl_nom.Location = new System.Drawing.Point(281, 85);
            lbl_nom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_nom.Name = "lbl_nom";
            lbl_nom.Size = new System.Drawing.Size(161, 20);
            lbl_nom.TabIndex = 6;
            lbl_nom.Text = "Medecin prescripteur:";
            // 
            // DatePersp
            // 
            DatePersp.AutoSize = true;
            DatePersp.Location = new System.Drawing.Point(281, 128);
            DatePersp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            DatePersp.Name = "DatePersp";
            DatePersp.Size = new System.Drawing.Size(134, 20);
            DatePersp.TabIndex = 8;
            DatePersp.Text = "Date prescription:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(281, 302);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 20);
            label1.TabIndex = 4;
            label1.Text = "Medicament ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(285, 346);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 20);
            label2.TabIndex = 4;
            label2.Text = "Utilisateur ID :";
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
            this.guna2TabControl1.Size = new System.Drawing.Size(1361, 706);
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
            // List
            // 
            this.List.Controls.Add(this.dgv_orodonnance);
            this.List.Controls.Add(this.panel2);
            this.List.Controls.Add(this.panel1);
            this.List.Location = new System.Drawing.Point(104, 4);
            this.List.Name = "List";
            this.List.Padding = new System.Windows.Forms.Padding(3);
            this.List.Size = new System.Drawing.Size(1253, 698);
            this.List.TabIndex = 0;
            this.List.Text = "List";
            this.List.UseVisualStyleBackColor = true;
            // 
            // dgv_orodonnance
            // 
            this.dgv_orodonnance.AllowUserToAddRows = false;
            this.dgv_orodonnance.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_orodonnance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_orodonnance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_orodonnance.ColumnHeadersHeight = 25;
            this.dgv_orodonnance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_orodonnance.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_orodonnance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_orodonnance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_orodonnance.Location = new System.Drawing.Point(3, 431);
            this.dgv_orodonnance.Name = "dgv_orodonnance";
            this.dgv_orodonnance.ReadOnly = true;
            this.dgv_orodonnance.RowHeadersVisible = false;
            this.dgv_orodonnance.RowHeadersWidth = 62;
            this.dgv_orodonnance.RowTemplate.Height = 28;
            this.dgv_orodonnance.Size = new System.Drawing.Size(1247, 150);
            this.dgv_orodonnance.TabIndex = 20;
            this.dgv_orodonnance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_orodonnance.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_orodonnance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_orodonnance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_orodonnance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_orodonnance.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_orodonnance.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_orodonnance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_orodonnance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_orodonnance.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_orodonnance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_orodonnance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_orodonnance.ThemeStyle.HeaderStyle.Height = 25;
            this.dgv_orodonnance.ThemeStyle.ReadOnly = true;
            this.dgv_orodonnance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_orodonnance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_orodonnance.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_orodonnance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_orodonnance.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_orodonnance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_orodonnance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_orodonnance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_orodonnance_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.to_pdf);
            this.panel2.Controls.Add(this.bt_toexcel);
            this.panel2.Controls.Add(this.btn_supprimer_ordo);
            this.panel2.Controls.Add(this.btn_Modifier_ordo);
            this.panel2.Controls.Add(this.btn_Vider_ordo);
            this.panel2.Controls.Add(this.btn_ajouter_ordo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 581);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1247, 114);
            this.panel2.TabIndex = 19;
            // 
            // btn_supprimer_ordo
            // 
            this.btn_supprimer_ordo.AutoRoundedCorners = true;
            this.btn_supprimer_ordo.BackColor = System.Drawing.Color.Transparent;
            this.btn_supprimer_ordo.BorderColor = System.Drawing.Color.White;
            this.btn_supprimer_ordo.BorderRadius = 21;
            this.btn_supprimer_ordo.BorderThickness = 2;
            this.btn_supprimer_ordo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_supprimer_ordo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_supprimer_ordo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_supprimer_ordo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_supprimer_ordo.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_supprimer_ordo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_supprimer_ordo.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer_ordo.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_supprimer_ordo.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_supprimer_ordo.HoverState.FillColor = System.Drawing.Color.Red;
            this.btn_supprimer_ordo.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer_ordo.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_supprimer_ordo.Location = new System.Drawing.Point(298, 51);
            this.btn_supprimer_ordo.Name = "btn_supprimer_ordo";
            this.btn_supprimer_ordo.ShadowDecoration.BorderRadius = 26;
            this.btn_supprimer_ordo.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_supprimer_ordo.ShadowDecoration.Enabled = true;
            this.btn_supprimer_ordo.Size = new System.Drawing.Size(180, 45);
            this.btn_supprimer_ordo.TabIndex = 1;
            this.btn_supprimer_ordo.Text = "Supprimer";
            this.btn_supprimer_ordo.Click += new System.EventHandler(this.btn_supprimer_ordo_Click);
            // 
            // btn_Modifier_ordo
            // 
            this.btn_Modifier_ordo.AutoRoundedCorners = true;
            this.btn_Modifier_ordo.BackColor = System.Drawing.Color.Transparent;
            this.btn_Modifier_ordo.BorderColor = System.Drawing.Color.White;
            this.btn_Modifier_ordo.BorderRadius = 21;
            this.btn_Modifier_ordo.BorderThickness = 2;
            this.btn_Modifier_ordo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Modifier_ordo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Modifier_ordo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Modifier_ordo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Modifier_ordo.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_Modifier_ordo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Modifier_ordo.ForeColor = System.Drawing.Color.White;
            this.btn_Modifier_ordo.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_Modifier_ordo.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_Modifier_ordo.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.btn_Modifier_ordo.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modifier_ordo.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_Modifier_ordo.Location = new System.Drawing.Point(496, 51);
            this.btn_Modifier_ordo.Name = "btn_Modifier_ordo";
            this.btn_Modifier_ordo.ShadowDecoration.BorderRadius = 26;
            this.btn_Modifier_ordo.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_Modifier_ordo.ShadowDecoration.Enabled = true;
            this.btn_Modifier_ordo.Size = new System.Drawing.Size(180, 45);
            this.btn_Modifier_ordo.TabIndex = 2;
            this.btn_Modifier_ordo.Text = "Modifier";
            this.btn_Modifier_ordo.Click += new System.EventHandler(this.btn_Modifier_ordo_Click);
            // 
            // btn_Vider_ordo
            // 
            this.btn_Vider_ordo.AutoRoundedCorners = true;
            this.btn_Vider_ordo.BackColor = System.Drawing.Color.Transparent;
            this.btn_Vider_ordo.BorderColor = System.Drawing.Color.White;
            this.btn_Vider_ordo.BorderRadius = 21;
            this.btn_Vider_ordo.BorderThickness = 2;
            this.btn_Vider_ordo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Vider_ordo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Vider_ordo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Vider_ordo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Vider_ordo.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_Vider_ordo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Vider_ordo.ForeColor = System.Drawing.Color.White;
            this.btn_Vider_ordo.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_Vider_ordo.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_Vider_ordo.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.btn_Vider_ordo.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vider_ordo.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_Vider_ordo.Location = new System.Drawing.Point(713, 51);
            this.btn_Vider_ordo.Name = "btn_Vider_ordo";
            this.btn_Vider_ordo.ShadowDecoration.BorderRadius = 26;
            this.btn_Vider_ordo.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_Vider_ordo.ShadowDecoration.Enabled = true;
            this.btn_Vider_ordo.Size = new System.Drawing.Size(180, 45);
            this.btn_Vider_ordo.TabIndex = 3;
            this.btn_Vider_ordo.Text = "Vider";
            this.btn_Vider_ordo.Click += new System.EventHandler(this.btn_Vider_ordo_Click);
            // 
            // btn_ajouter_ordo
            // 
            this.btn_ajouter_ordo.AutoRoundedCorners = true;
            this.btn_ajouter_ordo.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajouter_ordo.BorderColor = System.Drawing.Color.White;
            this.btn_ajouter_ordo.BorderRadius = 21;
            this.btn_ajouter_ordo.BorderThickness = 2;
            this.btn_ajouter_ordo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajouter_ordo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajouter_ordo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ajouter_ordo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ajouter_ordo.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_ajouter_ordo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ajouter_ordo.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter_ordo.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_ajouter_ordo.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_ajouter_ordo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ajouter_ordo.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter_ordo.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_ajouter_ordo.Location = new System.Drawing.Point(92, 51);
            this.btn_ajouter_ordo.Name = "btn_ajouter_ordo";
            this.btn_ajouter_ordo.ShadowDecoration.BorderRadius = 26;
            this.btn_ajouter_ordo.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_ajouter_ordo.ShadowDecoration.Enabled = true;
            this.btn_ajouter_ordo.Size = new System.Drawing.Size(180, 45);
            this.btn_ajouter_ordo.TabIndex = 0;
            this.btn_ajouter_ordo.Text = "Ajouter";
            this.btn_ajouter_ordo.Click += new System.EventHandler(this.btn_ajouter_ordo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpDatePersp);
            this.panel1.Controls.Add(this.ComboUtilisateurID);
            this.panel1.Controls.Add(this.ComboMedicamentID);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.comboClientID);
            this.panel1.Controls.Add(this.txtStatueOrdo);
            this.panel1.Controls.Add(this.txt_QuantiteOrd);
            this.panel1.Controls.Add(this.txtMedcinPers);
            this.panel1.Controls.Add(this.txtOrdonnanceID);
            this.panel1.Controls.Add(lbl_Numero_Cmd);
            this.panel1.Controls.Add(lbNumero_TEL);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(Statut_Ordonnances);
            this.panel1.Controls.Add(lbl_Adresse);
            this.panel1.Controls.Add(lbl_nom);
            this.panel1.Controls.Add(DatePersp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 428);
            this.panel1.TabIndex = 18;
            // 
            // ComboUtilisateurID
            // 
            this.ComboUtilisateurID.FormattingEnabled = true;
            this.ComboUtilisateurID.Location = new System.Drawing.Point(480, 343);
            this.ComboUtilisateurID.Name = "ComboUtilisateurID";
            this.ComboUtilisateurID.Size = new System.Drawing.Size(310, 28);
            this.ComboUtilisateurID.TabIndex = 22;
            // 
            // ComboMedicamentID
            // 
            this.ComboMedicamentID.FormattingEnabled = true;
            this.ComboMedicamentID.Location = new System.Drawing.Point(480, 302);
            this.ComboMedicamentID.Name = "ComboMedicamentID";
            this.ComboMedicamentID.Size = new System.Drawing.Size(310, 28);
            this.ComboMedicamentID.TabIndex = 21;
            // 
            // comboClientID
            // 
            this.comboClientID.FormattingEnabled = true;
            this.comboClientID.Location = new System.Drawing.Point(480, 256);
            this.comboClientID.Name = "comboClientID";
            this.comboClientID.Size = new System.Drawing.Size(310, 28);
            this.comboClientID.TabIndex = 5;
            // 
            // txtStatueOrdo
            // 
            this.txtStatueOrdo.Location = new System.Drawing.Point(480, 209);
            this.txtStatueOrdo.Name = "txtStatueOrdo";
            this.txtStatueOrdo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatueOrdo.Size = new System.Drawing.Size(310, 26);
            this.txtStatueOrdo.TabIndex = 4;
            // 
            // txt_QuantiteOrd
            // 
            this.txt_QuantiteOrd.Location = new System.Drawing.Point(480, 167);
            this.txt_QuantiteOrd.Name = "txt_QuantiteOrd";
            this.txt_QuantiteOrd.Size = new System.Drawing.Size(310, 26);
            this.txt_QuantiteOrd.TabIndex = 3;
            // 
            // txtMedcinPers
            // 
            this.txtMedcinPers.Location = new System.Drawing.Point(480, 79);
            this.txtMedcinPers.Name = "txtMedcinPers";
            this.txtMedcinPers.Size = new System.Drawing.Size(310, 26);
            this.txtMedcinPers.TabIndex = 1;
            // 
            // txtOrdonnanceID
            // 
            this.txtOrdonnanceID.Location = new System.Drawing.Point(480, 37);
            this.txtOrdonnanceID.Name = "txtOrdonnanceID";
            this.txtOrdonnanceID.Size = new System.Drawing.Size(310, 26);
            this.txtOrdonnanceID.TabIndex = 0;
            // 
            // dtpDatePersp
            // 
            this.dtpDatePersp.Location = new System.Drawing.Point(480, 121);
            this.dtpDatePersp.Name = "dtpDatePersp";
            this.dtpDatePersp.Size = new System.Drawing.Size(310, 26);
            this.dtpDatePersp.TabIndex = 23;
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
            this.bt_toexcel.TabIndex = 4;
            this.bt_toexcel.Click += new System.EventHandler(this.bt_toexcel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::proj_pharmacell.Properties.Resources.ordonnance;
            this.pictureBox1.Location = new System.Drawing.Point(1005, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 428);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // UC_Ordonnance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2TabControl1);
            this.Name = "UC_Ordonnance";
            this.Size = new System.Drawing.Size(1361, 706);
            this.Load += new System.EventHandler(this.UC_Ordonnance_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orodonnance)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage List;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_orodonnance;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ImageButton to_pdf;
        private Guna.UI2.WinForms.Guna2ImageButton bt_toexcel;
        private Guna.UI2.WinForms.Guna2Button btn_supprimer_ordo;
        private Guna.UI2.WinForms.Guna2Button btn_Modifier_ordo;
        private Guna.UI2.WinForms.Guna2Button btn_Vider_ordo;
        private Guna.UI2.WinForms.Guna2Button btn_ajouter_ordo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboClientID;
        private System.Windows.Forms.TextBox txtStatueOrdo;
        private System.Windows.Forms.TextBox txt_QuantiteOrd;
        private System.Windows.Forms.TextBox txtMedcinPers;
        private System.Windows.Forms.TextBox txtOrdonnanceID;
        private System.Windows.Forms.ComboBox ComboUtilisateurID;
        private System.Windows.Forms.ComboBox ComboMedicamentID;
        private System.Windows.Forms.DateTimePicker dtpDatePersp;
    }
}
