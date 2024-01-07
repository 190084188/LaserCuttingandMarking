namespace WindowsFormsApp1
{
    partial class Jog
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
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.textBoxEncPos = new System.Windows.Forms.TextBox();
            this.textBoxEncVel = new System.Windows.Forms.TextBox();
            this.textBoxPrfVel = new System.Windows.Forms.TextBox();
            this.textBoxPrfPos = new System.Windows.Forms.TextBox();
            this.labelEncVel = new System.Windows.Forms.Label();
            this.labelEncPos = new System.Windows.Forms.Label();
            this.labelPrfVel = new System.Windows.Forms.Label();
            this.labelPrfPos = new System.Windows.Forms.Label();
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.textBoxSmooth = new System.Windows.Forms.TextBox();
            this.labelSmooth = new System.Windows.Forms.Label();
            this.buttonPoMove = new System.Windows.Forms.Button();
            this.textBoxDec = new System.Windows.Forms.TextBox();
            this.buttonNeMove = new System.Windows.Forms.Button();
            this.textBoxAcc = new System.Windows.Forms.TextBox();
            this.textBoxVel = new System.Windows.Forms.TextBox();
            this.labelDec = new System.Windows.Forms.Label();
            this.labelAcc = new System.Windows.Forms.Label();
            this.labelVel = new System.Windows.Forms.Label();
            this.groupBoxStatus.SuspendLayout();
            this.groupBoxSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.textBoxEncPos);
            this.groupBoxStatus.Controls.Add(this.textBoxEncVel);
            this.groupBoxStatus.Controls.Add(this.textBoxPrfVel);
            this.groupBoxStatus.Controls.Add(this.textBoxPrfPos);
            this.groupBoxStatus.Controls.Add(this.labelEncVel);
            this.groupBoxStatus.Controls.Add(this.labelEncPos);
            this.groupBoxStatus.Controls.Add(this.labelPrfVel);
            this.groupBoxStatus.Controls.Add(this.labelPrfPos);
            this.groupBoxStatus.Location = new System.Drawing.Point(160, 315);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(328, 79);
            this.groupBoxStatus.TabIndex = 4;
            this.groupBoxStatus.TabStop = false;
            this.groupBoxStatus.Text = " 运动状态";
            // 
            // textBoxEncPos
            // 
            this.textBoxEncPos.Location = new System.Drawing.Point(233, 18);
            this.textBoxEncPos.Name = "textBoxEncPos";
            this.textBoxEncPos.ReadOnly = true;
            this.textBoxEncPos.Size = new System.Drawing.Size(86, 21);
            this.textBoxEncPos.TabIndex = 18;
            // 
            // textBoxEncVel
            // 
            this.textBoxEncVel.Location = new System.Drawing.Point(233, 47);
            this.textBoxEncVel.Name = "textBoxEncVel";
            this.textBoxEncVel.ReadOnly = true;
            this.textBoxEncVel.Size = new System.Drawing.Size(86, 21);
            this.textBoxEncVel.TabIndex = 17;
            // 
            // textBoxPrfVel
            // 
            this.textBoxPrfVel.Location = new System.Drawing.Point(73, 47);
            this.textBoxPrfVel.Name = "textBoxPrfVel";
            this.textBoxPrfVel.ReadOnly = true;
            this.textBoxPrfVel.Size = new System.Drawing.Size(86, 21);
            this.textBoxPrfVel.TabIndex = 16;
            // 
            // textBoxPrfPos
            // 
            this.textBoxPrfPos.Location = new System.Drawing.Point(73, 18);
            this.textBoxPrfPos.Name = "textBoxPrfPos";
            this.textBoxPrfPos.ReadOnly = true;
            this.textBoxPrfPos.Size = new System.Drawing.Size(86, 21);
            this.textBoxPrfPos.TabIndex = 12;
            // 
            // labelEncVel
            // 
            this.labelEncVel.AutoSize = true;
            this.labelEncVel.Location = new System.Drawing.Point(174, 51);
            this.labelEncVel.Name = "labelEncVel";
            this.labelEncVel.Size = new System.Drawing.Size(53, 12);
            this.labelEncVel.TabIndex = 15;
            this.labelEncVel.Text = "实际速度";
            // 
            // labelEncPos
            // 
            this.labelEncPos.AutoSize = true;
            this.labelEncPos.Location = new System.Drawing.Point(174, 22);
            this.labelEncPos.Name = "labelEncPos";
            this.labelEncPos.Size = new System.Drawing.Size(53, 12);
            this.labelEncPos.TabIndex = 14;
            this.labelEncPos.Text = "实际位置";
            // 
            // labelPrfVel
            // 
            this.labelPrfVel.AutoSize = true;
            this.labelPrfVel.Location = new System.Drawing.Point(14, 51);
            this.labelPrfVel.Name = "labelPrfVel";
            this.labelPrfVel.Size = new System.Drawing.Size(53, 12);
            this.labelPrfVel.TabIndex = 13;
            this.labelPrfVel.Text = "规划速度";
            // 
            // labelPrfPos
            // 
            this.labelPrfPos.AutoSize = true;
            this.labelPrfPos.Location = new System.Drawing.Point(14, 22);
            this.labelPrfPos.Name = "labelPrfPos";
            this.labelPrfPos.Size = new System.Drawing.Size(53, 12);
            this.labelPrfPos.TabIndex = 12;
            this.labelPrfPos.Text = "规划位置";
            // 
            // groupBoxSetting
            // 
            this.groupBoxSetting.Controls.Add(this.textBoxSmooth);
            this.groupBoxSetting.Controls.Add(this.labelSmooth);
            this.groupBoxSetting.Controls.Add(this.buttonPoMove);
            this.groupBoxSetting.Controls.Add(this.textBoxDec);
            this.groupBoxSetting.Controls.Add(this.buttonNeMove);
            this.groupBoxSetting.Controls.Add(this.textBoxAcc);
            this.groupBoxSetting.Controls.Add(this.textBoxVel);
            this.groupBoxSetting.Controls.Add(this.labelDec);
            this.groupBoxSetting.Controls.Add(this.labelAcc);
            this.groupBoxSetting.Controls.Add(this.labelVel);
            this.groupBoxSetting.Location = new System.Drawing.Point(160, 118);
            this.groupBoxSetting.Name = "groupBoxSetting";
            this.groupBoxSetting.Size = new System.Drawing.Size(328, 190);
            this.groupBoxSetting.TabIndex = 3;
            this.groupBoxSetting.TabStop = false;
            this.groupBoxSetting.Text = " 参数设置";
            // 
            // textBoxSmooth
            // 
            this.textBoxSmooth.Location = new System.Drawing.Point(143, 115);
            this.textBoxSmooth.Name = "textBoxSmooth";
            this.textBoxSmooth.Size = new System.Drawing.Size(113, 21);
            this.textBoxSmooth.TabIndex = 12;
            this.textBoxSmooth.Text = "0.8";
            // 
            // labelSmooth
            // 
            this.labelSmooth.AutoSize = true;
            this.labelSmooth.Location = new System.Drawing.Point(49, 119);
            this.labelSmooth.Name = "labelSmooth";
            this.labelSmooth.Size = new System.Drawing.Size(53, 12);
            this.labelSmooth.TabIndex = 11;
            this.labelSmooth.Text = "平滑系数";
            // 
            // buttonPoMove
            // 
            this.buttonPoMove.Location = new System.Drawing.Point(170, 161);
            this.buttonPoMove.Name = "buttonPoMove";
            this.buttonPoMove.Size = new System.Drawing.Size(80, 22);
            this.buttonPoMove.TabIndex = 5;
            this.buttonPoMove.Text = "正向运动";
            this.buttonPoMove.UseVisualStyleBackColor = true;
            this.buttonPoMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPoMove_MouseDown);
            this.buttonPoMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonPoMove_MouseUp);
            // 
            // textBoxDec
            // 
            this.textBoxDec.Location = new System.Drawing.Point(144, 87);
            this.textBoxDec.Name = "textBoxDec";
            this.textBoxDec.Size = new System.Drawing.Size(113, 21);
            this.textBoxDec.TabIndex = 10;
            this.textBoxDec.Text = "0.5";
            // 
            // buttonNeMove
            // 
            this.buttonNeMove.Location = new System.Drawing.Point(52, 161);
            this.buttonNeMove.Name = "buttonNeMove";
            this.buttonNeMove.Size = new System.Drawing.Size(80, 22);
            this.buttonNeMove.TabIndex = 4;
            this.buttonNeMove.Text = "负向运动";
            this.buttonNeMove.UseVisualStyleBackColor = true;
            this.buttonNeMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonNeMove_MouseDown);
            this.buttonNeMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonNeMove_MouseUp);
            // 
            // textBoxAcc
            // 
            this.textBoxAcc.Location = new System.Drawing.Point(144, 59);
            this.textBoxAcc.Name = "textBoxAcc";
            this.textBoxAcc.Size = new System.Drawing.Size(113, 21);
            this.textBoxAcc.TabIndex = 9;
            this.textBoxAcc.Text = "0.5";
            // 
            // textBoxVel
            // 
            this.textBoxVel.Location = new System.Drawing.Point(144, 31);
            this.textBoxVel.Name = "textBoxVel";
            this.textBoxVel.Size = new System.Drawing.Size(113, 21);
            this.textBoxVel.TabIndex = 7;
            this.textBoxVel.Text = "10";
            // 
            // labelDec
            // 
            this.labelDec.AutoSize = true;
            this.labelDec.Location = new System.Drawing.Point(50, 91);
            this.labelDec.Name = "labelDec";
            this.labelDec.Size = new System.Drawing.Size(41, 12);
            this.labelDec.TabIndex = 4;
            this.labelDec.Text = "减速度";
            // 
            // labelAcc
            // 
            this.labelAcc.AutoSize = true;
            this.labelAcc.Location = new System.Drawing.Point(50, 63);
            this.labelAcc.Name = "labelAcc";
            this.labelAcc.Size = new System.Drawing.Size(41, 12);
            this.labelAcc.TabIndex = 3;
            this.labelAcc.Text = "加速度";
            // 
            // labelVel
            // 
            this.labelVel.AutoSize = true;
            this.labelVel.Location = new System.Drawing.Point(50, 35);
            this.labelVel.Name = "labelVel";
            this.labelVel.Size = new System.Drawing.Size(29, 12);
            this.labelVel.TabIndex = 1;
            this.labelVel.Text = "速度";
            // 
            // Jog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.groupBoxSetting);
            this.Name = "Jog";
            this.Size = new System.Drawing.Size(660, 533);
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.groupBoxSetting.ResumeLayout(false);
            this.groupBoxSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.TextBox textBoxEncPos;
        private System.Windows.Forms.TextBox textBoxEncVel;
        private System.Windows.Forms.TextBox textBoxPrfVel;
        private System.Windows.Forms.TextBox textBoxPrfPos;
        private System.Windows.Forms.Label labelEncVel;
        private System.Windows.Forms.Label labelEncPos;
        private System.Windows.Forms.Label labelPrfVel;
        private System.Windows.Forms.Label labelPrfPos;
        private System.Windows.Forms.GroupBox groupBoxSetting;
        private System.Windows.Forms.TextBox textBoxSmooth;
        private System.Windows.Forms.Label labelSmooth;
        private System.Windows.Forms.Button buttonPoMove;
        private System.Windows.Forms.TextBox textBoxDec;
        private System.Windows.Forms.Button buttonNeMove;
        private System.Windows.Forms.TextBox textBoxAcc;
        private System.Windows.Forms.TextBox textBoxVel;
        private System.Windows.Forms.Label labelDec;
        private System.Windows.Forms.Label labelAcc;
        private System.Windows.Forms.Label labelVel;
    }
}
