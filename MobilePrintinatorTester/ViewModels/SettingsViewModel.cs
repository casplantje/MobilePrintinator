using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MobilePrintinator;
using MobilePrintinatorMaui;

namespace MobilePrintinatorTester.ViewModels
{
    public partial class SettingsViewModel : MobilePrintinatorMaui.ViewModels.SettingsViewModel
    {
        public SettingsViewModel()
        {
            m_printinatorService = App.Current!.MainPage!.Handler!.MauiContext!.Services.GetRequiredService<IMobilePrintinatorService>();
            LoadSettings();
        }

        [RelayCommand]
        private async Task TestPrint()
        {
            var printer = m_printinatorService.Printer();
            //TODO: extract to IMobilePrinter
            printer.InitPage();
            //printer.Write("Hello World");
            //printer.RichText(printer.RichText().NewLine().Bold().Text("bold text").CancelFont().NewLine().Italic().Text("italic text").NewLine().CancelFont().Underline().Text("underlined text"));
            printer.RichText(printer.RichText().Markup(new[] { RichTextMarkup.Large }).Text("Testpage - Yes it works!"));
            printer.Cut();
            await printer.PrintBufferAsync();
        }
    }
}
