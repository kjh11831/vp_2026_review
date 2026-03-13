namespace _006_basic_controls
{
    partial class Form1
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
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.welcome_label = new System.Windows.Forms.Label();
            this.click_button = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_textbox
            // 
            this.name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_textbox.Font = new System.Drawing.Font("굴림", 10F);
            this.name_textbox.Location = new System.Drawing.Point(132, 49);
            this.name_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.name_textbox.Multiline = true;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(200, 40);
            this.name_textbox.TabIndex = 27;
            this.name_textbox.Text = "\r\n\r\n";
            this.name_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("굴림", 10F);
            this.welcome_label.Location = new System.Drawing.Point(128, 126);
            this.welcome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(0, 24);
            this.welcome_label.TabIndex = 26;
            this.welcome_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // click_button
            // 
            this.click_button.AutoSize = true;
            this.click_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.click_button.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.click_button.FlatAppearance.BorderSize = 2;
            this.click_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.click_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.click_button.Location = new System.Drawing.Point(366, 49);
            this.click_button.Margin = new System.Windows.Forms.Padding(4);
            this.click_button.Name = "click_button";
            this.click_button.Size = new System.Drawing.Size(104, 41);
            this.click_button.TabIndex = 25;
            this.click_button.Text = "클릭";
            this.click_button.UseVisualStyleBackColor = false;
            this.click_button.Click += new System.EventHandler(this.click_button_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("굴림", 10F);
            this.name.Location = new System.Drawing.Point(53, 59);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(74, 24);
            this.name.TabIndex = 24;
            this.name.Text = "이름: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 198);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.click_button);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Basic Controls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button click_button;
        private System.Windows.Forms.Label name;
    }
}

