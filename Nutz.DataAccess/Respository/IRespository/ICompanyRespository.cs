using Nutz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutz.DataAccess.Respository.IRespository
{
    // 004 - Identity Management
    public interface ICompanyRespository : IRespository<Company>
    {
        // Update
        void Update(Company obj);
    }
}
