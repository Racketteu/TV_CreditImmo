using CreditImmo;
using System.Reflection.Metadata;

namespace TestUnitaireCreditImmo
{
    public class TestCustomerInput
    {
        //Get CustomerInputTest
        [Theory]
        [InlineData(1, 2, 3)]
        public void GetDuration_Returns_CorrectValue(int duration, int amount, int nominalRate)
        {
            CustomerInput customer = new CustomerInput(duration, amount, nominalRate);
            int durationResult = customer.GetDuration();
            Assert.Equal(5, durationResult);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        public void GetAmount_Returns_CorrectValue(int duration, int amount, int nominalRate)
        {
            CustomerInput customer = new CustomerInput(duration, amount, nominalRate);
            int amountResult = customer.GetAmount();
            Assert.Equal(100, amountResult);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        public void GetNominalRate_Returns_CorrectValue(int duration, int amount, int nominalRate)
        {
            CustomerInput customer = new CustomerInput(duration, amount, nominalRate);
            int nominalRateResult = customer.GetNominalRate();
            Assert.Equal(10, nominalRateResult);
        }

        [Fact]
        public void CheckDuration_Test()
        {
            Assert.True(CheckDuraction());
        }

        [Fact]
        public void CheckAmount_Test()
        {
            Assert.True(CheckAmount());
        }
        
        [Fact]
        public void CheckNominalRate_Test()
        { 
            Assert.True(CheckNominalRate());
        }




        public bool CheckDuraction()
        {
            CustomerInput customer = new CustomerInput(10,100, 10);
            if (customer.GetDuration() >= 108 && customer.GetDuration() <= 300)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckAmount()
        {
            CustomerInput customer = new CustomerInput(10, 100, 10);
            if (customer.GetAmount() >= 50000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckNominalRate()
        {
            CustomerInput customer = new CustomerInput(10, 100, 10);
            if (customer.GetNominalRate() >= 0 && customer.GetNominalRate() <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}