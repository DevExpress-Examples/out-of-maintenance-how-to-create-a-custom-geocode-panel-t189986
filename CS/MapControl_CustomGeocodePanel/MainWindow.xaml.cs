using DevExpress.Xpf.Map;
using System;
using System.Globalization;
using System.Windows;

namespace MapControl_CustomGeocodePanel {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        #region #SearchButtonClick
        public GeoPoint GeocodeTarget { get; private set; }

        public MainWindow() {
            InitializeComponent();
            GeocodeTarget = new GeoPoint();
            DataContext = GeocodeTarget;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            geocodeProvider.RequestLocationInformation(GeocodeTarget, null);
        }
        #endregion #SearchButtonClick
    }
}
