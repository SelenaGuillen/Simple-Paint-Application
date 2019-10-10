namespace Paint
{
    partial class Paint
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.shapeBox = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.thicBox = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.yelBtn = new System.Windows.Forms.RadioButton();
            this.bluBtn = new System.Windows.Forms.RadioButton();
            this.redBtn = new System.Windows.Forms.RadioButton();
            this.blkBtn = new System.Windows.Forms.RadioButton();
            this.clrBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 501);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.shapeBox);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.thicBox);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.clrBtn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 117);
            this.panel2.TabIndex = 0;
            // 
            // shapeBox
            // 
            this.shapeBox.CausesValidation = false;
            this.shapeBox.FormattingEnabled = true;
            this.shapeBox.Items.AddRange(new object[] {
            "Free Draw",
            "Line",
            "Rectangle",
            "Oval"});
            this.shapeBox.Location = new System.Drawing.Point(381, 20);
            this.shapeBox.Name = "shapeBox";
            this.shapeBox.Size = new System.Drawing.Size(121, 21);
            this.shapeBox.TabIndex = 9;
            this.shapeBox.Text = "Shape";
            this.shapeBox.SelectionChangeCommitted += new System.EventHandler(this.ShapeBox_SelectionChangeCommitted);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(381, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 13);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Shape:";
            // 
            // thicBox
            // 
            this.thicBox.CausesValidation = false;
            this.thicBox.FormattingEnabled = true;
            this.thicBox.Items.AddRange(new object[] {
            "Thin",
            "Normal",
            "Thick"});
            this.thicBox.Location = new System.Drawing.Point(204, 20);
            this.thicBox.Name = "thicBox";
            this.thicBox.Size = new System.Drawing.Size(121, 21);
            this.thicBox.TabIndex = 7;
            this.thicBox.Text = "Thickness";
            this.thicBox.SelectionChangeCommitted += new System.EventHandler(this.ThicBox_SelectionChangeCommitted);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(204, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Thickness:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(49, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Color:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.yelBtn);
            this.panel3.Controls.Add(this.bluBtn);
            this.panel3.Controls.Add(this.redBtn);
            this.panel3.Controls.Add(this.blkBtn);
            this.panel3.Location = new System.Drawing.Point(45, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(126, 91);
            this.panel3.TabIndex = 3;
            // 
            // yelBtn
            // 
            this.yelBtn.AutoSize = true;
            this.yelBtn.Location = new System.Drawing.Point(4, 50);
            this.yelBtn.Name = "yelBtn";
            this.yelBtn.Size = new System.Drawing.Size(56, 17);
            this.yelBtn.TabIndex = 3;
            this.yelBtn.TabStop = true;
            this.yelBtn.Text = "Yellow";
            this.yelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yelBtn.UseVisualStyleBackColor = true;
            this.yelBtn.CheckedChanged += new System.EventHandler(this.YelBtn_CheckedChanged);
            // 
            // bluBtn
            // 
            this.bluBtn.AutoSize = true;
            this.bluBtn.Location = new System.Drawing.Point(4, 71);
            this.bluBtn.Name = "bluBtn";
            this.bluBtn.Size = new System.Drawing.Size(46, 17);
            this.bluBtn.TabIndex = 2;
            this.bluBtn.TabStop = true;
            this.bluBtn.Text = "Blue";
            this.bluBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bluBtn.UseVisualStyleBackColor = true;
            this.bluBtn.CheckedChanged += new System.EventHandler(this.BluBtn_CheckedChanged);
            // 
            // redBtn
            // 
            this.redBtn.AutoSize = true;
            this.redBtn.Location = new System.Drawing.Point(3, 27);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(45, 17);
            this.redBtn.TabIndex = 1;
            this.redBtn.TabStop = true;
            this.redBtn.Text = "Red";
            this.redBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.redBtn.UseVisualStyleBackColor = true;
            this.redBtn.CheckedChanged += new System.EventHandler(this.RedBtn_CheckedChanged);
            // 
            // blkBtn
            // 
            this.blkBtn.AutoSize = true;
            this.blkBtn.Checked = true;
            this.blkBtn.Location = new System.Drawing.Point(4, 4);
            this.blkBtn.Name = "blkBtn";
            this.blkBtn.Size = new System.Drawing.Size(52, 17);
            this.blkBtn.TabIndex = 0;
            this.blkBtn.TabStop = true;
            this.blkBtn.Text = "Black";
            this.blkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.blkBtn.UseVisualStyleBackColor = true;
            this.blkBtn.CheckedChanged += new System.EventHandler(this.BlkBtn_CheckedChanged);
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(446, 87);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(75, 23);
            this.clrBtn.TabIndex = 2;
            this.clrBtn.Text = "CLEAR";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.BackColorChanged += new System.EventHandler(this.Panel1_Click);
            this.clrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 501);
            this.Controls.Add(this.panel1);
            this.Name = "Paint";
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton yelBtn;
        private System.Windows.Forms.RadioButton bluBtn;
        private System.Windows.Forms.RadioButton redBtn;
        private System.Windows.Forms.RadioButton blkBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox thicBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox shapeBox;
    }
}

