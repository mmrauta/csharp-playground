using System;
using System.Collections.Generic;
using Xunit;

namespace csharp_playground.DataStructures
{
    /// <summary>
    /// List - collection of objects that can be accessed by an index. 
    /// Lists are fixed in size. SOmetimes called 'dynamic arrays' or 'vectors'.
    /// List internally uses an array for storage.
    /// </summary>
    public class ListsTest
    {
        [Fact]
        public void InsertsNewElementAtTheRightPosition()
        {
            var list = new List<int>() { 1 };
            
            list.Add(9);                        // adding/removing item at the end - O(1)
            
            list.Insert(0, 8);                  // adding/removing item at the beginning - O(n)
                                                // - existing items need to be shifted in an underlying array
            
            Assert.Equal(new[] { 8, 1, 9 }, list);
        }

        [Fact]
        public void ReadsItems()
        {
            var list = new List<string>() { "x", "a", "b", "c" };

            var firstElement = list[0];         // accessing an item by an index - O(1)
            var hasX = list.Contains("x");      // linear search - O(n)
            var indexOfX = list.IndexOf("x");
            var count = list.Count;

            Assert.True(hasX);
            Assert.Equal(4, count);
            Assert.Equal(0, indexOfX);
            Assert.Equal("x", firstElement);
        }

        [Fact]
        public void RemovesTheItems()
        {
            var list = new List<string>(3);
            list.Add("a");                      // adds one items
            list.AddRange(new[] { "b", "c" });  // adds a collection of items

            list.RemoveAt(0);                   // removes an element at index 0
            var isBRemoved = list.Remove("b");  // removes an element "b"
            var isERemoved = list.Remove("e");

            Assert.True(isBRemoved);
            Assert.False(isERemoved);
            Assert.Equal(new[] { "c" }, list);
        }

        // Performing operations that use an index, we have to be sure that list is big enough
        // Otherwise we will end up with ArgumentOutOfRangeException exception
        [Fact]
        public void InsertsOnlyIfTheListsBigEnough()
        {
            var list = new List<string>() { };
            Action invalidExecution = () => list.Insert(1, "c");
            Assert.Throws<ArgumentOutOfRangeException>(invalidExecution);
        }

        [Fact]
        public void ThrowsExceptionWhenTryingToRemoveNotExistingLocation()
        {
            var list = new List<string>() { };
            Action invalidExecution = () => list.RemoveAt(1);
            Assert.Throws<ArgumentOutOfRangeException>(invalidExecution);
        }
    }
}
