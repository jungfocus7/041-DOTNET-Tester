
namespace WindowsFormsApp2
{
    partial class TPForm1
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
            this.m_xtc30 = new DevExpress.XtraTab.XtraTabControl();
            this.m_xtp31 = new DevExpress.XtraTab.XtraTabPage();
            this.m_trl31 = new DevExpress.XtraTreeList.TreeList();
            this.m_tlc1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.m_tlc2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.m_tlc3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.m_xtp32 = new DevExpress.XtraTab.XtraTabPage();
            this.m_trl32 = new DevExpress.XtraTreeList.TreeList();
            this.m_sbt31 = new DevExpress.XtraEditors.SimpleButton();
            this.m_sbt32 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_xtc30)).BeginInit();
            this.m_xtc30.SuspendLayout();
            this.m_xtp31.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_trl31)).BeginInit();
            this.m_xtp32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_trl32)).BeginInit();
            this.SuspendLayout();
            // 
            // m_xtc30
            // 
            this.m_xtc30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_xtc30.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_xtc30.Appearance.Options.UseFont = true;
            this.m_xtc30.AppearancePage.Header.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_xtc30.AppearancePage.Header.Options.UseFont = true;
            this.m_xtc30.AppearancePage.HeaderActive.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.m_xtc30.AppearancePage.HeaderActive.Options.UseFont = true;
            this.m_xtc30.Location = new System.Drawing.Point(9, 9);
            this.m_xtc30.Margin = new System.Windows.Forms.Padding(0);
            this.m_xtc30.Name = "m_xtc30";
            this.m_xtc30.SelectedTabPage = this.m_xtp31;
            this.m_xtc30.Size = new System.Drawing.Size(782, 540);
            this.m_xtc30.TabIndex = 0;
            this.m_xtc30.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.m_xtp31,
            this.m_xtp32});
            // 
            // m_xtp31
            // 
            this.m_xtp31.Controls.Add(this.m_trl31);
            this.m_xtp31.Name = "m_xtp31";
            this.m_xtp31.Size = new System.Drawing.Size(780, 511);
            this.m_xtp31.Text = "검사(31)";
            // 
            // m_trl31
            // 
            this.m_trl31.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.m_tlc1,
            this.m_tlc2,
            this.m_tlc3});
            this.m_trl31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_trl31.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_trl31.Location = new System.Drawing.Point(0, 0);
            this.m_trl31.Name = "m_trl31";
            this.m_trl31.BeginUnboundLoad();
            this.m_trl31.AppendNode(new object[] {
            "크레용",
            "피의자자백서",
            "의견"}, -1);
            this.m_trl31.AppendNode(new object[] {
            "크레용",
            "피의자자백서",
            "의견"}, -1);
            this.m_trl31.AppendNode(new object[] {
            "크레용",
            null,
            null}, 1);
            this.m_trl31.EndUnboundLoad();
            this.m_trl31.Size = new System.Drawing.Size(780, 511);
            this.m_trl31.TabIndex = 0;
            // 
            // m_tlc1
            // 
            this.m_tlc1.Caption = "문건종류";
            this.m_tlc1.FieldName = "Type";
            this.m_tlc1.Name = "m_tlc1";
            this.m_tlc1.Visible = true;
            this.m_tlc1.VisibleIndex = 0;
            // 
            // m_tlc2
            // 
            this.m_tlc2.Caption = "문건명";
            this.m_tlc2.FieldName = "Name";
            this.m_tlc2.Name = "m_tlc2";
            this.m_tlc2.Visible = true;
            this.m_tlc2.VisibleIndex = 1;
            // 
            // m_tlc3
            // 
            this.m_tlc3.Caption = "첨부";
            this.m_tlc3.FieldName = "Attach";
            this.m_tlc3.Name = "m_tlc3";
            this.m_tlc3.Visible = true;
            this.m_tlc3.VisibleIndex = 2;
            // 
            // m_xtp32
            // 
            this.m_xtp32.Controls.Add(this.m_trl32);
            this.m_xtp32.Name = "m_xtp32";
            this.m_xtp32.Size = new System.Drawing.Size(780, 511);
            this.m_xtp32.Text = "피고(24)";
            // 
            // m_trl32
            // 
            this.m_trl32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_trl32.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_trl32.Location = new System.Drawing.Point(0, 0);
            this.m_trl32.Name = "m_trl32";
            this.m_trl32.Size = new System.Drawing.Size(780, 511);
            this.m_trl32.TabIndex = 1;
            // 
            // m_sbt31
            // 
            this.m_sbt31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_sbt31.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_sbt31.Appearance.Options.UseFont = true;
            this.m_sbt31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_sbt31.Location = new System.Drawing.Point(713, 565);
            this.m_sbt31.Name = "m_sbt31";
            this.m_sbt31.Size = new System.Drawing.Size(75, 23);
            this.m_sbt31.TabIndex = 1;
            this.m_sbt31.Text = "TPK31";
            // 
            // m_sbt32
            // 
            this.m_sbt32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_sbt32.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_sbt32.Appearance.Options.UseFont = true;
            this.m_sbt32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_sbt32.Location = new System.Drawing.Point(632, 565);
            this.m_sbt32.Name = "m_sbt32";
            this.m_sbt32.Size = new System.Drawing.Size(75, 23);
            this.m_sbt32.TabIndex = 2;
            this.m_sbt32.Text = "TPK32";
            // 
            // TPForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.m_sbt32);
            this.Controls.Add(this.m_sbt31);
            this.Controls.Add(this.m_xtc30);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TPForm1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.m_xtc30)).EndInit();
            this.m_xtc30.ResumeLayout(false);
            this.m_xtp31.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_trl31)).EndInit();
            this.m_xtp32.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_trl32)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl m_xtc30;
        private DevExpress.XtraTab.XtraTabPage m_xtp31;
        private DevExpress.XtraTab.XtraTabPage m_xtp32;
        private DevExpress.XtraTreeList.TreeList m_trl31;
        private DevExpress.XtraTreeList.TreeList m_trl32;
        private DevExpress.XtraEditors.SimpleButton m_sbt31;
        private DevExpress.XtraTreeList.Columns.TreeListColumn m_tlc1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn m_tlc2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn m_tlc3;
        private DevExpress.XtraEditors.SimpleButton m_sbt32;
    }
}

