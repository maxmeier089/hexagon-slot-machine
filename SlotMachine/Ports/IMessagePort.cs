﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    public interface IMessagePort
    {
        void SendMessage(string message);

    }
}
