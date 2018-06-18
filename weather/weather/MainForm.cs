using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using weather.cn.com.webxml.www;

namespace weather
{
    public partial class FormMain : Form
    {
        WeatherWebService wsc = new WeatherWebService();
        
        public FormMain()
        {
            InitializeComponent();
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            Task<List<string>> t = getPro();
            List<string> pros = await t;//getPro();// wsc.getSupportProvince().ToList();
            pros.Insert(0, "");
            this.cbxPro.DataSource =pros;
        }

        private void cbxPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbxPro.Text)) { this.cbxCity.DataSource = null; return; }
            string pro = this.cbxPro.Text;
            if(!string.IsNullOrWhiteSpace(pro))
            {
                string[] city = wsc.getSupportCity(this.cbxPro.Text);
                List<string> citys = new List<string>();
                Dictionary<string, string> dicCity = new Dictionary<string, string>();
                for (int i=0;i<city.Count();i++)
                {
                    string cityName = GetChineseWord(city[i]);
                    string cityCode = city[i].Substring(city[i].IndexOf("(") + 1, city[i].IndexOf(")")-city[i].IndexOf("(")-1);
                    citys.Add(cityName);
                    dicCity.Add(cityCode, cityName);
                }
                BindingSource bs = new BindingSource();
                bs.DataSource = dicCity;
                this.cbxCity.DataSource = bs;
                this.cbxCity.DisplayMember = "Value";
                this.cbxCity.ValueMember = "Key";
            }
            
        }

        private void btnReq_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(cbxPro.Text)&&!string.IsNullOrWhiteSpace(cbxCity.Text))
            {
                string[] result = wsc.getWeatherbyCityName(cbxCity.SelectedValue.ToString());
                StringBuilder infobuilder = new StringBuilder();
                infobuilder.AppendLine("省份:"+result[0]);
                infobuilder.AppendLine("城市:"+result[1]);
                infobuilder.AppendLine("最后更新时间:"+result[4]);
                infobuilder.AppendLine("气温:"+result[5]);
                infobuilder.AppendLine("概况:"+result[6]);
                infobuilder.AppendLine("风向和风力:"+result[7]);
                this.labInfo.Text = infobuilder.ToString();

                string picName1 = result[8];
                string picName2 = result[9];
                string picPath = Application.StartupPath + "\\..\\..\\pic\\weather\\";
                pic1.Image = Image.FromFile(picPath + picName1);
                pic2.Image = new Bitmap(picPath + picName2);
                
            }
        }
       ///获取中文部分
        private string GetChineseWord(string oriText)
        {
            string x = @"[\u4E00-\u9FFF]+";
            MatchCollection Matches = Regex.Matches(oriText, x, RegexOptions.IgnoreCase);
            StringBuilder sb = new StringBuilder();
            foreach (Match NextMatch in Matches)
            {
                sb.Append(NextMatch.Value);
            }
            return sb.ToString();
        }

        private async Task<List<string>> getPro()
        {
            return wsc.getSupportProvince().ToList();
        }
    }
}
