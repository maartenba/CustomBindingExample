using System;
using Microsoft.Azure.WebJobs.Description;
using Microsoft.Azure.WebJobs.Host.Bindings;
using Microsoft.Azure.WebJobs.Host.Config;

namespace CustomBindingExample.Bindings
{
    [Extension("AppendFile")]
    internal class AppendFileExtensionConfigProvider : IExtensionConfigProvider
    {
        public void Initialize(ExtensionConfigContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var bindingRule = context.AddBindingRule<AppendFileAttribute>();
            bindingRule.BindToCollector(attribute => new AppendFileAsyncCollector(attribute));
        }
    }
}