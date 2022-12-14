using Q593HM_ZH3_Form.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q593HM_ZH3_Form
{
    public partial class Form_ujvasarlo : Form
    {
        BreadOrderContext context = new BreadOrderContext();
        public Form_ujvasarlo()
        {
            InitializeComponent();
        }

        private void textBox_név_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_név.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(textBox_név, "A név mező nem maradhat üresen");
                }
        }

        private void textBox_név_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox_név, "");
        }

        private void textBox_szemelyi_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex("^[0-9]{6}[A-Z]{2}$");
            if (!r.IsMatch(textBox_szemelyi.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox_szemelyi, "Az igazolványszámot a következő formátumban kell megadni: hat szám, két betű");
            }
        }

        private void textBox_szemelyi_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox_szemelyi, "");
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                Buyer újvásárló = new Buyer()
                {
                    Name = textBox_név.Text,
                    Idnumber = textBox_szemelyi.Text
                };

                context.Buyers.Add(újvásárló);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }
    }
}
