using MobilePrintinator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePrintinatorMaui
{
    public interface IMobilePrintinatorService
    {
        IMobilePrinter Printer();
        void Configure(PrinterProperties properties);
        void InitConfiguration();
        void SaveConfiguration();
        void LoadConfiguration();
        IEnumerable<string> GetBluetoothPrinterNames();
    }
}