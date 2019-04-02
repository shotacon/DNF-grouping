namespace Team
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox_blue = new System.Windows.Forms.ListBox();
            this.btn_blue_win = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox_red = new System.Windows.Forms.ListBox();
            this.btn_red_win = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_packet = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.box_name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBox_integral = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清空ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_rank = new System.Windows.Forms.ListView();
            this.rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox_player = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 276);
            this.panel2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(239, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 270);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分组结果";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox_blue);
            this.groupBox4.Controls.Add(this.btn_blue_win);
            this.groupBox4.Location = new System.Drawing.Point(167, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 239);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "蓝队";
            // 
            // listBox_blue
            // 
            this.listBox_blue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_blue.Enabled = false;
            this.listBox_blue.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_blue.FormattingEnabled = true;
            this.listBox_blue.Location = new System.Drawing.Point(3, 17);
            this.listBox_blue.Name = "listBox_blue";
            this.listBox_blue.Size = new System.Drawing.Size(149, 166);
            this.listBox_blue.TabIndex = 9;
            // 
            // btn_blue_win
            // 
            this.btn_blue_win.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_blue_win.Location = new System.Drawing.Point(3, 183);
            this.btn_blue_win.Name = "btn_blue_win";
            this.btn_blue_win.Size = new System.Drawing.Size(149, 53);
            this.btn_blue_win.TabIndex = 8;
            this.btn_blue_win.Text = "胜利";
            this.btn_blue_win.UseVisualStyleBackColor = true;
            this.btn_blue_win.Click += new System.EventHandler(this.btn_blue_win_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox_red);
            this.groupBox3.Controls.Add(this.btn_red_win);
            this.groupBox3.Location = new System.Drawing.Point(6, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 239);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "红队";
            // 
            // listBox_red
            // 
            this.listBox_red.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_red.Enabled = false;
            this.listBox_red.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_red.FormattingEnabled = true;
            this.listBox_red.Location = new System.Drawing.Point(3, 17);
            this.listBox_red.Name = "listBox_red";
            this.listBox_red.Size = new System.Drawing.Size(149, 166);
            this.listBox_red.TabIndex = 8;
            // 
            // btn_red_win
            // 
            this.btn_red_win.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_red_win.Location = new System.Drawing.Point(3, 183);
            this.btn_red_win.Name = "btn_red_win";
            this.btn_red_win.Size = new System.Drawing.Size(149, 53);
            this.btn_red_win.TabIndex = 7;
            this.btn_red_win.Text = "胜利";
            this.btn_red_win.UseVisualStyleBackColor = true;
            this.btn_red_win.Click += new System.EventHandler(this.btn_red_win_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_player);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_packet);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_add);
            this.groupBox1.Controls.Add(this.box_name);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 270);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选手列表(输入选手, 多人可逗号分隔)";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(161, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tips: 双击可删除单个";
            // 
            // btn_packet
            // 
            this.btn_packet.Location = new System.Drawing.Point(161, 78);
            this.btn_packet.Name = "btn_packet";
            this.btn_packet.Size = new System.Drawing.Size(58, 23);
            this.btn_packet.TabIndex = 7;
            this.btn_packet.Text = "分组";
            this.btn_packet.UseVisualStyleBackColor = true;
            this.btn_packet.Click += new System.EventHandler(this.btn_packet_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(161, 49);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(58, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(161, 20);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(58, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_1);
            // 
            // box_name
            // 
            this.box_name.Location = new System.Drawing.Point(10, 20);
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(145, 21);
            this.box_name.TabIndex = 2;
            this.box_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.box_name_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 265);
            this.panel1.TabIndex = 11;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBox_integral);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(406, 265);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "计分板";
            // 
            // listBox_integral
            // 
            this.listBox_integral.ContextMenuStrip = this.contextMenuStrip2;
            this.listBox_integral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_integral.FormattingEnabled = true;
            this.listBox_integral.HorizontalScrollbar = true;
            this.listBox_integral.ItemHeight = 12;
            this.listBox_integral.Location = new System.Drawing.Point(3, 17);
            this.listBox_integral.Name = "listBox_integral";
            this.listBox_integral.Size = new System.Drawing.Size(400, 245);
            this.listBox_integral.TabIndex = 9;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空ToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(101, 26);
            // 
            // 清空ToolStripMenuItem1
            // 
            this.清空ToolStripMenuItem1.Name = "清空ToolStripMenuItem1";
            this.清空ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.清空ToolStripMenuItem1.Text = "清空";
            this.清空ToolStripMenuItem1.Click += new System.EventHandler(this.清空ToolStripMenuItem1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listView_rank);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox6.Location = new System.Drawing.Point(406, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(163, 265);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "当前积分榜单";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.清空ToolStripMenuItem.Text = "清空";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // listView_rank
            // 
            this.listView_rank.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rank,
            this.name,
            this.score});
            this.listView_rank.ContextMenuStrip = this.contextMenuStrip1;
            this.listView_rank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_rank.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_rank.Location = new System.Drawing.Point(3, 17);
            this.listView_rank.Name = "listView_rank";
            this.listView_rank.Size = new System.Drawing.Size(157, 245);
            this.listView_rank.TabIndex = 0;
            this.listView_rank.UseCompatibleStateImageBehavior = false;
            this.listView_rank.View = System.Windows.Forms.View.Details;
            this.listView_rank.SelectedIndexChanged += new System.EventHandler(this.listView_rank_SelectedIndexChanged);
            // 
            // rank
            // 
            this.rank.Text = "rank";
            this.rank.Width = 38;
            // 
            // name
            // 
            this.name.Text = "name";
            this.name.Width = 54;
            // 
            // score
            // 
            this.score.Text = "score";
            // 
            // listBox_player
            // 
            this.listBox_player.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_player.FormattingEnabled = true;
            this.listBox_player.Location = new System.Drawing.Point(10, 49);
            this.listBox_player.Name = "listBox_player";
            this.listBox_player.Size = new System.Drawing.Size(145, 212);
            this.listBox_player.TabIndex = 9;
            this.listBox_player.DoubleClick += new System.EventHandler(this.listBox_player_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DNF分组器 v1.0 By Shotacon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox box_name;
        private System.Windows.Forms.Button btn_packet;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_blue_win;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox_blue;
        private System.Windows.Forms.ListBox listBox_red;
        private System.Windows.Forms.Button btn_red_win;
        private System.Windows.Forms.ListBox listBox_integral;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem1;
        private System.Windows.Forms.ListView listView_rank;
        private System.Windows.Forms.ColumnHeader rank;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader score;
        private System.Windows.Forms.ListBox listBox_player;
    }
}

