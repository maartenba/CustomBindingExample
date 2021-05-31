using CustomBindingExample.Bindings;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;

[assembly: WebJobsStartup(typeof(CustomBindingExampleStartup))]

namespace CustomBindingExample.Bindings
{
    public class CustomBindingExampleStartup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.AddExtension<AppendFileExtensionConfigProvider>();
        }
    }
}