using System;
using Microsoft.Azure.WebJobs.Description;

namespace CustomBindingExample.Bindings
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
    [Binding]
    public class AppendFileAttribute : Attribute
    {
        public string Path { get; set; }
    }
}