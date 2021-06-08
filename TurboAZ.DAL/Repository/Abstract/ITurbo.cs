using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAZ.Entity.Models;

namespace TurboAZ.DAL.Repository.Abstract
{
    public interface ITurbo
    {
        public List<Brand> GetBrands();

    }
}
