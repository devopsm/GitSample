Public Class Form1

    Private Sub combo_click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        If ComboBox1.SelectedItem = "Account Receivable Journal" Then
            With frmARJ
                .Show()
            End With

        End If
    End Sub
End Class
