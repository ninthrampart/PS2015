using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2015.Models.Fake
{
    public class VendorModelFakeRepository : IVendorModelRepository
    {
        public List<VendorModel> Get(int psid)
        {
            VendorModel m1 = new VendorModel()
            {
                BN = "Test BN",
                BNId = 1,
                Buy = 20,
                Comments = "Test",
                Cost = 25,
                DeliveryCost = 3,
                GUID = "---",
                Id = 444,
                Marga = 37,
                Marga_Percent = 45,
                RasxodKredit = 12,
                SrokKredit = 12,
                VendorName = "Рога & Копыта"


            };

            VendorModel m2 = new VendorModel()
            {
                BN = "Test BN 2",
                BNId = 2,
                Buy = 20,
                Comments = "Test",
                Cost = 25,
                DeliveryCost = 3,
                GUID = "---",
                Id = 555,
                Marga = 37,
                Marga_Percent = 45,
                RasxodKredit = 12,
                SrokKredit = 12,
                VendorName = "Рога & Копыта 2"


            };

            List<VendorModel> vendors = new List<VendorModel>() { m1, m2 };
            return vendors;
            //throw new NotImplementedException();
        }
    }
}
