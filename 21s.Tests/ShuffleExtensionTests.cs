using Xunit;
using _21s;
using System;
using System.Collections.Generic;
using System.Text;

namespace _21s.Tests
{
    public class ShuffleExtensionTests
    {
        [Fact()]
        public void ShuffleTest()
        {
            int[] array = new int[] { 1, 2, 3 };
            array.Shuffle<int>();

            var result = array[0] != 1 || array[1] != 2 || array[2] != 3;

            Assert.True(result, "Array should be shuffled");
        }
    }
}