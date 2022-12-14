namespace Q593HM_ZH3_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ujvasarlo_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl_Vasarlofel userc = new UserControl_Vasarlofel();
            userc.Dock = DockStyle.Fill;
            panel1.Controls.Add(userc);
        }

        private void button_ujrendeles_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl_Rendelesfel userc = new UserControl_Rendelesfel();
            userc.Dock = DockStyle.Fill;
            panel1.Controls.Add(userc);
        }

        private void button_rendelestorles_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl_Rendelestorl userc = new UserControl_Rendelestorl();
            userc.Dock = DockStyle.Fill;
            panel1.Controls.Add(userc);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan ki akar lépni?", "Kilépés", MessageBoxButtons.OKCancel) == DialogResult.Cancel) e.Cancel = true;
        }
    }
}