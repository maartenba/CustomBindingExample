using System;
using Microsoft.Azure.Functions.Worker;

namespace CustomBindingExample
{
    public static class ExampleTimer
    {
        [Function("ExampleTimer")]
        [AppendFileOutput(Path = "C:\\Users\\maart\\Desktop\\CustomBindingExample\\out.txt")]
        public static string Run([TimerTrigger("* * * * * *")] TimerInfo timer, FunctionContext context)
        {
            return DateTime.UtcNow.ToLongTimeString();
        }
    }
}