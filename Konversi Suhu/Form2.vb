Public Class Form2
    Private Sub btnproses_Click(sender As Object, e As EventArgs) Handles btnproses.Click
        Dim c As Double = Val(TextBox1.Text)
        Dim r As Double = Val(TextBox2.Text)
        Dim f As Double = Val(TextBox3.Text)
        Dim k As Double = Val(TextBox4.Text)

        If TextBox1.Text <> "" = True Then
            TextBox2.Text = (4 / 5) * c
            TextBox3.Text = (9 / 5) * c + 32
            TextBox4.Text = c + 273

        ElseIf TextBox2.Text <> "" = True Then
            TextBox1.Text = (5 / 4) * r
            TextBox3.Text = (9 / 4) * r + 32
            TextBox4.Text = (5 / 4) * r + 273

        ElseIf TextBox3.Text <> "" = True Then
            TextBox1.Text = 5 / 9 * (f - 32)
            TextBox2.Text = 4 / 9 * (f - 32)
            TextBox4.Text = 5 / 9 * (f - 32) + 273

        ElseIf TextBox4.Text <> "" = True Then
            TextBox1.Text = k - 273
            TextBox2.Text = 4 / 5 * (k - 273)
            TextBox3.Text = 9 / 5 * (k - 273) + 32
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim tutup As String
        tutup = MessageBox.Show("Anda yakin ingin keluar ?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tutup = MsgBoxResult.Yes Then
            End
        Else
        End If
    End Sub
End Class
