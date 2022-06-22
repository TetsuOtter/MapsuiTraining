using Mapsui.UI.Maui;

namespace MAUI_iOS_MapView_Callout;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		var mapView = new Mapsui.UI.Maui.MapView();
		mapView.Map?.Layers.Add(Mapsui.Tiling.OpenStreetMap.CreateTileLayer());
		Content = mapView;

		Pin pin = new()
		{
			Label = "Pin Title",
			Address = "Pin Subtitle",
			Type = Mapsui.UI.Maui.PinType.Pin,
			Position = new(0, 0)
		};

		Callout callout = pin.Callout;

		callout.Anchor = new(0, pin.Height * pin.Scale);
		callout.Type = Mapsui.Styles.CalloutType.Detail;

		mapView.PinClicked += (s, e) =>
		{
			if (e.Pin is not Pin pin)
				return;

			if (pin.IsCalloutVisible())
				pin.HideCallout();
			else
				pin.ShowCallout();
		};

		mapView.Pins.Add(pin);
	}
}

