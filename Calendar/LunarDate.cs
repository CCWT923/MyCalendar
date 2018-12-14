using System;
using System.Globalization;

namespace Calendar
{
    public class LunarDate
    {
        #region 常量定义
        private readonly string[] tianGan = { "甲","乙","丙","丁","戊","己","庚","辛","壬","癸" };
        private readonly string[] diZhi = { "子","丑","寅","卯","辰","巳","午","未","申","酉","戌","亥"};
        private readonly string[] shengXiao = { "鼠","牛","虎","兔","龙","蛇","马","羊","猴","鸡","狗","猪" };
        private readonly string[] nameOfLunarMonth = {"正月","二月","三月","四月","五月","六月","七月","八月","九月","十月","冬月","腊月" };
        private readonly string[] nameOfLunarDay = {"初一","初二","初三","初四","初五","初六","初七","初八","初九","初十","十一","十二",
            "十三","十四","十五","十六","十七","十八","十九","廿","廿一","廿二","廿三","廿四","廿五","廿六","廿七","廿八","廿九","三十" };
        private string[] sixtyJiaZi = new string[60];
        
        #endregion

        ChineseLunisolarCalendar clc;

        public LunarDate()
        {
            clc = new ChineseLunisolarCalendar();

            #region 生成六十甲子
            int tg = 0;
            int dz = 0;
            for (int count = 0; count < sixtyJiaZi.Length; count++)
            {
                sixtyJiaZi[count] = tianGan[tg] + "" + diZhi[dz];
                tg++;
                dz++;
                if(tg == 10)
                {
                    tg = 0;
                }
                if(dz == 12)
                {
                    dz = 0;
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
            if(lunarType == LunarDataType.CELESTIANSTEM)
            {
                return tianGan[index];
            }
            else if(lunarType == LunarDataType.TERRESTRIALBRANCH)
            {
                return diZhi[index];
            }
            else if(lunarType == LunarDataType.SEXAGENARYYEAR)
            {
                return sixtyJiaZi[index];
            }
            else if(lunarType == LunarDataType.CHINESEZODIAC)
            {
                return shengXiao[index];
            }
            else if(lunarType == LunarDataType.DAYNAME)
            {
                return nameOfLunarDay[index];
            }
            else if(lunarType == LunarDataType.MONTHNAME)
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
            /// <summary>
            /// 天干
            /// </summary>
            CELESTIANSTEM = 1,
            /// <summary>
            /// 地支
            /// </summary>
            TERRESTRIALBRANCH = 2,
            /// <summary>
            /// 生肖
            /// </summary>
            CHINESEZODIAC = 3,
            /// <summary>
            /// 六十甲子
            /// </summary>
            SEXAGENARYYEAR = 4,
            /// <summary>
            /// 月份名称
            /// </summary>
            MONTHNAME = 5,
            /// <summary>
            /// 日名称
            /// </summary>
            DAYNAME = 6
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
            return GetLunarData(LunarDataType.SEXAGENARYYEAR, clc.GetSexagenaryYear(new DateTime(year, 1, 1)) - 1);
        }
        #endregion
    }
}
