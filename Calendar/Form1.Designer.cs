namespace Calendar
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Table_MainBackground = new System.Windows.Forms.TableLayoutPanel();
            this.Table_CalendarBlock = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Sunday = new System.Windows.Forms.Label();
            this.Lbl_Saturday = new System.Windows.Forms.Label();
            this.Lbl_Friday = new System.Windows.Forms.Label();
            this.Lbl_Thursday = new System.Windows.Forms.Label();
            this.Lbl_Wednesday = new System.Windows.Forms.Label();
            this.Lbl_Tuesday = new System.Windows.Forms.Label();
            this.Lbl_Monday = new System.Windows.Forms.Label();
            this.Lbl_LunarYearName = new System.Windows.Forms.Label();
            this.Lbl_LunarDate = new System.Windows.Forms.Label();
            this.Lbl_SolarDayInfo = new System.Windows.Forms.Label();
            this.Lbl_SolarDate = new System.Windows.Forms.Label();
            this.Lbl_CNWeekName = new System.Windows.Forms.Label();
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.PicBox_ReturnToday = new System.Windows.Forms.PictureBox();
            this.Cbo_Months = new System.Windows.Forms.ComboBox();
            this.Cbo_Years = new System.Windows.Forms.ComboBox();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.Btn_MiniSize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dragControl1 = new CustomUserControl.DragControl();
            this.dragControl2 = new CustomUserControl.DragControl();
            this.dragControl3 = new CustomUserControl.DragControl();
            this.Table_MainBackground.SuspendLayout();
            this.Table_CalendarBlock.SuspendLayout();
            this.Panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_ReturnToday)).BeginInit();
            this.SuspendLayout();
            // 
            // Table_MainBackground
            // 
            this.Table_MainBackground.BackColor = System.Drawing.Color.White;
            this.Table_MainBackground.ColumnCount = 2;
            this.Table_MainBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.20979F));
            this.Table_MainBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.79021F));
            this.Table_MainBackground.Controls.Add(this.Table_CalendarBlock, 0, 0);
            this.Table_MainBackground.Controls.Add(this.Lbl_LunarYearName, 1, 5);
            this.Table_MainBackground.Controls.Add(this.Lbl_LunarDate, 1, 4);
            this.Table_MainBackground.Controls.Add(this.Lbl_SolarDayInfo, 1, 3);
            this.Table_MainBackground.Controls.Add(this.Lbl_SolarDate, 1, 1);
            this.Table_MainBackground.Controls.Add(this.Lbl_CNWeekName, 1, 2);
            this.Table_MainBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_MainBackground.Location = new System.Drawing.Point(0, 32);
            this.Table_MainBackground.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Table_MainBackground.Name = "Table_MainBackground";
            this.Table_MainBackground.RowCount = 7;
            this.Table_MainBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Table_MainBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Table_MainBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Table_MainBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.Table_MainBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Table_MainBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.Table_MainBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.Table_MainBackground.Size = new System.Drawing.Size(536, 365);
            this.Table_MainBackground.TabIndex = 0;
            // 
            // Table_CalendarBlock
            // 
            this.Table_CalendarBlock.BackColor = System.Drawing.Color.White;
            this.Table_CalendarBlock.ColumnCount = 7;
            this.Table_CalendarBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table_CalendarBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table_CalendarBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table_CalendarBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table_CalendarBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table_CalendarBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table_CalendarBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table_CalendarBlock.Controls.Add(this.Lbl_Sunday, 6, 0);
            this.Table_CalendarBlock.Controls.Add(this.Lbl_Saturday, 5, 0);
            this.Table_CalendarBlock.Controls.Add(this.Lbl_Friday, 4, 0);
            this.Table_CalendarBlock.Controls.Add(this.Lbl_Thursday, 3, 0);
            this.Table_CalendarBlock.Controls.Add(this.Lbl_Wednesday, 2, 0);
            this.Table_CalendarBlock.Controls.Add(this.Lbl_Tuesday, 1, 0);
            this.Table_CalendarBlock.Controls.Add(this.Lbl_Monday, 0, 0);
            this.Table_CalendarBlock.Location = new System.Drawing.Point(0, 0);
            this.Table_CalendarBlock.Margin = new System.Windows.Forms.Padding(0);
            this.Table_CalendarBlock.Name = "Table_CalendarBlock";
            this.Table_CalendarBlock.RowCount = 7;
            this.Table_MainBackground.SetRowSpan(this.Table_CalendarBlock, 7);
            this.Table_CalendarBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Table_CalendarBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Table_CalendarBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Table_CalendarBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Table_CalendarBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Table_CalendarBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Table_CalendarBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Table_CalendarBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.Table_CalendarBlock.Size = new System.Drawing.Size(376, 365);
            this.Table_CalendarBlock.TabIndex = 0;
            // 
            // Lbl_Sunday
            // 
            this.Lbl_Sunday.AutoSize = true;
            this.Lbl_Sunday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Lbl_Sunday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Sunday.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Sunday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_Sunday.Location = new System.Drawing.Point(120, 0);
            this.Lbl_Sunday.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Sunday.Name = "Lbl_Sunday";
            this.Lbl_Sunday.Size = new System.Drawing.Size(256, 36);
            this.Lbl_Sunday.TabIndex = 6;
            this.Lbl_Sunday.Text = "日";
            this.Lbl_Sunday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Saturday
            // 
            this.Lbl_Saturday.AutoSize = true;
            this.Lbl_Saturday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Lbl_Saturday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Saturday.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Saturday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Lbl_Saturday.Location = new System.Drawing.Point(100, 0);
            this.Lbl_Saturday.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Saturday.Name = "Lbl_Saturday";
            this.Lbl_Saturday.Size = new System.Drawing.Size(20, 36);
            this.Lbl_Saturday.TabIndex = 5;
            this.Lbl_Saturday.Text = "六";
            this.Lbl_Saturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Friday
            // 
            this.Lbl_Friday.AutoSize = true;
            this.Lbl_Friday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Lbl_Friday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Friday.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Friday.Location = new System.Drawing.Point(80, 0);
            this.Lbl_Friday.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Friday.Name = "Lbl_Friday";
            this.Lbl_Friday.Size = new System.Drawing.Size(20, 36);
            this.Lbl_Friday.TabIndex = 4;
            this.Lbl_Friday.Text = "五";
            this.Lbl_Friday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Thursday
            // 
            this.Lbl_Thursday.AutoSize = true;
            this.Lbl_Thursday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Lbl_Thursday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Thursday.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Thursday.Location = new System.Drawing.Point(60, 0);
            this.Lbl_Thursday.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Thursday.Name = "Lbl_Thursday";
            this.Lbl_Thursday.Size = new System.Drawing.Size(20, 36);
            this.Lbl_Thursday.TabIndex = 3;
            this.Lbl_Thursday.Text = "四";
            this.Lbl_Thursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Wednesday
            // 
            this.Lbl_Wednesday.AutoSize = true;
            this.Lbl_Wednesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Lbl_Wednesday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Wednesday.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Wednesday.Location = new System.Drawing.Point(40, 0);
            this.Lbl_Wednesday.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Wednesday.Name = "Lbl_Wednesday";
            this.Lbl_Wednesday.Size = new System.Drawing.Size(20, 36);
            this.Lbl_Wednesday.TabIndex = 2;
            this.Lbl_Wednesday.Text = "三";
            this.Lbl_Wednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Tuesday
            // 
            this.Lbl_Tuesday.AutoSize = true;
            this.Lbl_Tuesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Lbl_Tuesday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Tuesday.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Tuesday.Location = new System.Drawing.Point(20, 0);
            this.Lbl_Tuesday.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Tuesday.Name = "Lbl_Tuesday";
            this.Lbl_Tuesday.Size = new System.Drawing.Size(20, 36);
            this.Lbl_Tuesday.TabIndex = 1;
            this.Lbl_Tuesday.Text = "二";
            this.Lbl_Tuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Monday
            // 
            this.Lbl_Monday.AutoSize = true;
            this.Lbl_Monday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Lbl_Monday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Monday.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Monday.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Monday.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Monday.Name = "Lbl_Monday";
            this.Lbl_Monday.Size = new System.Drawing.Size(20, 36);
            this.Lbl_Monday.TabIndex = 0;
            this.Lbl_Monday.Text = "一";
            this.Lbl_Monday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_LunarYearName
            // 
            this.Lbl_LunarYearName.AutoSize = true;
            this.Lbl_LunarYearName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_LunarYearName.Font = new System.Drawing.Font("黑体", 10F);
            this.Lbl_LunarYearName.Location = new System.Drawing.Point(378, 201);
            this.Lbl_LunarYearName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_LunarYearName.Name = "Lbl_LunarYearName";
            this.Lbl_LunarYearName.Size = new System.Drawing.Size(156, 21);
            this.Lbl_LunarYearName.TabIndex = 3;
            this.Lbl_LunarYearName.Text = "戊戌【狗】年";
            this.Lbl_LunarYearName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_LunarDate
            // 
            this.Lbl_LunarDate.AutoSize = true;
            this.Lbl_LunarDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_LunarDate.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_LunarDate.ForeColor = System.Drawing.Color.Red;
            this.Lbl_LunarDate.Location = new System.Drawing.Point(378, 180);
            this.Lbl_LunarDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_LunarDate.Name = "Lbl_LunarDate";
            this.Lbl_LunarDate.Size = new System.Drawing.Size(156, 21);
            this.Lbl_LunarDate.TabIndex = 2;
            this.Lbl_LunarDate.Text = "农历 正月初九";
            this.Lbl_LunarDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_SolarDayInfo
            // 
            this.Lbl_SolarDayInfo.AutoSize = true;
            this.Lbl_SolarDayInfo.BackColor = System.Drawing.Color.White;
            this.Lbl_SolarDayInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_SolarDayInfo.Font = new System.Drawing.Font("黑体", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_SolarDayInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_SolarDayInfo.Location = new System.Drawing.Point(378, 78);
            this.Lbl_SolarDayInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_SolarDayInfo.Name = "Lbl_SolarDayInfo";
            this.Lbl_SolarDayInfo.Size = new System.Drawing.Size(156, 102);
            this.Lbl_SolarDayInfo.TabIndex = 1;
            this.Lbl_SolarDayInfo.Text = "01";
            this.Lbl_SolarDayInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_SolarDate
            // 
            this.Lbl_SolarDate.AutoSize = true;
            this.Lbl_SolarDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_SolarDate.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_SolarDate.ForeColor = System.Drawing.Color.Black;
            this.Lbl_SolarDate.Location = new System.Drawing.Point(378, 36);
            this.Lbl_SolarDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_SolarDate.Name = "Lbl_SolarDate";
            this.Lbl_SolarDate.Size = new System.Drawing.Size(156, 21);
            this.Lbl_SolarDate.TabIndex = 0;
            this.Lbl_SolarDate.Text = "2018年1月1日";
            this.Lbl_SolarDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_CNWeekName
            // 
            this.Lbl_CNWeekName.AutoSize = true;
            this.Lbl_CNWeekName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_CNWeekName.Font = new System.Drawing.Font("黑体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_CNWeekName.ForeColor = System.Drawing.Color.Black;
            this.Lbl_CNWeekName.Location = new System.Drawing.Point(378, 57);
            this.Lbl_CNWeekName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_CNWeekName.Name = "Lbl_CNWeekName";
            this.Lbl_CNWeekName.Size = new System.Drawing.Size(156, 21);
            this.Lbl_CNWeekName.TabIndex = 4;
            this.Lbl_CNWeekName.Text = "星期一";
            this.Lbl_CNWeekName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_Title
            // 
            this.Panel_Title.BackColor = System.Drawing.SystemColors.Highlight;
            this.Panel_Title.Controls.Add(this.PicBox_ReturnToday);
            this.Panel_Title.Controls.Add(this.Cbo_Months);
            this.Panel_Title.Controls.Add(this.Cbo_Years);
            this.Panel_Title.Controls.Add(this.Lbl_Time);
            this.Panel_Title.Controls.Add(this.Btn_MiniSize);
            this.Panel_Title.Controls.Add(this.btn_Close);
            this.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Title.Location = new System.Drawing.Point(0, 0);
            this.Panel_Title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(536, 32);
            this.Panel_Title.TabIndex = 0;
            // 
            // PicBox_ReturnToday
            // 
            this.PicBox_ReturnToday.Image = ((System.Drawing.Image)(resources.GetObject("PicBox_ReturnToday.Image")));
            this.PicBox_ReturnToday.Location = new System.Drawing.Point(248, 0);
            this.PicBox_ReturnToday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PicBox_ReturnToday.Name = "PicBox_ReturnToday";
            this.PicBox_ReturnToday.Size = new System.Drawing.Size(30, 32);
            this.PicBox_ReturnToday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicBox_ReturnToday.TabIndex = 5;
            this.PicBox_ReturnToday.TabStop = false;
            this.PicBox_ReturnToday.Visible = false;
            this.PicBox_ReturnToday.Click += new System.EventHandler(this.PicBox_ReturnToday_Click);
            // 
            // Cbo_Months
            // 
            this.Cbo_Months.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Months.DropDownWidth = 121;
            this.Cbo_Months.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_Months.Font = new System.Drawing.Font("等线", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cbo_Months.FormattingEnabled = true;
            this.Cbo_Months.ItemHeight = 14;
            this.Cbo_Months.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.Cbo_Months.Location = new System.Drawing.Point(131, 5);
            this.Cbo_Months.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbo_Months.MaxDropDownItems = 80;
            this.Cbo_Months.Name = "Cbo_Months";
            this.Cbo_Months.Size = new System.Drawing.Size(57, 22);
            this.Cbo_Months.TabIndex = 2;
            this.Cbo_Months.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Cbo_Years
            // 
            this.Cbo_Years.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Years.DropDownWidth = 121;
            this.Cbo_Years.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_Years.Font = new System.Drawing.Font("等线", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cbo_Years.FormattingEnabled = true;
            this.Cbo_Years.ItemHeight = 14;
            this.Cbo_Years.Location = new System.Drawing.Point(39, 5);
            this.Cbo_Years.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbo_Years.MaxDropDownItems = 80;
            this.Cbo_Years.Name = "Cbo_Years";
            this.Cbo_Years.Size = new System.Drawing.Size(62, 22);
            this.Cbo_Years.TabIndex = 1;
            this.Cbo_Years.SelectedIndexChanged += new System.EventHandler(this.Cbo_Years_SelectedIndexChanged);
            // 
            // Lbl_Time
            // 
            this.Lbl_Time.AutoSize = true;
            this.Lbl_Time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_Time.Font = new System.Drawing.Font("黑体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbl_Time.ForeColor = System.Drawing.Color.White;
            this.Lbl_Time.Location = new System.Drawing.Point(362, 9);
            this.Lbl_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Time.Name = "Lbl_Time";
            this.Lbl_Time.Size = new System.Drawing.Size(63, 14);
            this.Lbl_Time.TabIndex = 4;
            this.Lbl_Time.Text = "--:--:--";
            this.Lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_MiniSize
            // 
            this.Btn_MiniSize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_MiniSize.FlatAppearance.BorderSize = 0;
            this.Btn_MiniSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MiniSize.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_MiniSize.ForeColor = System.Drawing.Color.White;
            this.Btn_MiniSize.Location = new System.Drawing.Point(484, 6);
            this.Btn_MiniSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_MiniSize.Name = "Btn_MiniSize";
            this.Btn_MiniSize.Size = new System.Drawing.Size(19, 20);
            this.Btn_MiniSize.TabIndex = 0;
            this.Btn_MiniSize.Text = "—";
            this.Btn_MiniSize.UseVisualStyleBackColor = true;
            this.Btn_MiniSize.Click += new System.EventHandler(this.Btn_MiniSize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(513, 6);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(19, 20);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "×";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.Panel_Title;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.Table_MainBackground;
            // 
            // dragControl3
            // 
            this.dragControl3.SelectControl = this.Table_CalendarBlock;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 397);
            this.Controls.Add(this.Table_MainBackground);
            this.Controls.Add(this.Panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Table_MainBackground.ResumeLayout(false);
            this.Table_MainBackground.PerformLayout();
            this.Table_CalendarBlock.ResumeLayout(false);
            this.Table_CalendarBlock.PerformLayout();
            this.Panel_Title.ResumeLayout(false);
            this.Panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_ReturnToday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button Btn_MiniSize;
        private System.Windows.Forms.ComboBox Cbo_Years;
        private System.Windows.Forms.ComboBox Cbo_Months;
        private System.Windows.Forms.TableLayoutPanel Table_MainBackground;
        private System.Windows.Forms.Label Lbl_SolarDate;
        private System.Windows.Forms.Label Lbl_SolarDayInfo;
        private System.Windows.Forms.Label Lbl_LunarDate;
        private System.Windows.Forms.Label Lbl_LunarYearName;
        private System.Windows.Forms.Label Lbl_Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Lbl_CNWeekName;
        private System.Windows.Forms.TableLayoutPanel Table_CalendarBlock;
        private System.Windows.Forms.Label Lbl_Sunday;
        private System.Windows.Forms.Label Lbl_Saturday;
        private System.Windows.Forms.Label Lbl_Friday;
        private System.Windows.Forms.Label Lbl_Thursday;
        private System.Windows.Forms.Label Lbl_Wednesday;
        private System.Windows.Forms.Label Lbl_Tuesday;
        private System.Windows.Forms.Label Lbl_Monday;
        private System.Windows.Forms.PictureBox PicBox_ReturnToday;
        private CustomUserControl.DragControl dragControl1;
        private CustomUserControl.DragControl dragControl2;
        private CustomUserControl.DragControl dragControl3;
    }
}

