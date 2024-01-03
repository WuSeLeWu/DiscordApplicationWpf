Imports DevExpress.Pdf

Class ServerPageStrongArmy

    Public Sub New()
        InitializeComponent()
        Dim defaultPageType As Type = GetType(ServerChat)
        Dim pFrame As Type = GetType(profileFrame)

        If defaultPageType IsNot Nothing AndAlso pFrame IsNot Nothing Then
            Dim defaultPageInstance As Object = Activator.CreateInstance(defaultPageType)
            ServerPageChatFrame.Content = defaultPageInstance
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
                ServerPageChatFrame.Content = userControlInstance
            Else
                ' UserControl tipi bulunamadı veya yaratılamadı
            End If
        End If
    End Sub
End Class
