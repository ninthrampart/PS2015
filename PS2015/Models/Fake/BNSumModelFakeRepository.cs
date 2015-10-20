using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2015.Models.Fake
{
    public class BNSumModelFakeRepository : IBNSumModelRepository
    {
        public List<BNSumModel> Get(int psid)
        {
            BNSumModel sum1 = new BNSumModel()
            {
                Id = 1,
                BN = "Кабельные системы",
                BNSumma = 2000,
                //GUID = readerBNSummaList[""].AsString(),
                Marga_Percent = 25,
                Original_Marga_Percent = 61,
            };

            BNSumModel sum2 = new BNSumModel()
            {
                Id = 2,
                BN = "RFID",
                BNSumma = 5000,
                //GUID = readerBNSummaList[""].AsString(),
                Marga_Percent = 30,
                Original_Marga_Percent = 70,
            };

            List<BNSumModel> sums = new List<BNSumModel>()
            {
                sum1,
                sum2
            };

            return sums;
            //throw new NotImplementedException();
        }
    }
}
