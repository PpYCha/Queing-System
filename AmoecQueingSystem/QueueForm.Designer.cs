namespace AmoecQueingSystem
{
    partial class QueueForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridView_User = new ReaLTaiizor.Controls.PoisonDataGridView();
            dgvId = new DataGridViewTextBoxColumn();
            dgvNumber = new DataGridViewTextBoxColumn();
            dgvStatus = new DataGridViewTextBoxColumn();
            dgvTeller = new DataGridViewTextBoxColumn();
            button1 = new Button();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_User).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_User
            // 
            dataGridView_User.AllowUserToAddRows = false;
            dataGridView_User.AllowUserToDeleteRows = false;
            dataGridView_User.AllowUserToOrderColumns = true;
            dataGridView_User.AllowUserToResizeColumns = false;
            dataGridView_User.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView_User.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_User.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_User.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_User.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridView_User.BorderStyle = BorderStyle.None;
            dataGridView_User.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView_User.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_User.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_User.ColumnHeadersHeight = 80;
            dataGridView_User.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView_User.Columns.AddRange(new DataGridViewColumn[] { dgvId, dgvNumber, dgvStatus, dgvTeller });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 72F, FontStyle.Strikeout, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView_User.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_User.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView_User.EnableHeadersVisualStyles = false;
            dataGridView_User.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridView_User.GridColor = Color.FromArgb(255, 255, 255);
            dataGridView_User.Location = new Point(17, 84);
            dataGridView_User.MultiSelect = false;
            dataGridView_User.Name = "dataGridView_User";
            dataGridView_User.ReadOnly = true;
            dataGridView_User.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView_User.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_User.RowHeadersVisible = false;
            dataGridView_User.RowHeadersWidth = 51;
            dataGridView_User.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView_User.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView_User.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 90F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView_User.RowTemplate.Height = 220;
            dataGridView_User.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_User.Size = new Size(809, 345);
            dataGridView_User.TabIndex = 11;
            // 
            // dgvId
            // 
            dgvId.HeaderText = "id";
            dgvId.MinimumWidth = 6;
            dgvId.Name = "dgvId";
            dgvId.ReadOnly = true;
            dgvId.Visible = false;
            // 
            // dgvNumber
            // 
            dgvNumber.HeaderText = "Number";
            dgvNumber.MinimumWidth = 6;
            dgvNumber.Name = "dgvNumber";
            dgvNumber.ReadOnly = true;
            // 
            // dgvStatus
            // 
            dgvStatus.HeaderText = "Status";
            dgvStatus.MinimumWidth = 6;
            dgvStatus.Name = "dgvStatus";
            dgvStatus.ReadOnly = true;
            // 
            // dgvTeller
            // 
            dgvTeller.HeaderText = "Counter";
            dgvTeller.MinimumWidth = 6;
            dgvTeller.Name = "dgvTeller";
            dgvTeller.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(183, 400);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Bt_refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Image = Properties.Resources.amoecLogo_removebg_preview;
            hopePictureBox1.Location = new Point(832, 84);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(460, 333);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 13;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // QueueForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 450);
            Controls.Add(hopePictureBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView_User);
            Name = "QueueForm";
            Text = "Queue";
            WindowState = FormWindowState.Maximized;
            FormClosing += QueueForm_FormClosing;
            Load += QueueForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_User).EndInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView dataGridView_User;
        private Button button1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private DataGridViewTextBoxColumn dgvId;
        private DataGridViewTextBoxColumn dgvNumber;
        private DataGridViewTextBoxColumn dgvStatus;
        private DataGridViewTextBoxColumn dgvTeller;
    }
}