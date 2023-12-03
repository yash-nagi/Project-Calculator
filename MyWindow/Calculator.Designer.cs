namespace MyWindow
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.btnclear = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnzero = new System.Windows.Forms.Button();
            this.btndecimal = new System.Windows.Forms.Button();
            this.btnequalsto = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(12, 124);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(57, 42);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "CLR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(75, 124);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(59, 42);
            this.btndiv.TabIndex = 2;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmultiply
            // 
            this.btnmultiply.Location = new System.Drawing.Point(140, 124);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(57, 42);
            this.btnmultiply.TabIndex = 3;
            this.btnmultiply.Text = "*";
            this.btnmultiply.UseVisualStyleBackColor = true;
            this.btnmultiply.Click += new System.EventHandler(this.btnmultiply_Click);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(203, 124);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(57, 42);
            this.btnsub.TabIndex = 4;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 172);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(57, 42);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(75, 172);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(59, 42);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(140, 172);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(57, 42);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(203, 172);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(57, 90);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 220);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(57, 42);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(75, 220);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(59, 42);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(140, 220);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(57, 42);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 268);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(57, 42);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(75, 268);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(59, 42);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(140, 268);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(57, 42);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnzero
            // 
            this.btnzero.Location = new System.Drawing.Point(12, 316);
            this.btnzero.Name = "btnzero";
            this.btnzero.Size = new System.Drawing.Size(122, 42);
            this.btnzero.TabIndex = 15;
            this.btnzero.Text = "0";
            this.btnzero.UseVisualStyleBackColor = true;
            this.btnzero.Click += new System.EventHandler(this.btnzero_Click);
            // 
            // btndecimal
            // 
            this.btndecimal.Location = new System.Drawing.Point(140, 316);
            this.btndecimal.Name = "btndecimal";
            this.btndecimal.Size = new System.Drawing.Size(57, 42);
            this.btndecimal.TabIndex = 16;
            this.btndecimal.Text = ".";
            this.btndecimal.UseVisualStyleBackColor = true;
            this.btndecimal.Click += new System.EventHandler(this.btndecimal_Click);
            // 
            // btnequalsto
            // 
            this.btnequalsto.Location = new System.Drawing.Point(203, 268);
            this.btnequalsto.Name = "btnequalsto";
            this.btnequalsto.Size = new System.Drawing.Size(57, 90);
            this.btnequalsto.TabIndex = 17;
            this.btnequalsto.Text = "=";
            this.btnequalsto.UseVisualStyleBackColor = true;
            this.btnequalsto.Click += new System.EventHandler(this.btnequalsto_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(12, 12);
            this.result.Name = "result";
            this.result.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.result.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.result.Size = new System.Drawing.Size(248, 96);
            this.result.TabIndex = 18;
            this.result.Text = "0";
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 369);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btnequalsto);
            this.Controls.Add(this.btndecimal);
            this.Controls.Add(this.btnzero);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnmultiply);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnclear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnclear;
        private Button btndiv;
        private Button btnmultiply;
        private Button btnsub;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnadd;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnzero;
        private Button btndecimal;
        private Button btnequalsto;
        private RichTextBox result;
    }
}