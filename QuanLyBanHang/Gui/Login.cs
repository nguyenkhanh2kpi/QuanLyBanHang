using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Gui
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // find emp
        private Employee Find(string email)
        {
            using (var p = new QuanLyBanHang1Entities())
            {
                return p.Employees.FirstOrDefault(s => s.email == email);
            }
        }
        //check
        public Employee CheckPerson(string email, string password)
        {
            var per = Find(email);
            if (per != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password, per.e_password))
                {
                    return per;
                }
                else
                {
                    MessageBox.Show("Password invalid");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Email is not Exist");
            }
            return null;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void Register_Button_Click(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            using (var q = new QuanLyBanHang1Entities())
            {
                var email = emailTxt.Text.Trim();
                var password = passwordTxt.Text.Trim();
                var per = CheckPerson(email, password);
                if (per != null)
                {
                    if (per.e_status == "active")
                    {
                        if (per.email == "hoang@gmail.com")
                        {
                            var form1 = new Admin();
                            form1.Show();
                            this.Visible = false;
                        }
                        else
                        {
                            var form1 = new Home(per);
                            resetEachMonth();
                            form1.Show();
                            this.Visible = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your Account Is Not Active");
                    }
                }
                else
                {
                    MessageBox.Show("Account DOESN'T exist");
                }

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (passwordTxt.PasswordChar.ToString().Contains('*'))
            {
                passwordTxt.PasswordChar = (char)0;
                pictureBox3.Image = Properties.Resources.open_eye;
            }
            else
            {
                passwordTxt.PasswordChar = '*';
                pictureBox3.Image = Properties.Resources.visibility;
            }
        }

        // reset each month 
        private void resetEachMonth()
        {
            if(DateTime.Today.Day == 22)
            {
                resetRank();
            }
        }


        // reset rank
        private void resetRank()
        {
            using(var db = new QuanLyBanHang1Entities())
            {
                foreach(var i in db.CustomerRanks)
                {
                    db.CustomerRanks.Remove(i);
                }
                db.SaveChanges();
            }
        }
    }
}
