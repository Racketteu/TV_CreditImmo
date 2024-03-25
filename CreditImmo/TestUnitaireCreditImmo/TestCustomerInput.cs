namespace TestUnitaireCreditImmo
{
    public class TestCustomerInput
    {
        [Fact]
        public void GetDuration_Returns_CorrectValue()
        {
            Customer customer = new Customer(5, 100, 10);
            int duration = customer.GetDuration();
            Assert.Equal(5, duration);
        }

        [Fact]
        public void GetAmount_Returns_CorrectValue()
        {
            Customer customer = new Customer(5, 100, 10);
            int amount = customer.GetAmount();
            Assert.Equal(100, amount);
        }

        [Fact]
        public void GetNominalRate_Returns_CorrectValue()
        {
            Customer customer = new Customer(5, 100, 10);
            int nominalRate = customer.GetNominalRate();
            Assert.Equal(10, nominalRate);
        }

        public class Customer
        {
            private int Duration { get; set; }
            private int Amount { get; set; }
            private int NominalRate { get; set; }

            public Customer(int duration, int amount, int nominalRate)
            {
                Duration = duration;
                Amount = amount;
                NominalRate = nominalRate;
            }

            public int GetDuration() { return Duration; }
            public int GetAmount() { return Amount;}
            public int GetNominalRate() {  return NominalRate;}
        }
    }
}