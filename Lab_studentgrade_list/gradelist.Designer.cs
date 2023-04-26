namespace Lab_studentgrade_list
{
    partial class gradelist
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
            this.listView = new System.Windows.Forms.ListView();
            this.姓名 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.國文 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.英文 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.數學 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.總分 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.平均 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.最低 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.最高 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmath = new System.Windows.Forms.TextBox();
            this.txteng = new System.Windows.Forms.TextBox();
            this.txtchi = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtQueryStart = new System.Windows.Forms.TextBox();
            this.txtQueryEnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btb1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.姓名,
            this.國文,
            this.英文,
            this.數學,
            this.總分,
            this.平均,
            this.最低,
            this.最高});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(308, 29);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(657, 350);
            this.listView.TabIndex = 29;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // 姓名
            // 
            this.姓名.Text = "姓名";
            this.姓名.Width = 50;
            // 
            // 國文
            // 
            this.國文.Text = "國文";
            // 
            // 英文
            // 
            this.英文.Text = "英文";
            // 
            // 數學
            // 
            this.數學.Text = "數學";
            // 
            // 總分
            // 
            this.總分.Text = "總分";
            // 
            // 平均
            // 
            this.平均.Text = "平均";
            // 
            // 最低
            // 
            this.最低.Text = "最低";
            // 
            // 最高
            // 
            this.最高.Text = "最高";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(73, 642);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(160, 39);
            this.btnsearch.TabIndex = 28;
            this.btnsearch.Text = "SERCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(73, 480);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(160, 39);
            this.btnclear.TabIndex = 27;
            this.btnclear.Text = "清除所有資料";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(73, 434);
            this.btnremove.Margin = new System.Windows.Forms.Padding(4);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(160, 39);
            this.btnremove.TabIndex = 26;
            this.btnremove.Text = "移出資料";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click_1);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(73, 388);
            this.btnsave.Margin = new System.Windows.Forms.Padding(4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(160, 39);
            this.btnsave.TabIndex = 25;
            this.btnsave.Text = "插入儲存資料";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(73, 342);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(160, 38);
            this.btnadd.TabIndex = 24;
            this.btnadd.Text = "加入學生資料";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(48, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "數學";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(48, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "英文";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(48, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "國文";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(49, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "姓名";
            // 
            // txtmath
            // 
            this.txtmath.Location = new System.Drawing.Point(147, 286);
            this.txtmath.Margin = new System.Windows.Forms.Padding(4);
            this.txtmath.Multiline = true;
            this.txtmath.Name = "txtmath";
            this.txtmath.Size = new System.Drawing.Size(109, 43);
            this.txtmath.TabIndex = 19;
            // 
            // txteng
            // 
            this.txteng.Location = new System.Drawing.Point(147, 215);
            this.txteng.Margin = new System.Windows.Forms.Padding(4);
            this.txteng.Multiline = true;
            this.txteng.Name = "txteng";
            this.txteng.Size = new System.Drawing.Size(109, 42);
            this.txteng.TabIndex = 18;
            // 
            // txtchi
            // 
            this.txtchi.Location = new System.Drawing.Point(147, 134);
            this.txtchi.Margin = new System.Windows.Forms.Padding(4);
            this.txtchi.Multiline = true;
            this.txtchi.Name = "txtchi";
            this.txtchi.Size = new System.Drawing.Size(109, 42);
            this.txtchi.TabIndex = 17;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(147, 44);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(109, 40);
            this.txtname.TabIndex = 16;
            // 
            // txtQueryStart
            // 
            this.txtQueryStart.Location = new System.Drawing.Point(41, 560);
            this.txtQueryStart.Margin = new System.Windows.Forms.Padding(4);
            this.txtQueryStart.Multiline = true;
            this.txtQueryStart.Name = "txtQueryStart";
            this.txtQueryStart.Size = new System.Drawing.Size(84, 56);
            this.txtQueryStart.TabIndex = 31;
            // 
            // txtQueryEnd
            // 
            this.txtQueryEnd.Location = new System.Drawing.Point(191, 560);
            this.txtQueryEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtQueryEnd.Multiline = true;
            this.txtQueryEnd.Name = "txtQueryEnd";
            this.txtQueryEnd.Size = new System.Drawing.Size(81, 56);
            this.txtQueryEnd.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(133, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "----";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(68, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "搜尋國文成績範圍:";
            // 
            // btb1
            // 
            this.btb1.Location = new System.Drawing.Point(907, 621);
            this.btb1.Margin = new System.Windows.Forms.Padding(4);
            this.btb1.Name = "btb1";
            this.btb1.Size = new System.Drawing.Size(160, 39);
            this.btb1.TabIndex = 35;
            this.btb1.Text = "各科統計";
            this.btb1.UseVisualStyleBackColor = true;
            this.btb1.Click += new System.EventHandler(this.btb1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(308, 404);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(657, 184);
            this.listView1.TabIndex = 36;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "";
            // 
            // gradelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 696);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btb1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQueryEnd);
            this.Controls.Add(this.txtQueryStart);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmath);
            this.Controls.Add(this.txteng);
            this.Controls.Add(this.txtchi);
            this.Controls.Add(this.txtname);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "gradelist";
            this.Text = "gradelist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader 姓名;
        private System.Windows.Forms.ColumnHeader 國文;
        private System.Windows.Forms.ColumnHeader 英文;
        private System.Windows.Forms.ColumnHeader 數學;
        private System.Windows.Forms.ColumnHeader 總分;
        private System.Windows.Forms.ColumnHeader 平均;
        private System.Windows.Forms.ColumnHeader 最低;
        private System.Windows.Forms.ColumnHeader 最高;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmath;
        private System.Windows.Forms.TextBox txteng;
        private System.Windows.Forms.TextBox txtchi;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtQueryStart;
        private System.Windows.Forms.TextBox txtQueryEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btb1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

