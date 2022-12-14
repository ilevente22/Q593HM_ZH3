namespace Q593HM_ZH3_Form
{
    partial class UserControl_Rendelesfel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_kenyér = new System.Windows.Forms.TextBox();
            this.textBox_vásárló = new System.Windows.Forms.TextBox();
            this.listBox_kenyér = new System.Windows.Forms.ListBox();
            this.listBox_vásárló = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderSkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vasarlonev = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.buyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Kenyernev = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.breadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pcsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_kenyér
            // 
            this.textBox_kenyér.Location = new System.Drawing.Point(19, 40);
            this.textBox_kenyér.Name = "textBox_kenyér";
            this.textBox_kenyér.Size = new System.Drawing.Size(198, 23);
            this.textBox_kenyér.TabIndex = 0;
            this.textBox_kenyér.TextChanged += new System.EventHandler(this.textBox_kenyér_TextChanged);
            // 
            // textBox_vásárló
            // 
            this.textBox_vásárló.Location = new System.Drawing.Point(677, 40);
            this.textBox_vásárló.Name = "textBox_vásárló";
            this.textBox_vásárló.Size = new System.Drawing.Size(216, 23);
            this.textBox_vásárló.TabIndex = 1;
            this.textBox_vásárló.TextChanged += new System.EventHandler(this.textBox_vásárló_TextChanged);
            // 
            // listBox_kenyér
            // 
            this.listBox_kenyér.FormattingEnabled = true;
            this.listBox_kenyér.ItemHeight = 15;
            this.listBox_kenyér.Location = new System.Drawing.Point(19, 69);
            this.listBox_kenyér.Name = "listBox_kenyér";
            this.listBox_kenyér.Size = new System.Drawing.Size(198, 454);
            this.listBox_kenyér.TabIndex = 2;
            // 
            // listBox_vásárló
            // 
            this.listBox_vásárló.FormattingEnabled = true;
            this.listBox_vásárló.ItemHeight = 15;
            this.listBox_vásárló.Location = new System.Drawing.Point(678, 69);
            this.listBox_vásárló.Name = "listBox_vásárló";
            this.listBox_vásárló.Size = new System.Drawing.Size(216, 454);
            this.listBox_vásárló.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderSkDataGridViewTextBoxColumn,
            this.Vasarlonev,
            this.Kenyernev,
            this.pcsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(224, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(447, 437);
            this.dataGridView1.TabIndex = 4;
            // 
            // orderSkDataGridViewTextBoxColumn
            // 
            this.orderSkDataGridViewTextBoxColumn.DataPropertyName = "OrderSk";
            this.orderSkDataGridViewTextBoxColumn.HeaderText = "OrderSk";
            this.orderSkDataGridViewTextBoxColumn.Name = "orderSkDataGridViewTextBoxColumn";
            // 
            // Vasarlonev
            // 
            this.Vasarlonev.DataPropertyName = "BuyerFk";
            this.Vasarlonev.DataSource = this.buyerBindingSource;
            this.Vasarlonev.DisplayMember = "Name";
            this.Vasarlonev.HeaderText = "BuyerFk";
            this.Vasarlonev.Name = "Vasarlonev";
            this.Vasarlonev.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Vasarlonev.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Vasarlonev.ValueMember = "BuyerId";
            // 
            // buyerBindingSource
            // 
            this.buyerBindingSource.DataSource = typeof(Q593HM_ZH3_Form.Models.Buyer);
            // 
            // Kenyernev
            // 
            this.Kenyernev.DataPropertyName = "BreadFk";
            this.Kenyernev.DataSource = this.breadBindingSource;
            this.Kenyernev.DisplayMember = "FullName";
            this.Kenyernev.HeaderText = "BreadFk";
            this.Kenyernev.Name = "Kenyernev";
            this.Kenyernev.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Kenyernev.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Kenyernev.ValueMember = "BreadId";
            // 
            // breadBindingSource
            // 
            this.breadBindingSource.DataSource = typeof(Q593HM_ZH3_Form.Models.Bread);
            // 
            // pcsDataGridViewTextBoxColumn
            // 
            this.pcsDataGridViewTextBoxColumn.DataPropertyName = "Pcs";
            this.pcsDataGridViewTextBoxColumn.HeaderText = "Pcs";
            this.pcsDataGridViewTextBoxColumn.Name = "pcsDataGridViewTextBoxColumn";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Q593HM_ZH3_Form.Models.Order);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(224, 500);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(172, 23);
            this.numericUpDown1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Rendelés felvétele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kenyerek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(677, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vásárlók";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rendelések";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Darabszám";
            // 
            // UserControl_Rendelesfel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox_vásárló);
            this.Controls.Add(this.listBox_kenyér);
            this.Controls.Add(this.textBox_vásárló);
            this.Controls.Add(this.textBox_kenyér);
            this.Name = "UserControl_Rendelesfel";
            this.Size = new System.Drawing.Size(914, 555);
            this.Load += new System.EventHandler(this.UserControl_Rendelesfel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_kenyér;
        private TextBox textBox_vásárló;
        private ListBox listBox_kenyér;
        private ListBox listBox_vásárló;
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private BindingSource orderBindingSource;
        private BindingSource breadBindingSource;
        private BindingSource buyerBindingSource;
        private DataGridViewTextBoxColumn orderSkDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn Vasarlonev;
        private DataGridViewComboBoxColumn Kenyernev;
        private DataGridViewTextBoxColumn pcsDataGridViewTextBoxColumn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
