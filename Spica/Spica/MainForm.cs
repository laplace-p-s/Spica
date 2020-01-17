using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Spica
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CountTimer.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //バージョン情報を取得してウィンドウに表示
            Assembly assembly = Assembly.GetExecutingAssembly();
            Version version = assembly.GetName().Version;
            this.Text = "Spica " + version.ToString();
        }

        private void CountTimer_Tick(object sender, EventArgs e)
        {
            DateTime nowTime = DateTime.Now;
            TimerDayLabel.Text = nowTime.ToString("yyyy年 MM月 dd日 (ddd)");
            TimerTimeLabel.Text = nowTime.ToLongTimeString();
        }
    }
}
