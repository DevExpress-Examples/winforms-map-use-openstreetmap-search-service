using System;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace OsmSearchSample {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        #region #LayersSpecifying
        private void OnFormLoad(object sender, EventArgs e) {
            mapControl.Layers.AddRange(new LayerBase[] {
                new ImageLayer {
                    DataProvider = new OpenStreetMapDataProvider {
                        TileUriTemplate = "YOUR_WEB_SERVICE.com/{1}/{2}/{3}"
                    }
                },
                new InformationLayer {
                    DataProvider = new OsmSearchDataProvider { }
                }
            });
        }
        #endregion #LayersSpecifying
    }
}