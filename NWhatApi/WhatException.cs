using System;
using System.Linq;

namespace NWhatApi
{
    public class WhatException : Exception
    {
        public WhatException()
        {
        }

        public WhatException(string message)
            : base(message)
        {
        }
    }
}
