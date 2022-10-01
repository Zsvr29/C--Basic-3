Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Sub MenuDegıs(acılanForm As Form)
        Panel1.Controls.Clear()  'Acılan form kalmasın dıye temızledık.'
        acılanForm.TopLevel = False
        Panel1.Controls.Add(acılanForm) 'panel1 e bır form ekledık'
        acılanForm.Show()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuDegıs(Anasayfa)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MenuDegıs(Hakkımızda)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MenuDegıs(İletişim)

    End Sub
End Class
