namespace _003_temperature
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
            this.btnC2F = new System.Windows.Forms.Button();
            this.btnF2C = new System.Windows.Forms.Button();
            this.txtF = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.F = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnC2F
            // 
            this.btnC2F.Font = new System.Drawing.Font("굴림", 10F);
            this.btnC2F.Location = new System.Drawing.Point(227, 84);
            this.btnC2F.Margin = new System.Windows.Forms.Padding(4);
            this.btnC2F.Name = "btnC2F";
            this.btnC2F.Size = new System.Drawing.Size(103, 32);
            this.btnC2F.TabIndex = 12;
            this.btnC2F.Text = "→";
            this.btnC2F.UseVisualStyleBackColor = true;
            this.btnC2F.Click += new System.EventHandler(this.btnC2F_Click);
            // 
            // btnF2C
            // 
            this.btnF2C.Font = new System.Drawing.Font("굴림", 10F);
            this.btnF2C.Location = new System.Drawing.Point(227, 125);
            this.btnF2C.Margin = new System.Windows.Forms.Padding(4);
            this.btnF2C.Name = "btnF2C";
            this.btnF2C.Size = new System.Drawing.Size(103, 32);
            this.btnF2C.TabIndex = 11;
            this.btnF2C.Text = "←";
            this.btnF2C.UseVisualStyleBackColor = true;
            this.btnF2C.Click += new System.EventHandler(this.btnF2C_Click);
            // 
            // txtF
            // 
            this.txtF.Font = new System.Drawing.Font("굴림", 10F);
            this.txtF.Location = new System.Drawing.Point(353, 103);
            this.txtF.Margin = new System.Windows.Forms.Padding(4);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(136, 34);
            this.txtF.TabIndex = 10;
            this.txtF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("굴림", 10F);
            this.txtC.Location = new System.Drawing.Point(65, 103);
            this.txtC.Margin = new System.Windows.Forms.Padding(4);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(136, 34);
            this.txtC.TabIndex = 9;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Font = new System.Drawing.Font("굴림", 10F);
            this.F.Location = new System.Drawing.Point(367, 58);
            this.F.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(114, 24);
            this.F.TabIndex = 8;
            this.F.Text = "화씨 온도";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("굴림", 10F);
            this.C.Location = new System.Drawing.Point(78, 58);
            this.C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(114, 24);
            this.C.TabIndex = 7;
            this.C.Text = "섭씨 온도";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 223);
            this.Controls.Add(this.btnC2F);
            this.Controls.Add(this.btnF2C);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.F);
            this.Controls.Add(this.C);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnC2F;
        private System.Windows.Forms.Button btnF2C;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.Label C;
    }
}

