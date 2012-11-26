using System;
using System.Diagnostics;

namespace SignalProcessing.SignalGenerators
{
    internal static class TraceLog
    {
        public static void AddLogItem(Int32 objectHashCode, String methodFullName, Boolean status, String description, String traceCategory)
        {
            Trace.WriteLine(string.Format("[{0}.{1}] :: {5} :: [{2:X16}].{3} :: {4} :: Description: {5}", DateTime.Now, DateTime.Now.Millisecond, objectHashCode, methodFullName, status, description));
        }
    }
}