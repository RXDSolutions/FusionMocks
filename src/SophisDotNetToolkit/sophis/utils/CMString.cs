//  Copyright (c) RXD Solutions. All rights reserved.
//  FusionLink is licensed under the MIT license. See LICENSE.txt for details.

using System;

namespace sophis.utils
{
    public class CMString : IDisposable
    {
        public string StringValue { get; private set; }

        public void Dispose()
        {
        }

        public string GetString()
        {
            return StringValue;
        }

        public static implicit operator CMString(string d)
        {
            var str = new CMString();
            str.SetString(d);
            return str;
        }

        public void SetString(string v)
        {
            StringValue = v;
        }
    }
}
