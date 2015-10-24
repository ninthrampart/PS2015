using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2015.Models
{
    interface IVendorModelRepository
    {
        List<VendorModel> Get(int psid);
    }
}
