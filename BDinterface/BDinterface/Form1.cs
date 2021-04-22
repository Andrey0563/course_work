using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BDinterface
{
    
    public partial class Form1 : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\\0 Cursach\\BDinterface\\BDinterface\\Db Lecturers.mdb";
        private OleDbConnection myConnection;
        public Form1()
        {
           
                InitializeComponent();
                myConnection = new OleDbConnection(connectString);
                myConnection.Open();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "db_LecturersDataSet.Преподаватели". При необходимости она может быть перемещена или удалена.
            this.преподавателиTableAdapter.Fill(this.db_LecturersDataSet.Преподаватели);

        }

        




        private void button1_Click(object sender, EventArgs e)
        {


            int code = Convert.ToInt32(textBox1.Text);
            string query = "DELETE FROM Преподаватели WHERE [Код] =" + code;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Дані про викладача видалені");
            this.преподавателиTableAdapter.Fill(this.db_LecturersDataSet.Преподаватели);
            


        }

        private void button2_Click(object sender, EventArgs e)
        {

           
            int code = Convert.ToInt32(textBox2.Text);
            string query = "UPDATE Преподаватели SET Вчене звання викладача = '" + textBox3.Text + "' WHERE [Код] = " + code;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Дані про викладача змінено");
            this.преподавателиTableAdapter.Fill(this.db_LecturersDataSet.Преподаватели);
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();

        }


    }
}
