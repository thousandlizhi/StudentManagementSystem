namespace test1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("添加管理员信息");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("修改管理员信息");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("管理员信息管理", new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("退出系统");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("系统管理", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("开设课程");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("查询课程");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("课程管理", new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("录入成绩");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("统计成绩");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("修改成绩");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("成绩管理", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44,
            treeNode45});
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("添加学生信息");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("修改学生信息");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("学生信息管理", new System.Windows.Forms.TreeNode[] {
            treeNode47,
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("修改密码");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("关于");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.LineColor = System.Drawing.Color.LightGray;
            this.treeView1.Location = new System.Drawing.Point(5, 16);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView1.Name = "treeView1";
            treeNode35.Name = "addMan";
            treeNode35.Text = "添加管理员信息";
            treeNode36.Name = "modifyMan";
            treeNode36.Text = "修改管理员信息";
            treeNode37.Name = "manMan";
            treeNode37.Text = "管理员信息管理";
            treeNode38.Name = "节点0";
            treeNode38.Text = "退出系统";
            treeNode39.Name = "userInfo";
            treeNode39.SelectedImageIndex = 2;
            treeNode39.Text = "系统管理";
            treeNode40.Name = "addCL";
            treeNode40.Text = "开设课程";
            treeNode41.Name = "searchCL";
            treeNode41.Text = "查询课程";
            treeNode42.Name = "classMan";
            treeNode42.Text = "课程管理";
            treeNode43.Checked = true;
            treeNode43.Name = "luruCJ";
            treeNode43.NodeFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode43.Text = "录入成绩";
            treeNode44.Name = "tongjiCJ";
            treeNode44.Text = "统计成绩";
            treeNode45.Name = "节点0";
            treeNode45.Text = "修改成绩";
            treeNode46.Name = "chengjiMan";
            treeNode46.Text = "成绩管理";
            treeNode47.Name = "addStu";
            treeNode47.Text = "添加学生信息";
            treeNode48.Name = "modifyStu";
            treeNode48.Text = "修改学生信息";
            treeNode49.Name = "studentMan";
            treeNode49.Text = "学生信息管理";
            treeNode50.Name = "节点0";
            treeNode50.Text = "修改密码";
            treeNode51.Name = "about";
            treeNode51.Text = "关于";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode42,
            treeNode46,
            treeNode49,
            treeNode50,
            treeNode51});
            this.treeView1.Size = new System.Drawing.Size(221, 648);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(319, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生成绩管理系统";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::test1.Properties.Resources._2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(248, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 648);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 680);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生综合教务系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_close);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

