using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2015.Models
{
    public class WorkModel
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
        /// Возвращает и устанавливает комментарий
        /// </summary>
        public string Comments
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
        /// Возвращает и устанавливает маржу в процентах
        /// </summary>
        public double Marga_Percent
        {
            get;
            set;
        }

        public double Nalog
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
        /// Возвращает и устанавливает затраты на командировки
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [Range(0, int.MaxValue, ErrorMessage = "Указаны не корректно командировочные расходы")]
        public double KomCost
        {
            get;
            set;
        }
        /// <summary>
        /// Возвращает и устанавливает стоимость работ для АйТи
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [Range(0, int.MaxValue, ErrorMessage = "Указана не корректно стоимость для АйТи")]
        public double Buy
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает тип ресурса, выполняего работы
        /// </summary>
        public string ResType
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает тип ресурса, выполняего работы
        /// </summary>
        public int ResTypeId
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает стоимость работ для Заказчика
        /// </summary>        
        [Required(AllowEmptyStrings = true)]
        [Range(0, int.MaxValue, ErrorMessage = "Указана не корректно стоимость для заказчика")]
        public double Cost
        {
            get;
            set;
        }
        /// <summary>
        /// Возвращает и устанавливает наименование исполнителя
        /// </summary>
        public string Executor
        {
            get;
            set;
        }
        /// <summary>
        /// Возвращает и устанавливанет наименование работ
        /// </summary>
        public string WorksName
        {
            get;
            set;
        }

        /// <summary>
        /// Тип работы:
        /// 0 - Непроизводственные субподряды обязательные
        /// 1 - Непроизводственные субподряды партнерские
        /// 2 - Производственные субподряды и работы внутренних ресурсов
        /// </summary>
        public int WorkType
        {
            get;
            set;
        }
    }
}
