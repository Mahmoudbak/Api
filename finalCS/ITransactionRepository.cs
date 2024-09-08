using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalCS
{
    public interface ITransactionRepository
    {
        IEnumerable<Transaction> GetAllTransactions();
        Transaction GetTransactionById(int id);
        void AddTransaction(Transaction transaction);
        void UpdateTransaction(Transaction transaction);
        void DeleteTransaction(int id);
    }
}
