﻿///开始时间：2018年2月23日 19:00
///说明：打算写一个万年历程序，从开始设计自定义控件开始，即CalendarBlock组件
///初步完成时间：2018年2月25日23:33:03
///已实现功能：
///    可以查看1901年-2100年的公历和农历

using System;
using System.Windows.Forms;
using CalendarBlock;

namespace Calendar
{
    public partial class Form1 : Form
    {
        //是否已经完成初始化
        bool IsInitialized = false;
        public Form1()
        {
            InitializeComponent();
            FillYears(1902, 2100);
            Cbo_Years.SelectedIndex = Cbo_Years.Items.IndexOf(DateTime.Now.Year.ToString());
            Cbo_Months.SelectedIndex = DateTime.Now.Month - 1;
            IsInitialized = true;
            InitBlocks();
            FillTable(DateTime.Now.Year,DateTime.Now.Month,1);
            timer1.Start();
        }

        #region 填充年份
        public void FillYears(int StartYear, int EndYear)
        {
            
            for(int i = StartYear; i <= EndYear; i++)
            {
                Cbo_Years.Items.Add(i.ToString());
            }
            
        }
        #endregion

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_MiniSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        LunarDate lunarHelper = new LunarDate();
        /// <summary>
        /// 初始化日历块
        /// </summary>
        private void InitBlocks()
        {
            for(int i = 1; i < Table_CalendarBlock.RowCount;i++)
            {
                for(int j = 0; j < Table_CalendarBlock.ColumnCount; j++)
                {
                    LunisolarCalendar block = new LunisolarCalendar();
                    Table_CalendarBlock.Controls.Add(block, j, i);
                }
            }
        }

        #region 填充日历
        public void FillTable(int year, int month, int day)
        {
            //当月的第一天是星期几
            int firstDayWeekNum = -1;
            firstDayWeekNum = GetWeekNumber(year, month ,1);

            //某个月最大的天数
            int daysInMonth = GetDaysOfMonth(year, month);
            //一个日历块对象
            LunisolarCalendar calendarBlock;
            //从第二行开始，第一行为星期
            int row = 1;
            //当月第一天是星期几，就从第几列开始填充，前面的都不管
            int column = 0;
            column = firstDayWeekNum;

            //将这个月的前面的日历块内容情况，否则还会显示在那里
            for(int i = firstDayWeekNum - 1; i >= 0; i--)
            {
                calendarBlock = (LunisolarCalendar)Table_CalendarBlock.GetControlFromPosition(i,1);
                if (!(calendarBlock is null))
                {
                    //隐藏
                    calendarBlock.Clear();
                }
            }

            //农历日的名称
            string lunarDayName = "";
            LunarDate.DateOnly lunarDate = new LunarDate.DateOnly();

            for(int x = 0; x < daysInMonth; x++)
            {
                //从指定的行列获取一个日历块
                calendarBlock = (LunisolarCalendar)Table_CalendarBlock.GetControlFromPosition(column, row);
                //公历文本
                calendarBlock.SolarText = (x + 1).ToString();

                //获取农历日期
                lunarDate = lunarHelper.GetLunarDate(new DateTime(year, month, x + 1));
                //农历日名称
                if(lunarDate.Day  == 1)
                {
                    lunarDayName = lunarHelper.GetLunarData(LunarDate.LunarDataType.MONTHNAME, lunarDate.Month - 1);
                }
                else
                {
                    lunarDayName = lunarHelper.GetLunarData(LunarDate.LunarDataType.DAYNAME, lunarDate.Day - 1);
                }
                //TODO：农历节日
                if(lunarDate.Month == 8 && lunarDate.Day == 15)
                {
                    lunarDayName = "中秋节";
                }
                if(lunarDate.Month == 1 && lunarDate.Day == 1)
                {
                    lunarDayName = "春节";
                }
                //填充农历日期名称
                calendarBlock.LunarText = lunarDayName;

                //如果是今天
                if(year == DateTime.Now.Year && month == DateTime.Now.Month && (x+1) == DateTime.Now.Day)
                {
                    calendarBlock.IsToday = true;
                }
                else
                {
                    calendarBlock.IsToday = false;
                }
                //递增列，如果达到最大列，则重置为0，开始下一行的循环
                column++;
                if(column >= Table_CalendarBlock.ColumnCount)
                {
                    column = 0;
                    row++;
                }
                calendarBlock.ShowControl();

                //将最后剩下的清除，比如3月有31日，但是2月只有28天，如果从3月切换到2月，就会残留3月的最后几天
                for(int i = row; i < Table_CalendarBlock.RowCount; i++)
                {
                    for(int j = column; j < Table_CalendarBlock.ColumnCount; j++)
                    {
                        calendarBlock = (LunisolarCalendar)Table_CalendarBlock.GetControlFromPosition(j, i);
                        calendarBlock.Clear();
                    }
                }
            }
        }
        #endregion

        #region 计算星期几
        /// <summary>
        /// 计算指定的年月日星期几
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns>返回0-6之间的数字，0表示星期一，6表示星期日</returns>
        public int GetWeekNumber(int year, int month, int day)
        {
            int weekNum = 0;
            if(month == 1 || month == 2)
            {
                month += 12;
                year -= 1;
            }
            weekNum = (day + 2 * month + 3 * (month + 1) / 5 + year + year / 4 - year / 100 + year / 400) % 7;
            return weekNum;
        }
        /// <summary>
        /// 获取中文星期名称
        /// </summary>
        /// <param name="weekday">指定一个星期几的索引</param>
        /// <returns></returns>
        public string GetCNWeekName(int weekday)
        {
            string[] cnWeekName = new string[] { "一", "二", "三", "四", "五", "六", "日" };
            return cnWeekName[weekday];
        }
        #endregion

        #region 计算指定的月份最大的天数
        public int GetDaysOfMonth(int year, int month)
        {
            if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }
            else if(month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            else if(month == 2)
            {
                if(IsLeapYear(year))
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            }
            else
            {
                throw new Exception("给定的月份错误！");
            }
        }
        #endregion

        #region 计算是否是闰年
        public bool IsLeapYear(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                return true;
            else
                return false;
        }

        #endregion

        #region 选择了其他年份或月份
        /// <summary>
        /// 选择了其他月份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsInitialized)
                return;
            FillTable(DateTime.Now.Year, Cbo_Months.SelectedIndex + 1, 1);
            if(int.Parse(Cbo_Months.SelectedItem.ToString()) != DateTime.Now.Month)
            {
                Btn_BackToToday.Visible = true;
            }
            else
            {
                if(int.Parse(Cbo_Years.SelectedItem.ToString()) != DateTime.Now.Year)
                {
                    Btn_BackToToday.Visible = true;
                }
                else
                {
                    Btn_BackToToday.Visible = false;
                }
            }
        }
        /// <summary>
        /// 选择其他年份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cbo_Years_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!IsInitialized)
            {
                return;
            }
            FillTable(int.Parse(Cbo_Years.SelectedItem.ToString()), Cbo_Months.SelectedIndex + 1, 1);
            if (int.Parse(Cbo_Years.SelectedItem.ToString()) != DateTime.Now.Year)
            {
                Btn_BackToToday.Visible = true;
            }
            else
            {
                if (int.Parse(Cbo_Months.SelectedItem.ToString()) != DateTime.Now.Month)
                {
                    Btn_BackToToday.Visible = true;
                }
                else
                {
                    Btn_BackToToday.Visible = false;
                }
            }
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_Time.Text = string.Format(DateTime.Now.ToLongTimeString(), "HH:MM:SS");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LunarDate lunar = new LunarDate();
            int day = DateTime.Now.Day;
            Lbl_SolarDayInfo.Text = day < 10 ? "0" + day : day.ToString();
            Lbl_SolarDate.Text = DateTime.Now.ToString("yyyy年MM月dd日");
            Lbl_CNWeekName.Text = "星期" + GetCNWeekName(GetWeekNumber(DateTime.Now.Year, DateTime.Now.Month, day));
            var d = lunar.GetLunarDate(DateTime.Now);
            Lbl_LunarDate.Text = "农历 " + lunar.GetLunarData(LunarDate.LunarDataType.MONTHNAME,d.Month - 1) + lunar.GetLunarData(LunarDate.LunarDataType.DAYNAME,d.Day - 1);
            Lbl_LunarYearName.Text = lunar.GetGanZhi(DateTime.Now.Year) + " 年";
            
        }
        /// <summary>
        /// 返回今天
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Cbo_Years.SelectedItem = DateTime.Now.Year.ToString();
            Cbo_Months.SelectedItem = DateTime.Now.Month.ToString();
        }
    }
}
