using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Microsoft.Practices.Unity;

namespace TestConsole
{
    using CommonFunctions;
    using SignalGenerators;

    public class Program
    {
        public static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();
            container.RegisterType<ISignal, SinusSignal>();
        }
    }
}
