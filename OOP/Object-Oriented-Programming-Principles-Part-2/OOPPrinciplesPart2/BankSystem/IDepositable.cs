namespace BankSystem
{
    public interface IDepositable
    {
        void Deposit(decimal money, Customer customer);
    }
}
