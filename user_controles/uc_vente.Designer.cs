namespace proj_pharmacell.user_controles
{
    partial class uc_vente
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
            System.Windows.Forms.Label num_Vente_VentesLabel;
            System.Windows.Forms.Label date_Vente_VentesLabel;
            System.Windows.Forms.Label quantite_vendue_VentesLabel;
            System.Windows.Forms.Label prix_total_VentesLabel;
            System.Windows.Forms.Label mode_paiement_VentesLabel;
            System.Windows.Forms.Label clientID_ClientsLabel;
            System.Windows.Forms.Label utilisateurID_UtilisateursLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_vente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.combo_id_utilisateur = new System.Windows.Forms.ComboBox();
            this.combo_id_client = new System.Windows.Forms.ComboBox();
            this.combo_paiment = new System.Windows.Forms.ComboBox();
            this.txt_prix_total = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_num_vente = new System.Windows.Forms.TextBox();
            this.txt_quantite = new System.Windows.Forms.TextBox();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.List = new System.Windows.Forms.TabPage();
            this.dgv_vente = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_supprimer_vente = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Modifier_vente = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Vider_vente = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ajouter_vente = new Guna.UI2.WinForms.Guna2Button();
            this.to_pdf = new Guna.UI2.WinForms.Guna2ImageButton();
            this.bt_toexcel = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            num_Vente_VentesLabel = new System.Windows.Forms.Label();
            date_Vente_VentesLabel = new System.Windows.Forms.Label();
            quantite_vendue_VentesLabel = new System.Windows.Forms.Label();
            prix_total_VentesLabel = new System.Windows.Forms.Label();
            mode_paiement_VentesLabel = new System.Windows.Forms.Label();
            clientID_ClientsLabel = new System.Windows.Forms.Label();
            utilisateurID_UtilisateursLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vente)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // num_Vente_VentesLabel
            // 
            num_Vente_VentesLabel.AutoSize = true;
            num_Vente_VentesLabel.Location = new System.Drawing.Point(281, 37);
            num_Vente_VentesLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            num_Vente_VentesLabel.Name = "num_Vente_VentesLabel";
            num_Vente_VentesLabel.Size = new System.Drawing.Size(93, 20);
            num_Vente_VentesLabel.TabIndex = 2;
            num_Vente_VentesLabel.Text = "Num Vente:";
            // 
            // date_Vente_VentesLabel
            // 
            date_Vente_VentesLabel.AutoSize = true;
            date_Vente_VentesLabel.Location = new System.Drawing.Point(281, 71);
            date_Vente_VentesLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            date_Vente_VentesLabel.Name = "date_Vente_VentesLabel";
            date_Vente_VentesLabel.Size = new System.Drawing.Size(99, 20);
            date_Vente_VentesLabel.TabIndex = 3;
            date_Vente_VentesLabel.Text = "Date Vente :";
            // 
            // quantite_vendue_VentesLabel
            // 
            quantite_vendue_VentesLabel.AutoSize = true;
            quantite_vendue_VentesLabel.Location = new System.Drawing.Point(281, 104);
            quantite_vendue_VentesLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            quantite_vendue_VentesLabel.Name = "quantite_vendue_VentesLabel";
            quantite_vendue_VentesLabel.Size = new System.Drawing.Size(134, 20);
            quantite_vendue_VentesLabel.TabIndex = 4;
            quantite_vendue_VentesLabel.Text = "Quantite vendue :";
            // 
            // prix_total_VentesLabel
            // 
            prix_total_VentesLabel.AutoSize = true;
            prix_total_VentesLabel.Location = new System.Drawing.Point(285, 143);
            prix_total_VentesLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            prix_total_VentesLabel.Name = "prix_total_VentesLabel";
            prix_total_VentesLabel.Size = new System.Drawing.Size(77, 20);
            prix_total_VentesLabel.TabIndex = 6;
            prix_total_VentesLabel.Text = "Prix total :";
            // 
            // mode_paiement_VentesLabel
            // 
            mode_paiement_VentesLabel.AutoSize = true;
            mode_paiement_VentesLabel.Location = new System.Drawing.Point(285, 189);
            mode_paiement_VentesLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mode_paiement_VentesLabel.Name = "mode_paiement_VentesLabel";
            mode_paiement_VentesLabel.Size = new System.Drawing.Size(127, 20);
            mode_paiement_VentesLabel.TabIndex = 8;
            mode_paiement_VentesLabel.Text = "Mode paiement :";
            // 
            // clientID_ClientsLabel
            // 
            clientID_ClientsLabel.AutoSize = true;
            clientID_ClientsLabel.Location = new System.Drawing.Point(285, 229);
            clientID_ClientsLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            clientID_ClientsLabel.Name = "clientID_ClientsLabel";
            clientID_ClientsLabel.Size = new System.Drawing.Size(78, 20);
            clientID_ClientsLabel.TabIndex = 10;
            clientID_ClientsLabel.Text = "Client ID :";
            // 
            // utilisateurID_UtilisateursLabel
            // 
            utilisateurID_UtilisateursLabel.AutoSize = true;
            utilisateurID_UtilisateursLabel.Location = new System.Drawing.Point(285, 277);
            utilisateurID_UtilisateursLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            utilisateurID_UtilisateursLabel.Name = "utilisateurID_UtilisateursLabel";
            utilisateurID_UtilisateursLabel.Size = new System.Drawing.Size(109, 20);
            utilisateurID_UtilisateursLabel.TabIndex = 12;
            utilisateurID_UtilisateursLabel.Text = "Utilisateur ID :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dt_date);
            this.panel1.Controls.Add(this.combo_id_utilisateur);
            this.panel1.Controls.Add(this.combo_id_client);
            this.panel1.Controls.Add(this.combo_paiment);
            this.panel1.Controls.Add(this.txt_prix_total);
            this.panel1.Controls.Add(this.txt_date);
            this.panel1.Controls.Add(this.txt_num_vente);
            this.panel1.Controls.Add(num_Vente_VentesLabel);
            this.panel1.Controls.Add(date_Vente_VentesLabel);
            this.panel1.Controls.Add(utilisateurID_UtilisateursLabel);
            this.panel1.Controls.Add(quantite_vendue_VentesLabel);
            this.panel1.Controls.Add(clientID_ClientsLabel);
            this.panel1.Controls.Add(prix_total_VentesLabel);
            this.panel1.Controls.Add(mode_paiement_VentesLabel);
            this.panel1.Controls.Add(this.txt_quantite);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 373);
            this.panel1.TabIndex = 18;
            // 
            // dt_date
            // 
            this.dt_date.Location = new System.Drawing.Point(764, 77);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(25, 26);
            this.dt_date.TabIndex = 17;
            this.dt_date.ValueChanged += new System.EventHandler(this.dt_date_ValueChanged);
            // 
            // combo_id_utilisateur
            // 
            this.combo_id_utilisateur.FormattingEnabled = true;
            this.combo_id_utilisateur.Location = new System.Drawing.Point(481, 269);
            this.combo_id_utilisateur.Name = "combo_id_utilisateur";
            this.combo_id_utilisateur.Size = new System.Drawing.Size(309, 28);
            this.combo_id_utilisateur.TabIndex = 19;
            // 
            // combo_id_client
            // 
            this.combo_id_client.FormattingEnabled = true;
            this.combo_id_client.Location = new System.Drawing.Point(481, 226);
            this.combo_id_client.Name = "combo_id_client";
            this.combo_id_client.Size = new System.Drawing.Size(309, 28);
            this.combo_id_client.TabIndex = 19;
            // 
            // combo_paiment
            // 
            this.combo_paiment.FormattingEnabled = true;
            this.combo_paiment.Items.AddRange(new object[] {
            "espèces",
            "carte bancaire",
            "chèques"});
            this.combo_paiment.Location = new System.Drawing.Point(481, 181);
            this.combo_paiment.Name = "combo_paiment";
            this.combo_paiment.Size = new System.Drawing.Size(309, 28);
            this.combo_paiment.TabIndex = 19;
            // 
            // txt_prix_total
            // 
            this.txt_prix_total.Location = new System.Drawing.Point(480, 143);
            this.txt_prix_total.Name = "txt_prix_total";
            this.txt_prix_total.Size = new System.Drawing.Size(310, 26);
            this.txt_prix_total.TabIndex = 18;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(480, 77);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(310, 26);
            this.txt_date.TabIndex = 18;
            // 
            // txt_num_vente
            // 
            this.txt_num_vente.Location = new System.Drawing.Point(480, 37);
            this.txt_num_vente.Name = "txt_num_vente";
            this.txt_num_vente.Size = new System.Drawing.Size(310, 26);
            this.txt_num_vente.TabIndex = 18;
            // 
            // txt_quantite
            // 
            this.txt_quantite.Location = new System.Drawing.Point(480, 110);
            this.txt_quantite.Name = "txt_quantite";
            this.txt_quantite.Size = new System.Drawing.Size(310, 26);
            this.txt_quantite.TabIndex = 18;
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
            this.guna2TabControl1.Size = new System.Drawing.Size(1470, 965);
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
            this.guna2TabControl1.TabIndex = 19;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // List
            // 
            this.List.Controls.Add(this.dgv_vente);
            this.List.Controls.Add(this.panel2);
            this.List.Controls.Add(this.panel1);
            this.List.Location = new System.Drawing.Point(104, 4);
            this.List.Name = "List";
            this.List.Padding = new System.Windows.Forms.Padding(3);
            this.List.Size = new System.Drawing.Size(1362, 957);
            this.List.TabIndex = 0;
            this.List.Text = "List";
            this.List.UseVisualStyleBackColor = true;
            // 
            // dgv_vente
            // 
            this.dgv_vente.AllowUserToAddRows = false;
            this.dgv_vente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_vente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_vente.ColumnHeadersHeight = 25;
            this.dgv_vente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_vente.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_vente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_vente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_vente.Location = new System.Drawing.Point(3, 376);
            this.dgv_vente.Name = "dgv_vente";
            this.dgv_vente.ReadOnly = true;
            this.dgv_vente.RowHeadersVisible = false;
            this.dgv_vente.RowHeadersWidth = 62;
            this.dgv_vente.RowTemplate.Height = 28;
            this.dgv_vente.Size = new System.Drawing.Size(1356, 425);
            this.dgv_vente.TabIndex = 20;
            this.dgv_vente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_vente.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_vente.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_vente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_vente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_vente.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_vente.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_vente.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_vente.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_vente.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_vente.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_vente.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_vente.ThemeStyle.HeaderStyle.Height = 25;
            this.dgv_vente.ThemeStyle.ReadOnly = true;
            this.dgv_vente.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_vente.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_vente.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_vente.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_vente.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_vente.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_vente.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_vente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vente_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.to_pdf);
            this.panel2.Controls.Add(this.bt_toexcel);
            this.panel2.Controls.Add(this.btn_supprimer_vente);
            this.panel2.Controls.Add(this.btn_Modifier_vente);
            this.panel2.Controls.Add(this.btn_Vider_vente);
            this.panel2.Controls.Add(this.btn_ajouter_vente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 801);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 153);
            this.panel2.TabIndex = 19;
            // 
            // btn_supprimer_vente
            // 
            this.btn_supprimer_vente.AutoRoundedCorners = true;
            this.btn_supprimer_vente.BackColor = System.Drawing.Color.Transparent;
            this.btn_supprimer_vente.BorderColor = System.Drawing.Color.White;
            this.btn_supprimer_vente.BorderRadius = 21;
            this.btn_supprimer_vente.BorderThickness = 2;
            this.btn_supprimer_vente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_supprimer_vente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_supprimer_vente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_supprimer_vente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_supprimer_vente.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_supprimer_vente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_supprimer_vente.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer_vente.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_supprimer_vente.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_supprimer_vente.HoverState.FillColor = System.Drawing.Color.Red;
            this.btn_supprimer_vente.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer_vente.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_supprimer_vente.Location = new System.Drawing.Point(298, 51);
            this.btn_supprimer_vente.Name = "btn_supprimer_vente";
            this.btn_supprimer_vente.ShadowDecoration.BorderRadius = 26;
            this.btn_supprimer_vente.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_supprimer_vente.ShadowDecoration.Enabled = true;
            this.btn_supprimer_vente.Size = new System.Drawing.Size(180, 45);
            this.btn_supprimer_vente.TabIndex = 47;
            this.btn_supprimer_vente.Text = "Supprimer";
            this.btn_supprimer_vente.Click += new System.EventHandler(this.btn_supprimer_vente_Click);
            // 
            // btn_Modifier_vente
            // 
            this.btn_Modifier_vente.AutoRoundedCorners = true;
            this.btn_Modifier_vente.BackColor = System.Drawing.Color.Transparent;
            this.btn_Modifier_vente.BorderColor = System.Drawing.Color.White;
            this.btn_Modifier_vente.BorderRadius = 21;
            this.btn_Modifier_vente.BorderThickness = 2;
            this.btn_Modifier_vente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Modifier_vente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Modifier_vente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Modifier_vente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Modifier_vente.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_Modifier_vente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Modifier_vente.ForeColor = System.Drawing.Color.White;
            this.btn_Modifier_vente.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_Modifier_vente.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_Modifier_vente.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.btn_Modifier_vente.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modifier_vente.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_Modifier_vente.Location = new System.Drawing.Point(496, 51);
            this.btn_Modifier_vente.Name = "btn_Modifier_vente";
            this.btn_Modifier_vente.ShadowDecoration.BorderRadius = 26;
            this.btn_Modifier_vente.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_Modifier_vente.ShadowDecoration.Enabled = true;
            this.btn_Modifier_vente.Size = new System.Drawing.Size(180, 45);
            this.btn_Modifier_vente.TabIndex = 46;
            this.btn_Modifier_vente.Text = "Modifier";
            this.btn_Modifier_vente.Click += new System.EventHandler(this.btn_Modifier_vente_Click);
            // 
            // btn_Vider_vente
            // 
            this.btn_Vider_vente.AutoRoundedCorners = true;
            this.btn_Vider_vente.BackColor = System.Drawing.Color.Transparent;
            this.btn_Vider_vente.BorderColor = System.Drawing.Color.White;
            this.btn_Vider_vente.BorderRadius = 21;
            this.btn_Vider_vente.BorderThickness = 2;
            this.btn_Vider_vente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Vider_vente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Vider_vente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Vider_vente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Vider_vente.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_Vider_vente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Vider_vente.ForeColor = System.Drawing.Color.White;
            this.btn_Vider_vente.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_Vider_vente.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_Vider_vente.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.btn_Vider_vente.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Vider_vente.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_Vider_vente.Location = new System.Drawing.Point(713, 51);
            this.btn_Vider_vente.Name = "btn_Vider_vente";
            this.btn_Vider_vente.ShadowDecoration.BorderRadius = 26;
            this.btn_Vider_vente.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_Vider_vente.ShadowDecoration.Enabled = true;
            this.btn_Vider_vente.Size = new System.Drawing.Size(180, 45);
            this.btn_Vider_vente.TabIndex = 45;
            this.btn_Vider_vente.Text = "Vider";
            this.btn_Vider_vente.Click += new System.EventHandler(this.btn_Vider_vente_Click);
            // 
            // btn_ajouter_vente
            // 
            this.btn_ajouter_vente.AutoRoundedCorners = true;
            this.btn_ajouter_vente.BackColor = System.Drawing.Color.Transparent;
            this.btn_ajouter_vente.BorderColor = System.Drawing.Color.White;
            this.btn_ajouter_vente.BorderRadius = 21;
            this.btn_ajouter_vente.BorderThickness = 2;
            this.btn_ajouter_vente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajouter_vente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ajouter_vente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ajouter_vente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ajouter_vente.FillColor = System.Drawing.Color.LightSlateGray;
            this.btn_ajouter_vente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ajouter_vente.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter_vente.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_ajouter_vente.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.btn_ajouter_vente.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_ajouter_vente.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter_vente.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_ajouter_vente.Location = new System.Drawing.Point(92, 51);
            this.btn_ajouter_vente.Name = "btn_ajouter_vente";
            this.btn_ajouter_vente.ShadowDecoration.BorderRadius = 26;
            this.btn_ajouter_vente.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.btn_ajouter_vente.ShadowDecoration.Enabled = true;
            this.btn_ajouter_vente.Size = new System.Drawing.Size(180, 45);
            this.btn_ajouter_vente.TabIndex = 44;
            this.btn_ajouter_vente.Text = "Ajouter";
            this.btn_ajouter_vente.Click += new System.EventHandler(this.btn_ajouter_vente_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::proj_pharmacell.Properties.Resources.commerce;
            this.pictureBox1.Location = new System.Drawing.Point(1114, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // uc_vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2TabControl1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "uc_vente";
            this.Size = new System.Drawing.Size(1470, 965);
            this.Load += new System.EventHandler(this.uc_vente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2TabControl1.ResumeLayout(false);
            this.List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vente)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage List;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_vente;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_supprimer_vente;
        private Guna.UI2.WinForms.Guna2Button btn_Modifier_vente;
        private Guna.UI2.WinForms.Guna2Button btn_Vider_vente;
        private Guna.UI2.WinForms.Guna2Button btn_ajouter_vente;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.ComboBox combo_id_utilisateur;
        private System.Windows.Forms.ComboBox combo_id_client;
        private System.Windows.Forms.ComboBox combo_paiment;
        private System.Windows.Forms.TextBox txt_prix_total;
        private System.Windows.Forms.TextBox txt_quantite;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_num_vente;
        private Guna.UI2.WinForms.Guna2ImageButton to_pdf;
        private Guna.UI2.WinForms.Guna2ImageButton bt_toexcel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
