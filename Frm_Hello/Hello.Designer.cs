namespace Frm_Hello
{
    partial class Hello
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hello));
            this.btnHello1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labName4 = new System.Windows.Forms.Label();
            this.labName3 = new System.Windows.Forms.Label();
            this.labName2 = new System.Windows.Forms.Label();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.labName1 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.btnHello2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHello1
            // 
            this.btnHello1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello1.Image = global::Frm_Hello.Properties.Resources.按鈕;
            this.btnHello1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHello1.Location = new System.Drawing.Point(238, 318);
            this.btnHello1.Name = "btnHello1";
            this.btnHello1.Size = new System.Drawing.Size(143, 98);
            this.btnHello1.TabIndex = 21;
            this.btnHello1.Text = "Say Hi";
            this.btnHello1.UseVisualStyleBackColor = true;
            this.btnHello1.Click += new System.EventHandler(this.btnHello1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(337, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 26);
            this.label4.TabIndex = 20;
            // 
            // labName4
            // 
            this.labName4.AutoSize = true;
            this.labName4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName4.Location = new System.Drawing.Point(245, 252);
            this.labName4.Name = "labName4";
            this.labName4.Size = new System.Drawing.Size(64, 26);
            this.labName4.TabIndex = 19;
            this.labName4.Text = "星座 :";
            // 
            // labName3
            // 
            this.labName3.AutoSize = true;
            this.labName3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName3.Location = new System.Drawing.Point(245, 213);
            this.labName3.Name = "labName3";
            this.labName3.Size = new System.Drawing.Size(64, 26);
            this.labName3.TabIndex = 18;
            this.labName3.Text = "性別 :";
            // 
            // labName2
            // 
            this.labName2.AutoSize = true;
            this.labName2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName2.Location = new System.Drawing.Point(246, 155);
            this.labName2.Name = "labName2";
            this.labName2.Size = new System.Drawing.Size(168, 24);
            this.labName2.TabIndex = 17;
            this.labName2.Text = "ENGLISH NAME :";
            // 
            // txtBox4
            // 
            this.txtBox4.Location = new System.Drawing.Point(436, 252);
            this.txtBox4.Multiline = true;
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(144, 41);
            this.txtBox4.TabIndex = 16;
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(436, 200);
            this.txtBox3.Multiline = true;
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(144, 39);
            this.txtBox3.TabIndex = 15;
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(436, 139);
            this.txtBox2.Multiline = true;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(144, 40);
            this.txtBox2.TabIndex = 14;
            // 
            // labName1
            // 
            this.labName1.AutoSize = true;
            this.labName1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName1.Location = new System.Drawing.Point(245, 91);
            this.labName1.Name = "labName1";
            this.labName1.Size = new System.Drawing.Size(64, 26);
            this.labName1.TabIndex = 13;
            this.labName1.Text = "姓名 :";
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(436, 82);
            this.txtBox1.Multiline = true;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(144, 35);
            this.txtBox1.TabIndex = 12;
            // 
            // btnHello2
            // 
            this.btnHello2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello2.Image = global::Frm_Hello.Properties.Resources.按鈕;
            this.btnHello2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHello2.Location = new System.Drawing.Point(426, 318);
            this.btnHello2.Name = "btnHello2";
            this.btnHello2.Size = new System.Drawing.Size(154, 95);
            this.btnHello2.TabIndex = 11;
            this.btnHello2.Text = "Say Hello";
            this.btnHello2.UseVisualStyleBackColor = true;
            this.btnHello2.Click += new System.EventHandler(this.btnHello2_Click);
            // 
            // Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(888, 568);
            this.Controls.Add(this.btnHello1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labName4);
            this.Controls.Add(this.labName3);
            this.Controls.Add(this.labName2);
            this.Controls.Add(this.txtBox4);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.labName1);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.btnHello2);
            this.Name = "Hello";
            this.Text = "Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.Button btnHello1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labName4;
        private System.Windows.Forms.Label labName3;
        private System.Windows.Forms.Label labName2;
        private System.Windows.Forms.TextBox txtBox4;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Label labName1;
        private System.Windows.Forms.TextBox txtBox1;
        protected internal System.Windows.Forms.Button btnHello2;
    }
}

