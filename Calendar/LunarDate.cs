using System;
using System.Diagnostics;
using System.Globalization;

namespace Calendar
{
    class LunarDate
    {
        #region 常量定义
        private string[] tianGan = { "甲","乙","丙","丁","戊","己","庚","辛","壬","癸" };
        private string[] diZhi = { "子丑寅卯辰巳午未申酉戌亥" };
        private string[] shengXiao = { "鼠牛虎兔龙蛇马羊猴鸡狗猪" };
        private string[] nameOfLunarMonth = {"正月","二月","三月","四月","五月","六月","七月","八月","九月","十月","冬月","腊月" };
        private string[] nameOfLunarDay = {"初一","初二","初三","初四","初五","初六","初七","初八","初九","初十","十一","十二",
            "十三","十四","十五","十六","十七","十八","十九","廿","廿一","廿二","廿三","廿四","廿五","廿六","廿七","廿八","廿九","三十" };
        private string[] sixtyJiaZi = new string[60];
        #endregion

        ChineseLunisolarCalendar clc;

        public LunarDate()
        {
            clc = new ChineseLunisolarCalendar();

            #region 六十甲子
            int count = 0;
            for(int i = 0; i < tianGan.Length; i++)
            {
                for(int j = 0; j < diZhi.Length; j++)
                {
                    sixtyJiaZi[count] = tianGan[i++] + "" + diZhi[j++];
                    if(i >= 10)
                    {
                        i = 0;
                    }
                    if(j >= 12)
                    {
                        j = 0;
                    }
                }
            }
            #endregion
        }
        #region 结构体，存储年月日三个数据
        public struct DateOnly
        {
            public int Year;
            public int Month;
            public int Day;
            public DateOnly(int year, int month , int day)
            {
                this.Year = year;
                this.Month = month;
                this.Day = day;
            }
        }
        #endregion

        #region 返回指定公历日期的农历日期
        public DateOnly GetLunarDate(DateTime SolarDate)
        {
            DateOnly lunarDate;
            int month = clc.GetMonth(SolarDate); //获取月份，返回值是1-13
            if(month == 13)
            {
                month -= 1;
            }
            int day = clc.GetDayOfMonth(SolarDate);
            
            lunarDate = new DateOnly(SolarDate.Year, month, day);
            //Debug.Print("month = {0}, Day = {1}",month,day);
            return lunarDate;
        }
        #endregion

        #region 获取农历年中的第几天
        public int GetDayOfLunarYear(DateTime SolarDate)
        {
            return clc.GetDayOfYear(SolarDate);
        }
        #endregion

        #region 指定的农历年一共有多少天
        public int GetDaysInLunarYear(int year)
        {
            return clc.GetDaysInYear(year, ChineseLunisolarCalendar.ChineseEra);
        }
        #endregion

        #region 返回指定的农历月份有多少天
        public int GetDaysOfLunarMonth(int year, int month)
        {
            return clc.GetDaysInMonth(year, month,ChineseLunisolarCalendar.ChineseEra);
        }
        #endregion

        #region 获取天干、地支、生肖、月份、日期、六十甲子
        public string GetLunarData( LunarDataType lunarType, int index)
        {
            if(lunarType == LunarDataType.CelestianStem)
            {
                return tianGan[index];
            }
            else if(lunarType == LunarDataType.TerrestrialBranch)
            {
                return diZhi[index];
            }
            else if(lunarType == LunarDataType.SexagenaryYear)
            {
                return sixtyJiaZi[index];
            }
            else if(lunarType == LunarDataType.ChineseZodiac)
            {
                return shengXiao[index];
            }
            else if(lunarType == LunarDataType.DayName)
            {
                return nameOfLunarDay[index];
            }
            else if(lunarType == LunarDataType.MonthName)
            {
                return nameOfLunarMonth[index];
            }
            else
            {
                throw new Exception("无此类型！");
            }
        }
        #endregion

        #region 枚举值，可获取的农历数据类型
        ///
        public enum LunarDataType:byte
        {
            CelestianStem = 1,
            TerrestrialBranch = 2,
            ChineseZodiac = 3,
            SexagenaryYear = 4,
            MonthName = 5,
            DayName = 6
        }
        #endregion

        #region 获取指定年份中闰月的月份
        /// <summary>
        /// 获取指定年份中闰月的月份，返回0表示不闰月。返回大于0的数表示闰比返回值小1的月份
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public int GetLeapMonthInYear(int year)
        {
            return clc.GetLeapMonth(year, ChineseLunisolarCalendar.ChineseEra);
        }
        #endregion

        #region 指定农历年中的月份数
        /// <summary>
        /// 返回指定年份中农历月份数，如果存在闰月，则返回13
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public int GetMonthsInYear(int year)
        {
            return clc.GetMonthsInYear(year, ChineseLunisolarCalendar.ChineseEra);
        }
        #endregion

        #region 计算指定年份的干支
        public string GetGanZhi(int year)
        {
            return GetLunarData(LunarDataType.SexagenaryYear, clc.GetSexagenaryYear(new DateTime(year, 1, 1)) - 1);
        }
        #endregion
    }
}
