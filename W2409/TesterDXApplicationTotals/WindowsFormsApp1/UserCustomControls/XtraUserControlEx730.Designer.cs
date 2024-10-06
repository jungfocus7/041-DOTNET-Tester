
namespace WindowsFormsApp1.UserCustomControls
{
    partial class XtraUserControlEx730
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraUserControlEx730));
            this.m_xtce730 = new WindowsFormsApp1.UserCustomControls.XtraTabControlEx730();
            this.m_spbtn71 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_xtce730)).BeginInit();
            this.SuspendLayout();
            // 
            // m_xtce731
            // 
            this.m_xtce730.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_xtce730.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_xtce730.Location = new System.Drawing.Point(0, 0);
            this.m_xtce730.Margin = new System.Windows.Forms.Padding(0);
            this.m_xtce730.Name = "m_xtce731";
            this.m_xtce730.Size = new System.Drawing.Size(400, 500);
            this.m_xtce730.TabIndex = 0;
            // 
            // m_spbtn71
            // 
            this.m_spbtn71.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_spbtn71.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_spbtn71.Appearance.Options.UseFont = true;
            this.m_spbtn71.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_spbtn71.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("m_spbtn71.ImageOptions.Image")));
            this.m_spbtn71.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.m_spbtn71.Location = new System.Drawing.Point(370, 0);
            this.m_spbtn71.Name = "m_spbtn71";
            this.m_spbtn71.Size = new System.Drawing.Size(30, 24);
            this.m_spbtn71.TabIndex = 2;
            this.m_spbtn71.ToolTip = "팝업 윈도우로 전환";
            // 
            // XtraUserControlEx730
            // 
            this.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_spbtn71);
            this.Controls.Add(this.m_xtce730);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XtraUserControlEx731";
            this.Size = new System.Drawing.Size(400, 500);
            ((System.ComponentModel.ISupportInitialize)(this.m_xtce730)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserCustomControls.XtraTabControlEx730 m_xtce730;
        private DevExpress.XtraEditors.SimpleButton m_spbtn71;
    }
}
