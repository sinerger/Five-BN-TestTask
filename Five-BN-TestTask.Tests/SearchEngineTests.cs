using System;
using System.Collections.Generic;
using Xunit;

namespace Five_BN_TestTask.Tests
{
    public class SearchEngineTests
    {
        public static IEnumerable<object[]> GetDataForFindLastElement()
        {
            yield return new object[]
            {
                new List<object>() {0, 1, 2, 3, 4, 5, 6, 7, 8, 9},    
                2,
                4
            };
            yield return new object[]
            {
                new List<object>() {0, 1, 2, 3, 4, 5, 6, 7, 8, 9},
                3,
                3
            };
            yield return new object[]
            {
                new List<object>() {0, 1, 2, 3, 4, 5, 6, 7, 8, 9},    
                4,
                4
            };
        }

        [Theory]
        [MemberData(nameof(GetDataForFindLastElement))]
        public void FindLastElement_Valid(List<object> elements, int numberRemovedElement, int expectedLastElement)
        {
            var searchEngine = new SearchEngine();

            var actualLastElement = searchEngine.FindLastElement(elements, numberRemovedElement);

            Assert.Equal(expectedLastElement, actualLastElement);
        }
    }
}