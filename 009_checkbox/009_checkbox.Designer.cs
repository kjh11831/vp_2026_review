namespace _009_checkbox
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
            this.button1 = new System.Windows.Forms.Button();
            this.orange = new System.Windows.Forms.CheckBox();
            this.banana = new System.Windows.Forms.CheckBox();
            this.strawberry = new System.Windows.Forms.CheckBox();
            this.pear = new System.Windows.Forms.CheckBox();
            this.question_label = new System.Windows.Forms.Label();
            this.apple = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(346, 350);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 52);
            this.button1.TabIndex = 29;
            this.button1.Text = "제출";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // orange
            // 
            this.orange.AutoSize = true;
            this.orange.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orange.Location = new System.Drawing.Point(55, 302);
            this.orange.Margin = new System.Windows.Forms.Padding(4);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(112, 36);
            this.orange.TabIndex = 28;
            this.orange.Text = "오렌지";
            this.orange.UseVisualStyleBackColor = true;
            // 
            // banana
            // 
            this.banana.AutoSize = true;
            this.banana.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.banana.Location = new System.Drawing.Point(55, 256);
            this.banana.Margin = new System.Windows.Forms.Padding(4);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(112, 36);
            this.banana.TabIndex = 27;
            this.banana.Text = "바나나";
            this.banana.UseVisualStyleBackColor = true;
            // 
            // strawberry
            // 
            this.strawberry.AutoSize = true;
            this.strawberry.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.strawberry.Location = new System.Drawing.Point(55, 210);
            this.strawberry.Margin = new System.Windows.Forms.Padding(4);
            this.strawberry.Name = "strawberry";
            this.strawberry.Size = new System.Drawing.Size(88, 36);
            this.strawberry.TabIndex = 26;
            this.strawberry.Text = "딸기";
            this.strawberry.UseVisualStyleBackColor = true;
            // 
            // pear
            // 
            this.pear.AutoSize = true;
            this.pear.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pear.Location = new System.Drawing.Point(55, 164);
            this.pear.Margin = new System.Windows.Forms.Padding(4);
            this.pear.Name = "pear";
            this.pear.Size = new System.Drawing.Size(64, 36);
            this.pear.TabIndex = 25;
            this.pear.Text = "배";
            this.pear.UseVisualStyleBackColor = true;
            // 
            // question_label
            // 
            this.question_label.AutoSize = true;
            this.question_label.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.question_label.Location = new System.Drawing.Point(50, 50);
            this.question_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(435, 32);
            this.question_label.TabIndex = 24;
            this.question_label.Text = "질문: 좋아하는 과일을 모두 선택하세요";
            // 
            // apple
            // 
            this.apple.AutoSize = true;
            this.apple.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.apple.Location = new System.Drawing.Point(55, 118);
            this.apple.Margin = new System.Windows.Forms.Padding(4);
            this.apple.Name = "apple";
            this.apple.Size = new System.Drawing.Size(88, 36);
            this.apple.TabIndex = 23;
            this.apple.Text = "사과";
            this.apple.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orange);
            this.Controls.Add(this.banana);
            this.Controls.Add(this.strawberry);
            this.Controls.Add(this.pear);
            this.Controls.Add(this.question_label);
            this.Controls.Add(this.apple);
            this.Name = "Form1";
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox orange;
        private System.Windows.Forms.CheckBox banana;
        private System.Windows.Forms.CheckBox strawberry;
        private System.Windows.Forms.CheckBox pear;
        private System.Windows.Forms.Label question_label;
        private System.Windows.Forms.CheckBox apple;
    }
}

