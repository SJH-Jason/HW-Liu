namespace Lab_Guess
{
    partial class Guess
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
            this.btnguess = new System.Windows.Forms.Button();
            this.btnanswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelshow = new System.Windows.Forms.Panel();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnenter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultshow = new System.Windows.Forms.Label();
            this.panelshow.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnguess
            // 
            this.btnguess.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnguess.Location = new System.Drawing.Point(202, 209);
            this.btnguess.Name = "btnguess";
            this.btnguess.Size = new System.Drawing.Size(114, 59);
            this.btnguess.TabIndex = 0;
            this.btnguess.Text = "Guess";
            this.btnguess.UseVisualStyleBackColor = true;
            this.btnguess.Click += new System.EventHandler(this.btnguess_Click);
            // 
            // btnanswer
            // 
            this.btnanswer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnanswer.Location = new System.Drawing.Point(365, 209);
            this.btnanswer.Name = "btnanswer";
            this.btnanswer.Size = new System.Drawing.Size(141, 59);
            this.btnanswer.TabIndex = 1;
            this.btnanswer.Text = "Show Answer";
            this.btnanswer.UseVisualStyleBackColor = true;
            this.btnanswer.Click += new System.EventHandler(this.btnanswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(143, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please Select A Number Between 1-100!";
            // 
            // panelshow
            // 
            this.panelshow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelshow.Controls.Add(this.txtnum);
            this.panelshow.Controls.Add(this.btncancel);
            this.panelshow.Controls.Add(this.btnenter);
            this.panelshow.Controls.Add(this.label2);
            this.panelshow.Location = new System.Drawing.Point(418, 304);
            this.panelshow.Name = "panelshow";
            this.panelshow.Size = new System.Drawing.Size(341, 121);
            this.panelshow.TabIndex = 3;
            this.panelshow.Visible = false;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(32, 74);
            this.txtnum.Multiline = true;
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(179, 32);
            this.txtnum.TabIndex = 3;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(252, 49);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 32);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnenter
            // 
            this.btnenter.Location = new System.Drawing.Point(252, 11);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(75, 32);
            this.btnenter.TabIndex = 1;
            this.btnenter.Text = "Enter";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please Input The Number";
            // 
            // resultshow
            // 
            this.resultshow.AutoSize = true;
            this.resultshow.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultshow.Location = new System.Drawing.Point(74, 42);
            this.resultshow.Name = "resultshow";
            this.resultshow.Size = new System.Drawing.Size(0, 28);
            this.resultshow.TabIndex = 4;
            // 
            // Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultshow);
            this.Controls.Add(this.panelshow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnanswer);
            this.Controls.Add(this.btnguess);
            this.Name = "Guess";
            this.Text = "Guess";
            this.Load += new System.EventHandler(this.Guess_Load);
            this.panelshow.ResumeLayout(false);
            this.panelshow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguess;
        private System.Windows.Forms.Button btnanswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelshow;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label resultshow;
    }
}

