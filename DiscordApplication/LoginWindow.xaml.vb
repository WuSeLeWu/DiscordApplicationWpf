Public Class LoginWindow
    Private Sub BtnLogin_Click(sender As Object, e As RoutedEventArgs)
        If txtPosta.Text = "mustafa@gmail.com" And txtSifre.Password = "mustafa123" Then
            Dim main As MainW = New MainW()
            main.Show()
            Me.Close()
        Else
            txtPostaHata.Text = " - Giriş veya e-posta/telefon numarası geçersiz!"
            txtsifreHata.Text = " - Giriş veya şifre geçersiz!"
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As RoutedEventArgs)
        WindowState = WindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub

    Private Sub Window_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)
        If e.ChangedButton = MouseButton.Left Then
            Me.DragMove()
        End If
    End Sub
End Class
