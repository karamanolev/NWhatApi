using System;
using System.Linq;

namespace NWhatApi
{
    public class WhatAuthenticationException : WhatException
    {
        public WhatAuthenticationException()
        {
        }

        public WhatAuthenticationException(string message)
            : base(message)
        {
        }
    }
}
