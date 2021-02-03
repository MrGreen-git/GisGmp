using GisGmp.Common;
using System;
using System.Xml.Serialization;

namespace GisGmp.Organization
{
    /// <summary>
    /// Сведения о получателе средств
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.2.0")]
    [XmlRoot(Namespace = "http://roskazna.ru/gisgmp/xsd/Organization/2.2.0", IsNullable = false)]
    public class Payee : OrganizationType
    {
        /// <summary/>
        public  Payee() { }

        /// <summary/>
        public Payee(OrganizationType organization, OrgAccount orgAccount) 
            : base(organization) => OrgAccount = orgAccount;
        

        /// <summary>
        /// Реквизиты счета организации
        /// </summary>
        [XmlElement(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
        public OrgAccount OrgAccount 
        {
            get => _OrgAccount;
            set => _OrgAccount = Validator.IsNull(value: value, name: nameof(OrgAccount));
        }

        OrgAccount _OrgAccount;
    }
}