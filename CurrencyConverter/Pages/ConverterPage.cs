using System;

using Xamarin.Forms;

namespace CurrencyConverter
{
	public class ConverterPage : ContentPage
	{
		double exchangeRate = 6.5;
		double spacing = 10;
		double padding = 10;

		public ConverterPage ()
		{
			Title = "Currency Converter";

			var myLayout = new StackLayout {
				Spacing = spacing,
				Padding = padding,
				BackgroundColor = Color.White
			};

			var convertText = new Label {
				Text = "Input USD and convert to DKK",
				TextColor = Color.Black,
				XAlign = TextAlignment.Center,
				FontSize = 18
			};

			var input = new Entry {
				Placeholder = "Input value",
				Keyboard = Keyboard.Numeric,
				TextColor = Color.Black,
			};

			var output = new Label {
				TextColor = Color.Black
			};

			var button = new Button {
				Text = "Convert now!",
				BackgroundColor = Color.Maroon,
				BorderRadius = 5
			};

			button.Clicked += delegate {
				double value = 0;
				Double.TryParse(input.Text, out value);
				output.Text = Convert.ToString(value * exchangeRate) + " DKK";
			};

			myLayout.Children.Add (convertText);
			myLayout.Children.Add (input);
			myLayout.Children.Add (output);
			myLayout.Children.Add (button);

			Content = myLayout;
		}
	}
}


