using Array;

namespace Test.Array
{
    public class AppendTests
    {
        [Fact]
        public void WhenAddValues_ShouldHasSameLenght()
        {
            // Arrange

            var size = 3;
            var itemsToAppend = new int[size];

            for (int i = 0; i < size; i++)
            {
                itemsToAppend[i] = i;
            }

            // Act

            var array = new Array<int>(size);

            foreach (var item in itemsToAppend)
            {
                array.Append(item);
            }

            // Assert

            Assert.Equal(itemsToAppend.Length, array.Lenght);
        }

        [Fact]
        public void WhenAddValuesBiggerThanInitialSize_ShouldAddAll()
        {
            // Arrange

            var initialSize = 3;
            var newSize = initialSize * 10;
            var itemsToAppend = new int[newSize];

            for (int i = 0; i < newSize; i++)
            {
                itemsToAppend[i] = i;
            }

            // Act

            var array = new Array<int>(initialSize);

            foreach (var item in itemsToAppend)
            {
                array.Append(item);
            }

            // Assert

            Assert.Equal(itemsToAppend.Length, array.Lenght);
        }
    }
}
