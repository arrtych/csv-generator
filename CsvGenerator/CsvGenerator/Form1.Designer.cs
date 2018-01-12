namespace CsvGenerator
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
            this.addColumnName1 = new System.Windows.Forms.ComboBox();
            this.data_box = new System.Windows.Forms.RichTextBox();
            this.addColumnName2 = new System.Windows.Forms.ComboBox();
            this.addColumnName3 = new System.Windows.Forms.ComboBox();
            this.addColumnName4 = new System.Windows.Forms.ComboBox();
            this.addColumnName5 = new System.Windows.Forms.ComboBox();
            this.rows_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addColumnName1
            // 
            this.addColumnName1.FormattingEnabled = true;
            this.addColumnName1.Location = new System.Drawing.Point(29, 36);
            this.addColumnName1.Margin = new System.Windows.Forms.Padding(4);
            this.addColumnName1.Name = "addColumnName1";
            this.addColumnName1.Size = new System.Drawing.Size(136, 28);
            this.addColumnName1.TabIndex = 0;
            this.addColumnName1.Tag = "";
            this.addColumnName1.Text = "ID";
            // 
            // data_box
            // 
            this.data_box.Location = new System.Drawing.Point(29, 98);
            this.data_box.Margin = new System.Windows.Forms.Padding(4);
            this.data_box.Name = "data_box";
            this.data_box.Size = new System.Drawing.Size(855, 259);
            this.data_box.TabIndex = 1;
            this.data_box.Text = "";
            // 
            // addColumnName2
            // 
            this.addColumnName2.FormattingEnabled = true;
            this.addColumnName2.Location = new System.Drawing.Point(204, 36);
            this.addColumnName2.Margin = new System.Windows.Forms.Padding(4);
            this.addColumnName2.Name = "addColumnName2";
            this.addColumnName2.Size = new System.Drawing.Size(136, 28);
            this.addColumnName2.TabIndex = 2;
            this.addColumnName2.Text = "Name";
            // 
            // addColumnName3
            // 
            this.addColumnName3.FormattingEnabled = true;
            this.addColumnName3.Location = new System.Drawing.Point(395, 36);
            this.addColumnName3.Margin = new System.Windows.Forms.Padding(4);
            this.addColumnName3.Name = "addColumnName3";
            this.addColumnName3.Size = new System.Drawing.Size(136, 28);
            this.addColumnName3.TabIndex = 3;
            this.addColumnName3.Text = "Phone";
            // 
            // addColumnName4
            // 
            this.addColumnName4.FormattingEnabled = true;
            this.addColumnName4.Location = new System.Drawing.Point(574, 36);
            this.addColumnName4.Margin = new System.Windows.Forms.Padding(4);
            this.addColumnName4.Name = "addColumnName4";
            this.addColumnName4.Size = new System.Drawing.Size(136, 28);
            this.addColumnName4.TabIndex = 4;
            this.addColumnName4.Text = "City";
            // 
            // addColumnName5
            // 
            this.addColumnName5.FormattingEnabled = true;
            this.addColumnName5.Location = new System.Drawing.Point(748, 36);
            this.addColumnName5.Margin = new System.Windows.Forms.Padding(4);
            this.addColumnName5.Name = "addColumnName5";
            this.addColumnName5.Size = new System.Drawing.Size(136, 28);
            this.addColumnName5.TabIndex = 5;
            this.addColumnName5.Text = "Date";
            // 
            // rows_num
            // 
            this.rows_num.Location = new System.Drawing.Point(991, 33);
            this.rows_num.Margin = new System.Windows.Forms.Padding(4);
            this.rows_num.Name = "rows_num";
            this.rows_num.Size = new System.Drawing.Size(90, 27);
            this.rows_num.TabIndex = 6;
            this.rows_num.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(918, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rows";
            // 
            // generateBtn
            // 
            this.generateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateBtn.Location = new System.Drawing.Point(922, 98);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(159, 38);
            this.generateBtn.TabIndex = 8;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 406);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rows_num);
            this.Controls.Add(this.addColumnName5);
            this.Controls.Add(this.addColumnName4);
            this.Controls.Add(this.addColumnName3);
            this.Controls.Add(this.addColumnName2);
            this.Controls.Add(this.data_box);
            this.Controls.Add(this.addColumnName1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Random data CSV generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox data_box;
        private System.Windows.Forms.ComboBox addColumnName2;
        private System.Windows.Forms.ComboBox addColumnName3;
        private System.Windows.Forms.ComboBox addColumnName4;
        private System.Windows.Forms.ComboBox addColumnName5;
        private System.Windows.Forms.ComboBox addColumnName1;
        private System.Windows.Forms.TextBox rows_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateBtn;
    }
}

