using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Newtonsoft.Json;

namespace CustomBindingExample.Bindings
{
    public class AppendFileAsyncCollector : IAsyncCollector<string>
    {
        private readonly AppendFileAttribute _appendFileAttribute;

        public AppendFileAsyncCollector(AppendFileAttribute appendFileAttribute)
        {
            _appendFileAttribute = appendFileAttribute;
        }

        public async Task AddAsync(string item, CancellationToken cancellationToken = new CancellationToken())
        {
            File.AppendAllText(
                _appendFileAttribute.Path, 
                item + Environment.NewLine);
        }

        public Task FlushAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return Task.CompletedTask;
        }
    }
}