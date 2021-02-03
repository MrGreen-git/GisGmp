using System;
using System.Xml.Serialization;

namespace GisGmp.Subscription
{
    /// <summary>
    /// Значение параметра (группы параметров) подписки
    /// </summary>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Subscription/2.2.0")]
    public class SubscriptionParametersType
    {
        /// <summary />
        protected SubscriptionParametersType() { }

        /// <summary />
        public SubscriptionParametersType(Status status, string parameterId, ParameterValue[] parameterValue)
        {
            Status = status;
            ParameterId = parameterId;
            ParameterValue = parameterValue;
        }

        ParameterValue[] _ParameterValue;

        /// <summary>
        /// Значение параметра
        /// </summary>
        [XmlElement("ParameterValue")]
        public ParameterValue[] ParameterValue 
        {
            get => _ParameterValue;
            set
            {
                const int min = 1, max = 10;
                if (value is null) throw new Exception($"{nameof(ParameterValue)} не может иметь значание null");
                if (value.Length < min || value.Length > max) throw new Exception($"{nameof(ParameterValue)} допустимое кол-во символов {min}..{max}, текущее кол-во {value.Length}");
                foreach (var item in value) if (item is null) throw new Exception($"{nameof(ParameterValue)} элемент не может иметь значение null");
                _ParameterValue = value;
            }
        }

        /// <summary>
        /// Cтатус для обработки значения параметра (группы параметров). Возможные значения: 1-новое значение, 2-удаление значения
        /// </summary>
        [XmlAttribute("status")]
        public Status Status { get; set; }

        string _ParameterId;

        /// <summary>
        /// Идентификатор значения параметра (группы параметров) в пакете передаваемых значений
        /// </summary>
        [XmlAttribute("parameterId", DataType = "ID")]
        public string ParameterId 
        {
            get => _ParameterId;
            set
            {
                const int min = 0, max = 50;
                if (value is null) throw new Exception($"{nameof(ParameterId)} не может иметь значание null");
                if (value.Length < min || value.Length > max) throw new Exception($"{nameof(ParameterId)} допустимое кол-во символов {min}..{max}, текущее кол-во {value.Length}");
                _ParameterId = value;
            }
        }
    }
}