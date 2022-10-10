using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolm_rakendust
{
    public partial class Registr : Form
    {
        
        Button registrbutton;
        string[] sugupolo = { "Mees", "Naine" };
        TextBox kasutaja = new TextBox
        {
            Location = new System.Drawing.Point(200, 105),//Point(x,y)
            Height = 90,
            Width = 150
        };
        TextBox email = new TextBox
        {
            Location = new System.Drawing.Point(200, 165),//Point(x,y)
            Height = 90,
            Width = 150,
            UseSystemPasswordChar = true

        };
        ComboBox sugubox = new ComboBox
        {
            //DataSource = sugupolo.ToArray(),
            Location = new System.Drawing.Point(200, 225),//Point(x,y)
            Height = 50,
            Width = 150,
        };
        //sugubox.Items.Add("Mees");
        TextBox sugu = new TextBox
        {
            Location = new System.Drawing.Point(200, 225),//Point(x,y)
            Height = 90,
            Width = 150,
            UseSystemPasswordChar = true
        };
        NumericUpDown vanus = new NumericUpDown
        {
            Location = new System.Drawing.Point(200, 285),//Point(x,y)
            Height = 90,
            Width = 150,
            //UseSystemPasswordChar = true

        };
        TextBox password = new TextBox
        {
            Location = new System.Drawing.Point(200, 345),//Point(x,y)
            Height = 90,
            Width = 150,
            UseSystemPasswordChar = true

        };

        public Registr()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "Registr";
            this.Size = new Size(500, 600);

            Label nimilabel = new Label
            {
                Location = new System.Drawing.Point(200, 30),//Point(x,y)
                Height = 50,
                Width = 170,
                Text = "Registr vorm",
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
            Label emaillabel = new Label
            {
                Location = new System.Drawing.Point(50, 160),//Point(x,y)
                Height = 50,
                Width = 150,
                Text = "Email:",
                Font = new Font("Oswald", 16, FontStyle.Bold)
            };
            
            Label sugulabel = new Label
            {
                Location = new System.Drawing.Point(50, 220),//Point(x,y)
                Height = 50,
                Width = 150,
                Text = "Sugu:",
                Font = new Font("Oswald", 16, FontStyle.Bold)
            };
            Label vanuslabel = new Label
            {
                Location = new System.Drawing.Point(50, 280),//Point(x,y)
                Height = 50,
                Width = 150,
                Text = "Vanus:",
                Font = new Font("Oswald", 16, FontStyle.Bold)
            };
            Label passwordnimi = new Label
            {
                Location = new System.Drawing.Point(50, 340),//Point(x,y)
                Height = 50,
                Width = 150,
                Text = "Parool:",
                Font = new Font("Oswald", 16, FontStyle.Bold)
            };
            /*loginbutton = new Button
            {
                Text = "Registr",
                Location = new System.Drawing.Point(200, 250),//Point(x,y)
                Width = 150,
                Height = 35,
                BackColor = Color.LightYellow
            };*/
            registrbutton = new Button
            {
                Text = "Registr",
                Location = new System.Drawing.Point(200, 450),//Point(x,y)
                Width = 150,
                Height = 35,
                BackColor = Color.LightYellow
            };
            registrbutton.Click += Registrbutton_Click;

            this.Controls.Add(nimilabel);
            this.Controls.Add(loginnimi);
            this.Controls.Add(passwordnimi);
            this.Controls.Add(emaillabel);
            this.Controls.Add(sugulabel);
            this.Controls.Add(vanuslabel);
            this.Controls.Add(kasutaja);           
            this.Controls.Add(email);
            this.Controls.Add(sugubox);
            this.Controls.Add(vanus);
            this.Controls.Add(password);
            this.Controls.Add(registrbutton);
        }

        private void Registrbutton_Click(object sender, EventArgs e)
        {
            Start start = new Start();
            start.StartPosition = FormStartPosition.CenterScreen;
            start.Show();
            this.Hide();
        }
    }
}
