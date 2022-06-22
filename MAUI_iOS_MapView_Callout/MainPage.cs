namespace MAUI_iOS_MapView_Callout;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		var mapView = new Mapsui.UI.Maui.MapView();
		mapView.Map?.Layers.Add(Mapsui.Tiling.OpenStreetMap.CreateTileLayer());
		Content = mapView;
	}
}

