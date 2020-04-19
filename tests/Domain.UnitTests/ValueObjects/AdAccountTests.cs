using NLP.Domain.Exceptions;
using NLP.Domain.ValueObjects;
using FluentAssertions;
using NUnit.Framework;

namespace NLP.Domain.UnitTests.ValueObjects
{
    public class AdAccountTests
    {
        [Test]
        public void ShouldHaveCorrectDomainAndName()
        {
            const string accountString = "SSW\\Pin";

            var account = AdAccount.For(accountString);

            account.Domain.Should().Be("SSW");
            account.Name.Should().Be("Pin");
        }

        [Test]
        public void ToStringReturnsCorrectFormat()
        {
            const string accountString = "SSW\\Pin";

            var account = AdAccount.For(accountString);

            var result = account.ToString();

            result.Should().Be(accountString);
        }

        [Test]
        public void ImplicitConversionToStringResultsInCorrectString()
        {
            const string accountString = "SSW\\Pin";

            var account = AdAccount.For(accountString);

            string result = account;

            result.Should().Be(accountString);
        }

        [Test]
        public void ExplicitConversionFromStringSetsDomainAndName()
        {
            const string accountString = "SSW\\Pin";

            var account = (AdAccount)accountString;

            account.Domain.Should().Be("SSW");
            account.Name.Should().Be("Pin");
        }

        [Test]
        public void ShouldThrowAdAccountInvalidExceptionForInvalidAdAccount()
        {
            FluentActions.Invoking(() => (AdAccount)"SSWPin")
                .Should().Throw<AdAccountInvalidException>();
        }
    }
}
