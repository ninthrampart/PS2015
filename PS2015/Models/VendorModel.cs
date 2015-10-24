using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2015.Models
{
    public class VendorModel
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
        /// Возвращает и устанавливает наименование поставщика
        /// </summary>
        public string VendorName
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает стоимость ТМЦ для Заказчика
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [Range(0.0, double.MaxValue, ErrorMessage = "Указана не корректная стоимость для Заказчика")]
        public double Cost
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает закупочную стоимость ТМЦ
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [Range(0, int.MaxValue, ErrorMessage = "Указана не корректная закупочная стоимость")]
        public double Buy
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает стоимость доставки
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [Range(0, int.MaxValue, ErrorMessage = "Указаны не корректно транспортные расходы")]
        public double DeliveryCost
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает срок кредитования
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [Range(0, int.MaxValue, ErrorMessage = "Указан не корректно срок кредитования")]
        public int SrokKredit
        {
            get;
            set;
        }

        public double RasxodKredit
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает маржу
        /// </summary>
        public double Marga
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
        /// Возвращает и устанавливает наименование БН
        /// </summary>
        public string BN
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает наименование БН
        /// </summary>
        public int BNId
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает комментарии
        /// </summary>
        public string Comments
        {
            get;
            set;
        }
    }
}
