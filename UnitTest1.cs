using System;
using Xunit;

namespace Anagrama
{
    public class UnitTest1
    {
        [Fact]
        public void AnagramaTTest()
        {
            Assert.True(Program.verificarAnagrama("fresa","frase"));
        }
        [Fact]
        public void AnagramaFTest()
        {
            Assert.False(Program.verificarAnagrama("algo","lego"));
        }
        [Fact]
        public void AnagramaNullTest()
        {
            Assert.Throws<NullReferenceException>(() => Program.verificarAnagrama("",""));
        }
    }
}
