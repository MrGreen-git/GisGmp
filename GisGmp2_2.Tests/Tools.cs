using GisGmp;
using Microsoft.XmlDiffPatch;
using System.IO;
using System.Xml;

namespace GisGmp2_2.Tests
{
    /// <summary>
    /// Вспомогательные методы для тестов
    /// </summary>
    public static class Tools
    {
        /// <summary>
        /// Проверкака правильно ли происходит сериализация объекта
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">Объект запрос/ответ</param>
        /// <param name="nameObj">Название объекта</param>
        /// <param name="pathRoot">Путь к корневой папке с папкой Sample в которой эталон SnameObj.xml</param>
        /// <returns></returns>
        public static bool CheckObjToXml<T>(T obj, string nameObj, string pathRoot) where T : class
        {
            XmlDocument doc = GisGmpBuilder.SerializerObject(obj, true);
            doc.Save(@$"{pathRoot}\{nameObj}.xml");

            using FileStream diffFile = new FileStream(@$"{pathRoot}\Sample\Diff{nameObj}.xml", FileMode.OpenOrCreate);
            using XmlWriter diffWriter = XmlWriter.Create(diffFile);
            bool IsIdentical = new XmlDiff().Compare(@$"{pathRoot}\Sample\S{nameObj}.xml", @$"{pathRoot}\{nameObj}.xml", false, diffWriter);

            return IsIdentical;
        }
    }
}