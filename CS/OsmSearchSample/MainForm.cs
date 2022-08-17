using System;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace OsmSearchSample {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e) {

            ImageLayer imageLayer = new ImageLayer();
            OpenStreetMapDataProvider dataProvider = new OpenStreetMapDataProvider();
            dataProvider.TileUriTemplate = "https://{0}.tile.openstreetmap.org/{1}/{2}/{3}.png";
            imageLayer.DataProvider = dataProvider;
            dataProvider.WebRequest += DataProvider_WebRequest;

            InformationLayer infoLayer = new InformationLayer();
            OsmSearchDataProvider osmSearchDataProvider = new OsmSearchDataProvider();
            osmSearchDataProvider.ResultsCount = 5;
            infoLayer.DataProvider = osmSearchDataProvider;

            mapControl.SearchPanelOptions.Width = 400;

            mapControl.Layers.AddRange(new LayerBase[] { imageLayer, infoLayer });
        }

        private void DataProvider_WebRequest(object sender, MapWebRequestEventArgs e) {
            e.UserAgent = "Sample app with OSM tiles and search";
            e.Referer = "https://www.mycompanysite.com/";
        }
    }
}