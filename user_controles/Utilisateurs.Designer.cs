namespace proj_pharmacell.user_controles
{
    partial class Utilisateurs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Utilisateurs));
            this.List = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comb_role = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mot_passe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_utilisateur = new System.Windows.Forms.TextBox();
            this.dgv_user = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Vider = new Guna.UI2.WinForms.Guna2Button();
            this.bt_supprimer = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Ajouter = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Modifier = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.List.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.panel1.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // List
            // 
            this.List.Controls.Add(this.panel2);
            this.List.Controls.Add(this.dgv_user);
            this.List.Controls.Add(this.panel1);
            this.List.Location = new System.Drawing.Point(104, 4);
            this.List.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.List.Name = "List";
            this.List.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.List.Size = new System.Drawing.Size(1665, 958);
            this.List.TabIndex = 0;
            this.List.Text = "List";
            this.List.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::proj_pharmacell.Properties.Resources.towfiqu_barbhuiya_w8p9cQDLX7I_unsplash;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comb_role);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_mot_passe);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_nom);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_utilisateur);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1657, 629);
            this.panel2.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(102, 390);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 66;
            this.label8.Text = "Rôle";
            // 
            // comb_role
            // 
            this.comb_role.FormattingEnabled = true;
            this.comb_role.Items.AddRange(new object[] {
            "Administrateur",
            "Vendeur",
            "Gestionnaire"});
            this.comb_role.Location = new System.Drawing.Point(357, 390);
            this.comb_role.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comb_role.Name = "comb_role";
            this.comb_role.Size = new System.Drawing.Size(294, 28);
            this.comb_role.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "UtilisateurID\r\n";
            // 
            // txt_mot_passe
            // 
            this.txt_mot_passe.Location = new System.Drawing.Point(357, 351);
            this.txt_mot_passe.Margin = new System.Windows.Forms.Padding(2);
            this.txt_mot_passe.Name = "txt_mot_passe";
            this.txt_mot_passe.Size = new System.Drawing.Size(294, 26);
            this.txt_mot_passe.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 314);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Nom d\'Utilisateur";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(357, 317);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(294, 26);
            this.txt_nom.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 348);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "Mot de passe\r\n";
            // 
            // txt_utilisateur
            // 
            this.txt_utilisateur.Location = new System.Drawing.Point(357, 283);
            this.txt_utilisateur.Margin = new System.Windows.Forms.Padding(2);
            this.txt_utilisateur.Name = "txt_utilisateur";
            this.txt_utilisateur.Size = new System.Drawing.Size(294, 26);
            this.txt_utilisateur.TabIndex = 67;
            // 
            // dgv_user
            // 
            this.dgv_user.AllowUserToAddRows = false;
            this.dgv_user.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_user.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_user.ColumnHeadersHeight = 34;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_user.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_user.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_user.Location = new System.Drawing.Point(4, 636);
            this.dgv_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.ReadOnly = true;
            this.dgv_user.RowHeadersVisible = false;
            this.dgv_user.RowHeadersWidth = 62;
            this.dgv_user.Size = new System.Drawing.Size(1657, 163);
            this.dgv_user.TabIndex = 0;
            this.dgv_user.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_user.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_user.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_user.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_user.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_user.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_user.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_user.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_user.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_user.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_user.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_user.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_user.ThemeStyle.HeaderStyle.Height = 34;
            this.dgv_user.ThemeStyle.ReadOnly = true;
            this.dgv_user.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_user.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_user.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_user.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_user.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_user.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_user.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_Vider);
            this.panel1.Controls.Add(this.bt_supprimer);
            this.panel1.Controls.Add(this.bt_Ajouter);
            this.panel1.Controls.Add(this.bt_Modifier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 799);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1657, 154);
            this.panel1.TabIndex = 2;
            // 
            // bt_Vider
            // 
            this.bt_Vider.AutoRoundedCorners = true;
            this.bt_Vider.BackColor = System.Drawing.Color.Transparent;
            this.bt_Vider.BorderColor = System.Drawing.Color.White;
            this.bt_Vider.BorderRadius = 21;
            this.bt_Vider.BorderThickness = 2;
            this.bt_Vider.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Vider.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Vider.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Vider.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Vider.FillColor = System.Drawing.Color.LightSlateGray;
            this.bt_Vider.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_Vider.ForeColor = System.Drawing.Color.White;
            this.bt_Vider.HoverState.BorderColor = System.Drawing.Color.Black;
            this.bt_Vider.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.bt_Vider.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.bt_Vider.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Vider.HoverState.ForeColor = System.Drawing.Color.Black;
            this.bt_Vider.Location = new System.Drawing.Point(876, 60);
            this.bt_Vider.Name = "bt_Vider";
            this.bt_Vider.ShadowDecoration.BorderRadius = 26;
            this.bt_Vider.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.bt_Vider.ShadowDecoration.Enabled = true;
            this.bt_Vider.Size = new System.Drawing.Size(180, 45);
            this.bt_Vider.TabIndex = 72;
            this.bt_Vider.Text = "Vider";
            this.bt_Vider.Click += new System.EventHandler(this.bt_Vider_Click);
            // 
            // bt_supprimer
            // 
            this.bt_supprimer.AutoRoundedCorners = true;
            this.bt_supprimer.BackColor = System.Drawing.Color.Transparent;
            this.bt_supprimer.BorderColor = System.Drawing.Color.White;
            this.bt_supprimer.BorderRadius = 21;
            this.bt_supprimer.BorderThickness = 2;
            this.bt_supprimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_supprimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_supprimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_supprimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_supprimer.FillColor = System.Drawing.Color.LightSlateGray;
            this.bt_supprimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_supprimer.ForeColor = System.Drawing.Color.White;
            this.bt_supprimer.HoverState.BorderColor = System.Drawing.Color.Black;
            this.bt_supprimer.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.bt_supprimer.HoverState.FillColor = System.Drawing.Color.Red;
            this.bt_supprimer.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_supprimer.HoverState.ForeColor = System.Drawing.Color.Black;
            this.bt_supprimer.Location = new System.Drawing.Point(460, 60);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.ShadowDecoration.BorderRadius = 26;
            this.bt_supprimer.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.bt_supprimer.ShadowDecoration.Enabled = true;
            this.bt_supprimer.Size = new System.Drawing.Size(180, 45);
            this.bt_supprimer.TabIndex = 74;
            this.bt_supprimer.Text = "Supprimer";
            this.bt_supprimer.Click += new System.EventHandler(this.bt_Supprimer_Click);
            // 
            // bt_Ajouter
            // 
            this.bt_Ajouter.AutoRoundedCorners = true;
            this.bt_Ajouter.BackColor = System.Drawing.Color.Transparent;
            this.bt_Ajouter.BorderColor = System.Drawing.Color.White;
            this.bt_Ajouter.BorderRadius = 21;
            this.bt_Ajouter.BorderThickness = 2;
            this.bt_Ajouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Ajouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Ajouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Ajouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Ajouter.FillColor = System.Drawing.Color.LightSlateGray;
            this.bt_Ajouter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_Ajouter.ForeColor = System.Drawing.Color.White;
            this.bt_Ajouter.HoverState.BorderColor = System.Drawing.Color.Black;
            this.bt_Ajouter.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.bt_Ajouter.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_Ajouter.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Ajouter.HoverState.ForeColor = System.Drawing.Color.Black;
            this.bt_Ajouter.Location = new System.Drawing.Point(255, 60);
            this.bt_Ajouter.Name = "bt_Ajouter";
            this.bt_Ajouter.ShadowDecoration.BorderRadius = 26;
            this.bt_Ajouter.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.bt_Ajouter.ShadowDecoration.Enabled = true;
            this.bt_Ajouter.Size = new System.Drawing.Size(180, 45);
            this.bt_Ajouter.TabIndex = 71;
            this.bt_Ajouter.Text = "Ajouter";
            this.bt_Ajouter.Click += new System.EventHandler(this.bt_Ajouter_Click);
            // 
            // bt_Modifier
            // 
            this.bt_Modifier.AutoRoundedCorners = true;
            this.bt_Modifier.BackColor = System.Drawing.Color.Transparent;
            this.bt_Modifier.BorderColor = System.Drawing.Color.White;
            this.bt_Modifier.BorderRadius = 21;
            this.bt_Modifier.BorderThickness = 2;
            this.bt_Modifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Modifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Modifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Modifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Modifier.FillColor = System.Drawing.Color.LightSlateGray;
            this.bt_Modifier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_Modifier.ForeColor = System.Drawing.Color.White;
            this.bt_Modifier.HoverState.BorderColor = System.Drawing.Color.Black;
            this.bt_Modifier.HoverState.CustomBorderColor = System.Drawing.Color.SlateGray;
            this.bt_Modifier.HoverState.FillColor = System.Drawing.Color.Yellow;
            this.bt_Modifier.HoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Modifier.HoverState.ForeColor = System.Drawing.Color.Black;
            this.bt_Modifier.Location = new System.Drawing.Point(658, 60);
            this.bt_Modifier.Name = "bt_Modifier";
            this.bt_Modifier.ShadowDecoration.BorderRadius = 26;
            this.bt_Modifier.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.bt_Modifier.ShadowDecoration.Enabled = true;
            this.bt_Modifier.Size = new System.Drawing.Size(180, 45);
            this.bt_Modifier.TabIndex = 73;
            this.bt_Modifier.Text = "Modifier";
            this.bt_Modifier.Click += new System.EventHandler(this.bt_Modifier_Click);
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.List);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(100, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1773, 966);
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
            this.guna2TabControl1.TabIndex = 5;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // Utilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.guna2TabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Utilisateurs";
            this.Size = new System.Drawing.Size(1773, 966);
            this.Load += new System.EventHandler(this.Utilisateurs_Load);
            this.List.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.panel1.ResumeLayout(false);
            this.guna2TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage List;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_user;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TextBox txt_mot_passe;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_utilisateur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comb_role;
        private Guna.UI2.WinForms.Guna2Button bt_supprimer;
        private Guna.UI2.WinForms.Guna2Button bt_Modifier;
        private Guna.UI2.WinForms.Guna2Button bt_Vider;
        private Guna.UI2.WinForms.Guna2Button bt_Ajouter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
