using System;
using Xunit;
using System.IO;

namespace HalloWorld.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_prints_Hallo_World()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Hallo World",output);
        }
    }
}
