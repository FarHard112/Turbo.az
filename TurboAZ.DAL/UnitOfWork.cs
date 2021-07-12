using TurboAZ.DAL.Repository.Abstract;
using TurboAZ.DAL.Repository.Concrete;

namespace TurboAZ.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TurboDBContext _context;

        public UnitOfWork(TurboDBContext context)
        {
            _context = context;
            turboRepository = new TurboRepository(_context);
        }

        public ITurboRepository turboRepository { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}