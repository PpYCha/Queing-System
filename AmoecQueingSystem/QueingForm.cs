using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace AmoecQueingSystem
{
    public partial class QueingForm : MaterialForm
    {
        public QueingForm()
        {
            InitializeComponent();
        }



        private void bt_GenerateNumber_Click(object sender, EventArgs e)
        {


            int lastNumber = GetLastNumberFromDatabase();
            int newNumber = lastNumber + 1;

            InsertNewNumberInDatabase(newNumber);



            tb_Number.Text = newNumber.ToString();


            PrintDoc(newNumber);


        }

        private int GetLastNumberFromDatabase()
        {
            int lastNumber = 0;

            // Use your database connection to retrieve the last number from the database
            // For example, using SqlConnection and SqlCommand

            MainClass.con.Open();

            string query = "SELECT MAX(number) FROM queue_numbers WHERE date = @currentDate";
            using (SqlCommand cmd = new SqlCommand(query, MainClass.con))
            {

                cmd.Parameters.AddWithValue("@currentDate", DateTime.Today);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    lastNumber = Convert.ToInt32(result);
                }
            }

            MainClass.con.Close();


            return lastNumber;

        }

        private void InsertNewNumberInDatabase(int newNumber)
        {
            // Use your database connection to insert the new number into the database
            // For example, using SqlConnection and SqlCommand
            MainClass.con.Open();

            string query = "INSERT INTO queue_numbers (number, date, status) VALUES (@newNumber, @currentDate, @status)";
            using (SqlCommand cmd = new SqlCommand(query, MainClass.con))
            {
                cmd.Parameters.AddWithValue("@newNumber", newNumber);
                cmd.Parameters.AddWithValue("@currentDate", DateTime.Today);
                cmd.Parameters.AddWithValue("@status", "Pending");
                cmd.ExecuteNonQuery();
            }

            MainClass.con.Close();

        }



        public void PrintDoc(int queueNumber)
        {



            PaperSize pps = new PaperSize();
            pps.Width = 200;
            pps.Height = 300;

            PrintPreviewDialog PPdialog = new PrintPreviewDialog();
            PPdialog.Document = printDoc;
            PPdialog.StartPosition = FormStartPosition.CenterScreen;
            PPdialog.FormBorderStyle = FormBorderStyle.FixedSingle;
            PPdialog.PrintPreviewControl.Zoom = 1.0;
            printDoc.DefaultPageSettings.PaperSize = pps;
            PPdialog.Width = 0;
            PPdialog.Height = 400;

            printDoc.PrintPage += (s, ev) => printDoc_PrintPage(s, ev, queueNumber);



            PPdialog.ShowDialog();



        }



        private void printDoc_PrintPage(object sender, PrintPageEventArgs e, int queueNumber)
        {
            try
            {
                StringFormat sfC = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Near,
                    Trimming = StringTrimming.EllipsisCharacter
                };

                e.Graphics.DrawString("Welcome", new Font("Corbel", 24, FontStyle.Bold), Brushes.Black, new Rectangle(10, 30, 180, 40), sfC);

                e.Graphics.DrawString("---------------------------------", new Font("Corbel", 10, FontStyle.Bold), Brushes.Black, new Rectangle(10, 60, 180, 20), sfC);

                //e.Graphics.DrawString("Teller No:" + tellerNumber.ToString(), new Font("Corbel", 12, FontStyle.Bold), Brushes.Black, new Rectangle(10, 70, 180, 20), sfC);
                e.Graphics.DrawString("Your queing number", new Font("Corbel", 10, FontStyle.Bold), Brushes.Black, new Rectangle(10, 90, 180, 20), sfC);
                e.Graphics.DrawString(tb_Number.Text, new Font("Verdana", 36, FontStyle.Bold), Brushes.Black, new Rectangle(10, 100, 180, 100), sfC);

                //e.Graphics.DrawString("Currently waiting people :" + currentWaitingPeople.ToString(), new Font("Corbel", 9, FontStyle.Bold), Brushes.Black, new Rectangle(0, 155, 200, 30), sfC);

                e.Graphics.DrawString(DateTime.Now.ToLongDateString() + " | " + DateTime.Now.ToLongTimeString(), new Font("Corbel", 12, FontStyle.Bold), Brushes.Black, new Rectangle(10, 175, 180, 150), sfC);

                e.Graphics.DrawString("---------------------------------", new Font("Corbel", 10, FontStyle.Bold), Brushes.Black, new Rectangle(10, 210, 180, 20), sfC);

                e.Graphics.DrawString("Keep quiet and be patient pls.", new Font("Corbel", 8, FontStyle.Bold), Brushes.Black, new Rectangle(10, 230, 180, 20), sfC);

                e.Graphics.DrawString("Thanks for your support", new Font("Corbel", 8, FontStyle.Bold), Brushes.Black, new Rectangle(10, 240, 180, 20), sfC);

                e.Graphics.DrawString("***", new Font("Corbel", 8, FontStyle.Bold), Brushes.Black, new Rectangle(10, 260, 180, 40), sfC);



                printDoc.Dispose();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void QueingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            MainClass.con.Open();

            // Assuming the created_at column is of type DATE or DATETIME
            string qry = "DELETE FROM queue_numbers WHERE CONVERT(DATE, date) = CONVERT(DATE, GETDATE())";

            using (SqlCommand cmd = new SqlCommand(qry, MainClass.con))
            {
                cmd.ExecuteNonQuery(); // Execute the delete query
            }

            MainClass.con.Close();
        }
    }
}
