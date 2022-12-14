namespace Q593HM_ZH3_Form
{
    partial class Form_ujvasarlo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_név = new System.Windows.Forms.TextBox();
            this.textBox_szemelyi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_név
            // 
            this.textBox_név.Location = new System.Drawing.Point(196, 62);
            this.textBox_név.Name = "textBox_név";
            this.textBox_név.Size = new System.Drawing.Size(186, 23);
            this.textBox_név.TabIndex = 0;
            this.textBox_név.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_név_Validating);
            this.textBox_név.Validated += new System.EventHandler(this.textBox_név_Validated);
            // 
            // textBox_szemelyi
            // 
            this.textBox_szemelyi.Location = new System.Drawing.Point(196, 121);
            this.textBox_szemelyi.Name = "textBox_szemelyi";
            this.textBox_szemelyi.Size = new System.Drawing.Size(186, 23);
            this.textBox_szemelyi.TabIndex = 1;
            this.textBox_szemelyi.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_szemelyi_Validating);
            this.textBox_szemelyi.Validated += new System.EventHandler(this.textBox_szemelyi_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vásárló neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vásárló személyigazolvány száma";
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(421, 244);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(79, 32);
            this.button_Ok.TabIndex = 4;
            this.button_Ok.Text = "OK";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.CausesValidation = false;
            this.button_Cancel.Location = new System.Drawing.Point(510, 244);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(79, 32);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_ujvasarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 288);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_szemelyi);
            this.Controls.Add(this.textBox_név);
            this.Name = "Form_ujvasarlo";
            this.Text = "Form_ujvasarlo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_név;
        private TextBox textBox_szemelyi;
        private Label label1;
        private Label label2;
        private Button button_Ok;
        private Button button_Cancel;
        private ErrorProvider errorProvider1;
    }
}