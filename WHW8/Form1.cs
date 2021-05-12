using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WHW8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private class MessageBoxMethod
        {
            public string Name { get; set; }

            public int MessagePath { get; set; }
        }

        private List<MessageBoxMethod> _MessageMethod = new List<MessageBoxMethod>()
        {
            new MessageBoxMethod() { Name="機車",MessagePath = 1},
            new MessageBoxMethod() { Name="貨車",MessagePath = 2},
            new MessageBoxMethod() { Name="大客車",MessagePath = 3},
            new MessageBoxMethod() { Name="自用小客車",MessagePath = 4 },
            new MessageBoxMethod() { Name="營業用小客車",MessagePath = 5 }
        };

        #region 機車 _CCMethod1
        private List<MessageBoxMethod> _CCMethod1 = new List<MessageBoxMethod>()
        {
            new MessageBoxMethod() { Name="150以下 / 12HP以下(12.2PS以下)",MessagePath = 0},
            new MessageBoxMethod() { Name="151-250 / 12.1-20HP(12.3-20.3PS)",MessagePath = 800},
            new MessageBoxMethod() { Name="251-500 / 20.1HP以上(20.4PS以上)",MessagePath = 1620},
            new MessageBoxMethod() { Name="501-600",MessagePath = 2160},
            new MessageBoxMethod() { Name="601-1200",MessagePath = 4320},
            new MessageBoxMethod() { Name="1201-1800",MessagePath = 7120},
            new MessageBoxMethod() { Name="1801或以上",MessagePath = 11230}
        };

        #endregion

        #region 貨車 _CCMethod2
        private List<MessageBoxMethod> _CCMethod2 = new List<MessageBoxMethod>()
        {
            new MessageBoxMethod() { Name="500以下",MessagePath = 900},
            new MessageBoxMethod() { Name="501-600",MessagePath = 1080},
            new MessageBoxMethod() { Name="601-1200",MessagePath = 1800},
            new MessageBoxMethod() { Name="1201-1800",MessagePath = 2700},
            new MessageBoxMethod() { Name="1801-2400",MessagePath = 3600},
            new MessageBoxMethod() { Name="2401-3000 / 138HP以下(140.1PS以下)",MessagePath = 4500},
            new MessageBoxMethod() { Name="3001-3600",MessagePath = 5400},
            new MessageBoxMethod() { Name="3601-4200 / 138.1-200HP(140.2-203.0PS)",MessagePath = 6300},
            new MessageBoxMethod() { Name="4201-4800",MessagePath = 7200},
            new MessageBoxMethod() { Name="4801-5400 / 200.1-247HP(203.1-250.7PS)",MessagePath = 8100},
            new MessageBoxMethod() { Name="5401-6000",MessagePath = 9000},
            new MessageBoxMethod() { Name="6001-6600 / 247.1-286HP(250.8-290.3PS)",MessagePath = 9900},
            new MessageBoxMethod() { Name="6601-7200",MessagePath = 10800},
            new MessageBoxMethod() { Name="7201-7800 / 286.1-336HP(290.4-341.0PS)",MessagePath = 11700},
            new MessageBoxMethod() { Name="7801-8400",MessagePath = 12600},
            new MessageBoxMethod() { Name="8401-9000 / 336.1-361HP(341.1-366.4PS)",MessagePath = 13500},
            new MessageBoxMethod() { Name="9001-9600",MessagePath = 14400},
            new MessageBoxMethod() { Name="9601-10200 / 361.1HP以上(366.5PS以上)",MessagePath = 15300},
            new MessageBoxMethod() { Name="10201以上",MessagePath = 16200}
        };

        #endregion

        #region 小客車 _CCMethod3
        private List<MessageBoxMethod> _CCMethod3 = new List<MessageBoxMethod>()
        {
            new MessageBoxMethod() { Name="600以下",MessagePath = 1080},
            new MessageBoxMethod() { Name="601-1200",MessagePath = 1800},
            new MessageBoxMethod() { Name="1201-1800",MessagePath = 2700},
            new MessageBoxMethod() { Name="1801-2400",MessagePath = 3600},
            new MessageBoxMethod() { Name="2401-3000 / 138HP以下(140.1PS以下)",MessagePath = 4500},
            new MessageBoxMethod() { Name="3001-3600",MessagePath = 5400},
            new MessageBoxMethod() { Name="3601-4200 / 138.1-200HP(140.2-203.0PS)",MessagePath = 6300},
            new MessageBoxMethod() { Name="4201-4800",MessagePath = 7200},
            new MessageBoxMethod() { Name="4801-5400 / 200.1-247HP(203.1-250.7PS)",MessagePath = 8100},
            new MessageBoxMethod() { Name="5401-6000",MessagePath = 9000},
            new MessageBoxMethod() { Name="6001-6600 / 247.1-286HP(250.8-290.3PS)",MessagePath = 9900},
            new MessageBoxMethod() { Name="6601-7200",MessagePath = 10800},
            new MessageBoxMethod() { Name="7201-7800 / 286.1-336HP(290.4-341.0PS)",MessagePath = 11700},
            new MessageBoxMethod() { Name="7801-8400",MessagePath = 12600},
            new MessageBoxMethod() { Name="8401-9000 / 336.1-361HP(341.1-366.4PS)",MessagePath = 13500},
            new MessageBoxMethod() { Name="9001-9600",MessagePath = 14400},
            new MessageBoxMethod() { Name="9601-10200 / 361.1HP以上(366.5PS以上)",MessagePath = 15300},
            new MessageBoxMethod() { Name="10201以上",MessagePath = 16200}
        };
        #endregion

        #region  自用小客車 _CCMethod4
        private List<MessageBoxMethod> _CCMethod4 = new List<MessageBoxMethod>()
        {
            new MessageBoxMethod() { Name="500以下 / 38HP以下(38.6PS以下)",MessagePath = 1620},
            new MessageBoxMethod() { Name="501~600 / 38.1-56HP(38.7-56.8PS)",MessagePath = 2160},
            new MessageBoxMethod() { Name="601~1200 / 56.1-83HP(56.9-84.2PS)",MessagePath = 4320},
            new MessageBoxMethod() { Name="1201~1800 / 83.1-182HP(84.3-184.7PS)",MessagePath = 7120},
            new MessageBoxMethod() { Name="1801~2400 / 182.1-262HP(184.8-265.9PS)",MessagePath = 11230},
            new MessageBoxMethod() { Name="2401~3000 / 262.1-322HP(266-326.8PS)",MessagePath = 15210},
            new MessageBoxMethod() { Name="3001-4200 / 322.1-414HP(326.9-420.2PS",MessagePath = 28220},
            new MessageBoxMethod() { Name="4201-5400 / 414.1-469HP(420.3-476.0PS)",MessagePath = 46170},
            new MessageBoxMethod() { Name="5401-6600 / 469.1-509HP(476.1-516.6PS)",MessagePath = 69690},
            new MessageBoxMethod() { Name="601-7800 / 509.1HP以上(516.7PS以上)",MessagePath = 117000},
            new MessageBoxMethod() { Name="7801以上",MessagePath = 151200}
        };
        #endregion

        #region  營業用小客車 _CCMethod5
        private List<MessageBoxMethod> _CCMethod5 = new List<MessageBoxMethod>()
        {
            new MessageBoxMethod() { Name="500以下 / 38HP以下(38.6PS以下)",MessagePath = 900},
            new MessageBoxMethod() { Name="501~600 / 38.1-56HP(38.7-56.8PS)",MessagePath = 1260},
            new MessageBoxMethod() { Name="601~1200 / 56.1-83HP(56.9-84.2PS)",MessagePath = 2160},
            new MessageBoxMethod() { Name="1201~1800 / 83.1-182HP(84.3-184.7PS)",MessagePath = 3060},
            new MessageBoxMethod() { Name="1801~2400 / 182.1-262HP(184.8-265.9PS)",MessagePath = 6480},
            new MessageBoxMethod() { Name="2401~3000 / 262.1-322HP(266-326.8PS)",MessagePath = 9900},
            new MessageBoxMethod() { Name="3001-4200 / 322.1-414HP(326.9-420.2PS",MessagePath = 16380},
            new MessageBoxMethod() { Name="4201-5400 / 414.1-469HP(420.3-476.0PS)",MessagePath = 24300},
            new MessageBoxMethod() { Name="5401-6600 / 469.1-509HP(476.1-516.6PS)",MessagePath = 33660},
            new MessageBoxMethod() { Name="601-7800 / 509.1HP以上(516.7PS以上)",MessagePath = 44460},
            new MessageBoxMethod() { Name="7801以上",MessagePath = 56700}
        };
        #endregion


        int checkMBM = 0;//避免重複值 0:預設值



        private void Form1_Load(object sender, EventArgs e)
        {
            //DateTime dec31 = new DateTime(2010, 12, 31);
            //DateTime dateToDisplay = dec31.AddYears(0);
            //DateTime dec32 = new DateTime(2021, 12, 31);
            //DateTime dateToDisplay2 = dec32.AddYears(0);
            //DateTime BANG = DateTime.Now;

            //int intYear = DateTime.Now.Year;//取年
            //DateTime datetimeYearEnd = new DateTime(intYear,12, 31);//2021,12,31
            //DateTime dateToDisplay3 = datetimeYearEnd.AddYears(0);


            //int i = BANG.DayOfYear;
            ////int pppi = dateToDisplay.DayOfYear;
            //int CountThisYear = dateToDisplay3.DayOfYear;

            foreach (var MessageItem in this._MessageMethod)
            {
                this.comboBox1.Items.Add(MessageItem.Name); ;
            }

        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = comboBox1.SelectedItem as string;

            if (val == "機車")
                try
                {
                    if (checkMBM != 0)
                    {
                        this.comboBox2.Items.Clear();
                        foreach (var CcItem in this._CCMethod1)
                        {
                            checkMBM = 0;
                            this.comboBox2.Items.Add(CcItem.Name); ;
                        }
                    }
                }
                catch (Exception)
                {
                    this.comboBox2.SelectedItem = null;
                    MessageBox.Show("comboBox2.SelectedItem.item.Name" + val + " is defined");
                    return;
                }



            else if (val == "貨車")
            {
                try
                {
                    if (checkMBM != 1)
                    {
                        this.comboBox2.Items.Clear();
                        foreach (var CcItem in this._CCMethod2)
                        {
                            checkMBM = 1;
                            this.comboBox2.Items.Add(CcItem.Name); ;
                        }
                    }
                }
                catch (Exception)
                {
                    this.comboBox2.SelectedItem = null;
                    MessageBox.Show("comboBox2.SelectedItem.item.Name" + val + " is defined");
                    return;
                }
            }
            else if (val == "大客車")
                try
                {
                    if (checkMBM != 2)
                    {
                        this.comboBox2.Items.Clear();
                        foreach (var CcItem in this._CCMethod3)
                        {
                            checkMBM = 2;
                            this.comboBox2.Items.Add(CcItem.Name); ;
                        }
                    }
                }
                catch (Exception)
                {
                    this.comboBox2.SelectedItem = null;
                    MessageBox.Show("comboBox2.SelectedItem.item.Name" + val + " is defined");
                    return;
                }

            else if (val == "自用小客車")
                try
                {
                    if (checkMBM != 3)
                    {
                        this.comboBox2.Items.Clear();
                        foreach (var CcItem in this._CCMethod4)
                        {
                            checkMBM = 3;
                            this.comboBox2.Items.Add(CcItem.Name); ;
                        }
                    }
                }
                catch (Exception)
                {
                    this.comboBox2.SelectedItem = null;
                    MessageBox.Show("comboBox2.SelectedItem.item.Name" + val + " is defined");
                    return;
                }



            else if (val == "營業用小客車")

                try
                {
                    if (checkMBM != 4)
                    {
                        this.comboBox2.Items.Clear();
                        foreach (var CcItem in this._CCMethod5)
                        {
                            checkMBM = 4;
                            this.comboBox2.Items.Add(CcItem.Name); ;
                        }
                    }
                }
                catch (Exception)
                {
                    this.comboBox2.SelectedItem = null;
                    MessageBox.Show("comboBox2.SelectedItem.item.Name" + val + " is defined");
                    return;
                }





        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.AnsMessage.Text =
                "使用期間:" + Convert.ToString(110 + "-" + 01 + "-" + 01) + "~"
                            + Convert.ToString(110 + "-" + 12 + "-" + 31) + Environment.NewLine +
                "計算天數:" + 365 + "天" + Environment.NewLine +
                "汽缸CC數:" + 500 + "以下" + Environment.NewLine +
                "用途:" + this.comboBox1.SelectedItem + Environment.NewLine +
                "計算公式:" + Convert.ToString(900 + "*" + 365 + "/" + 365) + "=" + Convert.ToString(900) + "元" + Environment.NewLine +
                "應納稅額: 共" + Convert.ToString(900) + "元";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //DateTime bang = dateTimePicker1.Value;
            //label6.Text = DateTime.Today(bang);
            string _TimePicker = string.Empty;
            //DateTime Ttime = new DateTime("yyyy - mm - dd");

            DateTime Ttime = dateTimePicker1.Value;



            string convDate;
            convDate = Convert.ToString(Ttime);
            DateTime testTime = Convert.ToDateTime("2010-10-15");
            string BANG = Convert.ToString(testTime);

            MessageBox.Show(Ttime.ToString("yyyy/MM/dd"));

            label6.Text = convDate;
            label7.Text = BANG;

        }



        private void ThisAYear_CheckedChanged(object sender, EventArgs e)
        {

            string val = comboBox1.SelectedItem as string;


            int intThisYear = DateTime.Now.Year;//取年
            DateTime datetimeYearStart = new DateTime(intThisYear, 01, 01);//2021,01,01->取今年年初
            DateTime datetimeYearEnd = new DateTime(intThisYear, 12, 31);//2021,12,31->取今年年底

            string strYearstr = datetimeYearStart.ToString("yyyy/MM/dd");
            string strYearend = datetimeYearEnd.ToString("yyyy/MM/dd");

            TimeSpan ts =  datetimeYearEnd - datetimeYearStart;
            double days = ts.TotalDays;
            string strCountAYear = (Convert.ToInt32(days)+1).ToString();

            var PathItem =
                (from item in this._MessageMethod
                 where string.Compare(item.Name, val, true) == 0
                 select item.MessagePath).FirstOrDefault();//抓到_MessageMethod.MessagePath

            this.AnsMessage.Text =
                 "使用期間:" + strYearstr + "~"
                             + strYearend + Environment.NewLine +
                 "計算天數:" + strCountAYear + "天" + Environment.NewLine +
                 "汽缸CC數:" + PathItem + "以下" + Environment.NewLine +
                 "用途:" + this.comboBox1.SelectedItem + Environment.NewLine +
                 "計算公式:" + Convert.ToString(900 + "*" + 365 + "/" + 365) + "=" + Convert.ToString(900) + "元" + Environment.NewLine +
                 "應納稅額: 共" + Convert.ToString(900) + "元";


        }//算今年一整年並放入LABEL

        private void SelcetYearsRange_CheckedChanged(object sender, EventArgs e)
        {

        }


        //private static void ConvertToDateTime(string value,DateTime valu)
        //{
        //    DateTime convertedDate;
        //    string convDate;
        //    try
        //    {
        //        convertedDate = Convert.ToDateTime(value);
        //        convDate = Convert.ToString(valu);
        //        Console.WriteLine("'{0}' converts to {1} {2} time.",
        //                          value, convertedDate,
        //                          convertedDate.Kind.ToString());
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("'{0}' is not in the proper format.", value);
        //    }
        //}

    }
}
