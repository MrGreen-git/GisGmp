using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Organization
{
    /// <summary>
    /// Сведения о получателе средств
    /// </summary>
    [Serializable()]
    [XmlRoot("Payee", Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.1.1")]
    public class Payee : OrganizationType
    {
        /// <summary>
        /// Предназначен для работы сериализации/десериализации
        /// </summary>
        protected Payee() { }

        public Payee(string Name, string Inn, string Kpp, OrgAccount OrgAccount) 
            : base(Name, Inn, Kpp)
        {
            this.OrgAccount = OrgAccount;
        }
        /// <summary>
        /// Реквизиты счета организации
        /// </summary>
        [XmlElement("OrgAccount", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
        public OrgAccount OrgAccount { get; set; }
    }
}
