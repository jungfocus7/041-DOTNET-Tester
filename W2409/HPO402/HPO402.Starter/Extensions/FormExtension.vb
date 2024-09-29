Imports System
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Windows.Forms.Integration


Namespace Extensions
    Public Module FormExtension
        Public Sub GCCall()
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Sub


        Private Sub prSizeChanged(sd As Object, ea As EventArgs)
            'GCCall()
        End Sub

        Private Sub prResizeBegin(sd As Object, ea As EventArgs)
            CType(sd, Form).SuspendLayout()
            'GCCall()
        End Sub

        Private Sub prResizeEnd(sd As Object, ea As EventArgs)
            CType(sd, Form).ResumeLayout(True)
            GCCall()
        End Sub

        <Extension()>
        Public Sub FormFirstSetting(frm As Form)
            AddHandler frm.SizeChanged, AddressOf prSizeChanged
            AddHandler frm.ResizeBegin, AddressOf prResizeBegin
            AddHandler frm.ResizeEnd, AddressOf prResizeEnd

            '모니터가 듀얼 이상일때
            Dim tcs As Screen = Screen.FromPoint(Cursor.Position)
            Dim tsb As Rectangle = tcs.WorkingArea
            Dim tlp As New Point(tsb.Right, tsb.Bottom)
            Dim tws As Size = frm.Size
            tlp.Offset(-(tws.Width + 10), -(tws.Height + 10))
            frm.Location = tlp
        End Sub




        <Extension()>
        Public Sub ElementHostFirstSetting(elh As ElementHost)
            elh.BackColorTransparent = False

            '!! ElementHost에서 메모리 누수가 있다. 그래서 이걸 써야함
            '(https://stackoverflow.com/questions/24823103/how-to-clear-memoryleak-from-elementhost-control)
            elh.PropertyMap.Remove("BackgroundImage")
            elh.PropertyMap.Remove("BackgroundImageLayout")
            'elh.PropertyMap.Remove("BackColor")
            'elh.PropertyMap.Reset("BackgroundImage")
            'elh.PropertyMap.Clear()
        End Sub

    End Module
End Namespace