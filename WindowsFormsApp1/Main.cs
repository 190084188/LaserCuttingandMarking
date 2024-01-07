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
    public partial class Main : Form
    {
        public static short r;
        string cfg = "gtn_core.cfg";
        public static bool[] axisOn = new bool[8];
        public static short core = 1;
        public static short axis = 1;

        public Main()
        {
            InitializeComponent();
            
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C)
            {
                ctrlToolStripMenuItem.ShowDropDown();
            }
            else if (e.KeyCode == Keys.M)
            {
                motionToolStripMenuItem.ShowDropDown();
            }
            else if (e.KeyCode == Keys.R)
            {
                fileToolStripMenuItem.ShowDropDown();
            }
            else if (e.KeyCode == Keys.I)
            {
                infoToolStripMenuItem.ShowDropDown();
            }
            else if (e.KeyCode == Keys.F)
            {
                funToolStripMenuItem.ShowDropDown();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.No)
            { 
                e.Cancel = true;
            }
        }
        public static void Error_Code(string command, short code)
        {
            if (r != 0)
            {
                string msg;
                string meaning;
                switch (code)
                {
                    case 1:
                        {
                            meaning = "指令执行错误";
                            break;
                        }
                    case 2:
                        {
                            meaning = "license 不支持";
                            break;
                        }
                    case 7:
                        {
                            meaning = "指令参数错误";
                            break;
                        }
                    case -1:
                        {
                            meaning = "主机和运动控制器通讯失败";
                            break;
                        }
                    case -6:
                        {
                            meaning = "打开控制器失败";
                            break;
                        }
                    case -7:
                        {
                            meaning = "运动控制器没有响应";
                            break;
                        }
                    case -10:
                        {
                            meaning = "主机和运动控制器通讯失败";
                            break;
                        }
                    case -11:
                        {
                            meaning = "动态库加载失败";
                            break;
                        }
                    case -13:
                        {
                            meaning = "编码器初始化失败";
                            break;
                        }
                    case 14:
                        {
                            meaning = "编码器初始化失败";
                            break;
                        }
                    case -15:
                        {
                            meaning = "动态库版本不匹配";
                            break;
                        }
                    case 15:
                        {
                            meaning = "动态库版本不匹配";
                            break;
                        }
                    case 16:
                        {
                            meaning = "动态库版本不匹配";
                            break;
                        }
                    case 8:
                        meaning = "不支持的指令,此定义只用于函数返回值判断";
                        break;
                    case -100:
                        meaning = "申请内存失败";
                        break;
                    case -101:
                        meaning = "释放内存或者删除对象失败";
                        break;
                    case -102:
                        meaning = "内部运行监测到指针为空";
                        break;
                    case -103:
                        meaning = "函数调用顺序错误";
                        break;
                    case -104:
                        meaning = "PCI句柄为空";
                        break;
                    case -105:
                        meaning = "参数溢出";
                        break;
                    case -106:
                        meaning = "两个网口都连接失败";
                        break;
                    case -107:
                        meaning = "发生不可能的错误";
                        break;
                    case -108:
                        meaning = "ID冲突";
                        break;
                    case -109:
                        meaning = "扫描网络异常";
                        break;
                    case -110:
                        meaning = "未分配ID";
                        break;
                    case -111:
                        meaning = "多线程等待对象超时";
                        break;
                    case -112:
                        meaning = "访问数组越界";
                        break;
                    case -113:
                        meaning = "ID不存在";
                        break;
                    case -114:
                        meaning = "对象未创建";
                        break;
                    case -115:
                        meaning = "参数输入错误";
                        break;
                    case -116:
                        meaning = "Pdu DMA配置失败";
                        break;
                    case -117:
                        meaning = "PCI/FPGA操作错误";
                        break;
                    case -118:
                        meaning = "数据校验出错";
                        break;
                    case -119:
                        meaning = "该设备只能本地控制,不支持由网络控制";
                        break;
                    case -120:
                        meaning = "mail或者PDU操作的响应数据个数不能为0";
                        break;
                    case -121:
                        meaning = "多线程操作等待时间超时";
                        break;
                    case -122:
                        meaning = "目标站点没有响应";
                        break;
                    case -123:
                        meaning = "网络应答数据异常";
                        break;
                    case -124:
                        meaning = "设备初始化失败";
                        break;
                    case -125:
                        meaning = "目标站点的PC程序没有运行";
                        break;
                    case -127:
                        meaning = "该函数只能在主站中使用";
                        break;
                    case -128:
                        meaning = "不是所有站点都正常返回";
                        break;
                    case -129:
                        meaning = "等环网中的站点数目与配置的站点数目不一致";
                        break;
                    case -130:
                        meaning = "Check 模式下检测到站点数目不对";
                        break;
                    case 131:
                        meaning = "文件指针为空";
                        break;
                    case -131:
                        meaning = "打开文件失败";
                        break;
                    case -132:
                        meaning = "文件解析出错";
                        break;
                    case -133:
                        meaning = "文件信息和实际信息不匹配";
                        break;
                    case -134:
                        meaning = "在生成的DMA配置信息中没找到相应的站点";
                        break;
                    case -135:
                        meaning = "Check 模式下给的站点个数为0";
                        break;
                    case -136:
                        meaning = "输入信息跟实际信息不匹配";
                        break;
                    case -137:
                        meaning = "文件内容不对";
                        break;
                    case -138:
                        meaning = "多主情况配置文件中主站点类型不是带处理器的站点";
                        break;
                    case -139:
                        meaning = "网络中没有带处理器的站点";
                        break;
                    case -140:
                        meaning = "机器人类的控制器只扫描到一个站点";
                        break;
                    case -141:
                        meaning = "机器人类的控制器两次扫描到的站点数不一致";
                        break;
                    case -142:
                        meaning = "网络中存在站号为0xF0等非法设备";
                        break;
                    case -143:
                        meaning = "结构体大小不对";
                        break;
                    case -144:
                        meaning = "函数为空";
                        break;
                    case -145:
                        meaning = "300初始化输入的指针为空";
                        break;
                    case -146:
                        meaning = "函数未实现相应的功能";
                        break;
                    case -147:
                        meaning = "本地访问FPGA不支持";
                        break;
                    case -150:
                        meaning = "Mail 请求总线失败";
                        break;
                    case -151:
                        meaning = "指令出错";
                        break;
                    case -152:
                        meaning = "Mail应答错误";
                        break;
                    case -153:
                        meaning = "控制源错误";
                        break;
                    case -154:
                        meaning = "报文错误";
                        break;
                    case -155:
                        meaning = "站号错误";
                        break;
                    case -156:
                        meaning = "报文超时,对应设备没有返回信息";
                        break;
                    case -157:
                        meaning = "获取绝对位置异常";
                        break;
                    case -158:
                        meaning = "设备站点超出支持上限";
                        break;
                    case -159:
                        meaning = "当前需要的DMA个数超过最大DMA支持上限";
                        break;
                    case -160:
                        meaning = "映射个数超过最大支持上限";
                        break;
                    case -161:
                        meaning = "设备类型不匹配";
                        break;
                    case -170:
                        meaning = "线程创建失败";
                        break;
                    case -171:
                        meaning = "虚函数未定义";
                        break;
                    case -172:
                        meaning = "网络复位的时候,站点缺少";
                        break;
                    case -173:
                        meaning = "当前运动模式不支持该指令";
                        break;
                    case -174:
                        meaning = "目标站不支持该指令";
                        break;
                    case -180:
                        meaning = "返回索引值出错";
                        break;
                    case -181:
                        meaning = "应答失败";
                        break;
                    case -182:
                        meaning = "校验失败";
                        break;
                    case -183:
                        meaning = "返回长度错误";
                        break;
                    case 190:
                        meaning = "协议栈不存在,或者不知该协议栈";
                        break;
                    case -190:
                        meaning = "300扫描失败";
                        break;
                    case -200:
                        meaning = "500协议解析报文长度异常";
                        break;
                    case -201:
                        meaning = "500协议报文结束符不对";
                        break;
                    case -202:
                        meaning = "500协议模块类型不对";
                        break;
                    case -203:
                        meaning = "500协议模块连接失败";
                        break;
                    case -204:
                        meaning = "500协议的控制源错误";
                        break;
                    case -205:
                        meaning = "500协议模块升级失败";
                        break;
                    case -206:
                        meaning = "500协议接入的模块数量太多";
                        break;
                    case -207:
                        meaning = "500协议没有接模块";
                        break;
                    case -208:
                        meaning = "500协议模块调用手动ID函数时,或者存在站点冲突";
                        break;
                    case -209:
                        meaning = "500协议中非EHMI模块调用EHMI函数";
                        break;
                    case -210:
                        meaning = "设置500模块ID模式失败";
                        break;
                    case -211:
                        meaning = "站的扩展模块ID模式不一致";
                        break;
                    case -212:
                        meaning = "读写超时";
                        break;
                    case -220:
                        meaning = "该函数只支持多主情况";
                        break;
                    case -230:
                        meaning = "初始化“返回值函数”压数据失败";
                        break;
                    case -231:
                        meaning = "返回值中没有该值";
                        break;
                    case -232:
                        meaning = "等环网口调试库加载失败";
                        break;
                    case -262:
                        meaning = "读取数据长度错误";
                        break;
                    case -263:
                        meaning = "读取数据校验和错误";
                        break;
                    case -264:
                        meaning = "写入数据块错误";
                        break;
                    case -265:
                        meaning = "读取数据块错误";
                        break;
                    case -266:
                        meaning = "打开设备错误";
                        break;
                    case -267:
                        meaning = "DSP忙";
                        break;
                    case -268:
                        meaning = "多线程资源忙";
                        break;
                    case -269:
                        meaning = "DSP命令执行错误";
                        break;
                    case 301:
                        meaning = "没有报文";
                        break;
                    case -302:
                        meaning = "接收错误的PDU报文";
                        break;
                    case -303:
                        meaning = "状态机异常";
                        break;
                    case 304:
                        meaning = "DSP没有正常完成计算";
                        break;
                    case -305:
                        meaning = "指令往所有设备发送失败";
                        break;
                    case 310:
                        meaning = "该站点关闭,不需要处理";
                        break;
                    case 311:
                        meaning = "站点应答失败";
                        break;
                    case -312:
                        meaning = "站号不存在";
                        break;
                    case -330:
                        meaning = "模态通过正常模式更新失败";
                        break;
                    case -331:
                        meaning = "更新CPLD时,对比失败";
                        break;
                    case 340:
                        meaning = "缓冲区中没有mail数据";
                        break;
                    case 341:
                        meaning = "缓冲区中没有pdu数据";
                        break;
                    case -400:
                        meaning = "gt_rn.dll版本不对";
                        break;
                    case 400:
                        meaning = "gt_rn.dll版本不是最新";
                        break;
                    case -401:
                        meaning = "gts.dll版本不对";
                        break;
                    case 401:
                        meaning = "gts.dll版本不是最新";
                        break;
                    case -402:
                        meaning = "dma的配置文件版本不对";
                        break;
                    case 402:
                        meaning = "dma的配置文件版本不是最新";
                        break;
                    case -403:
                        meaning = "map的配置文件版本不对";
                        break;
                    case 403:
                        meaning = "map的配置文件版本不是最新";
                        break;
                    case -404:
                        meaning = "FPGA固件版本不对";
                        break;
                    case 404:
                        meaning = "FPGA固件版本不是最新";
                        break;
                    case -405:
                        meaning = "DSP固件版本不对";
                        break;
                    case 405:
                        meaning = "DSP固件版本不是最新";
                        break;
                    case -406:
                        meaning = "CPLD固件版本版本不对";
                        break;
                    case 406:
                        meaning = "CPLD固件版本版本不是最新";
                        break;
                    case -407:
                        meaning = "加载的文件与所需文件不匹配";
                        break;
                    case -410:
                        meaning = "配置同步周期大于库支持的同步周期";
                        break;
                    case -411:
                        meaning = "网络中有的模块不支持同步周期设置为500微秒";
                        break;
                    case -412:
                        meaning = "读到的同步周期超过了固件支持的值";
                        break;
                    case -413:
                        meaning = "网络端口CRC错误超出阈值";
                        break;
                    case -500:
                        meaning = "文件传输参数个数不对";
                        break;
                    case -501:
                        meaning = "文件传输参数长度不对";
                        break;
                    case -502:
                        meaning = "文件传输内存升级失败";
                        break;
                    case -503:
                        meaning = "文件传输内存释放失败";
                        break;
                    case -504:
                        meaning = "文件传输参数错误";
                        break;
                    case 505:
                        meaning = "文件传输时文件不存在";
                        break;
                    case 510:
                        meaning = "文件传输时创建文件失败";
                        break;
                    case 511:
                        meaning = "文件传输时删除文件失败";
                        break;
                    case -512:
                        meaning = "文件传输时检验文件失败";
                        break;
                    case -513:
                        meaning = "文件传输时文件格式错误";
                        break;
                    case -600:
                        meaning = "文件传输时返回值异常";
                        break;
                    case -601:
                        meaning = "文件传输时操作失败";
                        break;
                    case -602:
                        meaning = "文件传输时操作顺序错误";
                        break;
                    case -603:
                        meaning = "文件传输时参数不匹配";
                        break;
                    case -604:
                        meaning = "文件传输时不存在该命令";
                        break;
                    case -605:
                        meaning = "读回文件校验失败";
                        break;
                    case -700:
                        meaning = "升级等待超时";
                        break;
                    case -701:
                        meaning = "升级错误";
                        break;
                    case -702:
                        meaning = "升级校验失败";
                        break;
                    case -703:
                        meaning = "升级处理器帧起始命令";
                        break;
                    case -704:
                        meaning = "丢失数据帧中flash部分";
                        break;
                    case -720:
                        meaning = "操作的FLASH已被占用";
                        break;
                    case -721:
                        meaning = "写FLASH错误";
                        break;
                    case -800:
                        meaning = "该函数仅支持wince平台";
                        break;
                    case -801:
                        meaning = "该函数仅支持win32平台";
                        break;
                    case -802:
                        meaning = "DMA读写,命令执行失败";
                        break;
                    case -900:
                        meaning = "dma配置文件和站点类型不匹配";
                        break;
                    case -1001:
                        meaning = "多主通信函数异常返回";
                        break;
                    case 1001:
                        meaning = "多主通信函数异常返回";
                        break;
                    case -1002:
                        meaning = "多主通信函数异常返回";
                        break;
                    case 1002:
                        meaning = "多主通信函数异常返回";
                        break;
                    case -1003:
                        meaning = "多主通信函数异常返回";
                        break;
                    case -1004:
                        meaning = "多主通信函数异常返回";
                        break;
                    case 1004:
                        meaning = "多主通信函数异常返回";
                        break;
                    case -1005:
                        meaning = "多主通信函数异常返回";
                        break;
                    case -1006:
                        meaning = "多主通信函数异常返回";
                        break;
                    case -1010:
                        meaning = "多主通信函数异常返回";
                        break;
                    case 1011:
                        meaning = "多主情况下某一分组中没有主站点";
                        break;
                    case 1012:
                        meaning = "从站不支持次主功能,或者次主功能使能失败";
                        break;
                    case -1013:
                        meaning = "存储在DSP的配置信息读取回来发现异常";
                        break;
                    case -1014:
                        meaning = "ram溢出";
                        break;
                    case -1015:
                        meaning = "该站不具备多主功能,误认为支持多主";
                        break;
                    case -1100:
                        meaning = "伺服命令执行失败";
                        break;
                    case -1101:
                        meaning = "伺服指令执行成功";
                        break;
                    case -1102:
                        meaning = "伺服指令参数无效";
                        break;
                    case -1103:
                        meaning = "伺服指令不支持";
                        break;
                    case -1104:
                        meaning = "伺服指令其他错误";
                        break;
                    case -1150:
                        meaning = "gts命令参数溢出";
                        break;
                    case -1151:
                        meaning = "gts命令参数错误";
                        break;
                    case -1152:
                        meaning = "驱动器读取参数不合法";
                        break;
                    case -1200:
                        meaning = "输入的数据存储空间不满足要求";
                        break;
                    case -1201:
                        meaning = "通信传输中的index错误";
                        break;
                    case -1202:
                        meaning = "用户接口协议的传输长度非法";
                        break;
                    case -1251:
                        meaning = "设备dsp版本有误";
                        break;
                    case -1252:
                        meaning = "行数据超过读缓存区";
                        break;
                    case -1253:
                        meaning = "访问模式不对应";
                        break;
                    case -1254:
                        meaning = "文件格式有误";
                        break;
                    case -1255:
                        meaning = "模板文件内容缺失";
                        break;
                    case -1256:
                        meaning = "描述模板文件与参数模板文件版本不对应";
                        break;
                    case -1257:
                        meaning = "未寻找到任何参数";
                        break;
                    case -1258:
                        meaning = "未找到合适参数描述信息";
                        break;
                    case -1259:
                        meaning = "导出参数且当前软件参数模板版本相对设备dsp版本较低时报该返回值";
                        break;
                    case -1260:
                        meaning = "参数类型出错";
                        break;
                    case -1261:
                        meaning = "导入参数文件比对参数模板出现未知参数";
                        break;
                    case -1262:
                        meaning = "导入参数文件比对参数模板出现未知参数";
                        break;
                    case -1263:
                        meaning = "未寻找到模板文件版本号";
                        break;
                    case -1264:
                        meaning = "不是子集关系";
                        break;
                    case -1265:
                        meaning = "无数据,空行";
                        break;
                    case -1266:
                        meaning = "字符串超出longlong范围";
                        break;
                    case -1267:
                        meaning = "不为十进制数字时";
                        break;
                    case -1268:
                        meaning = "数值超出变量范围";
                        break;
                    case -1269:
                        meaning = "模板文件丢失";
                        break;
                    case -1270:
                        meaning = "读取参数值出错";
                        break;
                    case -1271:
                        meaning = "写入参数值出错";
                        break;
                    case -1300:
                        meaning = "加载socket dll失败";
                        break;
                    case -1301:
                        meaning = "socket创建失败";
                        break;
                    case -1302:
                        meaning = "socket通讯失败";
                        break;
                    case -1303:
                        meaning = "socket句柄无效";
                        break;
                    case -1304:
                        meaning = "套接字错误";
                        break;
                    case -1401:
                        meaning = "命令通信失败";
                        break;
                    case -1404:
                        meaning = "命令写失败";
                        break;
                    case -1405:
                        meaning = "命令读失败";
                        break;
                    case -1500:
                        meaning = "龙门配置信息错误";
                        break;
                    case 1600:
                        meaning = "网络分布时钟丢失";
                        break;
                    case -1700:
                        meaning = "DSP响应超时";
                        break;
                    case -1800:
                        meaning = "gts使用general command指令的时候,相应的宏无定义";
                        break;
                    case -1801:
                        meaning = "gts使用general command指令的时候,参数长度不匹配";
                        break;
                    case -3000:
                        meaning = "非环网情况下,只连接了控制器B口";
                        break;
                    case -3001:
                        meaning = "网络同步异常";
                        break;
                    case -3100:
                        meaning = "该设备不支持该功能";
                        break;
                    case -3101:
                        meaning = "输入参数指针未空";
                        break;
                    case -3102:
                        meaning = "网络未初始化";
                        break;
                    case -3103:
                        meaning = "ID超出允许的支持范围";
                        break;
                    case -3105:
                        meaning = "ID超过站的数量";
                        break;
                    case -3106:
                        meaning = "扫描到的站数量超过库宏定义最大值";
                        break;
                    case -3107:
                        meaning = "Ilink对象未空";
                        break;
                    case -3108:
                        meaning = "存储字典信息空";
                        break;
                    case -3109:
                        meaning = "存储字典协议信息错误";
                        break;
                    case -3110:
                        meaning = "字典中无该索引";
                        break;
                    case -3111:
                        meaning = "该索引字节数与输入不一致";
                        break;
                    case -3112:
                        meaning = "输入的buffer过小";
                        break;
                    case -3113:
                        meaning = "未设置多圈量程";
                        break;
                    case -3114:
                        meaning = "编码器类型未定义";
                        break;
                    case -3115:
                        meaning = "读取资源信息的时候,mail操作忙";
                        break;
                    case -3116:
                        meaning = "读取资源信息为0";
                        break;
                    case -3117:
                        meaning = "没有500模块";
                        break;
                    case -3118:
                        meaning = "对于GTM模块,没有子板";
                        break;
                    case -3119:
                        meaning = "数据内存空间超过宏定义范围";
                        break;
                    case -3120:
                        meaning = "未设置编码器多圈的量程";
                        break;
                    case -3200:
                        meaning = "can初始化失败";
                        break;
                    case -3201:
                        meaning = "can设置参数失败";
                        break;
                    case -3202:
                        meaning = "can通讯超时";
                        break;
                    case -3203:
                        meaning = "can全局指针为空";
                        break;
                    case -3204:
                        meaning = "通讯关闭";
                        break;
                    case -3250:
                        meaning = "加载xml文件失败";
                        break;
                    case -3251:
                        meaning = "xml元素为空";
                        break;
                    default:
                        {
                            meaning = "";
                            break;
                        }
                }

                msg = command + "执行错误！" + '\n' + "错误代码：" + code + '\n' + meaning;
                MessageBox.Show(msg);
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            r = GTN_Open(5,1);
            if (r!=0)
            {
                Error_Code("GTN_Open", r);
                return;
            }
            else
            {
                MessageBox.Show("开卡成功！");
            }
            this.comboBoxAxis.SelectedIndex = 0;
            this.comboBoxCore.SelectedIndex = 0;
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Application.Exit();
        }

        private void buttonLoadCfg_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) // 如果用户选择了文件并点击了“打开”按钮  
            {
                cfg = openFileDialog1.FileName; // 获取所选文件的完整路径  
                r = GTN_LoadConfig(core, cfg);
                Error_Code("GTN_LoadConfig", r);
                MessageBox.Show($"您选择了文件: {cfg}"); // 显示一个消息框，告知用户所选文件的路径  
                textBoxInform.Text = "加载成功！";
            }
            
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            r = GTN_LoadConfig(core, cfg);
            Error_Code("LoadCofig", r);
            r = GTN_ClrSts(core, axis, 1);
            Error_Code("ClrSts", r);
            if (r == 0)
            textBoxInform.Text = "初始化已完成！";
        }

        private void buttonClr_Click(object sender, EventArgs e)
        {
            r = GTN_ClrSts(core,axis,1);
            Error_Code("ClrSts", r);
            if (r == 0)
            textBoxInform.Text = "清除状态成功！";

        }

        private void buttonEnable_Click(object sender, EventArgs e)
        {
            axis = Convert.ToInt16(this.comboBoxAxis.SelectedIndex + 1);
            core = Convert.ToInt16(this.comboBoxCore.SelectedIndex + 1);
            if (!axisOn[axis-1])//如果没使能axisOn[axis-1]=false
            {
                r = GTN.mc.GTN_AxisOn(core, axis); //上伺服
            Error_Code("GTN_AxisOn", r);
        }
            else
            {
                r = GTN.mc.GTN_AxisOff(core, axis); //下伺服
                Error_Code("GTN_AxisOff", r);
            }
            axisOn[axis - 1] = !axisOn[axis - 1];
        }


        private void buttonMain_Click(object sender, EventArgs e)
        {
            if (panelMain.Controls.Count > 0)
            {
                UserControl oldControl = panelMain.Controls[0] as UserControl;
                if (oldControl != null)
                {
                    panelMain.Controls.Remove(oldControl);
                    oldControl.Dispose();
                }
            }
        }

        private void markingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl Marking = new Marking();
            ReplaceUserControl(Marking);
        }

        private void jogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl Jog = new Jog();
            ReplaceUserControl(Jog);
        }
        private void ReplaceUserControl(UserControl newUserControl)
        {
            panelMain.Controls.Clear(); // 移除panel中的所有控件
            panelMain.Controls.Add(newUserControl); // 添加新的用户控件
            newUserControl.Dock = DockStyle.Fill; // 使新控件填满面板
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!axisOn[axis - 1])//如果使能状态为false，反转
                this.buttonEnable.Text = "伺服使能";
            else
                this.buttonEnable.Text = "伺服关闭";
        }

        private void buttonZeroPos_Click(object sender, EventArgs e)
        {
            r = GTN.mc.GTN_ZeroPos(core, 1, 1);
            Error_Code("GTN_ZeroPos", r);
            textBoxInform.Text = "位置清除成功！";
        }

        private void resetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            r = GTN.mc.GTN_ZeroPos(core, 1, 8);
            Error_Code("GTN_ZeroPos", r);
            r = GTN_ClrSts(core, 1, 8);
            Error_Code("GTN_ClrSts",r);
            r = GTN_Reset(core);
            Error_Code("GTN_Reset", r);
            textBoxInform.Text = ("复位所有轴成功！");
        }

        public Timer GetSharedTimer()
        {
            return timer1;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            r = GTN_Reset(core);
            Error_Code("GTN_Reset", r);
            if (r == 0)
            textBoxInform.Text = "复位成功！";
        }
    }
}
