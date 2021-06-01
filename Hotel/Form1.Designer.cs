
namespace Hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBook = new System.Windows.Forms.Button();
            this.LbNumbers = new System.Windows.Forms.ListBox();
            this.dataFrom = new System.Windows.Forms.DateTimePicker();
            this.dataTo = new System.Windows.Forms.DateTimePicker();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.Lselect = new System.Windows.Forms.Label();
            this.Lmoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.Enabled = false;
            this.btnBook.Location = new System.Drawing.Point(645, 337);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(170, 78);
            this.btnBook.TabIndex = 0;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // LbNumbers
            // 
            this.LbNumbers.FormattingEnabled = true;
            this.LbNumbers.ItemHeight = 20;
            this.LbNumbers.Location = new System.Drawing.Point(470, 42);
            this.LbNumbers.Name = "LbNumbers";
            this.LbNumbers.Size = new System.Drawing.Size(184, 64);
            this.LbNumbers.TabIndex = 1;
            // 
            // dataFrom
            // 
            this.dataFrom.Location = new System.Drawing.Point(527, 123);
            this.dataFrom.Name = "dataFrom";
            this.dataFrom.Size = new System.Drawing.Size(235, 27);
            this.dataFrom.TabIndex = 2;
            this.dataFrom.ValueChanged += new System.EventHandler(this.dataFrom_ValueChanged);
            // 
            // dataTo
            // 
            this.dataTo.Location = new System.Drawing.Point(527, 156);
            this.dataTo.Name = "dataTo";
            this.dataTo.Size = new System.Drawing.Size(235, 27);
            this.dataTo.TabIndex = 3;
            this.dataTo.ValueChanged += new System.EventHandler(this.dataTo_ValueChanged);
            // 
            // btnAvailable
            // 
            this.btnAvailable.Location = new System.Drawing.Point(554, 252);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(170, 48);
            this.btnAvailable.TabIndex = 6;
            this.btnAvailable.Text = "Available numbers";
            this.btnAvailable.UseVisualStyleBackColor = true;
            this.btnAvailable.Click += new System.EventHandler(this.btnAvailable_Click);
            // 
            // cbClasses
            // 
            this.cbClasses.FormattingEnabled = true;
            this.cbClasses.Location = new System.Drawing.Point(527, 196);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(239, 28);
            this.cbClasses.TabIndex = 7;
            // 
            // Lselect
            // 
            this.Lselect.AutoSize = true;
            this.Lselect.Location = new System.Drawing.Point(451, 204);
            this.Lselect.Name = "Lselect";
            this.Lselect.Size = new System.Drawing.Size(57, 20);
            this.Lselect.TabIndex = 10;
            this.Lselect.Text = "SELECT";
            // 
            // Lmoney
            // 
            this.Lmoney.AutoSize = true;
            this.Lmoney.Location = new System.Drawing.Point(709, 61);
            this.Lmoney.Name = "Lmoney";
            this.Lmoney.Size = new System.Drawing.Size(15, 20);
            this.Lmoney.TabIndex = 11;
            this.Lmoney.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "DateFrom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "DateTo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 602);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lmoney);
            this.Controls.Add(this.Lselect);
            this.Controls.Add(this.cbClasses);
            this.Controls.Add(this.btnAvailable);
            this.Controls.Add(this.dataTo);
            this.Controls.Add(this.dataFrom);
            this.Controls.Add(this.LbNumbers);
            this.Controls.Add(this.btnBook);
            this.Name = "Form1";
            this.Text = "Hotel \"Sunny resort\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.ListBox LbNumbers;
        private System.Windows.Forms.DateTimePicker dataFrom;
        private System.Windows.Forms.DateTimePicker dataTo;
        private System.Windows.Forms.Button btnAvailable;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.Label Lselect;
        private System.Windows.Forms.Label Lmoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

