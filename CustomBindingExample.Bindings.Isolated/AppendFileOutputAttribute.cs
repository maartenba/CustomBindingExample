using System;
using Microsoft.Azure.Functions.Worker.Extensions.Abstractions;

namespace Microsoft.Azure.Functions.Worker
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
    public class AppendFileOutputAttribute : OutputBindingAttribute
    {
        public string Path { get; set; }
    }
}