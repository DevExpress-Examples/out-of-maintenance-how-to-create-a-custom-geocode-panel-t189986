Imports DevExpress.Xpf.Map
Imports System.Windows

Namespace MapControl_CustomGeocodePanel

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

'#Region "#SearchButtonClick"
        Private _GeocodeTarget As GeoPoint

        Public Property GeocodeTarget As GeoPoint
            Get
                Return _GeocodeTarget
            End Get

            Private Set(ByVal value As GeoPoint)
                _GeocodeTarget = value
            End Set
        End Property

        Public Sub New()
            Me.InitializeComponent()
            GeocodeTarget = New GeoPoint()
            DataContext = GeocodeTarget
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.geocodeProvider.RequestLocationInformation(GeocodeTarget, Nothing)
        End Sub
'#End Region  ' #SearchButtonClick
    End Class
End Namespace
