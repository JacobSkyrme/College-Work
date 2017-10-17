namespace Arrays_to_Functions
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
            this.btnGo2 = new System.Windows.Forms.Button();
            this.btnGo1 = new System.Windows.Forms.Button();
            this.txtTotal2 = new System.Windows.Forms.TextBox();
            this.txtTotal1 = new System.Windows.Forms.TextBox();
            this.txtNumbers1 = new System.Windows.Forms.TextBox();
            this.txtNumbers2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGo2
            // 
            this.btnGo2.Location = new System.Drawing.Point(421, 324);
            this.btnGo2.Name = "btnGo2";
            this.btnGo2.Size = new System.Drawing.Size(75, 23);
            this.btnGo2.TabIndex = 11;
            this.btnGo2.Text = "Go";
            this.btnGo2.UseVisualStyleBackColor = true;
            this.btnGo2.Click += new System.EventHandler(this.btnGo2_Click);
            // 
            // btnGo1
            // 
            this.btnGo1.Location = new System.Drawing.Point(141, 325);
            this.btnGo1.Name = "btnGo1";
            this.btnGo1.Size = new System.Drawing.Size(75, 23);
            this.btnGo1.TabIndex = 10;
            this.btnGo1.Text = "Go";
            this.btnGo1.UseVisualStyleBackColor = true;
            this.btnGo1.Click += new System.EventHandler(this.btnGo1_Click);
            // 
            // txtTotal2
            // 
            this.txtTotal2.Location = new System.Drawing.Point(511, 325);
            this.txtTotal2.Name = "txtTotal2";
            this.txtTotal2.Size = new System.Drawing.Size(100, 20);
            this.txtTotal2.TabIndex = 9;
            // 
            // txtTotal1
            // 
            this.txtTotal1.Location = new System.Drawing.Point(232, 328);
            this.txtTotal1.Name = "txtTotal1";
            this.txtTotal1.Size = new System.Drawing.Size(100, 20);
            this.txtTotal1.TabIndex = 8;
            // 
            // txtNumbers1
            // 
            this.txtNumbers1.Location = new System.Drawing.Point(141, 134);
            this.txtNumbers1.Multiline = true;
            this.txtNumbers1.Name = "txtNumbers1";
            this.txtNumbers1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNumbers1.Size = new System.Drawing.Size(191, 166);
            this.txtNumbers1.TabIndex = 7;
            // 
            // txtNumbers2
            // 
            this.txtNumbers2.Location = new System.Drawing.Point(421, 134);
            this.txtNumbers2.Multiline = true;
            this.txtNumbers2.Name = "txtNumbers2";
            this.txtNumbers2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNumbers2.Size = new System.Drawing.Size(190, 166);
            this.txtNumbers2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGo2);
            this.Controls.Add(this.btnGo1);
            this.Controls.Add(this.txtTotal2);
            this.Controls.Add(this.txtTotal1);
            this.Controls.Add(this.txtNumbers1);
            this.Controls.Add(this.txtNumbers2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnGo2;
        internal System.Windows.Forms.Button btnGo1;
        internal System.Windows.Forms.TextBox txtTotal2;
        internal System.Windows.Forms.TextBox txtTotal1;
        internal System.Windows.Forms.TextBox txtNumbers1;
        internal System.Windows.Forms.TextBox txtNumbers2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

