namespace PHD_TOOLS
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Tag = new System.Windows.Forms.Button();
            this.Btn_Trend = new System.Windows.Forms.Button();
            this.Btn_Info = new System.Windows.Forms.Button();
            this.Panel_Form = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_hide = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel_manu = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Panel_Form.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_manu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Tag
            // 
            this.Btn_Tag.Location = new System.Drawing.Point(12, 12);
            this.Btn_Tag.Name = "Btn_Tag";
            this.Btn_Tag.Size = new System.Drawing.Size(143, 42);
            this.Btn_Tag.TabIndex = 1;
            this.Btn_Tag.Text = "Tag";
            this.Btn_Tag.UseVisualStyleBackColor = true;
            this.Btn_Tag.Click += new System.EventHandler(this.BtnClick_Tag);
            // 
            // Btn_Trend
            // 
            this.Btn_Trend.Location = new System.Drawing.Point(161, 12);
            this.Btn_Trend.Name = "Btn_Trend";
            this.Btn_Trend.Size = new System.Drawing.Size(143, 42);
            this.Btn_Trend.TabIndex = 1;
            this.Btn_Trend.Text = "Trend";
            this.Btn_Trend.UseVisualStyleBackColor = true;
            // 
            // Btn_Info
            // 
            this.Btn_Info.Location = new System.Drawing.Point(310, 12);
            this.Btn_Info.Name = "Btn_Info";
            this.Btn_Info.Size = new System.Drawing.Size(143, 42);
            this.Btn_Info.TabIndex = 1;
            this.Btn_Info.Text = "Info";
            this.Btn_Info.UseVisualStyleBackColor = true;
            this.Btn_Info.Click += new System.EventHandler(this.BtnClick_Info);
            // 
            // Panel_Form
            // 
            this.Panel_Form.Controls.Add(this.panel_main);
            this.Panel_Form.Controls.Add(this.panel_manu);
            this.Panel_Form.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Form.Location = new System.Drawing.Point(0, 62);
            this.Panel_Form.Name = "Panel_Form";
            this.Panel_Form.Size = new System.Drawing.Size(1064, 554);
            this.Panel_Form.TabIndex = 2;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.tabControl1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(180, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(884, 554);
            this.panel_main.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_hide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(168, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 554);
            this.panel1.TabIndex = 3;
            // 
            // button_hide
            // 
            this.button_hide.BackColor = System.Drawing.Color.Transparent;
            this.button_hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_hide.FlatAppearance.BorderSize = 0;
            this.button_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hide.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_hide.Location = new System.Drawing.Point(0, 236);
            this.button_hide.Name = "button_hide";
            this.button_hide.Size = new System.Drawing.Size(12, 23);
            this.button_hide.TabIndex = 0;
            this.button_hide.Text = "◀";
            this.button_hide.UseVisualStyleBackColor = false;
            this.button_hide.Click += new System.EventHandler(this.BtnClick_ManuHide);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // panel_manu
            // 
            this.panel_manu.Controls.Add(this.comboBox1);
            this.panel_manu.Controls.Add(this.panel1);
            this.panel_manu.Controls.Add(this.label3);
            this.panel_manu.Controls.Add(this.label2);
            this.panel_manu.Controls.Add(this.label1);
            this.panel_manu.Controls.Add(this.textBox3);
            this.panel_manu.Controls.Add(this.textBox2);
            this.panel_manu.Controls.Add(this.textBox1);
            this.panel_manu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_manu.Location = new System.Drawing.Point(0, 0);
            this.panel_manu.Name = "panel_manu";
            this.panel_manu.Size = new System.Drawing.Size(180, 554);
            this.panel_manu.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(56, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.Tagname_change);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 616);
            this.Controls.Add(this.Panel_Form);
            this.Controls.Add(this.Btn_Info);
            this.Controls.Add(this.Btn_Trend);
            this.Controls.Add(this.Btn_Tag);
            this.Name = "MainForm";
            this.Text = "PHD Tools";
            this.Load += new System.EventHandler(this.FormLoad);
            this.Panel_Form.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_manu.ResumeLayout(false);
            this.panel_manu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Tag;
        private System.Windows.Forms.Button Btn_Trend;
        private System.Windows.Forms.Button Btn_Info;
        private System.Windows.Forms.Panel Panel_Form;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_manu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_hide;
        
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

