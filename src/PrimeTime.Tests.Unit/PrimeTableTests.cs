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
            Assert.Fail();
        }

        [Test]
        public void when_requested_size_is_5_then_return_a_5x5_table_with_the_products_calculated()
        {
            Assert.Fail();
        }
    }
}