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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password=root;database=dblogin";
            var con = new MySqlConnection(cs);

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from tblaccount where Username='"+textBox1.Text+"' AND Password = '"+textBox2.Text+"'",con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (textBox1.Text==""&&textBox2.Text=="")
                {
                    MessageBox.Show("Giriş yap");
                }
                else
                {
                    if (reader.Read())
                    {
                        main mn = new main();
                        this.Hide();
                        mn.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("giriş başarısız");
                    }
                }

                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                reader.Close();
                cmd.Dispose();
                con.Close();

            }
            
            catch (Exception ex)
            {
                MessageBox.Show("giriş başarısız");


            }
            


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayıtol ko = new kayıtol();
            this.Hide();
            ko.ShowDialog();
            this.Hide();
        }
    }
    } 
        


