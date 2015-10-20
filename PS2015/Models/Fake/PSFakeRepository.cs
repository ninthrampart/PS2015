using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2015.Models.Fake
{
    public class PSFakeRepository : IPSRepository
    {
        public PS Get(int id)
        {
            PS ps = new PS()
            {
                Id = 123,
                GUID = "2CB9357D-9056-4A46-BDCA-28745A9C470A",
                MSPProjectURL = "MSPProjectURL",
                Author = "Ivanov",
                Comments = "All ok",
                Version = 1,
                VersionDate = DateTime.Now,
                BargainNumber = "Opp 123456",
                OpportunityName = "Test opp",
                Client = "My client",
                Account = "My account",
                GMP = "GMP Ivan",
                GIP = "GIP Petr",
                Prodavec = "Seller Ashot",
                DealCost = 150,
                Buget = 250,
                Marga = 50,
                Marga_Percent = 88,
                MargaVendor = 70,
                MargaVendor_Percent = 99,
                MargaWork = 55,
                MargaWork_Percent = 80,
                FinRes = 300,
                FinRes_Percent = 100,
                Duration = 52,
                DeliveryDuration = 15,
                Pay = 120,
                Avans = 99,
                Distribution_rmdp = "88,9",
                Pay_for_sale = 11,
                Pay_for_sale_type = "TestType",
                Risks = 22,
                WarrantyCost = 31,
                Transit = 17,
                Credit_Percent = 12,
                Credit = 81,
                Bank_Percent = 65,
                Bank = 33,
                NalogNS_Percent = 71,
                NalogNS = 44,
                TotalDopCost = 12,
                TotalProdBuy = 45,
                TotalProdCost = 47,
                TotalDeliveryCost = 11,
                TotalProdMarga = 18,
                TotalProdMarga_Percent = 82
            };

            return ps;
            //throw new NotImplementedException();
        }

        public List<PS> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<PS> GetByOpportunity(Guid oppId)
        {
            throw new NotImplementedException();
        }
    }
}
