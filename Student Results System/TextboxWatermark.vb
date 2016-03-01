Public Class TextboxWatermark
    Inherits TextBox

    Private Const WM_PAINT = &HF

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)

        If m.Msg = WM_PAINT Then
            If Text.Length <> 0 Or Me.Focused Then
                Return
            End If
            Using g As Graphics = Me.CreateGraphics, format As New StringFormat()
                format.LineAlignment = StringAlignment.Near

                g.DrawString("Enter search term", Me.Font, Brushes.LightGray, Me.ClientRectangle, format)
            End Using
        End If
    End Sub

End Class
