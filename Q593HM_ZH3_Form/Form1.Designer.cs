namespace Q593HM_ZH3_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_ujvasarlo = new System.Windows.Forms.Button();
            this.button_ujrendeles = new System.Windows.Forms.Button();
            this.button_rendelestorles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_ujvasarlo
            // 
            this.button_ujvasarlo.Location = new System.Drawing.Point(12, 129);
            this.button_ujvasarlo.Name = "button_ujvasarlo";
            this.button_ujvasarlo.Size = new System.Drawing.Size(154, 91);
            this.button_ujvasarlo.TabIndex = 0;
            this.button_ujvasarlo.Text = "Vásárló felvétele";
            this.button_ujvasarlo.UseVisualStyleBackColor = true;
            this.button_ujvasarlo.Click += new System.EventHandler(this.button_ujvasarlo_Click);
            // 
            // button_ujrendeles
            // 
            this.button_ujrendeles.Location = new System.Drawing.Point(12, 226);
            this.button_ujrendeles.Name = "button_ujrendeles";
            this.button_ujrendeles.Size = new System.Drawing.Size(154, 91);
            this.button_ujrendeles.TabIndex = 1;
            this.button_ujrendeles.Text = "Rendelés Felvétele";
            this.button_ujrendeles.UseVisualStyleBackColor = true;
            this.button_ujrendeles.Click += new System.EventHandler(this.button_ujrendeles_Click);
            // 
            // button_rendelestorles
            // 
            this.button_rendelestorles.Location = new System.Drawing.Point(12, 323);
            this.button_rendelestorles.Name = "button_rendelestorles";
            this.button_rendelestorles.Size = new System.Drawing.Size(154, 91);
            this.button_rendelestorles.TabIndex = 2;
            this.button_rendelestorles.Text = "Rendelés törlése";
            this.button_rendelestorles.UseVisualStyleBackColor = true;
            this.button_rendelestorles.Click += new System.EventHandler(this.button_rendelestorles_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(205, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 555);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_rendelestorles);
            this.Controls.Add(this.button_ujrendeles);
            this.Controls.Add(this.button_ujvasarlo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_ujvasarlo;
        private Button button_ujrendeles;
        private Button button_rendelestorles;
        private Panel panel1;
    }
}