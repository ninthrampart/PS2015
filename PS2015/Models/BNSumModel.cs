using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2015.Models
{
    public class BNSumModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Возвращает и устанавливает GUID строки
        /// </summary>
        public string GUID
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает наименование БН
        /// </summary>
        public string BN
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает сумму БН
        /// </summary>
        public double BNSumma
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает маржу в процентах
        /// </summary>
        public double Marga_Percent
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает маржу в процентах
        /// </summary>
        public double Marga
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает оригинальное значение маржи в процентах
        /// </summary>
        public double Original_Marga_Percent
        {
            get;
            set;
        }
    }
}
