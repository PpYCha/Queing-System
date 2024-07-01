namespace AmoecQueingSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            materialDrawer1 = new ReaLTaiizor.Controls.MaterialDrawer();
            materialTabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            tab_User = new TabPage();
            label_Served = new Label();
            dateTimePicker1 = new DateTimePicker();
            bt_Reset = new ReaLTaiizor.Controls.MaterialButton();
            dataGridView_User = new ReaLTaiizor.Controls.PoisonDataGridView();
            dgvId = new DataGridViewTextBoxColumn();
            dgvUsername = new DataGridViewTextBoxColumn();
            dgvPassword = new DataGridViewTextBoxColumn();
            dgvRole = new DataGridViewTextBoxColumn();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            cb_Role = new ReaLTaiizor.Controls.MaterialComboBox();
            bt_Delete = new ReaLTaiizor.Controls.MaterialButton();
            bt_Save = new ReaLTaiizor.Controls.MaterialButton();
            tb_Password = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Username = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            imageList1 = new ImageList(components);
            label2 = new Label();
            materialTabControl1.SuspendLayout();
            tab_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_User).BeginInit();
            SuspendLayout();
            // 
            // materialDrawer1
            // 
            materialDrawer1.AutoHide = false;
            materialDrawer1.AutoShow = false;
            materialDrawer1.BackgroundWithAccent = false;
            materialDrawer1.BaseTabControl = null;
            materialDrawer1.Depth = 0;
            materialDrawer1.HighlightWithAccent = true;
            materialDrawer1.IndicatorWidth = 0;
            materialDrawer1.IsOpen = false;
            materialDrawer1.Location = new Point(-312, 169);
            materialDrawer1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialDrawer1.Name = "materialDrawer1";
            materialDrawer1.ShowIconsWhenHidden = false;
            materialDrawer1.ShowTabControl = null;
            materialDrawer1.Size = new Size(312, 150);
            materialDrawer1.TabIndex = 0;
            materialDrawer1.Text = "materialDrawer1";
            materialDrawer1.UseColors = false;
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tab_User);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1272, 669);
            materialTabControl1.TabIndex = 1;
            // 
            // tab_User
            // 
            tab_User.Controls.Add(label2);
            tab_User.Controls.Add(label_Served);
            tab_User.Controls.Add(dateTimePicker1);
            tab_User.Controls.Add(bt_Reset);
            tab_User.Controls.Add(dataGridView_User);
            tab_User.Controls.Add(bigLabel2);
            tab_User.Controls.Add(cb_Role);
            tab_User.Controls.Add(bt_Delete);
            tab_User.Controls.Add(bt_Save);
            tab_User.Controls.Add(tb_Password);
            tab_User.Controls.Add(tb_Username);
            tab_User.ImageKey = "people-roof-solid.png";
            tab_User.Location = new Point(4, 31);
            tab_User.Name = "tab_User";
            tab_User.Padding = new Padding(3);
            tab_User.Size = new Size(1264, 634);
            tab_User.TabIndex = 0;
            tab_User.Text = "Manage User";
            tab_User.UseVisualStyleBackColor = true;
            // 
            // label_Served
            // 
            label_Served.AutoSize = true;
            label_Served.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Served.Location = new Point(1085, 493);
            label_Served.Name = "label_Served";
            label_Served.Size = new Size(38, 46);
            label_Served.TabIndex = 14;
            label_Served.Text = "0";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(449, 508);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(259, 27);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // bt_Reset
            // 
            bt_Reset.AutoSize = false;
            bt_Reset.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_Reset.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            bt_Reset.Depth = 0;
            bt_Reset.HighEmphasis = true;
            bt_Reset.Icon = null;
            bt_Reset.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            bt_Reset.Location = new Point(38, 455);
            bt_Reset.Margin = new Padding(4, 6, 4, 6);
            bt_Reset.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            bt_Reset.Name = "bt_Reset";
            bt_Reset.NoAccentTextColor = Color.Empty;
            bt_Reset.Size = new Size(339, 80);
            bt_Reset.TabIndex = 11;
            bt_Reset.Text = "RESET QUE";
            bt_Reset.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            bt_Reset.UseAccentColor = false;
            bt_Reset.UseVisualStyleBackColor = true;
            bt_Reset.Click += bt_Reset_Click;
            // 
            // dataGridView_User
            // 
            dataGridView_User.AllowUserToResizeRows = false;
            dataGridView_User.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_User.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridView_User.BorderStyle = BorderStyle.None;
            dataGridView_User.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView_User.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_User.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_User.ColumnHeadersHeight = 40;
            dataGridView_User.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView_User.Columns.AddRange(new DataGridViewColumn[] { dgvId, dgvUsername, dgvPassword, dgvRole });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_User.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_User.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_User.EnableHeadersVisualStyles = false;
            dataGridView_User.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridView_User.GridColor = Color.FromArgb(255, 255, 255);
            dataGridView_User.Location = new Point(449, 119);
            dataGridView_User.MultiSelect = false;
            dataGridView_User.Name = "dataGridView_User";
            dataGridView_User.ReadOnly = true;
            dataGridView_User.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_User.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_User.RowHeadersVisible = false;
            dataGridView_User.RowHeadersWidth = 51;
            dataGridView_User.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView_User.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView_User.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_User.Size = new Size(765, 306);
            dataGridView_User.TabIndex = 10;
            dataGridView_User.CellDoubleClick += dataGridView_User_CellDoubleClick;
            // 
            // dgvId
            // 
            dgvId.HeaderText = "id";
            dgvId.MinimumWidth = 6;
            dgvId.Name = "dgvId";
            dgvId.ReadOnly = true;
            dgvId.Visible = false;
            // 
            // dgvUsername
            // 
            dgvUsername.HeaderText = "Username";
            dgvUsername.MinimumWidth = 6;
            dgvUsername.Name = "dgvUsername";
            dgvUsername.ReadOnly = true;
            // 
            // dgvPassword
            // 
            dgvPassword.HeaderText = "Password";
            dgvPassword.MinimumWidth = 6;
            dgvPassword.Name = "dgvPassword";
            dgvPassword.ReadOnly = true;
            dgvPassword.Visible = false;
            // 
            // dgvRole
            // 
            dgvRole.HeaderText = "Role";
            dgvRole.MinimumWidth = 6;
            dgvRole.Name = "dgvRole";
            dgvRole.ReadOnly = true;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 25F);
            bigLabel2.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel2.Location = new Point(26, 21);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(290, 57);
            bigLabel2.TabIndex = 9;
            bigLabel2.Text = "Manage Users";
            // 
            // cb_Role
            // 
            cb_Role.AutoResize = false;
            cb_Role.BackColor = Color.FromArgb(255, 255, 255);
            cb_Role.Depth = 0;
            cb_Role.DrawMode = DrawMode.OwnerDrawVariable;
            cb_Role.DropDownHeight = 174;
            cb_Role.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Role.DropDownWidth = 121;
            cb_Role.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cb_Role.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cb_Role.FormattingEnabled = true;
            cb_Role.IntegralHeight = false;
            cb_Role.ItemHeight = 43;
            cb_Role.Items.AddRange(new object[] { "Admin", "Guard", "Teller" });
            cb_Role.Location = new Point(38, 291);
            cb_Role.MaxDropDownItems = 4;
            cb_Role.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cb_Role.Name = "cb_Role";
            cb_Role.Size = new Size(339, 49);
            cb_Role.StartIndex = 0;
            cb_Role.TabIndex = 7;
            // 
            // bt_Delete
            // 
            bt_Delete.AutoSize = false;
            bt_Delete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_Delete.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            bt_Delete.Depth = 0;
            bt_Delete.HighEmphasis = true;
            bt_Delete.Icon = null;
            bt_Delete.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            bt_Delete.Location = new Point(219, 389);
            bt_Delete.Margin = new Padding(4, 6, 4, 6);
            bt_Delete.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            bt_Delete.Name = "bt_Delete";
            bt_Delete.NoAccentTextColor = Color.Empty;
            bt_Delete.Size = new Size(158, 36);
            bt_Delete.TabIndex = 6;
            bt_Delete.Text = "DELETE";
            bt_Delete.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            bt_Delete.UseAccentColor = false;
            bt_Delete.UseVisualStyleBackColor = true;
            bt_Delete.Click += bt_Delete_Click;
            // 
            // bt_Save
            // 
            bt_Save.AutoSize = false;
            bt_Save.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_Save.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            bt_Save.Depth = 0;
            bt_Save.HighEmphasis = true;
            bt_Save.Icon = null;
            bt_Save.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            bt_Save.Location = new Point(38, 389);
            bt_Save.Margin = new Padding(4, 6, 4, 6);
            bt_Save.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            bt_Save.Name = "bt_Save";
            bt_Save.NoAccentTextColor = Color.Empty;
            bt_Save.Size = new Size(158, 36);
            bt_Save.TabIndex = 5;
            bt_Save.Text = "SAVE";
            bt_Save.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            bt_Save.UseAccentColor = false;
            bt_Save.UseVisualStyleBackColor = true;
            bt_Save.Click += bt_Save_Click;
            // 
            // tb_Password
            // 
            tb_Password.AnimateReadOnly = false;
            tb_Password.AutoCompleteMode = AutoCompleteMode.None;
            tb_Password.AutoCompleteSource = AutoCompleteSource.None;
            tb_Password.BackgroundImageLayout = ImageLayout.None;
            tb_Password.CharacterCasing = CharacterCasing.Normal;
            tb_Password.Depth = 0;
            tb_Password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_Password.HideSelection = true;
            tb_Password.Hint = "Password";
            tb_Password.LeadingIcon = null;
            tb_Password.Location = new Point(38, 205);
            tb_Password.Margin = new Padding(4);
            tb_Password.MaxLength = 32767;
            tb_Password.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_Password.Name = "tb_Password";
            tb_Password.PasswordChar = '●';
            tb_Password.PrefixSuffixText = null;
            tb_Password.ReadOnly = false;
            tb_Password.RightToLeft = RightToLeft.No;
            tb_Password.SelectedText = "";
            tb_Password.SelectionLength = 0;
            tb_Password.SelectionStart = 0;
            tb_Password.ShortcutsEnabled = true;
            tb_Password.Size = new Size(339, 48);
            tb_Password.TabIndex = 4;
            tb_Password.TabStop = false;
            tb_Password.TextAlign = HorizontalAlignment.Left;
            tb_Password.TrailingIcon = null;
            tb_Password.UseAccent = false;
            tb_Password.UseSystemPasswordChar = true;
            // 
            // tb_Username
            // 
            tb_Username.AnimateReadOnly = false;
            tb_Username.AutoCompleteMode = AutoCompleteMode.None;
            tb_Username.AutoCompleteSource = AutoCompleteSource.None;
            tb_Username.BackgroundImageLayout = ImageLayout.None;
            tb_Username.CharacterCasing = CharacterCasing.Normal;
            tb_Username.Depth = 0;
            tb_Username.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_Username.HelperText = "USERNAME";
            tb_Username.HideSelection = true;
            tb_Username.Hint = "USERNAME";
            tb_Username.LeadingIcon = null;
            tb_Username.Location = new Point(38, 119);
            tb_Username.Margin = new Padding(4);
            tb_Username.MaxLength = 32767;
            tb_Username.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tb_Username.Name = "tb_Username";
            tb_Username.PasswordChar = '\0';
            tb_Username.PrefixSuffixText = null;
            tb_Username.ReadOnly = false;
            tb_Username.RightToLeft = RightToLeft.No;
            tb_Username.SelectedText = "";
            tb_Username.SelectionLength = 0;
            tb_Username.SelectionStart = 0;
            tb_Username.ShortcutsEnabled = true;
            tb_Username.Size = new Size(339, 48);
            tb_Username.TabIndex = 3;
            tb_Username.TabStop = false;
            tb_Username.TextAlign = HorizontalAlignment.Left;
            tb_Username.TrailingIcon = null;
            tb_Username.UseAccent = false;
            tb_Username.UseSystemPasswordChar = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "chart-line-solid.png");
            imageList1.Images.SetKeyName(1, "people-roof-solid.png");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(732, 493);
            label2.Name = "label2";
            label2.Size = new Size(363, 46);
            label2.TabIndex = 16;
            label2.Text = "Total Queue Numbers: ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1278, 736);
            Controls.Add(materialTabControl1);
            Controls.Add(materialDrawer1);
            DrawerTabControl = materialTabControl1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Amoec Queing System";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            materialTabControl1.ResumeLayout(false);
            tab_User.ResumeLayout(false);
            tab_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_User).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialDrawer materialDrawer1;
        private ReaLTaiizor.Controls.MaterialTabControl materialTabControl1;
        private TabPage tab_User;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialComboBox cb_Role;
        private ReaLTaiizor.Controls.MaterialButton bt_Delete;
        private ReaLTaiizor.Controls.MaterialButton bt_Save;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Password;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Username;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridView_User;
        private DataGridViewTextBoxColumn dgvId;
        private DataGridViewTextBoxColumn dgvUsername;
        private DataGridViewTextBoxColumn dgvPassword;
        private DataGridViewTextBoxColumn dgvRole;
        public ReaLTaiizor.Controls.MaterialButton bt_Reset;
        private Label label_Served;
        private DateTimePicker dateTimePicker1;
        private Label label2;
    }
}