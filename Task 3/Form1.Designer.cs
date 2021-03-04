
namespace WindowsFormsApp_ModeMedian
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMean = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMedian = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStandardDev = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVariance = new System.Windows.Forms.TextBox();
            this.lbxValues = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMean
            // 
            this.txtMean.Location = new System.Drawing.Point(115, 267);
            this.txtMean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMean.Name = "txtMean";
            this.txtMean.Size = new System.Drawing.Size(552, 22);
            this.txtMean.TabIndex = 1;
            this.txtMean.TextChanged += new System.EventHandler(this.txtMean_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(611, 95);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mean";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(611, 161);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(139, 44);
            this.txtValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(132, 22);
            this.txtValue.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mode";
            // 
            // txtMode
            // 
            this.txtMode.Location = new System.Drawing.Point(115, 311);
            this.txtMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(552, 22);
            this.txtMode.TabIndex = 1;
            this.txtMode.TextChanged += new System.EventHandler(this.txtMode_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Median";
            // 
            // txtMedian
            // 
            this.txtMedian.Location = new System.Drawing.Point(115, 348);
            this.txtMedian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMedian.Name = "txtMedian";
            this.txtMedian.Size = new System.Drawing.Size(552, 22);
            this.txtMedian.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 384);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "SD";
            // 
            // txtStandardDev
            // 
            this.txtStandardDev.Location = new System.Drawing.Point(115, 378);
            this.txtStandardDev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStandardDev.Name = "txtStandardDev";
            this.txtStandardDev.Size = new System.Drawing.Size(552, 22);
            this.txtStandardDev.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(184, 455);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(12, 461);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(118, 16);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "Number of Values:";
            this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 410);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Variance";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtVariance
            // 
            this.txtVariance.Location = new System.Drawing.Point(115, 410);
            this.txtVariance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVariance.Name = "txtVariance";
            this.txtVariance.Size = new System.Drawing.Size(552, 22);
            this.txtVariance.TabIndex = 1;
            // 
            // lbxValues
            // 
            this.lbxValues.FormattingEnabled = true;
            this.lbxValues.ItemHeight = 16;
            this.lbxValues.Location = new System.Drawing.Point(139, 95);
            this.lbxValues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxValues.Name = "lbxValues";
            this.lbxValues.Size = new System.Drawing.Size(132, 148);
            this.lbxValues.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(768, 548);
            this.Controls.Add(this.lbxValues);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txtVariance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStandardDev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMedian);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMean);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Meausres of Center";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMean;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMedian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStandardDev;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVariance;
        private System.Windows.Forms.ListBox lbxValues;
    }
}

