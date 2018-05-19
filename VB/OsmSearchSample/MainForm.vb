Imports DevExpress.XtraMap

Namespace OsmSearchSample
    Partial Public Class MainForm
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

#Region "#LayersSpecifying"
        Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            mapControl.Layers.AddRange(New LayerBase() {
                New ImageLayer With {
                    .DataProvider = New OpenStreetMapDataProvider With {
                        .TileUriTemplate = "YOUR_WEB_SERVICE.com/{1}/{2}/{3}"
                    }
                },
                New InformationLayer With {
                    .DataProvider = New OsmSearchDataProvider
                }
            })
        End Sub
#End Region ' #LayersSpecifying
    End Class
End Namespace