namespace CBS
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnyakinlastir = new System.Windows.Forms.Button();
            this.btnuzaklastir = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnmerkezle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 311);
            this.panel1.TabIndex = 0;
            // 
            // btnyakinlastir
            // 
            this.btnyakinlastir.Location = new System.Drawing.Point(12, 12);
            this.btnyakinlastir.Name = "btnyakinlastir";
            this.btnyakinlastir.Size = new System.Drawing.Size(75, 23);
            this.btnyakinlastir.TabIndex = 1;
            this.btnyakinlastir.Text = "Yakınlaştır";
            this.btnyakinlastir.UseVisualStyleBackColor = true;
            this.btnyakinlastir.Click += new System.EventHandler(this.btnyakinlastir_Click);
            // 
            // btnuzaklastir
            // 
            this.btnuzaklastir.Location = new System.Drawing.Point(93, 12);
            this.btnuzaklastir.Name = "btnuzaklastir";
            this.btnuzaklastir.Size = new System.Drawing.Size(75, 23);
            this.btnuzaklastir.TabIndex = 2;
            this.btnuzaklastir.Text = "Uzaklaştır";
            this.btnuzaklastir.UseVisualStyleBackColor = true;
            this.btnuzaklastir.Click += new System.EventHandler(this.btnuzaklastir_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(255, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnmerkezle
            // 
            this.btnmerkezle.Location = new System.Drawing.Point(174, 12);
            this.btnmerkezle.Name = "btnmerkezle";
            this.btnmerkezle.Size = new System.Drawing.Size(75, 23);
            this.btnmerkezle.TabIndex = 4;
            this.btnmerkezle.Text = "İşaretle";
            this.btnmerkezle.UseVisualStyleBackColor = true;
            this.btnmerkezle.Click += new System.EventHandler(this.btnmerkezle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 367);
            this.Controls.Add(this.btnmerkezle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnuzaklastir);
            this.Controls.Add(this.btnyakinlastir);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnyakinlastir;
        private System.Windows.Forms.Button btnuzaklastir;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnmerkezle;
    }
}

