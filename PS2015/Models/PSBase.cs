using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2015.Models
{
    public class PSBase
    {
        /// <summary>
        /// Возвращает и устанавливает идентификатор сделки
        /// </summary>
        public string GUID
        {
            get;
            set;
        }

        /// <summary>
        /// Информация о версии ПС
        /// </summary>
        public int Version
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает дату версии
        /// </summary>
        public DateTime VersionDate
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает Комментарии к черновикам
        /// </summary>
        public string Comments
        {
            get;
            set;
        }

        public string Author
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает номер сделки
        /// </summary>
        public string BargainNumber
        {
            get;
            set;
        }

        public string OpportunityName
        {
            get;
            set;
        }

        public string MSPProjectURL { get; set; }
    }
}
