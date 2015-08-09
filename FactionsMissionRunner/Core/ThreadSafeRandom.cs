//--------------------------------------------------------------------------
// 
//  Copyright (c) Microsoft Corporation.  All rights reserved. 
// 
//  File: ThreadSafeRandom.cs
//
//--------------------------------------------------------------------------

using System;
using System.Security.Cryptography;
using System.Threading;

namespace FactionsMissionRunner.Core
{
    public static class ThreadSafeRandom
    {
        [ThreadStatic] private static Random Local;

        public static Random ThisThreadsRandom => Local ??
                                                  (Local = new Random(unchecked(Environment.TickCount*31 + Thread.CurrentThread.ManagedThreadId)));
    }
}