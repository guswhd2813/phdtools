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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_Tag = new System.Windows.Forms.Button();
            this.Btn_Trend = new System.Windows.Forms.Button();
            this.Btn_Info = new System.Windows.Forms.Button();
            this.Panel_Form = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel_manu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_hide = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.splitContainer_Form = new System.Windows.Forms.SplitContainer();
            this.Btn_Sync = new System.Windows.Forms.Button();
            this.Panel_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_manu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Form)).BeginInit();
            this.splitContainer_Form.Panel1.SuspendLayout();
            this.splitContainer_Form.Panel2.SuspendLayout();
            this.splitContainer_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Tag
            // 
            this.Btn_Tag.Location = new System.Drawing.Point(4, 3);
            this.Btn_Tag.Name = "Btn_Tag";
            this.Btn_Tag.Size = new System.Drawing.Size(143, 42);
            this.Btn_Tag.TabIndex = 1;
            this.Btn_Tag.Text = "Tag";
            this.Btn_Tag.UseVisualStyleBackColor = true;
            this.Btn_Tag.Click += new System.EventHandler(this.BtnClick_Tag);
            // 
            // Btn_Trend
            // 
            this.Btn_Trend.Location = new System.Drawing.Point(153, 3);
            this.Btn_Trend.Name = "Btn_Trend";
            this.Btn_Trend.Size = new System.Drawing.Size(143, 42);
            this.Btn_Trend.TabIndex = 1;
            this.Btn_Trend.Text = "Trend";
            this.Btn_Trend.UseVisualStyleBackColor = true;
            // 
            // Btn_Info
            // 
            this.Btn_Info.Location = new System.Drawing.Point(302, 3);
            this.Btn_Info.Name = "Btn_Info";
            this.Btn_Info.Size = new System.Drawing.Size(143, 42);
            this.Btn_Info.TabIndex = 1;
            this.Btn_Info.Text = "Info";
            this.Btn_Info.UseVisualStyleBackColor = true;
            this.Btn_Info.Click += new System.EventHandler(this.BtnClick_Info);
            // 
            // Panel_Form
            // 
            this.Panel_Form.Controls.Add(this.splitContainer1);
            this.Panel_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Form.Location = new System.Drawing.Point(0, 0);
            this.Panel_Form.Name = "Panel_Form";
            this.Panel_Form.Size = new System.Drawing.Size(1062, 529);
            this.Panel_Form.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.CausesValidation = false;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Panel1.Controls.Add(this.panel_manu);
            this.splitContainer1.Panel1MinSize = 20;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_main);
            this.splitContainer1.Size = new System.Drawing.Size(1062, 529);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            this.splitContainer1.TabStop = false;
            // 
            // panel_manu
            // 
            this.panel_manu.AllowDrop = true;
            this.panel_manu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_manu.Controls.Add(this.panel1);
            this.panel_manu.Controls.Add(this.dataGridView1);
            this.panel_manu.Controls.Add(this.button1);
            this.panel_manu.Controls.Add(this.comboBox1);
            this.panel_manu.Controls.Add(this.label4);
            this.panel_manu.Controls.Add(this.label1);
            this.panel_manu.Controls.Add(this.textBox1);
            this.panel_manu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_manu.Location = new System.Drawing.Point(0, 0);
            this.panel_manu.Name = "panel_manu";
            this.panel_manu.Size = new System.Drawing.Size(188, 527);
            this.panel_manu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button_hide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(169, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(19, 527);
            this.panel1.TabIndex = 3;
            // 
            // button_hide
            // 
            this.button_hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_hide.FlatAppearance.BorderSize = 0;
            this.button_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hide.Location = new System.Drawing.Point(0, 234);
            this.button_hide.Name = "button_hide";
            this.button_hide.Size = new System.Drawing.Size(20, 23);
            this.button_hide.TabIndex = 0;
            this.button_hide.Text = "◀";
            this.button_hide.UseVisualStyleBackColor = true;
            this.button_hide.Click += new System.EventHandler(this.BtnClick_ManuHide);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(3, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(159, 416);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.SearchedTagDoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(82, 79);
            this.button1.MaximumSize = new System.Drawing.Size(200, 23);
            this.button1.MinimumSize = new System.Drawing.Size(60, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnClick_TagSearch);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 26);
            this.comboBox1.MaximumSize = new System.Drawing.Size(200, 0);
            this.comboBox1.MinimumSize = new System.Drawing.Size(75, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "RDI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "TAG";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(38, 52);
            this.textBox1.MaximumSize = new System.Drawing.Size(200, 21);
            this.textBox1.MinimumSize = new System.Drawing.Size(70, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 21);
            this.textBox1.TabIndex = 0;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.tabControl1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(865, 527);
            this.panel_main.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(865, 527);
            this.tabControl1.TabIndex = 0;
            // 
            // splitContainer_Form
            // 
            this.splitContainer_Form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Form.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Form.Name = "splitContainer_Form";
            this.splitContainer_Form.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Form.Panel1
            // 
            this.splitContainer_Form.Panel1.Controls.Add(this.Btn_Trend);
            this.splitContainer_Form.Panel1.Controls.Add(this.Btn_Tag);
            this.splitContainer_Form.Panel1.Controls.Add(this.Btn_Sync);
            this.splitContainer_Form.Panel1.Controls.Add(this.Btn_Info);
            // 
            // splitContainer_Form.Panel2
            // 
            this.splitContainer_Form.Panel2.Controls.Add(this.Panel_Form);
            this.splitContainer_Form.Size = new System.Drawing.Size(1064, 616);
            this.splitContainer_Form.SplitterDistance = 81;
            this.splitContainer_Form.TabIndex = 6;
            // 
            // Btn_Sync
            // 
            this.Btn_Sync.Location = new System.Drawing.Point(451, 3);
            this.Btn_Sync.Name = "Btn_Sync";
            this.Btn_Sync.Size = new System.Drawing.Size(143, 42);
            this.Btn_Sync.TabIndex = 1;
            this.Btn_Sync.Text = "Time Sync";
            this.Btn_Sync.UseVisualStyleBackColor = true;
            this.Btn_Sync.Click += new System.EventHandler(this.BtnClick_Sync);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 616);
            this.Controls.Add(this.splitContainer_Form);
            this.Name = "MainForm";
            this.Text = "PHD Tools";
            this.Load += new System.EventHandler(this.FormLoad);
            this.Panel_Form.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_manu.ResumeLayout(false);
            this.panel_manu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.splitContainer_Form.Panel1.ResumeLayout(false);
            this.splitContainer_Form.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Form)).EndInit();
            this.splitContainer_Form.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer_Form;
        private System.Windows.Forms.Button Btn_Sync;
    }
}

