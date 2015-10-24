using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2015.Models.Fake
{
    public class WorkModelFakeRepository : IWorkModelRepository
    {
        public List<WorkModel> GetForPassport(int psid)
        {
            WorkModel m1 = new WorkModel() {
                BN = "Test BN",
                BNId = 1,
                Buy = 20,
                Comments = "Test",
                Cost = 25,                
                GUID = "---",
                Id = 444,
                Marga = 37,
                Marga_Percent = 45,
                Executor = "Иван и сын",
                KomCost = 33,
                Nalog = 13,
                ResType = "Res1",
                ResTypeId = 1,
                WorksName = "Копать",
                WorkType = 0
                
            };

            WorkModel m2 = new WorkModel()
            {
                BN = "Test BN 2",
                BNId = 2,
                Buy = 20,
                Comments = "Test",
                Cost = 25,
                GUID = "---",
                Id = 444,
                Marga = 37,
                Marga_Percent = 45,
                Executor = "Иван и сын",
                KomCost = 33,
                Nalog = 13,
                ResType = "Res1",
                ResTypeId = 1,
                WorksName = "Копать",
                WorkType = 0

            };

            List<WorkModel> works = new List<WorkModel>() { m1, m2 };
            return works;
            //throw new NotImplementedException();
        }
    }
}
