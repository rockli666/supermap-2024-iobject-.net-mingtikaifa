namespace CampusMap
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
            this.workspace1 = new SuperMap.Data.Workspace(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mapControl1 = new SuperMap.UI.MapControl();
            this.side1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.sousuo1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.nagtive1 = new System.Windows.Forms.Panel();
            this.toolStripButtonPlay = new System.Windows.Forms.Button();
            this.toolStripButtonStop = new System.Windows.Forms.Button();
            this.toolStripButtonAnalyst = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button = new System.Windows.Forms.Button();
            this.toolStrip_clear = new System.Windows.Forms.Button();
            this.radioButtonPoint = new System.Windows.Forms.Button();
            this.place1 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.side = new System.Windows.Forms.Timer(this.components);
            this.mapNavigationControl1 = new SuperMap.UI.MapNavigationControl(this.components);
            this.sousuo = new System.Windows.Forms.Timer(this.components);
            this.nagtive = new System.Windows.Forms.Timer(this.components);
            this.place = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.side1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.sousuo1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.nagtive1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.place1.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // workspace1
            // 
            this.workspace1.Caption = "UntitledWorkspace";
            this.workspace1.Description = "";
            this.workspace1.DesktopInfo = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.mapControl1);
            this.panel1.Location = new System.Drawing.Point(0, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1621, 863);
            this.panel1.TabIndex = 2;
            // 
            // mapControl1
            // 
            this.mapControl1.Action = SuperMap.UI.Action.Select2;
            this.mapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapControl1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mapControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapControl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mapControl1.Location = new System.Drawing.Point(-12, 0);
            this.mapControl1.Margin = new System.Windows.Forms.Padding(96, 44, 96, 44);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(1645, 863);
            this.mapControl1.TabIndex = 3;
            this.mapControl1.TrackMode = SuperMap.UI.TrackMode.Edit;
            // 
            // side1
            // 
            this.side1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.side1.AutoScroll = true;
            this.side1.BackColor = System.Drawing.Color.White;
            this.side1.Controls.Add(this.panel2);
            this.side1.Controls.Add(this.panel3);
            this.side1.Controls.Add(this.sousuo1);
            this.side1.Controls.Add(this.panel5);
            this.side1.Controls.Add(this.nagtive1);
            this.side1.Controls.Add(this.place1);
            this.side1.Controls.Add(this.panel10);
            this.side1.Location = new System.Drawing.Point(0, 0);
            this.side1.MaximumSize = new System.Drawing.Size(269, 854);
            this.side1.MinimumSize = new System.Drawing.Size(83, 854);
            this.side1.Name = "side1";
            this.side1.Size = new System.Drawing.Size(83, 854);
            this.side1.TabIndex = 3;
            this.side1.Paint += new System.Windows.Forms.PaintEventHandler(this.side1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 72);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 69);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(3, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 74);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-54, -27);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(282, 131);
            this.button1.TabIndex = 0;
            this.button1.Text = "     全幅显示";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sousuo1
            // 
            this.sousuo1.Controls.Add(this.panel7);
            this.sousuo1.Controls.Add(this.panel4);
            this.sousuo1.Location = new System.Drawing.Point(3, 161);
            this.sousuo1.MaximumSize = new System.Drawing.Size(227, 127);
            this.sousuo1.MinimumSize = new System.Drawing.Size(227, 82);
            this.sousuo1.Name = "sousuo1";
            this.sousuo1.Size = new System.Drawing.Size(227, 82);
            this.sousuo1.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Controls.Add(this.button5);
            this.panel7.Location = new System.Drawing.Point(3, 83);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(225, 47);
            this.panel7.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 35);
            this.textBox1.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(179, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 37);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 74);
            this.panel4.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-54, -31);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(52, 10, 0, 0);
            this.button2.Size = new System.Drawing.Size(288, 131);
            this.button2.TabIndex = 0;
            this.button2.Text = "     搜   索";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Location = new System.Drawing.Point(3, 249);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(224, 74);
            this.panel5.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-54, -27);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(57, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(282, 131);
            this.button3.TabIndex = 0;
            this.button3.Text = "     查   询";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nagtive1
            // 
            this.nagtive1.Controls.Add(this.toolStripButtonPlay);
            this.nagtive1.Controls.Add(this.toolStripButtonStop);
            this.nagtive1.Controls.Add(this.toolStripButtonAnalyst);
            this.nagtive1.Controls.Add(this.panel6);
            this.nagtive1.Controls.Add(this.toolStrip_clear);
            this.nagtive1.Controls.Add(this.radioButtonPoint);
            this.nagtive1.Location = new System.Drawing.Point(3, 329);
            this.nagtive1.MaximumSize = new System.Drawing.Size(224, 335);
            this.nagtive1.MinimumSize = new System.Drawing.Size(224, 83);
            this.nagtive1.Name = "nagtive1";
            this.nagtive1.Size = new System.Drawing.Size(224, 83);
            this.nagtive1.TabIndex = 4;
            // 
            // toolStripButtonPlay
            // 
            this.toolStripButtonPlay.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripButtonPlay.Location = new System.Drawing.Point(0, 235);
            this.toolStripButtonPlay.Name = "toolStripButtonPlay";
            this.toolStripButtonPlay.Size = new System.Drawing.Size(218, 45);
            this.toolStripButtonPlay.TabIndex = 10;
            this.toolStripButtonPlay.Text = "停止动画";
            this.toolStripButtonPlay.UseVisualStyleBackColor = false;
            this.toolStripButtonPlay.Click += new System.EventHandler(this.toolStrip_pathAnalyst_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripButtonStop.Location = new System.Drawing.Point(0, 186);
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(218, 43);
            this.toolStripButtonStop.TabIndex = 9;
            this.toolStripButtonStop.Text = "引导动画";
            this.toolStripButtonStop.UseVisualStyleBackColor = false;
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStrip_addEndPoint_Click);
            // 
            // toolStripButtonAnalyst
            // 
            this.toolStripButtonAnalyst.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStripButtonAnalyst.Location = new System.Drawing.Point(0, 132);
            this.toolStripButtonAnalyst.Name = "toolStripButtonAnalyst";
            this.toolStripButtonAnalyst.Size = new System.Drawing.Size(218, 47);
            this.toolStripButtonAnalyst.TabIndex = 8;
            this.toolStripButtonAnalyst.Text = "路线规划";
            this.toolStripButtonAnalyst.UseVisualStyleBackColor = false;
            this.toolStripButtonAnalyst.Click += new System.EventHandler(this.toolStrip_addStartPoint_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(224, 74);
            this.panel6.TabIndex = 7;
            // 
            // button
            // 
            this.button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button.BackColor = System.Drawing.Color.Transparent;
            this.button.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button.ForeColor = System.Drawing.Color.Black;
            this.button.Image = ((System.Drawing.Image)(resources.GetObject("button.Image")));
            this.button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button.Location = new System.Drawing.Point(-54, -27);
            this.button.Name = "button";
            this.button.Padding = new System.Windows.Forms.Padding(54, 0, 0, 0);
            this.button.Size = new System.Drawing.Size(278, 131);
            this.button.TabIndex = 0;
            this.button.Text = "     路   径";
            this.button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button4_Click);
            // 
            // toolStrip_clear
            // 
            this.toolStrip_clear.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip_clear.Location = new System.Drawing.Point(0, 286);
            this.toolStrip_clear.Name = "toolStrip_clear";
            this.toolStrip_clear.Size = new System.Drawing.Size(218, 43);
            this.toolStrip_clear.TabIndex = 11;
            this.toolStrip_clear.Text = "清除";
            this.toolStrip_clear.UseVisualStyleBackColor = false;
            this.toolStrip_clear.Click += new System.EventHandler(this.toolStrip_clear_Click);
            // 
            // radioButtonPoint
            // 
            this.radioButtonPoint.BackColor = System.Drawing.Color.Gainsboro;
            this.radioButtonPoint.Location = new System.Drawing.Point(0, 83);
            this.radioButtonPoint.Name = "radioButtonPoint";
            this.radioButtonPoint.Size = new System.Drawing.Size(218, 43);
            this.radioButtonPoint.TabIndex = 12;
            this.radioButtonPoint.Text = "开始/关闭";
            this.radioButtonPoint.UseVisualStyleBackColor = false;
            this.radioButtonPoint.Click += new System.EventHandler(this.toolStrip_dataCompiler_Click);
            // 
            // place1
            // 
            this.place1.AutoScrollMargin = new System.Drawing.Size(100, 0);
            this.place1.Controls.Add(this.panel15);
            this.place1.Controls.Add(this.panel14);
            this.place1.Controls.Add(this.panel8);
            this.place1.Controls.Add(this.panel13);
            this.place1.Controls.Add(this.panel12);
            this.place1.Controls.Add(this.panel11);
            this.place1.Controls.Add(this.panel9);
            this.place1.Location = new System.Drawing.Point(3, 418);
            this.place1.MaximumSize = new System.Drawing.Size(228, 466);
            this.place1.MinimumSize = new System.Drawing.Size(228, 80);
            this.place1.Name = "place1";
            this.place1.Size = new System.Drawing.Size(228, 80);
            this.place1.TabIndex = 10;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.button11);
            this.panel15.Location = new System.Drawing.Point(3, 84);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(224, 57);
            this.panel15.TabIndex = 13;
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.BackColor = System.Drawing.Color.Gainsboro;
            this.button11.Font = new System.Drawing.Font("仿宋", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(-34, -32);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(80, 0, 0, 10);
            this.button11.Size = new System.Drawing.Size(259, 131);
            this.button11.TabIndex = 0;
            this.button11.Text = "     道路";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.button10);
            this.panel14.Location = new System.Drawing.Point(3, 401);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(224, 57);
            this.panel14.TabIndex = 12;
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackColor = System.Drawing.Color.Gainsboro;
            this.button10.Font = new System.Drawing.Font("仿宋", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(-34, -32);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(80, 0, 0, 10);
            this.button10.Size = new System.Drawing.Size(259, 131);
            this.button10.TabIndex = 0;
            this.button10.Text = "     出入口";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button4);
            this.panel8.Location = new System.Drawing.Point(3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(224, 74);
            this.panel8.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(-56, -22);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(57, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(290, 131);
            this.button4.TabIndex = 0;
            this.button4.Text = "     场   地";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.button9);
            this.panel13.Location = new System.Drawing.Point(3, 338);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(224, 57);
            this.panel13.TabIndex = 10;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.Gainsboro;
            this.button9.Font = new System.Drawing.Font("仿宋", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(-34, -32);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(80, 0, 0, 10);
            this.button9.Size = new System.Drawing.Size(259, 131);
            this.button9.TabIndex = 0;
            this.button9.Text = "     停车场";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.button8);
            this.panel12.Location = new System.Drawing.Point(3, 275);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(224, 57);
            this.panel12.TabIndex = 11;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.Gainsboro;
            this.button8.Font = new System.Drawing.Font("仿宋", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(-34, -32);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(80, 0, 0, 10);
            this.button8.Size = new System.Drawing.Size(259, 131);
            this.button8.TabIndex = 0;
            this.button8.Text = "     运动场";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.button7);
            this.panel11.Location = new System.Drawing.Point(3, 210);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(224, 57);
            this.panel11.TabIndex = 10;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.Gainsboro;
            this.button7.Font = new System.Drawing.Font("仿宋", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(-34, -32);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(80, 0, 0, 10);
            this.button7.Size = new System.Drawing.Size(259, 131);
            this.button7.TabIndex = 0;
            this.button7.Text = "     植被";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button6);
            this.panel9.Location = new System.Drawing.Point(3, 147);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(224, 57);
            this.panel9.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.Gainsboro;
            this.button6.Font = new System.Drawing.Font("仿宋", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-34, -32);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(80, 0, 0, 10);
            this.button6.Size = new System.Drawing.Size(259, 131);
            this.button6.TabIndex = 0;
            this.button6.Text = "     建筑";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.button12);
            this.panel10.Location = new System.Drawing.Point(3, 504);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(224, 74);
            this.panel10.TabIndex = 11;
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(-54, -27);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(282, 131);
            this.button12.TabIndex = 0;
            this.button12.Text = "     三   维";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // side
            // 
            this.side.Interval = 10;
            this.side.Tick += new System.EventHandler(this.sidebarTimer_tICK);
            // 
            // mapNavigationControl1
            // 
            this.mapNavigationControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapNavigationControl1.Location = new System.Drawing.Point(1510, 520);
            this.mapNavigationControl1.MapControl = null;
            this.mapNavigationControl1.MaxScale = 0D;
            this.mapNavigationControl1.MinScale = 0D;
            this.mapNavigationControl1.PanPercent = 25;
            this.mapNavigationControl1.Visible = true;
            // 
            // sousuo
            // 
            this.sousuo.Interval = 10;
            this.sousuo.Tick += new System.EventHandler(this.sousuo_tICK);
            // 
            // nagtive
            // 
            this.nagtive.Interval = 10;
            this.nagtive.Tick += new System.EventHandler(this.nagtive_tICK);
            // 
            // place
            // 
            this.place.Interval = 10;
            this.place.Tick += new System.EventHandler(this.place_tICK);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 854);
            this.Controls.Add(this.side1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "智慧校园系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.From1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.side1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.sousuo1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.nagtive1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.place1.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private SuperMap.Data.Workspace workspace1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel side1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer side;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SuperMap.UI.MapNavigationControl mapNavigationControl1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer sousuo;
        private System.Windows.Forms.Panel sousuo1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Panel nagtive1;
        private System.Windows.Forms.Button toolStripButtonPlay;
        private System.Windows.Forms.Button toolStripButtonStop;
        private System.Windows.Forms.Button toolStripButtonAnalyst;
        private System.Windows.Forms.Timer nagtive;
        private System.Windows.Forms.Button toolStrip_clear;
        private System.Windows.Forms.Button radioButtonPoint;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel place1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Timer place;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button12;
        private SuperMap.UI.MapControl mapControl1;
    }
}

