namespace WindowsFormsApp1
{
    partial class Marking
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDXF = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonConfirmed = new System.Windows.Forms.Button();
            this.groupBoxOutPower = new System.Windows.Forms.GroupBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxOutFrq = new System.Windows.Forms.TextBox();
            this.labelOutFrq = new System.Windows.Forms.Label();
            this.textBoxMaxValue = new System.Windows.Forms.TextBox();
            this.textBoxMinValue = new System.Windows.Forms.TextBox();
            this.labelMinValue = new System.Windows.Forms.Label();
            this.labelMaxValue = new System.Windows.Forms.Label();
            this.groupBoxLaserMode = new System.Windows.Forms.GroupBox();
            this.radioButtonAnalog = new System.Windows.Forms.RadioButton();
            this.radioButtonFrequency = new System.Windows.Forms.RadioButton();
            this.radioButtonDutyCycle = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelPower = new System.Windows.Forms.Label();
            this.textBoxPower = new System.Windows.Forms.TextBox();
            this.checkBoxLaserOn = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxOutPower.SuspendLayout();
            this.groupBoxLaserMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDXF
            // 
            this.buttonDXF.Location = new System.Drawing.Point(20, 27);
            this.buttonDXF.Name = "buttonDXF";
            this.buttonDXF.Size = new System.Drawing.Size(90, 42);
            this.buttonDXF.TabIndex = 0;
            this.buttonDXF.Text = "导入DXF文件";
            this.buttonDXF.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 437);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(609, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "激光参数设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonConfirmed);
            this.panel1.Controls.Add(this.groupBoxOutPower);
            this.panel1.Controls.Add(this.groupBoxLaserMode);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 157);
            this.panel1.TabIndex = 2;
            // 
            // buttonConfirmed
            // 
            this.buttonConfirmed.Location = new System.Drawing.Point(3, 109);
            this.buttonConfirmed.Name = "buttonConfirmed";
            this.buttonConfirmed.Size = new System.Drawing.Size(97, 42);
            this.buttonConfirmed.TabIndex = 2;
            this.buttonConfirmed.Text = "确认设置";
            this.buttonConfirmed.UseVisualStyleBackColor = true;
            this.buttonConfirmed.Click += new System.EventHandler(this.buttonConfirmed_Click);
            // 
            // groupBoxOutPower
            // 
            this.groupBoxOutPower.Controls.Add(this.textBoxPower);
            this.groupBoxOutPower.Controls.Add(this.labelWidth);
            this.groupBoxOutPower.Controls.Add(this.textBoxWidth);
            this.groupBoxOutPower.Controls.Add(this.labelPower);
            this.groupBoxOutPower.Controls.Add(this.textBoxOutFrq);
            this.groupBoxOutPower.Controls.Add(this.labelOutFrq);
            this.groupBoxOutPower.Controls.Add(this.textBoxMaxValue);
            this.groupBoxOutPower.Controls.Add(this.textBoxMinValue);
            this.groupBoxOutPower.Controls.Add(this.labelMinValue);
            this.groupBoxOutPower.Controls.Add(this.labelMaxValue);
            this.groupBoxOutPower.Location = new System.Drawing.Point(106, 3);
            this.groupBoxOutPower.Name = "groupBoxOutPower";
            this.groupBoxOutPower.Size = new System.Drawing.Size(142, 148);
            this.groupBoxOutPower.TabIndex = 1;
            this.groupBoxOutPower.TabStop = false;
            this.groupBoxOutPower.Text = "激光输出大小";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(80, 85);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(51, 21);
            this.textBoxWidth.TabIndex = 5;
            this.textBoxWidth.Visible = false;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(0, 88);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(71, 12);
            this.labelWidth.TabIndex = 4;
            this.labelWidth.Text = "脉宽(μs)：";
            this.labelWidth.Visible = false;
            // 
            // textBoxOutFrq
            // 
            this.textBoxOutFrq.Location = new System.Drawing.Point(101, 85);
            this.textBoxOutFrq.Name = "textBoxOutFrq";
            this.textBoxOutFrq.Size = new System.Drawing.Size(30, 21);
            this.textBoxOutFrq.TabIndex = 3;
            this.textBoxOutFrq.TextChanged += new System.EventHandler(this.textBoxOutFrq_TextChanged);
            // 
            // labelOutFrq
            // 
            this.labelOutFrq.AutoSize = true;
            this.labelOutFrq.Location = new System.Drawing.Point(0, 88);
            this.labelOutFrq.Name = "labelOutFrq";
            this.labelOutFrq.Size = new System.Drawing.Size(95, 12);
            this.labelOutFrq.TabIndex = 2;
            this.labelOutFrq.Text = "输出频率(KHz)：";
            // 
            // textBoxMaxValue
            // 
            this.textBoxMaxValue.Location = new System.Drawing.Point(77, 18);
            this.textBoxMaxValue.Name = "textBoxMaxValue";
            this.textBoxMaxValue.Size = new System.Drawing.Size(54, 21);
            this.textBoxMaxValue.TabIndex = 1;
            this.textBoxMaxValue.Tag = "";
            this.textBoxMaxValue.TextChanged += new System.EventHandler(this.textBoxMaxValue_TextChanged);
            // 
            // textBoxMinValue
            // 
            this.textBoxMinValue.Location = new System.Drawing.Point(77, 45);
            this.textBoxMinValue.Name = "textBoxMinValue";
            this.textBoxMinValue.Size = new System.Drawing.Size(54, 21);
            this.textBoxMinValue.TabIndex = 1;
            this.textBoxMinValue.TextChanged += new System.EventHandler(this.textBoxMinValue_TextChanged);
            // 
            // labelMinValue
            // 
            this.labelMinValue.AutoSize = true;
            this.labelMinValue.Location = new System.Drawing.Point(0, 49);
            this.labelMinValue.Name = "labelMinValue";
            this.labelMinValue.Size = new System.Drawing.Size(71, 12);
            this.labelMinValue.TabIndex = 0;
            this.labelMinValue.Text = "最小值(%)：";
            // 
            // labelMaxValue
            // 
            this.labelMaxValue.AutoSize = true;
            this.labelMaxValue.Location = new System.Drawing.Point(0, 21);
            this.labelMaxValue.Name = "labelMaxValue";
            this.labelMaxValue.Size = new System.Drawing.Size(71, 12);
            this.labelMaxValue.TabIndex = 0;
            this.labelMaxValue.Text = "最大值(%)：";
            // 
            // groupBoxLaserMode
            // 
            this.groupBoxLaserMode.Controls.Add(this.radioButtonAnalog);
            this.groupBoxLaserMode.Controls.Add(this.radioButtonFrequency);
            this.groupBoxLaserMode.Controls.Add(this.radioButtonDutyCycle);
            this.groupBoxLaserMode.Location = new System.Drawing.Point(3, 3);
            this.groupBoxLaserMode.Name = "groupBoxLaserMode";
            this.groupBoxLaserMode.Size = new System.Drawing.Size(100, 100);
            this.groupBoxLaserMode.TabIndex = 0;
            this.groupBoxLaserMode.TabStop = false;
            this.groupBoxLaserMode.Text = "激光输出模式";
            // 
            // radioButtonAnalog
            // 
            this.radioButtonAnalog.AutoSize = true;
            this.radioButtonAnalog.Location = new System.Drawing.Point(7, 67);
            this.radioButtonAnalog.Name = "radioButtonAnalog";
            this.radioButtonAnalog.Size = new System.Drawing.Size(83, 16);
            this.radioButtonAnalog.TabIndex = 2;
            this.radioButtonAnalog.TabStop = true;
            this.radioButtonAnalog.Text = "模拟量模式";
            this.radioButtonAnalog.UseVisualStyleBackColor = true;
            this.radioButtonAnalog.CheckedChanged += new System.EventHandler(this.radioButtonAnalog_CheckedChanged);
            // 
            // radioButtonFrequency
            // 
            this.radioButtonFrequency.AutoSize = true;
            this.radioButtonFrequency.Location = new System.Drawing.Point(7, 44);
            this.radioButtonFrequency.Name = "radioButtonFrequency";
            this.radioButtonFrequency.Size = new System.Drawing.Size(71, 16);
            this.radioButtonFrequency.TabIndex = 1;
            this.radioButtonFrequency.TabStop = true;
            this.radioButtonFrequency.Text = "频率模式";
            this.radioButtonFrequency.UseVisualStyleBackColor = true;
            this.radioButtonFrequency.CheckedChanged += new System.EventHandler(this.radioButtonFrequency_CheckedChanged);
            // 
            // radioButtonDutyCycle
            // 
            this.radioButtonDutyCycle.AutoSize = true;
            this.radioButtonDutyCycle.Checked = true;
            this.radioButtonDutyCycle.Location = new System.Drawing.Point(7, 21);
            this.radioButtonDutyCycle.Name = "radioButtonDutyCycle";
            this.radioButtonDutyCycle.Size = new System.Drawing.Size(83, 16);
            this.radioButtonDutyCycle.TabIndex = 0;
            this.radioButtonDutyCycle.TabStop = true;
            this.radioButtonDutyCycle.Text = "占空比模式";
            this.radioButtonDutyCycle.UseVisualStyleBackColor = true;
            this.radioButtonDutyCycle.CheckedChanged += new System.EventHandler(this.radioButtonDutyCycle_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(609, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Location = new System.Drawing.Point(0, 121);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(53, 12);
            this.labelPower.TabIndex = 6;
            this.labelPower.Text = "占空比：";
            // 
            // textBoxPower
            // 
            this.textBoxPower.Location = new System.Drawing.Point(77, 118);
            this.textBoxPower.Name = "textBoxPower";
            this.textBoxPower.Size = new System.Drawing.Size(54, 21);
            this.textBoxPower.TabIndex = 7;
            // 
            // checkBoxLaserOn
            // 
            this.checkBoxLaserOn.AutoSize = true;
            this.checkBoxLaserOn.Location = new System.Drawing.Point(203, 41);
            this.checkBoxLaserOn.Name = "checkBoxLaserOn";
            this.checkBoxLaserOn.Size = new System.Drawing.Size(72, 16);
            this.checkBoxLaserOn.TabIndex = 3;
            this.checkBoxLaserOn.Text = "激光开启";
            this.checkBoxLaserOn.UseVisualStyleBackColor = true;
            this.checkBoxLaserOn.CheckedChanged += new System.EventHandler(this.checkBoxLaserOn_CheckedChanged);
            // 
            // Marking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxLaserOn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonDXF);
            this.Name = "Marking";
            this.Size = new System.Drawing.Size(660, 533);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxOutPower.ResumeLayout(false);
            this.groupBoxOutPower.PerformLayout();
            this.groupBoxLaserMode.ResumeLayout(false);
            this.groupBoxLaserMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDXF;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxLaserMode;
        private System.Windows.Forms.RadioButton radioButtonDutyCycle;
        private System.Windows.Forms.RadioButton radioButtonAnalog;
        private System.Windows.Forms.RadioButton radioButtonFrequency;
        private System.Windows.Forms.GroupBox groupBoxOutPower;
        private System.Windows.Forms.TextBox textBoxMaxValue;
        private System.Windows.Forms.TextBox textBoxMinValue;
        private System.Windows.Forms.Label labelMinValue;
        private System.Windows.Forms.Label labelMaxValue;
        private System.Windows.Forms.TextBox textBoxOutFrq;
        private System.Windows.Forms.Label labelOutFrq;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonConfirmed;
        private System.Windows.Forms.TextBox textBoxPower;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.CheckBox checkBoxLaserOn;
    }
}
