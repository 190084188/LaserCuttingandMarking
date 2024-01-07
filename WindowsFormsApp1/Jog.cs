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
    public partial class Jog : UserControl
    {
        //核号、轴号变量
        const short core = 1;
        short axis = Main.axis;
        //运动参数  
        double vel;
        TJogPrm jog;
        //状态变量
        double prfpos, prfvel, encpos, encvel;
        private Timer timer;
        uint clk;
        short r = 0;
        public Jog()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            Main mainForm = this.FindForm() as Main;
            if (mainForm != null)
            {
                // 从Main获取定时器
                timer = mainForm.GetSharedTimer();
                // 这里可以添加定时器的事件处理，如果需要的话
                timer.Tick += timer_Tick;
            }
            else
            {
                MessageBox.Show("ParentForm不是Main或还未设置");
            }
        }

        private void buttonPoMove_MouseDown(object sender, MouseEventArgs e)
        {
            jog.acc = double.Parse(textBoxAcc.Text);
            jog.dec = double.Parse(textBoxDec.Text);
            jog.smooth = double.Parse(textBoxSmooth.Text);
            vel = double.Parse(textBoxVel.Text);
            r = GTN_PrfJog(core, axis);
            Main.Error_Code("GTN_PrfJog", r);
            r = GTN_SetJogPrm(core, axis, ref jog);
            Main.Error_Code("GTN_SetJogPrm", r);
            r = GTN_SetVel(core, axis, vel);
            Main.Error_Code("GTN_SetVel", r);
            r = GTN_Update(core, 1 << (axis - 1));
            Main.Error_Code("GTN_Update", r);
        }

        private void buttonPoMove_MouseUp(object sender, MouseEventArgs e)
        {
            r = GTN_Stop(core, 1 << (axis - 1), 0);   // 0为平滑停止，1为急停
            Main.Error_Code("GTN_Stop", r);
        }


        private void buttonNeMove_MouseDown(object sender, MouseEventArgs e)
        {
            jog.acc = double.Parse(textBoxAcc.Text);
            jog.dec = double.Parse(textBoxDec.Text);
            jog.smooth = double.Parse(textBoxSmooth.Text);
            vel = double.Parse(textBoxVel.Text);
            r = GTN_PrfJog(core, axis);
            Main.Error_Code("GTN_PrfJog", r);
            r = GTN_SetJogPrm(core, axis, ref jog);
            Main.Error_Code("GTN_SetJogPrm", r);
            r = GTN_SetVel(core, axis, -vel);
            Main.Error_Code("GTN_SetVel", r);
            r = GTN_Update(core, 1 << (axis - 1));
            Main.Error_Code("GTN_Update", r);
        }
        private void buttonNeMove_MouseUp(object sender, MouseEventArgs e)
        {
            r = GTN_Stop(core, 1 << (axis - 1), 0);   // 0为平滑停止，1为急停
            Main.Error_Code("GTN_Stop", r);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            GTN_GetPrfPos(core, axis, out prfpos, 1, out clk);
            textBoxPrfPos.Text = prfpos.ToString();

            GTN_GetPrfVel(core, axis, out prfvel, 1, out clk);
            textBoxPrfVel.Text = prfvel.ToString();

            GTN_GetEncPos(core, axis, out encpos, 1, out clk);
            textBoxEncPos.Text = encpos.ToString();

            GTN_GetEncVel(core, axis, out encvel, 1, out clk);
            textBoxEncVel.Text = encvel.ToString();
        }

    }
}
