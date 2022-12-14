using Q593HM_ZH3_Form.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q593HM_ZH3_Form
{
    public partial class UserControl_Rendelestorl : UserControl
    {
        BreadOrderContext context = new BreadOrderContext();
        public UserControl_Rendelestorl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            rendelesmegj();
        }

        private void rendelesmegj()
        {
            var rendelesek = from x in context.Orders
                             where x.OrderSk.ToString().Contains(textBox1.Text)
                             select x;

            listBox1.DataSource = rendelesek.ToList();
            listBox1.DisplayMember = "OrderSk";
        }

        private void UserControl_Rendelestorl_Load(object sender, EventArgs e)
        {
            breadBindingSource.DataSource = context.Breads.ToList();
            buyerBindingSource.DataSource = context.Buyers.ToList();
            orderBindingSource.DataSource = context.Orders.ToList();

            rendelesmegj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan törölni szeretné a kiválasztott elemet?", "Törlés", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var törlendő = (Order)listBox1.SelectedItem;

                context.Orders.Remove(törlendő);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                rendelesmegj();
                orderBindingSource.DataSource = context.Orders.ToList();
            }

            
        }
    }
}
