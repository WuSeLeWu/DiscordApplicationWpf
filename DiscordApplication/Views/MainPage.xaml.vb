Imports FontAwesome.WPF

Class MainPage

    Private profileWindow As ProfileWindow
    Private mainWindow As MainW


    Public Sub New()
        InitializeComponent()
        Dim defaultPageType As Type = GetType(Çevrimiçi)

        If defaultPageType IsNot Nothing Then
            Dim defaultPageInstance As Object = Activator.CreateInstance(defaultPageType)
            MainPageFrame.Content = defaultPageInstance
        End If

        AddHandler Me.MouseDown, AddressOf OutsideClickHandler
    End Sub
    Private Sub checkBox_Checked(sender As Object, e As RoutedEventArgs)
        Dim checkMik As ImageAwesome = TryCast(checkBoxMic.Template.FindName("checkMik", checkBoxMic), ImageAwesome)
        If checkMik IsNot Nothing Then
            checkMik.Foreground = Brushes.Red
            checkMik.Icon = FontAwesomeIcon.MicrophoneSlash
            checkMik.Width = 15
        End If
    End Sub


    Private Sub checkBox_Unchecked(sender As Object, e As RoutedEventArgs)
        Dim checkMik As ImageAwesome = TryCast(checkBoxMic.Template.FindName("checkMik", checkBoxMic), ImageAwesome)
        If checkMik IsNot Nothing Then
            checkMik.Foreground = New SolidColorBrush(Color.FromRgb(220, 224, 227))
            checkMik.Icon = FontAwesomeIcon.Microphone
            checkMik.Width = 13
        End If
    End Sub

    Private Sub checkBoxHead_Checked(sender As Object, e As RoutedEventArgs)
        Dim checkMik As ImageAwesome = TryCast(checkBoxHead.Template.FindName("checkMik", checkBoxHead), ImageAwesome)
        If checkMik IsNot Nothing Then
            checkMik.Foreground = Brushes.Red
        End If
    End Sub

    Private Sub checkBoxHead_Unchecked(sender As Object, e As RoutedEventArgs)
        Dim checkMik As ImageAwesome = TryCast(checkBoxHead.Template.FindName("checkMik", checkBoxHead), ImageAwesome)
        If checkMik IsNot Nothing Then
            checkMik.Foreground = New SolidColorBrush(Color.FromRgb(220, 224, 227))
        End If
    End Sub

    Private Sub ProfileOpen_Click(sender As Object, e As RoutedEventArgs)
        profileWindow = New ProfileWindow()
        profileWindow.Show()
        mainWindow = New MainW()
        mainWindow.mainGrid.Opacity = 0.05
    End Sub

    Private Sub OutsideClickHandler(sender As Object, e As MouseButtonEventArgs)

        If profileWindow IsNot Nothing AndAlso profileWindow.IsVisible AndAlso Not IsMouseOverWindow(profileWindow) Then
            profileWindow.Close()
            mainWindow = New MainW()
            mainWindow.mainGrid.Opacity = 1.0
        End If
    End Sub

    Private Function IsMouseOverWindow(window As Window) As Boolean
        Dim mousePosition As Point = Mouse.GetPosition(window)
        Return mousePosition.X >= 0 AndAlso mousePosition.Y >= 0 AndAlso mousePosition.X < window.Width AndAlso mousePosition.Y < window.Height
    End Function

    Private Sub PageNavigation_Click(sender As Object, e As RoutedEventArgs)
        Dim clickedRadioButton As Controls.RadioButton = TryCast(sender, Controls.RadioButton)

        If clickedRadioButton IsNot Nothing Then
            Dim userControlType As Type = Type.GetType("DiscordApplication." & clickedRadioButton.Content)

            If userControlType IsNot Nothing Then
                Dim userControlInstance As Object = Activator.CreateInstance(userControlType)
                MainPageFrame.Content = userControlInstance
            Else
                ' UserControl tipi bulunamadı veya yaratılamadı
            End If
        End If
    End Sub
End Class
