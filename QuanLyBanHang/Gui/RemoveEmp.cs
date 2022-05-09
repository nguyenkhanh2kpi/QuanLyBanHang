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
    public partial class RemoveEmp : Form
    {
        Employee emp;
        public RemoveEmp(Employee emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void RemoveEmp_Load(object sender, EventArgs e)
        {
            labelID.Text = this.emp.id.ToString();
            labelName.Text = this.emp.e_name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var db = new QuanLyBanHang1Entities())
            {
                Employee Emp = db.Employees.FirstOrDefault(emp => emp.id == this.emp.id);
                db.Employees.Remove(Emp);
                db.SaveChanges();
                MessageBox.Show("SUCCESS");
                this.Close();
            }
        }
    }
}
