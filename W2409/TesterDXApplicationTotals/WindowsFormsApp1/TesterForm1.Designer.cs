
namespace WindowsFormsApp1
{
    partial class TesterForm1
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
            this.m_xucc731 = new WindowsFormsApp1.UserCustomControls.XtraUserControlEx730();
            this.SuspendLayout();
            // 
            // m_xucc731
            // 
            this.m_xucc731.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_xucc731.Location = new System.Drawing.Point(9, 9);
            this.m_xucc731.Margin = new System.Windows.Forms.Padding(0);
            this.m_xucc731.Name = "m_xucc731";
            this.m_xucc731.Size = new System.Drawing.Size(806, 423);
            this.m_xucc731.TabIndex = 0;
            // 
            // TesterForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 497);
            this.Controls.Add(this.m_xucc731);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TesterForm1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserCustomControls.XtraUserControlEx730 m_xucc731;
    }
}

