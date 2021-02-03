using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <remarks/>
    [Serializable]
    [XmlType(Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.2.0")]
    public class PagingType
    {
        /// <summary/>
        protected PagingType() { }

        /// <summary/>
        public PagingType(string pageNumber, string pageLength)
        {
            PageNumber = pageNumber;
            PageLength = pageLength;
        }

        /// <summary>
        /// Номер страницы предоставления информации Вся выборка по запросу разбивается на страницы размером pageLength, начиная с первого элемента. Последняя страница может быть меньше, чем pageLength. В ответ на запрос возвращается только страница, номер которой равен pageNumber.
        /// </summary>
        [XmlAttribute("pageNumber", DataType = "nonNegativeInteger")]
        public string PageNumber { get; set; }

        /// <summary>
        /// Количество элементов на странице предоставления информации
        /// </summary>
        [XmlAttribute("pageLength", DataType = "nonNegativeInteger")]
        public string PageLength { get; set; }
    }
}