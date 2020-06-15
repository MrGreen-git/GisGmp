using System;
using System.Xml.Serialization;

namespace GisGmp.Common
{
    /// <summary>
    /// Параметры постраничного предоставления информации
    /// </summary>
    [Serializable()]
    [XmlRoot("PagingType", Namespace = "http://roskazna.ru/gisgmp/xsd/Common/2.1.1")]
    public class PagingType
    {
        /// <summary>
        /// Предназначен только для сериализации/десериализации
        /// </summary>
        protected PagingType() { }

        public PagingType(
            string PageNumber,
            string PageLength
            )
        {
            this.PageNumber = PageNumber;
            this.PageLength = PageLength;
        }

        /// <summary>
        /// Номер страницы предоставления информации Вся выборка по запросу разбивается на страницы размером pageLength, начиная с первого элемента. Последняя страница может быть меньше, чем pageLength. В ответ на запрос возвращается только страница, номер которой равен pageNumber.
        /// </summary>
        [XmlAttribute("pageNumber")]
        public string PageNumber { get; set; }

        /// <summary>
        /// Количество элементов на странице предоставления информации
        /// </summary>
        [XmlAttribute("pageLength")]
        public string PageLength { get; set; }
    }
}