using GisGmp.Services.ExportCharges;
using GisGmp.Services.ExportNotice;
using GisGmp.Services.ExportNoticeNSI;
using GisGmp.Services.ExportNSI;
using GisGmp.Services.ExportPayments;
using GisGmp.Services.ExportQuittances;
using GisGmp.Services.ExportRefunds;
using GisGmp.Services.ForcedAcknowledgement;
using GisGmp.Services.ImportCertificates;
using GisGmp.Services.ImportCharges;
using GisGmp.Services.ImportChargesTemplate;
using GisGmp.Services.ImportPayments;
using GisGmp.Services.ImportRefunds;
using GisGmp.Services.SubscriptionService;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary/>
        public static XmlDocument SerializerObject<T>(T obj, bool auto = false) where T : class => SerializerObject(obj, auto ? CreateXSN(obj) : null);

        /// <summary/>
        public static XmlDocument SerializerObject<T>(T obj, XmlSerializerNamespaces xsn) where T : class
        {
            XmlDocument xmlDocument = new XmlDocument();

            using (var xs = xmlDocument.CreateNavigator().AppendChild())
            {
                new XmlSerializer(typeof(T)).Serialize(xs, obj, xsn);
            }
            return xmlDocument;
        }

        /*Ошибки в файлах разработчиков
         *ExportQuitance нет тега с постраничной выгрузкой
         *Где то ошибка в пространсве имен 1 - нет его, 2 - дубл, ImportRefund - лишнее пространство importRefund Response неправильное пространство
        */
        /// <summary/>
        private static XmlSerializerNamespaces CreateXSN<T>(T obj) where T : class
        {
            XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
     
            void AddPrefix(params string[] prefixs)
            {
                foreach (var prefix in prefixs)
                {
                    switch (prefix)
                    {
                        case "chg":   xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Charge/2.2.0"); break;
                        case "com":   xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Common/2.2.0"); break;
                        case "cn":    xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Common-nsi/2.2.0"); break;
                        case "N/A":   xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Income/2.2.0"); break;
                        case "nc":    xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/NoticeCharge/2.2.0"); break;
                        case "org":   xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Organization/2.2.0"); break;
                        case "pkg":   xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Package/2.2.0"); break;
                        case "pmnt":  xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Payment/2.2.0"); break;
                        case "qt":    xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Quittance/2.2.0"); break;
                        case "rf":
                        case "rfnd":
                        case "rfd":   xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Refund/2.2.0"); break;
                        case "sc":    xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.2.0"); break;
                        case "sub":   xsn.Add(prefix, "http://roskazna.ru/gisgmp/xsd/Subscription/2.2.0"); break;
                        //--
                        case "ns0_1": xsn.Add("ns0",  "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.2.0"); break;
                        case "nt_1":  xsn.Add("nt",   "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.2.0"); break;
                        case "nt_2":  xsn.Add("ns0",  "urn://roskazna.ru/gisgmp/xsd/services/ExportNoticeNSI/2.2.0"); break;
                        case "nsi":   xsn.Add(prefix, "urn://roskazna.ru/gisgmp/xsd/services/export-nsi/2.2.0"); break;
                        case "ns0_2": xsn.Add("ns0",  "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.2.0"); break;
                        case "ns0_3": xsn.Add("ns0",  "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.2.0"); break;
                        case "ns0_4": xsn.Add("ns0",  "urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.2.0"); break;
                        case "fa":    xsn.Add(prefix, "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.2.0"); break;
                        case "ic":    xsn.Add(prefix, "urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.2.0"); break;
                        case "req_1": xsn.Add("req",  "urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.2.0"); break;
                        case "req_2": xsn.Add("req",  "urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.2.0"); break;
                        case "req_3": xsn.Add("req",  "urn://roskazna.ru/gisgmp/xsd/services/import-payments/2.2.0"); break;
                        case "ns0_5": xsn.Add("ns0",  "urn://roskazna.ru/gisgmp/xsd/services/import-refunds/2.2.0"); break;
                        case "ns0_6": xsn.Add("ns0",  "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.2.0"); break;
                        
                        case "xsi":   xsn.Add(prefix, "http://www.w3.org/2001/XMLSchema-instance"); break;

                        default: 
                            throw new Exception($"XSN нет указанного префикса {prefix}");
                    }
                }
            }

            switch (obj)
            {
                case ExportChargesRequest _: AddPrefix("com", "org", "sc", "chg", "ns0_1", "xsi"); break;
                case ExportChargesResponse _: AddPrefix("com", "sc", "chg", "org", "ns0_1"); break;

                case ExportNoticeRequest _: AddPrefix("nt_1", "com", "nc", "pmnt", "org"); break; //Объеденены все запросы
                case ExportNoticeResponse _: AddPrefix("nt_1"); break;

                case ExportNoticeNSIRequest _: AddPrefix("com", "cn", "nt_2", "xsi"); break;
                case ExportNoticeNSIResponse _: AddPrefix("com", "nt_2", "cn", "xsi"); break;

                case ExportNSIRequest _: AddPrefix("cn", "com", "nsi", "xsi"); break;
                case ExportNSIResponse _: AddPrefix("cn", "com", "nsi", "xsi"); break;

                case ExportPaymentsRequest _: AddPrefix("com", "org", "sc", "pmnt", "ns0_2"); break;
                case ExportPaymentsResponse _: AddPrefix("com", "pmnt", "sc", "org", "ns0_2"); break;

                case ExportQuittancesRequest _: AddPrefix("com", "sc", "qt", "pmnt", "org", "ns0_3"); break;
                case ExportQuittancesResponse _: AddPrefix("com", "org", "sc", "qt", "pmnt", "ns0_3"); break;
                  
                case ExportRefundsRequest _: AddPrefix("com", "sc", "org", "rfd", "ns0_4"); break;
                case ExportRefundsResponse _: AddPrefix("com", "sc", "org", "rf", "ns0_4"); break;

                case ForcedAcknowledgementRequest _: AddPrefix("com", "fa"); break;
                case ForcedAcknowledgementResponse _: AddPrefix("qt", "fa"); break;    
                    
                case ImportCertificateRequest _: AddPrefix("com", "ic"); break;
                case ImportCertificateResponse _: AddPrefix("com", "ic"); break;

                case ImportChargesRequest _: AddPrefix("org", "com", "chg", "pkg", "req_1", "rfd", "pmnt"); break;
                case ImportChargesResponse _: AddPrefix("chg", "com", "pmnt", "rfnd", "pkg", "org", "req_1"); break;

                //ImportChargesTemplate
                case ChargeCreationRequest _: AddPrefix("org", "com", "chg", "req_2"); break;
                case ChargeCreationResponse _: AddPrefix("com", "chg", "req_2", "org"); break;

                case ImportPaymentsRequest _: AddPrefix("com", "req_3", "pkg", "org", "chg", "rfd", "pmnt"); break;
                case ImportPaymentsResponse _: AddPrefix("org", "com", "rfd", "req_3", "pkg", "chg", "pmnt"); break;

                case ImportRefundsRequest _: AddPrefix("com", "pkg", "org", "chg", "pmnt", "rfnd", "ns0_5"); break; //Удален дубл namespace
                case ImportRefundsResponse _: AddPrefix("com", "pkg", "org", "rfd", "chg", "pmnt", "ns0_5"); break; //Удален дубл namespace

                case SubscriptionServiceRequest _: AddPrefix("ns0_6", "com", "sub"); break;
                case SubscriptionServiceResponse _: AddPrefix("sub", "com", "ns0_6"); break;

                default: break;
            }

            return xsn;
        }

        /// <summary/>
        public static T Deserialize<T>(XmlDocument xmlDocument)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            Stream xmlStream = new MemoryStream();
            xmlDocument.Save(xmlStream);
            xmlStream.Flush();
            xmlStream.Position = 0;
            T result = (T)serializer.Deserialize(xmlStream);
            xmlStream.Close();
            return result;
        }
    }
}
