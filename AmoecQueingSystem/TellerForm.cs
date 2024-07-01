using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmoecQueingSystem
{
    public partial class TellerForm : MaterialForm
    {
        public TellerForm()
        {
            InitializeComponent();
        }

        private int id;
        private int currentNumber = 0;

        private void TellerForm_Load(object sender, EventArgs e)
        {

            //tb_TellerName.Text = MainClass.USER.ToString();
        }

        private void bt_Next_Click(object sender, EventArgs e)
        {
            int firstNumber = GetFirstNumberFromDatabase();
            currentNumber = Convert.ToInt32(tb_Number.Text);
            tb_Number.Text = firstNumber.ToString();


            UpdateTheStatus(id, firstNumber, currentNumber);


        }

        private int GetFirstNumberFromDatabase()
        {

            if(tb_Status.Text != "Called") { 

            int firstNumber = 0;
            
            MainClass.con.Open();

            string query = "SELECT MIN(number) as number, id, status FROM queue_numbers WHERE date = @currentDate and status = @status GROUP BY id, status";
            using (SqlCommand cmd = new SqlCommand(query, MainClass.con))
            {

                cmd.Parameters.AddWithValue("@currentDate", DateTime.Today);
                cmd.Parameters.AddWithValue("@status", "Pending");
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    firstNumber = Convert.ToInt32(reader["number"]);
                    id = Convert.ToInt32(reader["id"]);
                    tb_Status.Text = Convert.ToString(reader["status"]); 
                }
                reader.Close();
            }

            MainClass.con.Close();

            return firstNumber;
            }

            return Convert.ToInt32(tb_Number.Text);
        }

        private void UpdateTheStatus(int queId, int firstNumber, int currentNumber)
        {
            if (tb_Status.Text == "Pending")
            {

                MainClass.con.Open();

                string query = "UPDATE queue_numbers SET status = @newStatus, teller = @teller WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(query, MainClass.con))
                {

                    cmd.Parameters.AddWithValue("@newStatus", "Called");
                    cmd.Parameters.AddWithValue("@teller", MainClass.USER);
                    cmd.Parameters.AddWithValue("@id", id);



                    cmd.ExecuteNonQuery();




                }

                tb_Status.Text = "Called";

                MainClass.con.Close();
            }
            
        }

        private void bt_Done_Click(object sender, EventArgs e)
        {

            

            MainClass.con.Open();

            string query = "UPDATE queue_numbers SET status = @newStatus WHERE id = @id";
            using (SqlCommand cmd = new SqlCommand(query, MainClass.con))
            {

                cmd.Parameters.AddWithValue("@newStatus", "Done");
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

            }

            tb_Status.Text = "Done";
            MainClass.con.Close();


        }
    }
}
