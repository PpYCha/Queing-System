namespace AmoecQueingSystem
{
    partial class QueingForm
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
            bt_GenerateNumber = new ReaLTaiizor.Controls.MaterialButton();
            printDoc = new System.Drawing.Printing.PrintDocument();
            tb_Number = new TextBox();
            bt_Reset = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
            // 
            // bt_GenerateNumber
            // 
            bt_GenerateNumber.AutoSize = false;
            bt_GenerateNumber.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_GenerateNumber.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            bt_GenerateNumber.Depth = 0;
            bt_GenerateNumber.Font = new Font("Segoe UI", 30F);
            bt_GenerateNumber.HighEmphasis = true;
            bt_GenerateNumber.Icon = null;
            bt_GenerateNumber.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            bt_GenerateNumber.Location = new Point(124, 97);
            bt_GenerateNumber.Margin = new Padding(4, 6, 4, 6);
            bt_GenerateNumber.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            bt_GenerateNumber.Name = "bt_GenerateNumber";
            bt_GenerateNumber.NoAccentTextColor = Color.Empty;
            bt_GenerateNumber.Size = new Size(343, 128);
            bt_GenerateNumber.TabIndex = 7;
            bt_GenerateNumber.Text = "GENERATE QUEING NUMBER";
            bt_GenerateNumber.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            bt_GenerateNumber.UseAccentColor = false;
            bt_GenerateNumber.UseVisualStyleBackColor = true;
            bt_GenerateNumber.Click += bt_GenerateNumber_Click;
            // 
            // tb_Number
            // 
            tb_Number.Location = new Point(387, 67);
            tb_Number.Multiline = true;
            tb_Number.Name = "tb_Number";
            tb_Number.Size = new Size(207, 21);
            tb_Number.TabIndex = 8;
            tb_Number.Visible = false;
            // 
            // bt_Reset
            // 
            bt_Reset.AutoSize = false;
            bt_Reset.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_Reset.BackColor = Color.Crimson;
            bt_Reset.BackgroundImageLayout = ImageLayout.None;
            bt_Reset.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            bt_Reset.Depth = 0;
            bt_Reset.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            bt_Reset.ForeColor = Color.FromArgb(255, 192, 128);
            bt_Reset.HighEmphasis = true;
            bt_Reset.Icon = null;
            bt_Reset.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            bt_Reset.Location = new Point(124, 249);
            bt_Reset.Margin = new Padding(4, 6, 4, 6);
            bt_Reset.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            bt_Reset.Name = "bt_Reset";
            bt_Reset.NoAccentTextColor = Color.Empty;
            bt_Reset.Size = new Size(343, 105);
            bt_Reset.TabIndex = 12;
            bt_Reset.Text = "RESET QUE";
            bt_Reset.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            bt_Reset.UseAccentColor = false;
            bt_Reset.UseVisualStyleBackColor = false;
            bt_Reset.Click += bt_Reset_Click;
            // 
            // QueingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 376);
            Controls.Add(bt_Reset);
            Controls.Add(tb_Number);
            Controls.Add(bt_GenerateNumber);
            Name = "QueingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Queing Generate";
            FormClosing += QueingForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialButton bt_GenerateNumber;
        private System.Drawing.Printing.PrintDocument printDoc;
        private TextBox tb_Number;
        public ReaLTaiizor.Controls.MaterialButton bt_Reset;
    }
}