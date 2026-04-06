namespace CalculatorApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtDisplay;

        private System.Windows.Forms.Button btn0, btn1, btn2, btn3, btn4,
                                            btn5, btn6, btn7, btn8, btn9;

        private System.Windows.Forms.Button btnAdd, btnSub, btnMul, btnDiv;
        private System.Windows.Forms.Button btnEqual, btnClear, btnDot;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();

            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();

            this.btnEqual = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // txtDisplay
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Size = new System.Drawing.Size(260, 35);
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // Buttons Row 1
            btn7.SetBounds(12, 60, 60, 40); btn7.Text = "7";
            btn8.SetBounds(78, 60, 60, 40); btn8.Text = "8";
            btn9.SetBounds(144, 60, 60, 40); btn9.Text = "9";
            btnDiv.SetBounds(210, 60, 60, 40); btnDiv.Text = "/";

            // Row 2
            btn4.SetBounds(12, 110, 60, 40); btn4.Text = "4";
            btn5.SetBounds(78, 110, 60, 40); btn5.Text = "5";
            btn6.SetBounds(144, 110, 60, 40); btn6.Text = "6";
            btnMul.SetBounds(210, 110, 60, 40); btnMul.Text = "*";

            // Row 3
            btn1.SetBounds(12, 160, 60, 40); btn1.Text = "1";
            btn2.SetBounds(78, 160, 60, 40); btn2.Text = "2";
            btn3.SetBounds(144, 160, 60, 40); btn3.Text = "3";
            btnSub.SetBounds(210, 160, 60, 40); btnSub.Text = "-";

            // Row 4
            btn0.SetBounds(12, 210, 60, 40); btn0.Text = "0";
            btnDot.SetBounds(78, 210, 60, 40); btnDot.Text = ".";
            btnEqual.SetBounds(144, 210, 60, 40); btnEqual.Text = "=";
            btnAdd.SetBounds(210, 210, 60, 40); btnAdd.Text = "+";

            // Row 5
            btnClear.SetBounds(12, 260, 258, 40); btnClear.Text = "C";

            // Add Controls
            this.Controls.Add(txtDisplay);

            this.Controls.Add(btn0); this.Controls.Add(btn1); this.Controls.Add(btn2);
            this.Controls.Add(btn3); this.Controls.Add(btn4); this.Controls.Add(btn5);
            this.Controls.Add(btn6); this.Controls.Add(btn7); this.Controls.Add(btn8);
            this.Controls.Add(btn9);

            this.Controls.Add(btnAdd); this.Controls.Add(btnSub);
            this.Controls.Add(btnMul); this.Controls.Add(btnDiv);

            this.Controls.Add(btnEqual); this.Controls.Add(btnClear);
            this.Controls.Add(btnDot);

            // Events
            btn0.Click += new System.EventHandler(this.number_Click);
            btn1.Click += new System.EventHandler(this.number_Click);
            btn2.Click += new System.EventHandler(this.number_Click);
            btn3.Click += new System.EventHandler(this.number_Click);
            btn4.Click += new System.EventHandler(this.number_Click);
            btn5.Click += new System.EventHandler(this.number_Click);
            btn6.Click += new System.EventHandler(this.number_Click);
            btn7.Click += new System.EventHandler(this.number_Click);
            btn8.Click += new System.EventHandler(this.number_Click);
            btn9.Click += new System.EventHandler(this.number_Click);
            btnDot.Click += new System.EventHandler(this.number_Click);

            btnAdd.Click += new System.EventHandler(this.operator_Click);
            btnSub.Click += new System.EventHandler(this.operator_Click);
            btnMul.Click += new System.EventHandler(this.operator_Click);
            btnDiv.Click += new System.EventHandler(this.operator_Click);

            btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Form Settings
            this.ClientSize = new System.Drawing.Size(284, 320);
            this.Name = "Form1";
            this.Text = "Simple Calculator";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}