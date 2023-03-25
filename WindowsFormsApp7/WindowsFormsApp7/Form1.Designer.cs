namespace WindowsFormsApp7
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
            this.btnResult = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lbldisplayA = new System.Windows.Forms.TextBox();
            this.lbldisplayResult = new System.Windows.Forms.TextBox();
            this.lbldisplayC = new System.Windows.Forms.TextBox();
            this.lbldisplayB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(230, 506);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(82, 44);
            this.btnResult.TabIndex = 0;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(358, 506);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(82, 44);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // lbldisplayA
            // 
            this.lbldisplayA.Location = new System.Drawing.Point(216, 104);
            this.lbldisplayA.Multiline = true;
            this.lbldisplayA.Name = "lbldisplayA";
            this.lbldisplayA.Size = new System.Drawing.Size(243, 66);
            this.lbldisplayA.TabIndex = 2;
            // 
            // lbldisplayResult
            // 
            this.lbldisplayResult.Location = new System.Drawing.Point(216, 401);
            this.lbldisplayResult.Multiline = true;
            this.lbldisplayResult.Name = "lbldisplayResult";
            this.lbldisplayResult.Size = new System.Drawing.Size(243, 66);
            this.lbldisplayResult.TabIndex = 3;
            this.lbldisplayResult.TextChanged += new System.EventHandler(this.txtresult_TextChanged);
            // 
            // lbldisplayC
            // 
            this.lbldisplayC.Location = new System.Drawing.Point(216, 300);
            this.lbldisplayC.Multiline = true;
            this.lbldisplayC.Name = "lbldisplayC";
            this.lbldisplayC.Size = new System.Drawing.Size(243, 66);
            this.lbldisplayC.TabIndex = 4;
            // 
            // lbldisplayB
            // 
            this.lbldisplayB.Location = new System.Drawing.Point(216, 203);
            this.lbldisplayB.Multiline = true;
            this.lbldisplayB.Name = "lbldisplayB";
            this.lbldisplayB.Size = new System.Drawing.Size(243, 66);
            this.lbldisplayB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 134);
            this.label1.MaximumSize = new System.Drawing.Size(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "a";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(142, 230);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(15, 16);
            this.b.TabIndex = 7;
            this.b.Text = "b";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "c";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "SOLVE THE 2ND ORDER EQUATION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 617);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbldisplayB);
            this.Controls.Add(this.lbldisplayC);
            this.Controls.Add(this.lbldisplayResult);
            this.Controls.Add(this.lbldisplayA);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnResult);
            this.Name = "Form1";
            this.Text = "2nd order equation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox lbldisplayA;
        private System.Windows.Forms.TextBox lbldisplayResult;
        private System.Windows.Forms.TextBox lbldisplayC;
        private System.Windows.Forms.TextBox lbldisplayB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

