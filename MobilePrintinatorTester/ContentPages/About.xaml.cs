namespace MobilePrintinatorTester.ContentPages;

public partial class About : ContentPage
{
	public About()
	{
		InitializeComponent();
		var part1 = "cas";
        var part2 = "derooij.tech";
		contactLabel.Text = $"Contact me at: {part1}@{part2} for inquiries on commercial use.";

    }
}