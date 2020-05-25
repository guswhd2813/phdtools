namespace PHD_TOOLS
{
    partial class TimePanel
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.EndDate = new System.Windows.Forms.TextBox();
            this.StartDate = new System.Windows.Forms.TextBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.comboBox_Datasamplingtype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(507, 4);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(100, 21);
            this.EndDate.TabIndex = 6;
            this.EndDate.Text = "2020-04-20 00:00:00";
            this.EndDate.TextChanged += new System.EventHandler(this.EndDateChange);
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(174, 3);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(123, 21);
            this.StartDate.TabIndex = 6;
            this.StartDate.Text = "2020-01-01 00:00:00";
            this.StartDate.TextChanged += new System.EventHandler(this.StartDateChange);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(300, 4);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(204, 20);
            this.hScrollBar1.TabIndex = 4;
            // 
            // comboBox_Datasamplingtype
            // 
            this.comboBox_Datasamplingtype.FormattingEnabled = true;
            this.comboBox_Datasamplingtype.Items.AddRange(new object[] {
            "Raw",
            "Snapshot",
            "Average"});
            this.comboBox_Datasamplingtype.Location = new System.Drawing.Point(47, 3);
            this.comboBox_Datasamplingtype.Name = "comboBox_Datasamplingtype";
            this.comboBox_Datasamplingtype.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Datasamplingtype.TabIndex = 5;
            this.comboBox_Datasamplingtype.Text = "Raw";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // TimePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.comboBox_Datasamplingtype);
            this.Name = "TimePanel";
            this.Size = new System.Drawing.Size(931, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EndDate;
        private System.Windows.Forms.TextBox StartDate;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.ComboBox comboBox_Datasamplingtype;
        private System.Windows.Forms.Label label1;
    }
}
