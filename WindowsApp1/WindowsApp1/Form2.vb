Public Class Form2
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Enabled Then
            Form1.BackColor = Color.FromArgb(64, 64, 64)
        Else
            Form1.BackColor = Color.FromArgb(244, 244, 244)

        End If
    End Sub
End Class