namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEgal = new System.Windows.Forms.Button();
            this.btnNrNeg = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn7Adn = new System.Windows.Forms.Button();
            this.btnInmultire = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn7Scad = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnRadical = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn7Imp = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(59, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 60);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEgal
            // 
            this.btnEgal.Location = new System.Drawing.Point(252, 481);
            this.btnEgal.Name = "btnEgal";
            this.btnEgal.Size = new System.Drawing.Size(101, 34);
            this.btnEgal.TabIndex = 55;
            this.btnEgal.Text = "=";
            this.btnEgal.UseVisualStyleBackColor = true;
            this.btnEgal.Click += new System.EventHandler(this.btnEgal_Click);
            // 
            // btnNrNeg
            // 
            this.btnNrNeg.Location = new System.Drawing.Point(90, 481);
            this.btnNrNeg.Name = "btnNrNeg";
            this.btnNrNeg.Size = new System.Drawing.Size(101, 34);
            this.btnNrNeg.TabIndex = 54;
            this.btnNrNeg.Text = "-/+";
            this.btnNrNeg.UseVisualStyleBackColor = true;
            // 
            // btnVirgula
            // 
            this.btnVirgula.Location = new System.Drawing.Point(90, 416);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(51, 39);
            this.btnVirgula.TabIndex = 53;
            this.btnVirgula.Text = ".";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.click_button);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(163, 416);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(51, 39);
            this.btn0.TabIndex = 52;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.click_button);
            // 
            // btn7Adn
            // 
            this.btn7Adn.Location = new System.Drawing.Point(234, 416);
            this.btn7Adn.Name = "btn7Adn";
            this.btn7Adn.Size = new System.Drawing.Size(51, 39);
            this.btn7Adn.TabIndex = 51;
            this.btn7Adn.Text = "+";
            this.btn7Adn.UseVisualStyleBackColor = true;
            this.btn7Adn.Click += new System.EventHandler(this.operator_click_event);
            // 
            // btnInmultire
            // 
            this.btnInmultire.Location = new System.Drawing.Point(302, 416);
            this.btnInmultire.Name = "btnInmultire";
            this.btnInmultire.Size = new System.Drawing.Size(51, 39);
            this.btnInmultire.TabIndex = 50;
            this.btnInmultire.Text = "*";
            this.btnInmultire.UseVisualStyleBackColor = true;
            this.btnInmultire.Click += new System.EventHandler(this.operator_click_event);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(234, 344);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(51, 39);
            this.btn3.TabIndex = 49;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.click_button);
            // 
            // btn7Scad
            // 
            this.btn7Scad.Location = new System.Drawing.Point(302, 344);
            this.btn7Scad.Name = "btn7Scad";
            this.btn7Scad.Size = new System.Drawing.Size(51, 39);
            this.btn7Scad.TabIndex = 48;
            this.btn7Scad.Text = "-";
            this.btn7Scad.UseVisualStyleBackColor = true;
            this.btn7Scad.Click += new System.EventHandler(this.operator_click_event);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(163, 191);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(51, 39);
            this.btn8.TabIndex = 47;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.click_button);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(234, 191);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(51, 39);
            this.btn9.TabIndex = 46;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.click_button);
            // 
            // btnRadical
            // 
            this.btnRadical.Location = new System.Drawing.Point(302, 191);
            this.btnRadical.Name = "btnRadical";
            this.btnRadical.Size = new System.Drawing.Size(51, 39);
            this.btnRadical.TabIndex = 45;
            this.btnRadical.Text = "sqrt";
            this.btnRadical.UseVisualStyleBackColor = true;
            this.btnRadical.Click += new System.EventHandler(this.operator_click_event);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(163, 344);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(51, 39);
            this.btn2.TabIndex = 44;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.click_button);
            // 
            // btn7Imp
            // 
            this.btn7Imp.Location = new System.Drawing.Point(302, 264);
            this.btn7Imp.Name = "btn7Imp";
            this.btn7Imp.Size = new System.Drawing.Size(51, 39);
            this.btn7Imp.TabIndex = 43;
            this.btn7Imp.Text = "/";
            this.btn7Imp.UseVisualStyleBackColor = true;
            this.btn7Imp.Click += new System.EventHandler(this.operator_click_event);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(90, 264);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(51, 39);
            this.btn4.TabIndex = 42;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.click_button);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(163, 264);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(51, 39);
            this.btn5.TabIndex = 41;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.click_button);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(234, 264);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(51, 39);
            this.btn6.TabIndex = 40;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.click_button);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(90, 344);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(51, 39);
            this.btn1.TabIndex = 39;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.click_button);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 39);
            this.button1.TabIndex = 38;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.ClientSizeChanged += new System.EventHandler(this.click_button);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Bisque;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(55, 160);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(331, 388);
            this.listBox2.TabIndex = 37;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(59, 578);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 34);
            this.btnExit.TabIndex = 56;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(252, 578);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 34);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 58;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 624);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEgal);
            this.Controls.Add(this.btnNrNeg);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn7Adn);
            this.Controls.Add(this.btnInmultire);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn7Scad);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnRadical);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn7Imp);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEgal;
        private System.Windows.Forms.Button btnNrNeg;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn7Adn;
        private System.Windows.Forms.Button btnInmultire;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn7Scad;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnRadical;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn7Imp;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
    }
}

