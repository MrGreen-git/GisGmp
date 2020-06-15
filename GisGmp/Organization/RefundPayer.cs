using System;
using System.Xml.Serialization;

namespace GisGmp.Organization
{
    /// <summary>
    /// Сведения об организации, осуществляющей возврат денежных средств
    /// </summary>
    [Serializable()]
    [XmlRoot("RefundPayer", Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.1.1")]
    public class RefundPayer : OrganizationType
    {
        /// <summary>
        /// Реквизиты платежного документа
        /// </summary>
        protected RefundPayer() { }

        public RefundPayer(
            string CodeUBP,
            string Name,
            string Inn,
            string Kpp
            ) : base (Name, Inn, Kpp)
        {
            this.CodeUBP = CodeUBP;
        }

        /// <summary>
        /// Поле номер 3003: Код организации.Особенности заполнения: - для организаций, отсутствующих в Сводном реестре, указывается код органа в соответствии с регистрационными данными, присвоенными органами ФК, равный 5 знакам. - для остальных клиентов указывается уникальный код организации по Сводному реестру, равный 8 знакам; - для налоговых органов указывается код УФНС России, передающего информацию в ТОФК.
        /// </summary>
        [XmlAttribute("codeUBP")]
        public string CodeUBP { get; set; }
    }
}