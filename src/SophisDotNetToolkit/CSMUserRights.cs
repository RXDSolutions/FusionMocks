//  Copyright (c) RXD Solutions. All rights reserved.
//  FusionLink is licensed under the MIT license. See LICENSE.txt for details.

using System;
using sophis.utils;

public class CSMUserRights : IDisposable
{
    public unsafe CSMUserRights()
    {
    }

    public unsafe CSMUserRights(uint ident)
    {
    }

    public unsafe CSMUserRights(uint ident, uint parentIdent)
    {
    }

    public unsafe static uint ConvNameToIdent(CMString name)
    {
        return 1;
    }

    public eMRightStatusType GetUserDefRight(CMString right)
    {
        return eMRightStatusType.M_rsEnable;
    }

    public int GetParentID()
    {
        return 1;
    }

    public int LoadDetails()
    {
        return 1;
    }

    public CMString GetName()
    {
        var result = new CMString();
        result.SetString("Right1");
        return result;
    }

    public void Dispose()
    {
        
    }
}