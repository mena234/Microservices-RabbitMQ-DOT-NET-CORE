using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _transferDb;

        public TransferRepository(TransferDbContext transferDb)
        {
            _transferDb = transferDb;
        }
        public IEnumerable<TransferLog> GeTransferLogs()
        {
            return _transferDb.TransferLogs;
        }

        public void PostTransferLog(TransferLog transferLog)
        {
            _transferDb.TransferLogs.Add(transferLog);
            _transferDb.SaveChanges();
        }
    }
}
