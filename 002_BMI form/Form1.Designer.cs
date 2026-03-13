namespace _002_BMI_form
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
            this.txtH = new System.Windows.Forms.TextBox();
            this.H = new System.Windows.Forms.Label();
            this.W = new System.Windows.Forms.Label();
            this.txtW = new System.Windows.Forms.TextBox();
            this.lblBMI = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtH
            // 
            this.txtH.Font = new System.Drawing.Font("굴림", 10F);
            this.txtH.Location = new System.Drawing.Point(188, 66);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(134, 34);
            this.txtH.TabIndex = 0;
            this.txtH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Font = new System.Drawing.Font("굴림", 10F);
            this.H.Location = new System.Drawing.Point(61, 66);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(81, 24);
            this.H.TabIndex = 1;
            this.H.Text = "키(cm)";
            this.H.Click += new System.EventHandler(this.label1_Click);
            // 
            // W
            // 
            this.W.AutoSize = true;
            this.W.Font = new System.Drawing.Font("굴림", 10F);
            this.W.Location = new System.Drawing.Point(61, 135);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(97, 24);
            this.W.TabIndex = 3;
            this.W.Text = "체중(kg)";
            this.W.Click += new System.EventHandler(this.W_Click);
            // 
            // txtW
            // 
            this.txtW.Font = new System.Drawing.Font("굴림", 10F);
            this.txtW.Location = new System.Drawing.Point(188, 135);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(134, 34);
            this.txtW.TabIndex = 2;
            this.txtW.TextChanged += new System.EventHandler(this.txtW_TextChanged);
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("굴림", 10F);
            this.lblBMI.Location = new System.Drawing.Point(61, 262);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(75, 24);
            this.lblBMI.TabIndex = 5;
            this.lblBMI.Text = "BMI = ";
            this.lblBMI.Click += new System.EventHandler(this.lblBMI_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 207);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "BMI 계산";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.W);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.H);
            this.Controls.Add(this.txtH);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label H;
        private System.Windows.Forms.Label W;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Button button1;
    }
}

