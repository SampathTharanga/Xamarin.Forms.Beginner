using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace CustomizingMap
{
    public class MapPageCS : ContentPage
    {
        public MapPageCS()
        {
            var customMap = new CustomMap
            {
                MapType = MapType.Street,
                WidthRequest = App.ScreenWidth,
                HeightRequest = App.ScreenHeight
            };

            var pin = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(8.301492, 80.427367),
                Label = "Bancolombia Cajero",
                Address = "cajero automatico bancolombia",
                Id = "Xamarin",
                Url = "http://xamarin.com/about/"

            };

            var pin2 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(8.301492, 80.427367),
                Label = "Bancolombia Cajero",
                Address = "cajero automatico bancolombia",
                Id = "Xamarin",
                Url = "http://xamarin.com/about/"

            };

            customMap.CustomPins = new List<CustomPin> { pin };
            customMap.Pins.Add(pin);
            customMap.Pins.Add(pin2);
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(8.301492, 80.427367), Distance.FromMiles(1.0)));

            Content = customMap;
        }
    }
}
