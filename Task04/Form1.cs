using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Mohammad Al-Qaisy

namespace Task04
{
    public partial class Form1 : Form
    {
        List<Client> list = new List<Client>();
        string search;
        Client ans;
        bool info = true, found=false;

        public Form1()
        {
            InitializeComponent();
            button3.Enabled = true;
            button2.Enabled = false;
            button4.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            found = false;
            if (textBox1.Text != "")
            {
                search = textBox1.Text;
                foreach (Client t in list)
                {
                    if (search == t._userName || search == t._firstName || search == t._middleName ||
                        search == t._lastName || search == t._shortName || search == t._phone || search == t._email)
                    {
                        ans = t;
                        button2.Enabled = true;
                        button4.Enabled = true;
                        button3.Enabled = false;
                        textBox2.Text = t._userName;
                        textBox3.Text = t._firstName;
                        textBox4.Text = t._middleName;
                        textBox6.Text = t._phone;
                        textBox7.Text = t._password;
                        textBox8.Text = t._lastName;
                        textBox9.Text = t._shortName;
                        textBox10.Text = t._email;
                        if (t._gender == "Male")
                            radioButton1.Checked = true;
                        else
                            radioButton2.Checked = true;
                        show();
                        found = true;
                    }

                }
                if (!list.Any())
                    MessageBox.Show("There is no client");
                else if (!found) 
                    MessageBox.Show("Not found 404");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            info = true;
            checkInfo();
            if (info)
            {
                string gender = "", pass = "";
                if (radioButton1.Checked)
                    gender = "Male";
                if (radioButton2.Checked)
                    gender = "Female";
                Client obj = new Client(textBox2.Text, textBox3.Text, textBox4.Text,
                    textBox8.Text, textBox9.Text, gender, textBox6.Text,
                    textBox7.Text, textBox10.Text);
                list.Add(obj);
                clearIt();
                foreach (char t in obj._password)
                    pass += "*";
                var row = new string[] { obj._userName,obj._firstName, obj._middleName,obj._lastName,
                obj._shortName, obj._gender,obj._phone,obj._email,pass};
                var x = new ListViewItem(row);
                listView.Items.Add(x);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void checkInfo()
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
            textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text =="" || 
            textBox10.Text == "" || ((radioButton1.Checked == false) && (radioButton2.Checked == false)))
            {
                 MessageBox.Show("Please enter all information");
                 info = false;
            }
        }
        void show()
        {
            listView.Items.Clear();
            string pass;
            foreach(Client obj in list)
            {
                pass = "";
                foreach (char t in obj._password)
                    pass += "*";
                var row = new string[] { obj._userName,obj._firstName, obj._middleName,obj._lastName,
                obj._shortName, obj._gender,obj._phone,obj._email,pass};
                var x = new ListViewItem(row);
                listView.Items.Add(x);
            }
        }
        void delete(Client t)
        {
            list.Remove(t);
        }
        void update(Client t)
        {
            t._userName = textBox2.Text;
            t._firstName = textBox3.Text;
            t._middleName = textBox4.Text;
            t._phone = textBox6.Text;
            t._password=textBox7.Text;
            t._lastName= textBox8.Text;
            t._shortName= textBox9.Text;
            t._email = textBox10.Text;
            if (radioButton1.Checked)
                t._gender = "Male";
            else if (radioButton2.Checked)
                t._gender = "Female";
        }
        void clearIt()
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            info = true;
            checkInfo();
            if (info)
            {
                update(ans);
                show();
                clearIt();
                button3.Enabled = true;
                button2.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete(ans);
            show();
            clearIt();
            button3.Enabled = true;
            button2.Enabled = false;
            button4.Enabled = false;
        }
    }
}