Imports System.Text
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Forms
Imports System.Windows.Media.Animation
Imports FontAwesome.WPF

''' <summary>
''' Interaction logic for MainWindow.xaml
''' </summary>
Public Class MainW
    Inherits Window

    Public Sub New()
        InitializeComponent()
        Dim defaultPageType As Type = GetType(MainPage)

        If defaultPageType IsNot Nothing Then
            Dim defaultPageInstance As Object = Activator.CreateInstance(defaultPageType)
            MainFrame.Content = defaultPageInstance
        End If

    End Sub

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

    Private Sub PageNavigation_Click(sender As Object, e As RoutedEventArgs)
        Dim clickedRadioButton As Controls.RadioButton = TryCast(sender, Controls.RadioButton)

        If clickedRadioButton IsNot Nothing Then
            Dim userControlType As Type = Type.GetType("DiscordApplication." & clickedRadioButton.Name)

            If userControlType IsNot Nothing Then
                Dim userControlInstance As Object = Activator.CreateInstance(userControlType)
                MainFrame.Content = userControlInstance
            Else
                ' UserControl tipi bulunamadı veya yaratılamadı
            End If
        End If
    End Sub

End Class
