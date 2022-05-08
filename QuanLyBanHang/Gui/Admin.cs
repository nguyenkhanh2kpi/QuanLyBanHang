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
    public partial class Admin : Form
    {
        string manage="";
        public Admin()
        {
            InitializeComponent();
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            labeltitle.Text = "Category";
            this.manage = "Category"; 
            using (var db = new QuanLyBanHang1Entities())
            {
                var cat = (from c in db.Categories
                           select new { ID = c.cat_id, Name = c.cat_name }).ToList();
                dataGridView1.DataSource = cat;
            }
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            labeltitle.Text = "Product";
            this.manage = "Product";
            using (var db = new QuanLyBanHang1Entities())
            {
                var pro = (from p in db.Products
                           select new { ID = p.pro_id, 
                               Name = p.pro_name, 
                               Stock = p.units_instock,
                               Price = p.unit_price,
                               Status = p.pro_status == "active" ? true : false }).ToList();
                dataGridView1.DataSource = pro;

            }
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            labeltitle.Text = "Employee";
            this.manage = "Employee";
            using (var db = new QuanLyBanHang1Entities())
            {
                var employee = (from emp in db.Employees
                                select new
                                {
                                    ID = emp.id,
                                    Name = emp.e_name,
                                    Gender = emp.gender == "nam" ? "Male" : "Female",
                                    Phone = emp.phone_number,
                                    Email = emp.email,
                                    Status = emp.e_status == "active" ? true : false
                                }).ToList();
                dataGridView1.DataSource = employee;
            }
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            labeltitle.Text = "Customer";
            this.manage = "Customer";
            using (var db = new QuanLyBanHang1Entities())
            {
                var employee = (from emp in db.Customers
                                select new
                                {
                                    ID = emp.id,
                                    Name = emp.e_name,
                                    Phone = emp.phone_number,
                                }).ToList();
                dataGridView1.DataSource = employee;
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            labeltitle.Text = "Orders";
            this.manage = "Orders";
            using (var db = new QuanLyBanHang1Entities())
            {
                var od = (from o in db.Orders
                          select new { id = o.order_id,
                              customer = o.Customer.e_name,
                              phone = o.Customer.phone_number,
                              order_date = o.order_date, 
                            }).ToList();
                dataGridView1.DataSource = od;
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
      
        }


        // right click
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    contextMenuStripCatProduct.Show();
                }
            }
        }


        // add tool trip
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (this.manage)
            {
                case "Customer":
                    break;
                case "Employee":
   
                    break;
                case "Category":
                    var formc = new AddCat();
                    formc.ShowDialog();     
                    break;
                case "Product":
                    var formp = new AddProduct();
                    formp.ShowDialog();
                    break;
                case "":
                    MessageBox.Show("No object selected");
                    break;

            }
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            switch (this.manage)
            {
                case "Customer":
                    break;
                case "Employee":

                    break;
                case "Category":
                    string selected_cat_id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    var formc = new ChangeCategory(selected_cat_id);
                    formc.ShowDialog();
                    break;
                case "Product":
                    string selected_pro_id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    var formp = new ChangeProduct(selected_pro_id);
                    formp.ShowDialog();
                    break;
                case "":
                    MessageBox.Show("No object selected");
                    break;
            }

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            switch (this.manage)
            {
                case "Customer":
                    break;
                case "Employee":

                    break;
                case "Category":
                    string selected_cat_id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    var formc = new RemoveCategory(selected_cat_id);
                    formc.ShowDialog();
                    break;
                case "Product":
                    string selected_pro_id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                    var formp = new RemoveProduct(selected_pro_id);
                    formp.ShowDialog();
                    break;
                case "":
                    MessageBox.Show("No object selected");
                    break;

            }
        }
    }
}
