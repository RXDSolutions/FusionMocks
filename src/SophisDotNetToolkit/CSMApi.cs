//  Copyright (c) RXD Solutions. All rights reserved.
//  FusionLink is licensed under the MIT license. See LICENSE.txt for details.

using System;
using sophis.utils;

public class CSMApi : IDisposable
{
    public void initFrameWork()
    {
        throw new NotImplementedException();
    }

    public void Initialise()
    {
        throw new NotImplementedException();
    }

    public unsafe virtual bool IsRTconnected()
    {
        throw new NotImplementedException();
    }

    public unsafe virtual void GetUser(CMString user)
    {
        user.SetString(Environment.UserName);
    }

    public void DisposeApi()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
