using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2015.Models
{
    public interface IPSRepository
    {
        List<PS> GetAll();
        List<PS> GetByOpportunity(Guid oppId);
        PS Get(int id);
    }
}
