namespace PHD_TOOLS
{
    partial class InfoForm
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
            this.label_Host = new System.Windows.Forms.Label();
            this.label_RemoteAPI = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_PW = new System.Windows.Forms.Label();
            this.checkbox_RemoteAPI = new System.Windows.Forms.CheckBox();
            this.textBox_Host = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.button_Info_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Host
            // 
            this.label_Host.AutoSize = true;
            this.label_Host.Location = new System.Drawing.Point(47, 45);
            this.label_Host.Name = "label_Host";
            this.label_Host.Size = new System.Drawing.Size(30, 12);
            this.label_Host.TabIndex = 0;
            this.label_Host.Text = "Host";
            // 
            // label_RemoteAPI
            // 
            this.label_RemoteAPI.AutoSize = true;
            this.label_RemoteAPI.Location = new System.Drawing.Point(47, 83);
            this.label_RemoteAPI.Name = "label_RemoteAPI";
            this.label_RemoteAPI.Size = new System.Drawing.Size(48, 12);
            this.label_RemoteAPI.TabIndex = 0;
            this.label_RemoteAPI.Text = "Remote";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(47, 137);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(63, 12);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "Username";
            // 
            // label_PW
            // 
            this.label_PW.AutoSize = true;
            this.label_PW.Location = new System.Drawing.Point(47, 169);
            this.label_PW.Name = "label_PW";
            this.label_PW.Size = new System.Drawing.Size(62, 12);
            this.label_PW.TabIndex = 0;
            this.label_PW.Text = "Password";
            // 
            // checkbox_RemoteAPI
            // 
            this.checkbox_RemoteAPI.AutoSize = true;
            this.checkbox_RemoteAPI.Location = new System.Drawing.Point(115, 83);
            this.checkbox_RemoteAPI.Name = "checkbox_RemoteAPI";
            this.checkbox_RemoteAPI.Size = new System.Drawing.Size(15, 14);
            this.checkbox_RemoteAPI.TabIndex = 1;
            this.checkbox_RemoteAPI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkbox_RemoteAPI.UseVisualStyleBackColor = true;
            // 
            // textBox_Host
            // 
            this.textBox_Host.Location = new System.Drawing.Point(115, 42);
            this.textBox_Host.Name = "textBox_Host";
            this.textBox_Host.Size = new System.Drawing.Size(136, 21);
            this.textBox_Host.TabIndex = 2;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(115, 134);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(136, 21);
            this.textBox_ID.TabIndex = 2;
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(115, 166);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.Size = new System.Drawing.Size(136, 21);
            this.textBoxPW.TabIndex = 2;
            // 
            // button_Info_Save
            // 
            this.button_Info_Save.Location = new System.Drawing.Point(49, 211);
            this.button_Info_Save.Name = "button_Info_Save";
            this.button_Info_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Info_Save.TabIndex = 3;
            this.button_Info_Save.Text = "Save";
            this.button_Info_Save.UseVisualStyleBackColor = true;
            this.button_Info_Save.Click += new System.EventHandler(this.BtnClick_IniSave);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Info_Save);
            this.Controls.Add(this.textBoxPW);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.textBox_Host);
            this.Controls.Add(this.checkbox_RemoteAPI);
            this.Controls.Add(this.label_PW);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_RemoteAPI);
            this.Controls.Add(this.label_Host);
            this.Name = "InfoForm";
            this.Size = new System.Drawing.Size(891, 551);
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Host;
        private System.Windows.Forms.Label label_RemoteAPI;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_PW;
        private System.Windows.Forms.CheckBox checkbox_RemoteAPI;
        private System.Windows.Forms.TextBox textBox_Host;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.Button button_Info_Save;
    }
}
