Imports FontAwesome.WPF

Public Class profileFrame

    Private profileWindow As ProfileWindow

    Public Sub New()
        InitializeComponent()

    End Sub

    Private Sub ProfileOpen_Click(sender As Object, e As RoutedEventArgs)
        myPopup.IsOpen = False
        profileCheckBox.IsChecked = False
        profileWindow = New ProfileWindow()
        profileWindow.ShowDialog()
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

    Private Sub Close_Click(sender As Object, e As RoutedEventArgs)
        myPopup.IsOpen = False
    End Sub

    Private Sub profileCheckBox_Checked(sender As Object, e As RoutedEventArgs)
        myPopup.IsOpen = True
    End Sub

    Private Sub profileCheckBox_Unchecked(sender As Object, e As RoutedEventArgs)
        myPopup.IsOpen = False
    End Sub
End Class
