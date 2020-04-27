﻿//  Copyright (c) RXD Solutions. All rights reserved.
//  FusionLink is licensed under the MIT license. See LICENSE.txt for details.

using System;
using System.Collections;
using MEnums;
using sophis.portfolio;

namespace sophis.misc
{
    public class CSMGlobalFunctions : IDisposable
    {
        private static Lazy<CSMGlobalFunctions> _default = new Lazy<CSMGlobalFunctions>();
        private static CSMGlobalFunctions _registeredCSMGlobalFunctions;

        public unsafe CSMGlobalFunctions()
        {
        }

        protected unsafe CSMGlobalFunctions(void* A_1, void* A_2)
        {
        }

        protected eMode m_Mode;

#pragma warning disable IDE1006 // Naming Styles
        public unsafe bool fLoadingPortfolio { get; set; }
#pragma warning restore IDE1006 // Naming Styles

        public enum eMPortfolioCalculationType
        {
            M_pcJustSumming = 2,
            M_pcFullCalculation = 1,
            M_pcNotInPortfolio = 0
        }

#pragma warning disable IDE1006 // Naming Styles
        public unsafe eMPortfolioCalculationType fInPortfolioCalculation { get; set; }
#pragma warning restore IDE1006 // Naming Styles

        public unsafe eMPortfolioCalculationType IsInPortfolioCalculation()
        {
            throw new NotImplementedException();
        }

        public unsafe static void Register(CSMGlobalFunctions ptr)
        {
            _registeredCSMGlobalFunctions = ptr;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

#if !V72

        public unsafe virtual void EndPortfolioCalculation(CSMExtraction extraction, int folio_id)
        {
        }

#endif

#if V72

        public unsafe virtual void EndPortfolioCalculation(CSMExtraction extraction, int folio_id, bool full, ArrayList impactedPortfolios)
        {
        }

#endif

        public unsafe virtual void SendEvent(CSMUserEvent evt)
        {
            HandleEvent(evt);
        }

        public unsafe virtual void HandleEvent(CSMUserEvent evt)
        {
        }

        public unsafe static CSMGlobalFunctions GetCurrentGlobalFunctions()
        {
            if (_registeredCSMGlobalFunctions is object)
                return _registeredCSMGlobalFunctions;
            else
                return _default.Value;
        }
    }
}