using QuanLyBanHang.Models;
using QuanLyBanHang.UserController;
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
    public partial class Home : Form
    {
        private Employee emp;
        private Customer cus;
        public Home()
        {
            InitializeComponent();
        }
        public Home(Employee e)
        {
            InitializeComponent();
            this.emp = e;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadProduct();
            DeleteCart();
            cus = null;
            textBoxCusphone.Text = "";
            labelCusname.Text = "no-customer";
            comboBox1.Items.Add("All");
            using (var q = new QuanLyBanHang1Entities())
            {
                var cat = from c in q.Categories select c;
                foreach (var i in cat)
                {
                    comboBox1.Items.Add(i.cat_name.ToString());
                }
            }
            comboBox1.SelectedIndex = 0;
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }
        private void LoadProduct()
        {
            using (var db = new QuanLyBanHang1Entities())
            {
                flowLayoutPanel1.Controls.Clear();

                var a = db.Products.ToList();
                foreach (var i in a)
                {
                    flowLayoutPanel1.Controls.Add(new ProductControl(i));
                }
            }
        }

        private void LoadProductByCat(string category)
        {
            using (var db = new QuanLyBanHang1Entities())
            {

                flowLayoutPanel1.Controls.Clear();

                var a = from p in db.Products
                        where p.Category.cat_name.ToString() == category
                        select p;
                foreach (var i in a)
                {
                    flowLayoutPanel1.Controls.Add(new ProductControl(i));
                }
            }
        }

        private void DeleteCart()
        {
            using (var q = new QuanLyBanHang1Entities())
            {
                foreach (var item in q.CartItems)
                {
                    q.CartItems.Remove(item);
                }
                q.SaveChanges();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var loginform = new Login();
            loginform.Show();
            this.Visible = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "All")
            {
                LoadProduct();
            }
            else
            {
                LoadProductByCat(comboBox1.SelectedItem.ToString());
            }
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            using (var db = new QuanLyBanHang1Entities())
            {
                int total = 0;
                var c = db.CartItems.ToList();
                foreach (var item in c)
                {
                    flowLayoutPanel1.Controls.Add(new CartControl(item));
                    total = total + (item.quantity * item.Product.unit_price);
                }

                labelTotalCart.Text = total.ToString();
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (textBoxCusphone.Text == null)
            {
                MessageBox.Show("Enter a phone number");
            }
            else
            {
                using(var db = new QuanLyBanHang1Entities())
                {
                    var cusbyphone = db.Customers.FirstOrDefault(s => s.phone_number == textBoxCusphone.Text);
                    if (cusbyphone == null)
                    {
                         DialogResult dlr =  MessageBox.Show(" 'Yes' to create a customer or 'No' to retry","Customer", MessageBoxButtons.YesNo);
                        if(dlr == DialogResult.Yes)
                        {
                            var form = new AddCustomer(textBoxCusphone.Text);
                            form.ShowDialog();
                        }
                    }
                    else
                    {
                        cus = cusbyphone;
                        labelCusname.Text = cusbyphone.e_name;
                        MessageBox.Show("Sucess");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonCart_Click(sender, e);
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            if (cus == null)
            {
                MessageBox.Show("can find your customer");
            }
            else
            {
                buttonCart_Click(sender, e);
                var form = new CheckOut(this.emp, this.cus);
                form.ShowDialog();
            }

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

            Home_Load(sender,e);
        }
    }
}
