﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobilePrintinator
{
    public interface IESCPOSDriver
    {
        Task SendDataAsync(byte[] data);
        Task Connect();
        bool isConnected { get; }
        IEnumerable<string> GetBluetoothPrinterNames();
    }
}