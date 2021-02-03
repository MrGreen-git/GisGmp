using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace GisGmp.Services.ExportNSI
{
    /// <summary>
    /// Данные для идентификации получателя средств
    /// </summary>
    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.2.0")]
    public class PayeeData
    {
        /// <summary />
        protected PayeeData() { }

        /// <summary />
        public PayeeData(string inn, string kpp)
        {
            Inn = inn;
            Kpp = kpp;
        }

        /// <summary>
        /// ИНН организации, являющейся получателем средств
        /// </summary>
        [XmlIgnore]
        public INNType Inn 
        {
            get => _Inn;
            set => _Inn = Validator.IsNull(value: value, name: nameof(Inn));
        }

        INNType _Inn;

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("inn")]
        public string WrapperInn { get => Inn; set => Inn = value; }


        /// <summary>
        /// КПП организации, являющейся получателем средств
        /// </summary>
        [XmlIgnore]
        public KPPType Kpp
        {
            get => _Kpp;
            set => _Kpp = Validator.IsNull(value: value, name: nameof(Kpp));
        }

        KPPType _Kpp;

        /// <summary />
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlAttribute("kpp")]
        public string WrapperKpp { get => Kpp; set => Kpp = value; }
    }
}