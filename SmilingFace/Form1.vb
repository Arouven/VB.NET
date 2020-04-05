Public Class FormSmilingFace
    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        LabelO.Left = HScrollBar1.Value
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        LabelO.Top = VScrollBar1.Value
    End Sub
End Class
