﻿using Array;

namespace Test.Array
{
    public class Insert
    {
        [Fact]
        public void WhenInsertNewValueInExistentArray_ShouldInsertInEspecificIndexAndMoveValues()
        {
            // Arrange
            var initialArray = new int[] { 1, 2, 3, 4, 5 };

            var array = new Array<int>();

            for (int i = 0; i < initialArray.Length; i++)
            {
                array.Append(initialArray[i]);
            }

            // Act

            var newValue = 99;
            var index = 3;

            array.Insert(index, newValue);

            // Assert

            var expectedArray = new int[] { 1, 2, 3, 99, 4, 5 };

            array.Should()
                .ContainInOrder(expectedArray)
                .And.HaveElementAt(index, newValue);
        }
    }
}
