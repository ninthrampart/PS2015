using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2015.Models
{
    public class PS : PSBase
    {
        public int Id { get; set; }

        #region Основные данные сделки      

        /// <summary>
        /// Юр. лицо
        /// </summary>
        public string Account
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает наименование Заказчика
        /// </summary>
        public string Client
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает ФИО Продавца
        /// </summary>
        public string Prodavec
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает ФИО ГИП
        /// </summary>
        public string GIP
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает ФИО ГМП
        /// </summary>
        public string GMP
        {
            get;
            set;
        }

        #endregion

        #region Основные показатели сделки

        /// <summary>
        /// Бюджет исполнения 
        /// </summary>
        public double Buget
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает стоимость сделки
        /// </summary>
        public double DealCost
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает маржу сделки
        /// </summary>
        public double Marga
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает процент маржи сделки
        /// </summary>
        public double Marga_Percent
        {
            get;
            set;
        }

        /// <summary>
        /// Маржа ТМЦ, НПИ
        /// </summary>
        public double MargaVendor
        {
            get;
            set;
        }

        /// <summary>
        /// Процент маржи ТМЦ, НПИ 
        /// </summary>
        public double MargaVendor_Percent
        {
            get;
            set;
        }

        /// <summary>
        /// Маржа, работы
        /// </summary>
        public double MargaWork
        {
            get;
            set;
        }

        /// <summary>
        /// Процент маржи по работам
        /// </summary>
        public double MargaWork_Percent
        {
            get;
            set;
        }


        /// <summary>
        /// Возвращает и устанавливает финрезультат сделки
        /// </summary>
        public double FinRes
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает финрезультат сделки в процентах
        /// </summary>
        public double FinRes_Percent
        {
            get;
            set;
        }

        #endregion

        #region Сроки по договору

        /// <summary>
        /// Возвращает и устанавливает длительность сделки
        /// </summary>
        //[Required(AllowEmptyStrings = true)]
        //[Range(0, int.MaxValue, ErrorMessage = "Указана не корректная длительность сделки")]
        public int Duration
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает срок поставки
        /// </summary>        
        //[Required(AllowEmptyStrings = true)]
        //[Range(0, int.MaxValue, ErrorMessage = "Указан не корректный срок поставки оборудования")]
        public int DeliveryDuration
        {
            get;
            set;
        }

        #endregion

        #region Условия оплаты по договору

        /// <summary>
        /// Возвращает и устанавливает платеж
        /// </summary>
        public double Pay
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает аванс
        /// </summary>        
        //[Required(AllowEmptyStrings = true)]
        //[Range(0, int.MaxValue, ErrorMessage = "Указана не корректно величина аванса")]
        public double Avans
        {
            get;
            set;
        }

        #endregion

        #region Сейлз-комиссия (справочная информация)

        /// <summary>
        /// Распределение, % 
        /// </summary>
        public string Distribution_rmdp { get; set; }

        /// <summary>
        /// Распределение (Размер)
        /// </summary>
        public double Pay_for_sale { get; set; }

        /// <summary>
        /// Распределение (Тип)
        /// </summary>
        public string Pay_for_sale_type { get; set; }

        #endregion

        #region Информация о суммах БН

        /// <summary>
        /// Возвращает коллекцию выполняемых работ
        /// </summary>
        //public List<BNSumModel> BNSumma
        //{
        //    get;
        //    set;
        //}

        #endregion Информация о суммах БН

        #region Затраты на исполнение

        /// <summary>
        /// Возвращает и устанавливает непредвиденные расходы по сделке
        /// </summary>
        //[Required(AllowEmptyStrings = true)]
        //[Range(0, int.MaxValue, ErrorMessage = "Указана не корректная величина непредвиденных расходов")]
        public double Risks
        {
            get;
            set;
        }


        /// <summary>
        /// Возвращает и устанавливает длительность гарантийного обслуживания ТМЦ
        /// </summary>
        //[Required(AllowEmptyStrings = true)]
        //[Range(0, int.MaxValue, ErrorMessage = "Указанн не корректный срок гарантийного обслуживания")]
        public int WarrantyDuration
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает непредвиденные расходы по сделке
        /// </summary>       
        public double WarrantyCost
        {
            get;
            set;
        }

        /// <summary>
        /// Комиссия за транзитную сделку (сумма )
        /// </summary>
        public double Transit
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает сумму кредита за оборудование в процентах
        /// </summary>
        public double Credit_Percent
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает сумму кредита за оборудование
        /// </summary>
        public double Credit
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает сумму банковского обслуживания сделки в процентах
        /// </summary>
        public double Bank_Percent
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает сумму банковского обслуживания сделки
        /// </summary>
        public double Bank
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает сумму налога за использование НС в процентах
        /// </summary>
        public double NalogNS_Percent
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает сумму затрат на исполнение
        /// </summary>
        public double TotalDopCost
        {
            get;
            set;
        }


        #endregion

        #region ТМЦ, НПИ

        /// <summary>
        /// Возвращает и устанавливает суммарную закупочная стоимость ТМЦ
        /// </summary>
        public double TotalProdBuy
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает суммарную стоимость ТМЦ для Заказчика
        /// </summary>
        public double TotalProdCost
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает суммарную стоимость доставки ТМЦ
        /// </summary>
        public double TotalDeliveryCost
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает товарную маржу
        /// </summary>
        public double TotalProdMarga
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает товарную маржу в процентах
        /// </summary>
        public double TotalProdMarga_Percent
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает коллекцию закупок ТМЦ
        /// </summary>
        //public List<VendorModel> Vendors
        //{
        //    get;
        //    set;
        //}

        #endregion

        #region Рассчет по работам

        /// <summary>
        /// Возвращает и устанавливает суммарную стоимость работ для Заказчика
        /// </summary>
        public double TotalWorksCost
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает cуммарные затраты на коммандировки
        /// </summary>
        public double TotalKomCost
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает суммарную стоимость внутренних ресурсов
        /// </summary>
        public double TotalWorksBuyInside
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает суммарную стоимость НС
        /// </summary>
        public double TotalWorksBuyOutsideNS
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает суммарную стоимость БНС
        /// </summary>
        public double TotalWorksBuyOutsideBNS
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает суммарную стоимость БНС без НДС
        /// </summary>
        public double TotalWorksBuyOutsideBNSWithoutNDS
        {
            get;
            set;
        }


        /// <summary>
        /// Возвращает коллекцию выполняемых работ
        /// </summary>
        //public List<WorkModel> Works
        //{
        //    get;
        //    set;
        //}

        #endregion

        #region  Справочники

        //public List<BNModel> BNs { get; set; }

        //public List<ResourceTypeModel> ResourceTypes { get; set; }

        //public List<WorkTypeModel> WorkTypes { get; set; }

        #endregion


        #region Obsolete

        /// <summary>
        /// Возвращает и устанавливает внутренние отчисления
        /// </summary>
        public double InnerPay_2
        {
            get;
            set;

        }

        /// <summary>
        /// Возвращает и устанавливает внутренние отчисления в процентах от стоимости сделки
        /// </summary>
        public float InnerPay_2_Percent
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает сумму внутренних отчислений в процентах
        /// </summary>
        public float InnerPay_Percent
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает сумму внутренних отчислений
        /// </summary>
        public double InnerPay
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает сумму кредита и налогов
        /// </summary>
        public double Credit_And_Nalogs
        {
            get;
            set;

        }


        /// <summary>
        /// Возвращает и устанавливает кредит и налоги в процентах от стоимости сделки
        /// </summary>
        public float Credit_And_Nalogs_Percent
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает прочие расходы
        /// </summary>
        public double Other
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает прочие расходы в процентах от стоимости сделки
        /// </summary>
        public float Other_Percent
        {
            get;
            set;
        }

        /// <summary>
        /// Комиссия за транзитную сделку ( процент )
        /// </summary>
        public double TransitPercent
        {
            get;
            set;
        }

        /// <summary>
        /// Возвращает и устанавливает сумму расходов на коммандировки и транспортировку ТМЦ
        /// </summary>
        public double OtherProdPay
        {
            get;
            set;
        }



        /// <summary>
        /// Возвращает и устанавливает сумму налога за использование
        /// </summary>
        public double NalogNS
        {
            get;
            set;
        }


        #endregion
    }
}
