Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports HPO402.Common.EventManages
Imports HPO402.Starter.Extensions


Public NotInheritable Class MainForm
    Public Sub New()
        ' 디자이너에서 이 호출이 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하세요.

    End Sub

    Protected Overrides Sub OnLoad(ea As EventArgs)
        MyBase.OnLoad(ea)

        FormFirstSetting()
        m_elementHost.ElementHostFirstSetting()

        Text = "💀 기록뷰어 데이터연동 추출기 (build: 240918)"
        Dim sz As Size = Size
        'sz.Width -= 200
        sz.Height -= 100
        MinimumSize = sz
    End Sub


    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        'Debug.WriteLine($"==={keyData}")

        'Dim keyChar As Char = Convert.ToChar(keyData)
        Dim keyStr As String = keyData.ToString()
        GlobalKeyboardManager.OnKeyboardEvent(keyStr)

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

End Class
