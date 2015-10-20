using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2015.Models
{
    interface IBNSumModelRepository
    {
        List<BNSumModel> Get(int psid);
    }
}
