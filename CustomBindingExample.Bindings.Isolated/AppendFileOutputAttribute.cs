using System;
using Microsoft.Azure.Functions.Worker.Extensions.Abstractions;

[assembly: ExtensionInformation("CustomBindingExample.Bindings", "1.0.10")]

namespace Microsoft.Azure.Functions.Worker
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
    public class AppendFileOutputAttribute : OutputBindingAttribute
    {
        public string Path { get; set; }
    }
}