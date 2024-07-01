namespace AmoecQueingSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_Username = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tb_Password = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            bt_Login = new ReaLTaiizor.Controls.MaterialButton();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            bt_ShowQue = new ReaLTaiizor.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
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
            tb_Username.Location = new Point(404, 98);
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
            tb_Username.Size = new Size(291, 48);
            tb_Username.TabIndex = 0;
            tb_Username.TabStop = false;
            tb_Username.TextAlign = HorizontalAlignment.Left;
            tb_Username.TrailingIcon = null;
            tb_Username.UseAccent = false;
            tb_Username.UseSystemPasswordChar = false;
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
            tb_Password.Location = new Point(404, 184);
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
            tb_Password.Size = new Size(291, 48);
            tb_Password.TabIndex = 1;
            tb_Password.TabStop = false;
            tb_Password.TextAlign = HorizontalAlignment.Left;
            tb_Password.TrailingIcon = null;
            tb_Password.UseAccent = false;
            tb_Password.UseSystemPasswordChar = true;
            // 
            // bt_Login
            // 
            bt_Login.AutoSize = false;
            bt_Login.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_Login.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            bt_Login.Depth = 0;
            bt_Login.HighEmphasis = true;
            bt_Login.Icon = null;
            bt_Login.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            bt_Login.Location = new Point(468, 260);
            bt_Login.Margin = new Padding(4, 6, 4, 6);
            bt_Login.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            bt_Login.Name = "bt_Login";
            bt_Login.NoAccentTextColor = Color.Empty;
            bt_Login.Size = new Size(158, 36);
            bt_Login.TabIndex = 2;
            bt_Login.Text = "LOGIN";
            bt_Login.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            bt_Login.UseAccentColor = false;
            bt_Login.UseVisualStyleBackColor = true;
            bt_Login.Click += bt_Login_Click;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Image = Properties.Resources.amoecLogo_removebg_preview;
            hopePictureBox1.Location = new Point(6, 76);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(367, 265);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 4;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // bt_ShowQue
            // 
            bt_ShowQue.AutoSize = false;
            bt_ShowQue.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_ShowQue.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            bt_ShowQue.Depth = 0;
            bt_ShowQue.HighEmphasis = true;
            bt_ShowQue.Icon = null;
            bt_ShowQue.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            bt_ShowQue.Location = new Point(468, 308);
            bt_ShowQue.Margin = new Padding(4, 6, 4, 6);
            bt_ShowQue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            bt_ShowQue.Name = "bt_ShowQue";
            bt_ShowQue.NoAccentTextColor = Color.Empty;
            bt_ShowQue.Size = new Size(158, 36);
            bt_ShowQue.TabIndex = 5;
            bt_ShowQue.Text = "SHOW QUE";
            bt_ShowQue.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            bt_ShowQue.UseAccentColor = false;
            bt_ShowQue.UseVisualStyleBackColor = true;
            bt_ShowQue.Click += bt_ShowQue_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(764, 365);
            Controls.Add(bt_ShowQue);
            Controls.Add(hopePictureBox1);
            Controls.Add(bt_Login);
            Controls.Add(tb_Password);
            Controls.Add(tb_Username);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Padding = new Padding(3, 64, 4, 4);
            Sizable = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += LoginForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Username;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tb_Password;
        private ReaLTaiizor.Controls.MaterialButton bt_Login;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.MaterialButton bt_ShowQue;
    }
}
