using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace oteluygulaması
{
    public partial class kayıtol : Form
    {
        public kayıtol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cs = @"server=localhost;userid=root;password=root;database=dblogin";
            var con = new MySqlConnection(cs);
            string ekle = "INSERT INTO tblaccount(Username,Password,num,) values (@Username," +
                " @Password, @num)";
            

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from tblaccount where Username='" + textBox1.Text + "' AND Password = '" + textBox2.Text + "'AND num = '" + textBox3.Text+"'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                
                {
                    
                }
                    
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void kayıtol_Load(object sender, EventArgs e)
        {

        }
    }
}
