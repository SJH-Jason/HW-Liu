﻿namespace Frm_StudentGrade
{
    partial class studentgrade
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtchi = new System.Windows.Forms.TextBox();
            this.txteng = new System.Windows.Forms.TextBox();
            this.txtmath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnstat = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnadds = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.姓名 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.國文 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.英文 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.數學 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.總分 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.平均 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.最低 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.最高 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(96, 45);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(83, 33);
            this.txtname.TabIndex = 0;
            // 
            // txtchi
            // 
            this.txtchi.Location = new System.Drawing.Point(96, 98);
            this.txtchi.Multiline = true;
            this.txtchi.Name = "txtchi";
            this.txtchi.Size = new System.Drawing.Size(83, 34);
            this.txtchi.TabIndex = 1;
            // 
            // txteng
            // 
            this.txteng.Location = new System.Drawing.Point(96, 158);
            this.txteng.Multiline = true;
            this.txteng.Name = "txteng";
            this.txteng.Size = new System.Drawing.Size(83, 34);
            this.txteng.TabIndex = 2;
            // 
            // txtmath
            // 
            this.txtmath.Location = new System.Drawing.Point(96, 214);
            this.txtmath.Multiline = true;
            this.txtmath.Name = "txtmath";
            this.txtmath.Size = new System.Drawing.Size(83, 35);
            this.txtmath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(34, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(33, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "國文";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(33, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "英文";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(33, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "數學";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(51, 268);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(120, 30);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "加入學生資料";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(51, 304);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(120, 31);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "隨機儲存資料";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnstat
            // 
            this.btnstat.Location = new System.Drawing.Point(51, 341);
            this.btnstat.Name = "btnstat";
            this.btnstat.Size = new System.Drawing.Size(120, 31);
            this.btnstat.TabIndex = 10;
            this.btnstat.Text = "各科統計";
            this.btnstat.UseVisualStyleBackColor = true;
            this.btnstat.Click += new System.EventHandler(this.btnstat_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(51, 378);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(120, 31);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "重設所有資料";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnadds
            // 
            this.btnadds.Location = new System.Drawing.Point(51, 415);
            this.btnadds.Name = "btnadds";
            this.btnadds.Size = new System.Drawing.Size(120, 31);
            this.btnadds.TabIndex = 12;
            this.btnadds.Text = "隨機加入20筆";
            this.btnadds.UseVisualStyleBackColor = true;
            this.btnadds.Click += new System.EventHandler(this.btnadds_Click);
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
            this.listView.Location = new System.Drawing.Point(217, 26);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(494, 257);
            this.listView.TabIndex = 14;
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(217, 304);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(494, 119);
            this.listView1.TabIndex = 15;
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
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            // 
            // studentgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnadds);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnstat);
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
            this.Name = "studentgrade";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtchi;
        private System.Windows.Forms.TextBox txteng;
        private System.Windows.Forms.TextBox txtmath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnstat;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnadds;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader 姓名;
        private System.Windows.Forms.ColumnHeader 國文;
        private System.Windows.Forms.ColumnHeader 英文;
        private System.Windows.Forms.ColumnHeader 數學;
        private System.Windows.Forms.ColumnHeader 總分;
        private System.Windows.Forms.ColumnHeader 平均;
        private System.Windows.Forms.ColumnHeader 最低;
        private System.Windows.Forms.ColumnHeader 最高;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

