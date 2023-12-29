Imports System.Text
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Forms
Imports FontAwesome.WPF

''' <summary>
''' Interaction logic for MainWindow.xaml
''' </summary>
Public Class MainW
    Inherits Window
    Private Sub btnMinimize_Click(sender As Object, e As RoutedEventArgs)
        WindowState = WindowState.Minimized
    End Sub

    Private Sub BtnMaximize_Click(sender As Object, e As RoutedEventArgs)
        If WindowState = WindowState.Maximized Then
            WindowState = WindowState.Normal
        Else
            WindowState = WindowState.Maximized
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub

    Private Sub Window_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)
        If e.ChangedButton = MouseButton.Left Then
            Me.DragMove()
        End If
    End Sub

    Private Sub radioHeadphones_Click(sender As Object, e As RoutedEventArgs)
        'If radioHeadphones.IsChecked Then
        '    radioHeadphones.Foreground = New SolidColorBrush(Color.FromRgb(&H95, &H39, &H3D))
        'End If
    End Sub

    Private Sub radioHeadphones_MouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs)
        'Dim imageAwesome As fa.ImageAwesome = TryCast(sender, fa.ImageAwesome)
        'If imageAwesome IsNot Nothing Then
        '    imageAwesome.Foreground = New SolidColorBrush(Color.FromRgb(&H95, &H39, &H3D))
        'End If
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

End Class
