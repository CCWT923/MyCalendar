namespace CalendarBlock
{
    partial class LunisolarCalendar
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Solar = new System.Windows.Forms.Label();
            this.lbl_Lunar = new System.Windows.Forms.Label();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Solar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Lunar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Note, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(70, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.MouseEnter_Hightlight);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.MouseLeave_NotHighlight);
            // 
            // lbl_Solar
            // 
            this.lbl_Solar.AutoSize = true;
            this.lbl_Solar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Solar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Solar.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_Solar.Location = new System.Drawing.Point(4, 1);
            this.lbl_Solar.Name = "lbl_Solar";
            this.lbl_Solar.Size = new System.Drawing.Size(61, 42);
            this.lbl_Solar.TabIndex = 1;
            this.lbl_Solar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Solar.MouseEnter += new System.EventHandler(this.MouseEnter_Hightlight);
            this.lbl_Solar.MouseLeave += new System.EventHandler(this.MouseLeave_NotHighlight);
            // 
            // lbl_Lunar
            // 
            this.lbl_Lunar.AutoSize = true;
            this.lbl_Lunar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Lunar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Lunar.Location = new System.Drawing.Point(4, 43);
            this.lbl_Lunar.Name = "lbl_Lunar";
            this.lbl_Lunar.Size = new System.Drawing.Size(61, 23);
            this.lbl_Lunar.TabIndex = 2;
            this.lbl_Lunar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Lunar.MouseEnter += new System.EventHandler(this.MouseEnter_Hightlight);
            this.lbl_Lunar.MouseLeave += new System.EventHandler(this.MouseLeave_NotHighlight);
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.BackColor = System.Drawing.Color.Yellow;
            this.lbl_Note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Note.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Note.Location = new System.Drawing.Point(1, 66);
            this.lbl_Note.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(67, 4);
            this.lbl_Note.TabIndex = 3;
            this.lbl_Note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LunisolarCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "LunisolarCalendar";
            this.Size = new System.Drawing.Size(70, 70);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Solar;
        private System.Windows.Forms.Label lbl_Lunar;
        private System.Windows.Forms.Label lbl_Note;
    }
}
