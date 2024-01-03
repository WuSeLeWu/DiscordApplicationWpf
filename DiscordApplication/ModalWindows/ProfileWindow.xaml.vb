Imports System.Windows.Media.Animation

Public Class ProfileWindow
    Public Sub New()
        InitializeComponent()

        AddHandler Me.Loaded, AddressOf Window_Loaded
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Dim animation As New DoubleAnimation(0, 1, New Duration(TimeSpan.FromSeconds(0.7)))
        Me.BeginAnimation(UIElement.OpacityProperty, animation)
    End Sub

    Private Sub Close_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub
End Class
