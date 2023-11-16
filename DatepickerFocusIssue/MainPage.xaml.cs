namespace DatepickerFocusIssue
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
			datePicker.DateSelected += DatePicker_DateSelected;
			datePicker.Focused += DatePicker_Focused;
			datePicker.Unfocused += DatePicker_Unfocused;

		}

		private void DatePicker_Unfocused(object? sender, FocusEventArgs e)
		{
			datePicker.TextColor = Colors.Red;
		}

		private void DatePicker_Focused(object? sender, FocusEventArgs e)
		{
			datePicker.TextColor = Colors.Orange;
		}

		private void DatePicker_DateSelected(object? sender, DateChangedEventArgs e)
		{
			datePicker.TextColor = Colors.Green;
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			count++;

			if (count == 1)
				CounterBtn.Text = $"Clicked {count} time";
			else
				CounterBtn.Text = $"Clicked {count} times";

			SemanticScreenReader.Announce(CounterBtn.Text);
			datePicker.TextColor = Colors.Blue;
		}



	}

}
