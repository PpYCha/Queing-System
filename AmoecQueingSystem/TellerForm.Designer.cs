namespace AmoecQueingSystem
{
    partial class TellerForm
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
            bt_Next = new ReaLTaiizor.Controls.MaterialButton();
            label1 = new Label();
            tb_TellerName = new Label();
            bt_Done = new ReaLTaiizor.Controls.MaterialButton();
            label2 = new Label();
            tb_Number = new Label();
            tb_Status = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // bt_Next
            // 
            bt_Next.AutoSize = false;
            bt_Next.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_Next.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            bt_Next.Depth = 0;
            bt_Next.Font = new Font("Segoe UI", 30F);
            bt_Next.HighEmphasis = true;
            bt_Next.Icon = null;
            bt_Next.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            bt_Next.Location = new Point(22, 278);
            bt_Next.Margin = new Padding(4, 6, 4, 6);
            bt_Next.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            bt_Next.Name = "bt_Next";
            bt_Next.NoAccentTextColor = Color.Empty;
            bt_Next.Size = new Size(251, 122);
            bt_Next.TabIndex = 6;
            bt_Next.Text = "SERVE NOW";
            bt_Next.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            bt_Next.UseAccentColor = false;
            bt_Next.UseVisualStyleBackColor = true;
            bt_Next.Click += bt_Next_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(22, 80);
            label1.Name = "label1";
            label1.Size = new Size(235, 46);
            label1.TabIndex = 7;
            label1.Text = "TELLER NAME:";
            // 
            // tb_TellerName
            // 
            tb_TellerName.AutoSize = true;
            tb_TellerName.Font = new Font("Segoe UI", 20F);
            tb_TellerName.Location = new Point(263, 80);
            tb_TellerName.Name = "tb_TellerName";
            tb_TellerName.Size = new Size(235, 46);
            tb_TellerName.TabIndex = 8;
            tb_TellerName.Text = "TELLER NAME:";
            // 
            // bt_Done
            // 
            bt_Done.AutoSize = false;
            bt_Done.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bt_Done.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            bt_Done.Depth = 0;
            bt_Done.Font = new Font("Segoe UI", 30F);
            bt_Done.HighEmphasis = true;
            bt_Done.Icon = null;
            bt_Done.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            bt_Done.Location = new Point(367, 278);
            bt_Done.Margin = new Padding(4, 6, 4, 6);
            bt_Done.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            bt_Done.Name = "bt_Done";
            bt_Done.NoAccentTextColor = Color.Empty;
            bt_Done.Size = new Size(251, 122);
            bt_Done.TabIndex = 9;
            bt_Done.Text = "Done";
            bt_Done.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            bt_Done.UseAccentColor = false;
            bt_Done.UseVisualStyleBackColor = true;
            bt_Done.Click += bt_Done_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(22, 139);
            label2.Name = "label2";
            label2.Size = new Size(217, 46);
            label2.TabIndex = 10;
            label2.Text = "Now Serving:";
            // 
            // tb_Number
            // 
            tb_Number.AutoSize = true;
            tb_Number.Font = new Font("Segoe UI", 20F);
            tb_Number.Location = new Point(236, 139);
            tb_Number.Name = "tb_Number";
            tb_Number.Size = new Size(38, 46);
            tb_Number.TabIndex = 11;
            tb_Number.Text = "0";
            // 
            // tb_Status
            // 
            tb_Status.AutoSize = true;
            tb_Status.Font = new Font("Segoe UI", 20F);
            tb_Status.Location = new Point(236, 208);
            tb_Status.Name = "tb_Status";
            tb_Status.Size = new Size(0, 46);
            tb_Status.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(121, 208);
            label4.Name = "label4";
            label4.Size = new Size(118, 46);
            label4.TabIndex = 12;
            label4.Text = "Status:";
            // 
            // TellerForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(668, 429);
            Controls.Add(tb_Status);
            Controls.Add(label4);
            Controls.Add(tb_Number);
            Controls.Add(label2);
            Controls.Add(bt_Done);
            Controls.Add(tb_TellerName);
            Controls.Add(label1);
            Controls.Add(bt_Next);
            Name = "TellerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teller";
            Load += TellerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialButton bt_Next;
        private Label label1;
        private Label tb_TellerName;
        private ReaLTaiizor.Controls.MaterialButton bt_Done;
        private Label label2;
        private Label tb_Number;
        private Label tb_Status;
        private Label label4;
    }
}