//  Copyright (c) RXD Solutions. All rights reserved.
//  FusionLink is licensed under the MIT license. See LICENSE.txt for details.

using System;
using sophis.instrument;

namespace sophis.portfolio
{
    public class CSMPosition : IDisposable
    {
        public void Dispose()
        {
            
        }

        public int GetIdentifier()
        {
            return 0;
        }

        public static CSMPosition GetCSRPosition(int position)
        {
            return new CSMPosition();
        }

        public int GetPortfolioCode()
        {
            return 1;
        }

        public int GetInstrumentCode()
        {
            return 2;
        }

        public CSMPortfolio GetPortfolio()
        {
            return new CSMPortfolio();
        }

        public CSMInstrument GetCSRInstrument()
        {
            return new CSMInstrument();
        }

        public unsafe double GetInstrumentCount()
        {
            return 1;
        }
    }
}