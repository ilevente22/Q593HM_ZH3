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
    public partial class UserControl_Vasarlofel : UserControl
    {
        BreadOrderContext context = new BreadOrderContext();
        public UserControl_Vasarlofel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Vásárlómegj();
        }

        private void Vásárlómegj()
        {
            var vásárlók = from x in context.Buyers
                           where x.Name.Contains(textBox1.Text)
                           select x;

            listBox1.DataSource = vásárlók.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void UserControl_Vasarlofel_Load(object sender, EventArgs e)
        {
            Vásárlómegj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_ujvasarlo form = new Form_ujvasarlo();

            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Sikerült az új vásárló felvétele");
                Vásárlómegj();
            }
            else
            {
                MessageBox.Show("Nem vett fel új vásárlót");
            }
        }
    }
}
