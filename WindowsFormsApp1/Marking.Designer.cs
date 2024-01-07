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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(20, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Marking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDXF);
            this.Name = "Marking";
            this.Size = new System.Drawing.Size(660, 533);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDXF;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
