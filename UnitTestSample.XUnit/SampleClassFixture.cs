﻿using System;
using System.Diagnostics;

namespace UnitTestSample.XUnit
{
    public class SampleClassFixture : IDisposable
    {
        public SampleClassFixture()
        {
            Trace.WriteLine("ClassInitialize");
        }

        public void Dispose()
        {
            Trace.WriteLine("ClassCleanup");
        }
    }
}
