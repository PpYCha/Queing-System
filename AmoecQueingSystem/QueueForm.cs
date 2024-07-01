using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;


namespace AmoecQueingSystem
{
    public partial class QueueForm : MaterialForm
    {
        public QueueForm()
        {
            InitializeComponent();
        }

        private Timer timer;


        private void QueueForm_Load(object sender, EventArgs e)
        {
            LoadData();

            timer = new Timer();
            timer.Interval = 3000; // Check every 5 seconds (adjust as needed)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Check for changes in the database and reload data if needed
            CheckForChanges();
        }

        private void CheckForChanges()
        {
            // Implement your logic to check for changes in the database
            // For example, you can compare the current data with the previous data
            // If there are changes, call the LoadData method to reload the data
            LoadData();
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvId);
            lb.Items.Add(dgvNumber);
            lb.Items.Add(dgvStatus);
            lb.Items.Add(dgvTeller);

            //string qry = @"Select id, number, status from queue_numbers";

            string qry = @"SELECT id, number, status, teller
               FROM queue_numbers
               WHERE CAST(GETDATE() AS DATE) = CAST(date AS DATE) AND status != 'Done'";


            MainClass.LoadData(qry, dataGridView_User, lb);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void QueueForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
