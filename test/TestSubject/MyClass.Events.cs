﻿using System;

// This project defines a set of types that will be rewritten by the test cases to a new
// dll named "ClonedTestSubject".  The test cases then compare the final type information of both
// assemblies to confirm everything was re-written correction

// SEE RewriteTest in Lokad.ILPack.Tests


namespace TestSubject
{
    public partial class MyClass : IMyItf
    {
        public event Action NoParamEvent;
        public event Action<int> IntParamEvent;

        public void InvokeNoParamEvent()
        {
            NoParamEvent?.Invoke();
        }

        public void InvokeIntParamEvent(int withValue)
        {
            IntParamEvent?.Invoke(withValue);
        }
    }
}
