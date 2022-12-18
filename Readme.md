<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128571279/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T189986)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MapControl_CustomGeocodePanel/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MapControl_CustomGeocodePanel/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MapControl_CustomGeocodePanel/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MapControl_CustomGeocodePanel/MainWindow.xaml.vb))
<!-- default file list end -->
# How to create a custom geocode panel


This example demonstrates how to create a custom geocode panel.


<h3>Description</h3>

To implement a custom geocode panel do the following.<br>- Create an&nbsp;<a href="https://documentation.devexpress.com/#wpf/clsDevExpressXpfMapInformationLayertopic">InformationLayer</a> object and add it to the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfMapMapControl_Layerstopic">MapControl.Layers</a>&nbsp;collection. Assign an instance of the&nbsp;<a href="https://documentation.devexpress.com/#wpf/clsDevExpressXpfMapBingGeocodeDataProvidertopic">BingGeocodeDataProvider</a> class to the&nbsp;<a href="https://documentation.devexpress.com/#wpf/DevExpressXpfMapInformationLayer_DataProvidertopic">InformationLayer.DataProvider</a> property. Specify the provider's&nbsp;BingKey property.<br>- Create a custom geocode panel. In this example this panel includes two&nbsp;spin edits (for the <strong>Latitude</strong> and <strong>Longitude</strong>) and the <strong>Search</strong> button.<br>- Call the BingGeocodeDataProvider.RequestLocationInformation&nbsp;method. In this&nbsp;example this method&nbsp;is called in the <strong>Search</strong> button click event handler.

<br/>


