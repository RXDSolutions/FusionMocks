//  Copyright (c) RXD Solutions. All rights reserved.
//  FusionLink is licensed under the MIT license. See LICENSE.txt for details.

using System;
using System.Collections;
using System.Threading;
using sophis.utils;

namespace sophis.portfolio
{
    public class CSMPortfolio : IDisposable
    {
        public int GetCode()
        {
            return new Random().Next(10000, 20000);
        }

        public unsafe void GetFullName(CMString full_name)
        {
            full_name.SetString("Test Full Name");
        }

        public int GetParentCode()
        {
            return new Random().Next(10000, 20000);
        }

        public static CSMPortfolio GetCSRPortfolio(int portfolioId)
        {
            return new CSMPortfolio();
        }

        public void GetName(CMString name)
        {
            name.SetString("Test");
        }

        public bool IsLoaded()
        {
            return true;
        }

        public void Load()
        {
            Thread.Sleep(5000);
        }

        public int GetPortfolioType()
        {
            return 1;
        }

        public void Compute()
        {
            Thread.Sleep(1000);
        }

        public static int GetPortfolioDate()
        {
            return Convert.ToInt32(DateTime.Today.ToOADate() - new DateTime(1904, 1, 1).ToOADate());
        }

        public int GetTreeViewPositionCount()
        {
            return 1;
        }

        public CSMPosition GetNthTreeViewPosition(int i)
        {
            return new CSMPosition();
        }

        public int GetChildCount()
        {
            return 1;
        }

        public CSMPortfolio GetNthChild(int i)
        {
            return new CSMPortfolio();
        }

        public void GetChildren(ArrayList children)
        {
        }

        public void Dispose()
        {
        }
    }
}