using FluentAssertions;
using NUnit.Framework;

namespace PrimeTime.Tests.Unit
{
    [TestFixture]
    public class PrimeTableTests
    {
        [Test]
        public void when_requested_size_is_zero_then_return_an_empty_table()
        {
            PrimeTable.WithSizeOf(0).ToGridArray().Should().BeEmpty();
        }

        [Test]
        public void when_requested_size_is_1_then_return_a_single_cell_table_with_the_value_1()
        {
            PrimeTable.WithSizeOf(1).ToGridArray().Should().BeEquivalentTo(new[,] {{1}});
        }

        [Test]
        public void when_requested_size_is_3_then_return_a_3x3_table_with_the_products_calculated()
        {
            var expectedTable = new[,]
            {
                {1 , 2, 3},
                {2 , 4, 6},
                {3 , 6, 9}
            };
            PrimeTable.WithSizeOf(3).ToGridArray().Should().BeEquivalentTo(expectedTable);
        }

        [Test]
        public void when_requested_size_is_5_then_return_a_5x5_table_with_the_products_calculated()
        {
            var expectedTable = new[,]
            {
                {1 , 2, 3, 5, 7},
                {2 , 4, 6, 10, 14},
                {3 , 6, 9, 15, 21},
                {5 , 10, 15, 25, 35},
                {7 , 14, 21, 35, 49}

            };
            PrimeTable.WithSizeOf(5).ToGridArray().Should().BeEquivalentTo(expectedTable);
        }
    }
}