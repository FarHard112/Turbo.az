using System;
using System.Collections.Generic;
using System.Linq;
using TurboAZ.DAL.Repository.Abstract;
using TurboAZ.Entity.Models;

namespace TurboAZ.DAL.Repository.Concrete
{

    public class TurboRepo : ITurbo
    {
        private readonly TurboDBContext _context;

        public TurboRepo(TurboDBContext context)
        {
            _context = context;
        }

        public List<Brand> GetBrands()
        {
            var brands = _context.Brands.ToList();
            return brands;
        }
    }
}
