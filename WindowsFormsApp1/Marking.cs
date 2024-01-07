using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GTN.mc;

namespace WindowsFormsApp1
{
    public partial class Marking : UserControl
    {
        private short r;
        private short laserPowerMode = 0;
        private double maxValue = 100;
        private double minValue = 10;
        private double outFrq = 10;
        private double power = 25;
        private ushort width = 10;
        private short channel = 0;
        public Marking()
        {
            InitializeComponent();

        }

        private void radioButtonDutyCycle_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonDutyCycle.Checked)
            {
                laserPowerMode = 0;
                textBoxWidth.Visible = false;
                labelWidth.Visible = false;
                textBoxOutFrq.Visible = true;
                labelOutFrq.Visible = true;
                labelMaxValue.Text = "最大值(%)：";
                labelMinValue.Text = "最小值(%)：";
                labelPower.Text = "占空比：";
            }
        }

        private void radioButtonFrequency_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonFrequency.Checked)
            {
                laserPowerMode = 1;
                labelMaxValue.Text = "最大值(KHz)：";
                labelMinValue.Text = "最小值(KHz)：";
                labelPower.Text = "输出频率：";
                textBoxWidth.Visible = true;
                labelWidth.Visible = true;
                textBoxOutFrq.Visible = false;
                labelOutFrq.Visible = false;
            }
        }
        private void radioButtonAnalog_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonAnalog.Checked)
            {
                laserPowerMode = 2;
                labelMaxValue.Text = "最大值(V)：";
                labelMinValue.Text = "最小值(V)：";
                labelPower.Text = "输出电压：";
                textBoxWidth.Visible = false;
                labelWidth.Visible = false;
                textBoxOutFrq.Visible = false;
                labelOutFrq.Visible = false;
            }
        }
        private void textBoxMaxValue_TextChanged(object sender, EventArgs e)
        {
            maxValue = double.Parse(textBoxMaxValue.Text);
        }

        private void textBoxMinValue_TextChanged(object sender, EventArgs e)
        {
            minValue = double.Parse(textBoxMinValue.Text);
        }
        private void textBoxOutFrq_TextChanged(object sender, EventArgs e)
        {
            outFrq = double.Parse(textBoxOutFrq.Text);
        }
        private void buttonConfirmed_Click(object sender, EventArgs e)
        {
            switch (laserPowerMode)
            {
                case 0:
                    r = GTN_LaserPowerMode(Main.core, laserPowerMode, maxValue, minValue, channel); // 设置激光能量控制方式为占空比调节模式
                    Main.Error_Code("GTN_LaserPowerMode", r);
                    r = GTN_LaserOutFrq(Main.core, outFrq, channel); // 设置 PWM 输出的频率为：10kHz
                    Main.Error_Code("GTN_LaserOutFrq", r);
                    r = GTN_LaserPrfCmd(Main.core, power, channel); // 设置占空比为 25%
                    Main.Error_Code("GTN_LaserPrfCmd", r);
                    break;
                case 1:
                    r = GTN_LaserPowerMode(Main.core, laserPowerMode, maxValue, minValue, channel); // 设置激光能量控制方式为频率输出
                    Main.Error_Code("GTN_LaserPowerMode", r);
                    r = GTN_SetPulseWidth(Main.core, width, channel); // 设置脉宽为：10μs
                    Main.Error_Code("SetPulseWidth", r);
                    r = GTN_LaserPrfCmd(Main.core, power, channel); // 设置输出能量
                    Main.Error_Code("GTN_LaserPrfCmd", r);
                    break;
                case 2:
                    r = GTN_LaserPowerMode(Main.core, laserPowerMode, maxValue, minValue, channel);
                    Main.Error_Code("GTN_LaserPowerMode", r);
                    r = GTN_LaserPrfCmd(Main.core, power, channel);
                    Main.Error_Code("GTN_LaserPrfCmd", r);
                    break;
                default:
                    break;
            }
        }

        private void checkBoxLaserOn_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLaserOn.Checked == true)
            {
                GTN_LaserOn(Main.core, channel);
                checkBoxLaserOn.Text = "激光关闭";
            }
            else
            {
                GTN_LaserOff(Main.core, channel);
                checkBoxLaserOn.Text = "激光开启";
            }
        }
    }
}
