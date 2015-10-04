using FluentAssertions;
using NUnit.Framework;

namespace PrimeTime.Tests.Unit
{
    [TestFixture]
    public class PrimeNumberTests
    {
        [Test]
        public void when_zero_primes_are_requested_return_empty_list()
        {
            PrimeList.With(0.Elements()).Should().BeEmpty();
        }

        [Test]
        public void when_1_prime_is_requested_return_the_number_two()
        {
            PrimeList.With(1.Elements()).Should().BeEquivalentTo(new [] {2});
        }

        [Test]
        public void when_5_primes_are_requested_return_2_3_5_7_11()
        {
            PrimeList.With(5.Elements()).Should().BeEquivalentTo(new[] { 2, 3, 5, 7, 11 });
        }
    }
}