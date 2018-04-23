Imports DevExpress.Xpf.Map
Imports System
Imports System.Globalization
Imports System.Windows

Namespace MapControl_CustomGeocodePanel
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        #Region "#SearchButtonClick"
        Private privateGeocodeTarget As GeoPoint
        Public Property GeocodeTarget() As GeoPoint
            Get
                Return privateGeocodeTarget
            End Get
            Private Set(ByVal value As GeoPoint)
                privateGeocodeTarget = value
            End Set
        End Property

        Public Sub New()
            InitializeComponent()
            GeocodeTarget = New GeoPoint()
            DataContext = GeocodeTarget
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            geocodeProvider.RequestLocationInformation(GeocodeTarget, Nothing)
        End Sub
        #End Region ' #SearchButtonClick
    End Class
End Namespace
