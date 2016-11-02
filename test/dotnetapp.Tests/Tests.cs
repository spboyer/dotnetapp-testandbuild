using System;
using Xunit;

namespace Tests
{
    public class BotTest
    {
        [Fact]
        public void Contains_Message() 
        {
            var m = new dotnetbot.maker();
            var msg = "Testing Dotnet-bot";

            Assert.True(m.GetBot(msg).Contains(msg));
        }
    }
}
