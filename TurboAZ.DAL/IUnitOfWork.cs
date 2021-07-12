using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ.DAL.Repository.Abstract;

namespace TurboAZ.DAL
{
    public interface IUnitOfWork:IDisposable
    {
        ITurboRepository turboRepository { get; set; }
        int Complete();
    }
}
