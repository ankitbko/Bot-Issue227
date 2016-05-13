using Microsoft.Bot.Builder.FormFlow;
using System;

namespace SampleBot
{
    [Serializable]
    public class Employee
    {
        [Describe("Employee Name")]
        [Prompt("Please enter your Name: ")]
        public string Name;
    }
}
