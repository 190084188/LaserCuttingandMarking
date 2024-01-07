
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ctrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p2pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAxis = new System.Windows.Forms.Label();
            this.comboBoxAxis = new System.Windows.Forms.ComboBox();
            this.labelCore = new System.Windows.Forms.Label();
            this.comboBoxCore = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonLoadCfg = new System.Windows.Forms.Button();
            this.buttonInit = new System.Windows.Forms.Button();
            this.buttonClr = new System.Windows.Forms.Button();
            this.buttonEnable = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonMain = new System.Windows.Forms.Button();
            this.textBoxInform = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonZeroPos = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrlToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.motionToolStripMenuItem,
            this.funToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ctrlToolStripMenuItem
            // 
            this.ctrlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.ctrlToolStripMenuItem.Name = "ctrlToolStripMenuItem";
            this.ctrlToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.ctrlToolStripMenuItem.Text = "控制(C)";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem1});
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.resetToolStripMenuItem.Text = "复位运动控制卡";
            // 
            // resetToolStripMenuItem1
            // 
            this.resetToolStripMenuItem1.Name = "resetToolStripMenuItem1";
            this.resetToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.resetToolStripMenuItem1.Text = "复位核所有轴";
            this.resetToolStripMenuItem1.Click += new System.EventHandler(this.resetToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "退出";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.fileToolStripMenuItem.Text = "配方(R)";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "新建";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.openToolStripMenuItem.Text = "打开";
            // 
            // motionToolStripMenuItem
            // 
            this.motionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.jogToolStripMenuItem,
            this.p2pToolStripMenuItem,
            this.gearToolStripMenuItem,
            this.itpToolStripMenuItem});
            this.motionToolStripMenuItem.Name = "motionToolStripMenuItem";
            this.motionToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.motionToolStripMenuItem.Text = "运动(M)";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.homeToolStripMenuItem.Text = "回零";
            // 
            // jogToolStripMenuItem
            // 
            this.jogToolStripMenuItem.Name = "jogToolStripMenuItem";
            this.jogToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.jogToolStripMenuItem.Text = "Jog运动";
            this.jogToolStripMenuItem.Click += new System.EventHandler(this.jogToolStripMenuItem_Click);
            // 
            // p2pToolStripMenuItem
            // 
            this.p2pToolStripMenuItem.Name = "p2pToolStripMenuItem";
            this.p2pToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.p2pToolStripMenuItem.Text = "点位运动";
            // 
            // gearToolStripMenuItem
            // 
            this.gearToolStripMenuItem.Name = "gearToolStripMenuItem";
            this.gearToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.gearToolStripMenuItem.Text = "齿轮运动";
            // 
            // itpToolStripMenuItem
            // 
            this.itpToolStripMenuItem.Name = "itpToolStripMenuItem";
            this.itpToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.itpToolStripMenuItem.Text = "插补运动";
            // 
            // funToolStripMenuItem
            // 
            this.funToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.markingToolStripMenuItem});
            this.funToolStripMenuItem.Name = "funToolStripMenuItem";
            this.funToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.funToolStripMenuItem.Text = "功能(F)";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cutToolStripMenuItem.Text = "激光切割";
            // 
            // markingToolStripMenuItem
            // 
            this.markingToolStripMenuItem.Name = "markingToolStripMenuItem";
            this.markingToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.markingToolStripMenuItem.Text = "激光打标";
            this.markingToolStripMenuItem.Click += new System.EventHandler(this.markingToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.infoToolStripMenuItem.Text = "信息(I)";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // labelAxis
            // 
            this.labelAxis.AutoSize = true;
            this.labelAxis.Location = new System.Drawing.Point(12, 96);
            this.labelAxis.Name = "labelAxis";
            this.labelAxis.Size = new System.Drawing.Size(41, 12);
            this.labelAxis.TabIndex = 1;
            this.labelAxis.Text = "轴号：";
            // 
            // comboBoxAxis
            // 
            this.comboBoxAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAxis.FormattingEnabled = true;
            this.comboBoxAxis.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxAxis.Location = new System.Drawing.Point(59, 93);
            this.comboBoxAxis.Name = "comboBoxAxis";
            this.comboBoxAxis.Size = new System.Drawing.Size(52, 20);
            this.comboBoxAxis.TabIndex = 2;
            // 
            // labelCore
            // 
            this.labelCore.AutoSize = true;
            this.labelCore.Location = new System.Drawing.Point(12, 62);
            this.labelCore.Name = "labelCore";
            this.labelCore.Size = new System.Drawing.Size(41, 12);
            this.labelCore.TabIndex = 1;
            this.labelCore.Text = "核号：";
            // 
            // comboBoxCore
            // 
            this.comboBoxCore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCore.FormattingEnabled = true;
            this.comboBoxCore.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxCore.Location = new System.Drawing.Point(59, 59);
            this.comboBoxCore.Name = "comboBoxCore";
            this.comboBoxCore.Size = new System.Drawing.Size(52, 20);
            this.comboBoxCore.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "cfg";
            this.openFileDialog1.Filter = "配置文件(*.cfg)|*.cfg";
            this.openFileDialog1.Title = "请选择配置文件";
            // 
            // buttonLoadCfg
            // 
            this.buttonLoadCfg.Location = new System.Drawing.Point(14, 231);
            this.buttonLoadCfg.Name = "buttonLoadCfg";
            this.buttonLoadCfg.Size = new System.Drawing.Size(88, 23);
            this.buttonLoadCfg.TabIndex = 3;
            this.buttonLoadCfg.Text = "加载配置文件";
            this.buttonLoadCfg.UseVisualStyleBackColor = true;
            this.buttonLoadCfg.Click += new System.EventHandler(this.buttonLoadCfg_Click);
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(14, 202);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(88, 23);
            this.buttonInit.TabIndex = 4;
            this.buttonInit.Text = "初始化";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // buttonClr
            // 
            this.buttonClr.Location = new System.Drawing.Point(14, 260);
            this.buttonClr.Name = "buttonClr";
            this.buttonClr.Size = new System.Drawing.Size(88, 23);
            this.buttonClr.TabIndex = 4;
            this.buttonClr.Text = "清除状态";
            this.buttonClr.UseVisualStyleBackColor = true;
            this.buttonClr.Click += new System.EventHandler(this.buttonClr_Click);
            // 
            // buttonEnable
            // 
            this.buttonEnable.Location = new System.Drawing.Point(14, 318);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(88, 23);
            this.buttonEnable.TabIndex = 5;
            this.buttonEnable.Text = "伺服使能";
            this.buttonEnable.UseVisualStyleBackColor = true;
            this.buttonEnable.Click += new System.EventHandler(this.buttonEnable_Click);
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Location = new System.Drawing.Point(117, 28);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(660, 533);
            this.panelMain.TabIndex = 6;
            // 
            // buttonMain
            // 
            this.buttonMain.Location = new System.Drawing.Point(14, 398);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(88, 23);
            this.buttonMain.TabIndex = 7;
            this.buttonMain.Text = "返回主界面";
            this.buttonMain.UseVisualStyleBackColor = true;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // textBoxInform
            // 
            this.textBoxInform.Location = new System.Drawing.Point(14, 504);
            this.textBoxInform.Name = "textBoxInform";
            this.textBoxInform.Size = new System.Drawing.Size(88, 21);
            this.textBoxInform.TabIndex = 8;
            this.textBoxInform.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonZeroPos
            // 
            this.buttonZeroPos.Location = new System.Drawing.Point(14, 289);
            this.buttonZeroPos.Name = "buttonZeroPos";
            this.buttonZeroPos.Size = new System.Drawing.Size(88, 23);
            this.buttonZeroPos.TabIndex = 9;
            this.buttonZeroPos.Text = "位置清零";
            this.buttonZeroPos.UseVisualStyleBackColor = true;
            this.buttonZeroPos.Click += new System.EventHandler(this.buttonZeroPos_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(14, 173);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(88, 23);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "复位";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonZeroPos);
            this.Controls.Add(this.textBoxInform);
            this.Controls.Add(this.buttonMain);
            this.Controls.Add(this.labelCore);
            this.Controls.Add(this.buttonEnable);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.labelAxis);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonClr);
            this.Controls.Add(this.buttonLoadCfg);
            this.Controls.Add(this.comboBoxAxis);
            this.Controls.Add(this.comboBoxCore);
            this.Controls.Add(this.buttonInit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "激光切割与打标";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem motionToolStripMenuItem;
        private ToolStripMenuItem jogToolStripMenuItem;
        private ToolStripMenuItem p2pToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem gearToolStripMenuItem;
        private ToolStripMenuItem itpToolStripMenuItem;
        private ToolStripMenuItem funToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem markingToolStripMenuItem;
        private ToolStripMenuItem ctrlToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label labelAxis;
        private ComboBox comboBoxAxis;
        private Label labelCore;
        private ComboBox comboBoxCore;
        private OpenFileDialog openFileDialog1;
        private Button buttonLoadCfg;
        private Button buttonInit;
        private Button buttonClr;
        private Button buttonEnable;
        private Panel panelMain;
        private Button buttonMain;
        private TextBox textBoxInform;
        public Timer timer1;
        private Button buttonZeroPos;
        private Button buttonReset;
    }
}

