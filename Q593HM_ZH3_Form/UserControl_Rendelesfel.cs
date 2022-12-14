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
    public partial class UserControl_Rendelesfel : UserControl
    {
        BreadOrderContext context = new BreadOrderContext();
        public UserControl_Rendelesfel()
        {
            InitializeComponent();
        }

        private void textBox_kenyér_TextChanged(object sender, EventArgs e)
        {
            Kenyérmegj();

        }

        private void Kenyérmegj()
        {
            var kenyerek = from x in context.Breads
                           where x.FullName.Contains(textBox_kenyér.Text)
                           select x;

            listBox_kenyér.DataSource = kenyerek.ToList();
            listBox_kenyér.DisplayMember = "FullName";
        }

        private void textBox_vásárló_TextChanged(object sender, EventArgs e)
        {
            Vásárlómegj();
        }

        private void Vásárlómegj()
        {
            var vásárlók = from x in context.Buyers
                           where x.Name.Contains(textBox_vásárló.Text)
                           select x;

            listBox_vásárló.DataSource = vásárlók.ToList();
            listBox_vásárló.DisplayMember = "Name";
        }

        private void UserControl_Rendelesfel_Load(object sender, EventArgs e)
        {
            breadBindingSource.DataSource = context.Breads.ToList();
            buyerBindingSource.DataSource = context.Buyers.ToList();
            orderBindingSource.DataSource = context.Orders.ToList();

            Kenyérmegj();
            Vásárlómegj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var választottkenyér = (Bread)listBox_kenyér.SelectedItem;
            var választottvásárló = (Buyer)listBox_vásárló.SelectedItem;
            int darab = int.Parse(numericUpDown1.Value.ToString());

            Order újrendelés = new Order()
            {
                BreadFk = választottkenyér.BreadId,
                BuyerFk = választottvásárló.BuyerId,
                Pcs = darab
            };

            context.Orders.Add(újrendelés);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            orderBindingSource.DataSource = context.Orders.ToList();
        }
    }
}
