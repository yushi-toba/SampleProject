using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleProject
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///　ロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            OutputConsoleLog("aaa");
            OutputConsoleLog("bbb");
        }

        /// <summary>
        /// コンソール出力
        /// </summary>
        private void OutputConsoleLog(string text)
        {
            Console.WriteLine(text);
        }

    }
}
