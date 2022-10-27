namespace PDF_Util;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			FileBtn.Text = $"Clicked {count} time";
		else
            FileBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(FileBtn.Text);
	}

	private async void FileBtn_Clicked(object sender, EventArgs e)
	{
		var files = await FilePicker.Default.PickMultipleAsync();

		FileBtn.Text = "Files selected: " + files.Select(f => f.FileName).Aggregate((a, b) => a + " " + b);

        SemanticScreenReader.Announce(FileBtn.Text);
    }
}

