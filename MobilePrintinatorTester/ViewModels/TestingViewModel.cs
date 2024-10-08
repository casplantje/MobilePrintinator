using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MobilePrintinator;
using MobilePrintinatorMaui;


namespace MobilePrintinatorTester.ViewModels
{
    public partial class TestingViewModel : ObservableObject
    {
        private IMobilePrintinatorService m_printinatorService = null;

        public TestingViewModel()
        {
            m_printinatorService = App.Current!.MainPage!.Handler!.MauiContext!.Services.GetRequiredService<IMobilePrintinatorService>();
        }

        [RelayCommand]
        private async Task TestText()
        {
            var printer = m_printinatorService.Printer();
            printer.InitPage();
            printer.Write("Text test page.");
            printer.RichText(printer.RichText().NewLine().Bold().Text("bold text").CancelFont().NewLine().Italic().Text("italic text").NewLine().CancelFont().Underline().Text("underlined text"));
            printer.RichText(printer.RichText().Markup(new[] { RichTextMarkup.Large }).Text("Large text"));
            printer.Cut();
            await printer.PrintBufferAsync();
        }

        [RelayCommand]
        private async Task TestBarcodeEAN8()
        {
            var printer = m_printinatorService.Printer();
            printer.InitPage();
            printer.Write("Barcode:");
            printer.NewLine();
            printer.BarCode(BarCodeType.EAN8, new byte[]{ 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08 });
            printer.Cut();
            await printer.PrintBufferAsync();
        }
    }
}
