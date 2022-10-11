using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kolm_rakendust
{

    public partial class Login : Form
    {
        
        Button loginbutton, registrbutton;
        TextBox login = new TextBox
        {
            Location = new System.Drawing.Point(200, 105),//Point(x,y)
            Height = 90,
            Width = 150
        };
        TextBox parool = new TextBox
        {
            Location = new System.Drawing.Point(200, 165),//Point(x,y)
            Height = 90,
            Width = 150,
            

        };


        static string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\Source\Repos\Kolm_rakendust\Kolm rakendust\Dbkasutaja.mdf,Integrated Security=True";
        /*Vaja muuta           ↑ ↑ ↑ ↑ ↑ ↑ ↑ see on see, kui kolisite teise arvuti taha!!!!!!!!!*/
        SqlConnection connect_to_DB = new SqlConnection(conn);

        SqlCommand command;

        public Login()
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "Login";
            this.Size = new Size(500, 400);

            Label nimilabel = new Label
            {
                Location = new System.Drawing.Point(200, 30),//Point(x,y)
                Height = 50,
                Width = 170,
                Text = "Login vorm",
                Font = new Font("Oswald", 16, FontStyle.Bold)
            };

            Label loginnimi = new Label
            {
                Location = new System.Drawing.Point(50, 100),//Point(x,y)
                Height = 50,
                Width = 150,
                Text = "Login:",
                Font = new Font("Oswald", 16, FontStyle.Bold)
            };

            Label passwordnimi = new Label
            {
                Location = new System.Drawing.Point(50, 160),//Point(x,y)
                Height = 50,
                Width = 150,
                Text = "Parool:",
                Font = new Font("Oswald", 16, FontStyle.Bold)
            };

            loginbutton = new Button
            {
                Text = "Login",
                Location = new System.Drawing.Point(90, 275),//Point(x,y)
                Width = 150,
                Height = 35,
                BackColor = Color.LightYellow
            };
            loginbutton.Click += Loginbutton_Click;
            registrbutton = new Button
            {
                Text = "Registr",
                Location = new System.Drawing.Point(270, 275),//Point(x,y)
                Width = 150,
                Height = 35,
                BackColor = Color.LightYellow
            };
            registrbutton.Click += Registrbutton_Click;

            this.Controls.Add(nimilabel);
            this.Controls.Add(loginnimi);
            this.Controls.Add(passwordnimi);
            this.Controls.Add(login);
            this.Controls.Add(parool);
            this.Controls.Add(loginbutton);
            this.Controls.Add(registrbutton);
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\Source\Repos\Kolm_rakendust\Kolm rakendust\Dbkasutaja.mdf,Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(*) FROM Kasutaja WHERE kasutajanimi='" + login.Text + "' and parool ='" + parool.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Start start = new Start();
                start.StartPosition = FormStartPosition.CenterScreen;
                start.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vale parool või sisselogimine");
            }

            
        }
        private void Registrbutton_Click(object sender, EventArgs e)
        {
            Registr registr = new Registr();
            registr.StartPosition = FormStartPosition.CenterScreen;
            registr.Show();
            this.Hide();
        }
    }
}
