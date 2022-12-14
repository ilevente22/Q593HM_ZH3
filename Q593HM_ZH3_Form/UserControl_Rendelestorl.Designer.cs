namespace Q593HM_ZH3_Form
{
    partial class UserControl_Rendelestorl
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.breadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderSkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vasarlonev = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kenyernev = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pcsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(84, 140);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 334);
            this.listBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderSkDataGridViewTextBoxColumn,
            this.Vasarlonev,
            this.kenyernev,
            this.pcsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(378, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(452, 376);
            this.dataGridView1.TabIndex = 2;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Q593HM_ZH3_Form.Models.Order);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Törlés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // breadBindingSource
            // 
            this.breadBindingSource.DataSource = typeof(Q593HM_ZH3_Form.Models.Bread);
            // 
            // buyerBindingSource
            // 
            this.buyerBindingSource.DataSource = typeof(Q593HM_ZH3_Form.Models.Buyer);
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
            // kenyernev
            // 
            this.kenyernev.DataPropertyName = "BreadFk";
            this.kenyernev.DataSource = this.breadBindingSource;
            this.kenyernev.DisplayMember = "FullName";
            this.kenyernev.HeaderText = "BreadFk";
            this.kenyernev.Name = "kenyernev";
            this.kenyernev.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kenyernev.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.kenyernev.ValueMember = "BreadId";
            // 
            // pcsDataGridViewTextBoxColumn
            // 
            this.pcsDataGridViewTextBoxColumn.DataPropertyName = "Pcs";
            this.pcsDataGridViewTextBoxColumn.HeaderText = "Pcs";
            this.pcsDataGridViewTextBoxColumn.Name = "pcsDataGridViewTextBoxColumn";
            // 
            // UserControl_Rendelestorl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "UserControl_Rendelestorl";
            this.Size = new System.Drawing.Size(914, 555);
            this.Load += new System.EventHandler(this.UserControl_Rendelestorl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private Button button1;
        private BindingSource orderBindingSource;
        private BindingSource breadBindingSource;
        private BindingSource buyerBindingSource;
        private DataGridViewTextBoxColumn orderSkDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn Vasarlonev;
        private DataGridViewComboBoxColumn kenyernev;
        private DataGridViewTextBoxColumn pcsDataGridViewTextBoxColumn;
    }
}
