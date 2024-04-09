using CreditImmo;
using System.Reflection.Metadata;

namespace TestUnitaireCreditImmo
{
    public class TestCustomerInput
    {
        #region Get CustomerInput
        [Theory]
        [InlineData(1, 2, 3)]
        public void GetDuration_Returns_CorrectValue(int duration, decimal amount, decimal nominalRate)
        {
            CustomerInput customer = new CustomerInput(duration, amount, nominalRate);
            int durationResult = customer.GetDuration();
            Assert.Equal(duration, durationResult);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        public void GetAmount_Returns_CorrectValue(int duration, decimal amount, decimal nominalRate)
        {
            CustomerInput customer = new CustomerInput(duration, amount, nominalRate);
            decimal amountResult = customer.GetAmount();
            Assert.Equal(amount, amountResult);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        public void GetNominalRate_Returns_CorrectValue(int duration, decimal amount, decimal nominalRate)
        {
            CustomerInput customer = new CustomerInput(duration, amount, nominalRate);
            decimal nominalRateResult = customer.GetNominalRate();
            Assert.Equal(nominalRate, nominalRateResult);
        }
        #endregion

        #region Test Check CustomerInput
        [Theory]
        [InlineData(108)]
        [InlineData(300)]
        public void CheckDuration_TestTrue(int duration)
        {
            CustomerInput customer = new CustomerInput(duration, 0, 0);
            Assert.True(customer.CheckDuraction());
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(107)]
        [InlineData(301)]
        public void CheckDuration_TestFalse(int duration)
        {
            CustomerInput customer = new CustomerInput(duration, 0, 0);
            Assert.False(customer.CheckDuraction());
        }

        [Theory]
        [InlineData(50000)]
        [InlineData(50001)]
        public void CheckAmount_TestTrue(decimal amount)
        {
            CustomerInput customer = new CustomerInput(0, amount, 0);
            Assert.True(customer.CheckAmount());
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(49999)]
        public void CheckAmount_TestFalse(decimal amount)
        {
            CustomerInput customer = new CustomerInput(0, amount, 0);
            Assert.False(customer.CheckAmount());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(100)]
        public void CheckNominalRate_TestTrue(decimal nominalRate)
        {
            CustomerInput customer = new CustomerInput(0, 0, nominalRate);
            Assert.True(customer.CheckNominalRate());
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(101)]
        public void CheckNominalRate_TestFalse(decimal nominalRate)
        {
            CustomerInput customer = new CustomerInput(0, 0, nominalRate);
            Assert.False(customer.CheckNominalRate());
        }
        #endregion
    }
}