///时间：2018年2月23日
///自定义的控件，用来显示日历
///
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CalendarBlock
{
    public partial class LunisolarCalendar: UserControl
    {
        public LunisolarCalendar()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            //公历字体颜色
            LunarFontColor = Color.FromArgb(255,100,100,100);
            //农历字体颜色
            SolarFontColor = Color.FromArgb(255,70,70,70);
            //是否有备忘
            HasNote = false;
            //高亮色，鼠标经过
            HighlightBackColor = Color.FromArgb(255,235,235,235);
            HighlightTodayBackcolor = Color.FromArgb(255, 107, 169, 246);
            //默认背景色
            DefaultBackColor = Color.FromArgb(255,255,255,255);
            //今天的背景色
            TodayColor = Color.FromArgb(255, 181, 211, 248);
            this.IsToday = false;
            //公历字体
            SolorFont = new Font("Arial",13);
            //农历字体
            LunarFont = new Font("微软雅黑",9);
            //选中的颜色
            SelectedColor = Color.FromArgb(255,220,220,220);
        }

        #region 私有字段
        //农历标签字体颜色
        private Color _lunarFontColor;
        //公历标签字体颜色
        private Color _solarFontColor;
        //公历字体
        private Font _solarFont;
        //农历字体
        private Font _lunarFont;
        //是否处于选中模式
        private bool _isSelected;
        //是否是今日
        private bool _isToday;
        //今日的背景色
        private Color _todayColor;
        //是否有提醒
        private bool _hasNote;
        //高亮背景颜色
        private Color _highlightBackColor;
        //是今天，高亮
        private Color _highlightTodayBackcolor;
        //默认背景颜色
        private Color _defaultBackColor;
        //公历文本
        private string _solarText;
        //农历文本
        private string _lunarText;
        //选中背景色
        private Color _selectedColor;
        #endregion

        #region 重写OnPaint事件
        protected override void OnPaint(PaintEventArgs e)
        {
            //设置字体颜色
            lbl_Lunar.ForeColor = LunarFontColor;
            lbl_Solar.ForeColor = SolarFontColor;
            //设置字体
            lbl_Lunar.Font = LunarFont;
            lbl_Solar.Font = SolorFont;
            //是否是今天
            if(IsToday)
            {
                this.BackColor = TodayColor;
                lbl_Lunar.ForeColor = Color.Black;
                lbl_Solar.ForeColor = Color.Black;
            }
            else
            {
                this.BackColor = DefaultBackColor;
            }
            //是否有提醒
            if(_hasNote == true)
            {
                lbl_Note.Visible = true;
            }
            else
            {
                lbl_Note.Visible = false;
            }

            //切换选中的背景色
            //if(this.IsSelected == true)
            //{
            //    this.BackColor = SelectedColor;
            //}
            //else
            //{
            //    this.BackColor = DefaultBackColor;
            //}
            base.OnPaint(e);
        }
        #endregion

        #region 自定义属性
        [Category("外观")]
        public Color SelectedColor
        {
            get { return _selectedColor;}
            set { _selectedColor = value; RePaint(); }
        }
        [Category("其他")]
        public bool IsSelected
        {
            get { return _isSelected;}
            set { _isSelected = value; RePaint(); }
        }
        [Category("外观")]
        public Font SolorFont
        {
            get
            {
                return _solarFont;
            }
            set
            {
                _solarFont = value;
                RePaint();
            }
        }
        [Category("外观")]
        public Font LunarFont
        {
            get { return _lunarFont; }
            set { _lunarFont = value; RePaint(); }
        }
        public Color TodayColor
        {
            get
            {
                return _todayColor;
            }
            set
            {
                _todayColor = value;
                RePaint();
            }
        }
        /// <summary>
        /// 获取或设置农历标签字体颜色
        /// </summary>
        [Category("外观")]
        public Color LunarFontColor
        {
            get
            {
                return _lunarFontColor;
            }
            set
            {
                _lunarFontColor = value;
                RePaint();
            }
        }
        /// <summary>
        /// 获取或设置公历标签字体颜色
        /// </summary>
        [Category("外观")]
        public Color SolarFontColor
        {
            get
            {
                return _solarFontColor;
            }
            set
            {
                _solarFontColor = value;
                RePaint();
            }
        }

        /// <summary>
        /// 获取或设置是否有提醒
        /// </summary>
        [Category("其他")]
        public bool HasNote
        {
            get
            {
                return _hasNote;
            }
            set
            {
                _hasNote = value;
                RePaint();
            }
        }
        [Category("外观")]
        public Color HighlightBackColor
        {
            get
            {
                return _highlightBackColor;
            }
            set
            {
                _highlightBackColor = value;
                RePaint();
            }
        }
        [Category("外观"),Description("鼠标经过时的高亮色")]
        public Color HighlightTodayBackcolor
        {
            get => _highlightTodayBackcolor;
            set
            {
                _highlightTodayBackcolor = value;
                RePaint();
            }
        }
        [Category("外观")]
        public new Color DefaultBackColor
        {
            get
            {
                return _defaultBackColor;
            }
            set
            {
                _defaultBackColor = value;
                RePaint();
            }
        }

        [Category("外观")]
        public string SolarText
        {
            get
            {
                return _solarText;
            }
            set
            {
                _solarText = value;
                lbl_Solar.Text = value;
                RePaint();
            }
        }

        [Category("外观")]
        public string LunarText
        {
            get
            {
                return _lunarText;
            }
            set
            {
                _lunarText = value;
                lbl_Lunar.Text = value;
                RePaint();
            }
        }
        /// <summary>
        /// 是否是今天
        /// </summary>
        public bool IsToday
        {
            get
            {
                return _isToday;
            }
            set
            {
                _isToday = value;
                RePaint();
            }
        }

        #endregion

        public void RePaint()
        {
            OnPaint(new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
        }

        #region 鼠标进入时高亮，离开时恢复
        private void MouseEnter_Hightlight(object sender, EventArgs e)
        {
            //if(this.lbl_Lunar.Text == string.Empty && this.lbl_Solar.Text == string.Empty)
            //{
            //    return;
            //}
            if(this.IsToday)
            {
                this.BackColor = HighlightTodayBackcolor;
            }
            else
            {
                this.BackColor = HighlightBackColor;
            }
        }

        private void MouseLeave_NotHighlight(object sender, EventArgs e)
        {
            if (this.IsSelected) return;
            if (this.IsToday)
                this.BackColor = TodayColor;
            else
                this.BackColor = DefaultBackColor;
        }
        #endregion

        #region 清除所有内容并隐藏
        /// <summary>
        /// 清除所有内容并隐藏控件
        /// </summary>
        public void Clear()
        {
            //this.lbl_Solar.Text = string.Empty;
            //this.lbl_Lunar.Text = string.Empty;
            this.Visible = false;
        }
        #endregion

        /// <summary>
        /// 取消隐藏
        /// </summary>
        public void ShowControl()
        {
            this.Visible = true;
        }
    }
}
