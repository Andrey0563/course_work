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
    public partial class Form2 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\0 Cursach\\BDinterface\\BDinterface\\Db Lecturers.mdb";
        private OleDbConnection myConnection;
       
        public Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(textBox1.Text);
            string Name = textBox4.Text;
            string Surname = textBox5.Text;
            string Thirdname = textBox3.Text;
            string Position = textBox2.Text;
            string query = "INSERT INTO Преподаватели ([Код], Прізвище, Ім'я, Ім'я по батькові, Вчене звання викладача ) VALUES (" + code + ", '" + Surname + "', '" + Name + "', '" + Thirdname + "','" + Position + "')" ;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Дані про викладача додано");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
