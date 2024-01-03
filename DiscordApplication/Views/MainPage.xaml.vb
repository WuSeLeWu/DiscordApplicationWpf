Imports FontAwesome.WPF

Class MainPage

    Public Sub New()
        InitializeComponent()
        Dim defaultPageType As Type = GetType(Çevrimiçi)
        Dim pFrame As Type = GetType(profileFrame)

        If defaultPageType IsNot Nothing Then
            Dim defaultPageInstance As Object = Activator.CreateInstance(defaultPageType)
            MainPageFrame.Content = defaultPageInstance
            Dim profileFrameIstance As Object = Activator.CreateInstance(pFrame)
            ProfileFrame.Content = profileFrameIstance
        End If
    End Sub

    Private Sub PageNavigation_Click(sender As Object, e As RoutedEventArgs)
        Dim clickedRadioButton As Controls.RadioButton = TryCast(sender, Controls.RadioButton)

        If clickedRadioButton IsNot Nothing Then
            Dim userControlType As Type = Type.GetType("DiscordApplication." & clickedRadioButton.Name)

            If userControlType IsNot Nothing Then
                Dim userControlInstance As Object = Activator.CreateInstance(userControlType)
                MainPageFrame.Content = userControlInstance
            Else
                ' UserControl tipi bulunamadı veya yaratılamadı
            End If
        End If
    End Sub
End Class
