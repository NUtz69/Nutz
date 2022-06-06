using Nutz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Repository.IRepository
{
    // 004 - Identity Management
    public interface ICompanyRepository : IRepository<Company>
    {
        // Update
        void Update(Company obj);
    }
}
