﻿using MobilePrintinator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePrintinatorMaui.Platforms.Windows
{
    public class ESCPOSDriver : IESCPOSDriver
    {
        public bool isConnected => throw new NotImplementedException();

        public Task Connect()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetBluetoothPrinterNames()
        {
            throw new NotImplementedException();
        }

        public Task SendDataAsync(byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
