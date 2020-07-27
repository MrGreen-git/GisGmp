using GisGmp.Services.ExportCharges;
using GisGmp.Services.ExportNotice;
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
using System.Xml;
using System.Xml.Serialization;

namespace GisGmp.Service
{
    public partial class GISGMP_Dll
    {
        public static XmlDocument SerializerObject<T>(T obj, bool auto = false) where T : class => SerializerObject(obj, auto ? CreateXSN(obj) : null);

        public static XmlDocument SerializerObject<T>(T obj, XmlSerializerNamespaces xsn) where T : class
        {
            XmlDocument xmlDocument = new XmlDocument();

            using (var xs = xmlDocument.CreateNavigator().AppendChild())
            {
                new XmlSerializer(typeof(T)).Serialize(xs, obj, xsn);
            }
            return xmlDocument;
        }

        private static XmlSerializerNamespaces CreateXSN<T>(T obj) where T : class
        {
            XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();

            if (obj is ExportChargesRequest)
            {
                xsn.Add("ns0", "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.1.1");
                xsn.Add("com", "http://roskazna.ru/gisgmp/xsd/Common/2.1.1");
                xsn.Add("org", "http://roskazna.ru/gisgmp/xsd/Organization/2.1.1");
                xsn.Add("sc", "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1");
                xsn.Add("chg", "http://roskazna.ru/gisgmp/xsd/Charge/2.1.1");
                xsn.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            }
            else

            if (obj is ExportNoticeRequest)
            {
                xsn.Add("nt", "urn://roskazna.ru/gisgmp/xsd/services/ExportNotice/2.1.1");
                xsn.Add("com", "http://roskazna.ru/gisgmp/xsd/Common/2.1.1");
                xsn.Add("nc", "http://roskazna.ru/gisgmp/xsd/NoticeCharge/2.1.1");
            }
            else

            if (obj is ExportPaymentsRequest)
            {
                xsn.Add("ns0", "urn://roskazna.ru/gisgmp/xsd/services/export-payments/2.1.1");
                xsn.Add("com", "http://roskazna.ru/gisgmp/xsd/Common/2.1.1");
                xsn.Add("org", "http://roskazna.ru/gisgmp/xsd/Organization/2.1.1");
                xsn.Add("sc", "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1");
                xsn.Add("pmnt", "http://roskazna.ru/gisgmp/xsd/Payment/2.1.1");
            }
            else

            if (obj is ExportQuittancesRequest)
            {
                xsn.Add("ns0", "urn://roskazna.ru/gisgmp/xsd/services/export-quittances/2.1.1");
                xsn.Add("com", "http://roskazna.ru/gisgmp/xsd/Common/2.1.1");
                xsn.Add("sc", "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1");
                xsn.Add("qt", "http://roskazna.ru/gisgmp/xsd/Quittance/2.1.1");
                xsn.Add("pmnt", "http://roskazna.ru/gisgmp/xsd/Payment/2.1.1");
                xsn.Add("org", "http://roskazna.ru/gisgmp/xsd/Organization/2.1.1");
            }
            else

            if (obj is ExportRefundsRequest)
            {
                xsn.Add("ns0", "urn://roskazna.ru/gisgmp/xsd/services/export-refunds/2.1.1");
                xsn.Add("com", "http://roskazna.ru/gisgmp/xsd/Common/2.1.1");
                xsn.Add("sc", "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1");
                xsn.Add("org", "http://roskazna.ru/gisgmp/xsd/Organization/2.1.1");
                xsn.Add("rfd", "http://roskazna.ru/gisgmp/xsd/Refund/2.1.1");
            }
            else

            if (obj is ForcedAcknowledgementRequest)
            {
                xsn.Add("fa", "urn://roskazna.ru/gisgmp/xsd/services/forced-ackmowledgement/2.1.1");
                xsn.Add("com", "http://roskazna.ru/gisgmp/xsd/Common/2.1.1");
            }
            else

            if (obj is ImportCertificateRequest)
            {
                xsn.Add("ic", "urn://roskazna.ru/gisgmp/xsd/services/import-certificates/2.1.1");
                xsn.Add("com", "http://roskazna.ru/gisgmp/xsd/Common/2.1.1");
            }
            else

            if (obj is ImportChargesRequest)
            {
                xsn.Add("req", "urn://roskazna.ru/gisgmp/xsd/services/import-charges/2.1.1");
                xsn.Add("org", "http://roskazna.ru/gisgmp/xsd/Organization/2.1.1");
                xsn.Add("com", "http://roskazna.ru/gisgmp/xsd/Common/2.1.1");
                xsn.Add("chg", "http://roskazna.ru/gisgmp/xsd/Charge/2.1.1");
                xsn.Add("pkg", "http://roskazna.ru/gisgmp/xsd/Package/2.1.1");
                xsn.Add("rfd", "http://roskazna.ru/gisgmp/xsd/Refund/2.1.1");
                xsn.Add("pmnt", "http://roskazna.ru/gisgmp/xsd/Payment/2.1.1");
            }
            else

            if (obj is ChargeCreationRequest)
            {
                xsn.Add("req", "urn://roskazna.ru/gisgmp/xsd/services/import-chargestemplate/2.1.1");
                xsn.Add("com", "http://roskazna.ru/gisgmp/xsd/Common/2.1.1");
                xsn.Add("sc", "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1");
                xsn.Add("org", "http://roskazna.ru/gisgmp/xsd/Organization/2.1.1");
                xsn.Add("rfd", "http://roskazna.ru/gisgmp/xsd/Refund/2.1.1");
            }
            else

            if (obj is ImportPaymentsRequest)
            {
                xsn.Add("req", "urn://roskazna.ru/gisgmp/xsd/services/import-payments/2.1.1");
                xsn.Add("com", "http://roskazna.ru/gisgmp/xsd/Common/2.1.1");
                xsn.Add("pkg", "http://roskazna.ru/gisgmp/xsd/Package/2.1.1");
                xsn.Add("org", "http://roskazna.ru/gisgmp/xsd/Organization/2.1.1");
                xsn.Add("chg", "http://roskazna.ru/gisgmp/xsd/Charge/2.1.1");
                xsn.Add("rfd", "http://roskazna.ru/gisgmp/xsd/Refund/2.1.1");
                xsn.Add("pmnt", "http://roskazna.ru/gisgmp/xsd/Payment/2.1.1");
            }
            else

            if (obj is ImportRefundsRequest)
            {
                xsn.Add("ns0", "urn://roskazna.ru/gisgmp/xsd/services/import-refunds/2.1.1");
                xsn.Add("com", "http://roskazna.ru/gisgmp/xsd/Common/2.1.1");
                xsn.Add("pkg", "http://roskazna.ru/gisgmp/xsd/Package/2.1.1");
                xsn.Add("req", "urn://roskazna.ru/gisgmp/services/import-refund/2.1.1");
                xsn.Add("org", "http://roskazna.ru/gisgmp/xsd/Organization/2.1.1");
                xsn.Add("chg", "http://roskazna.ru/gisgmp/xsd/Charge/2.1.1");
                xsn.Add("pmnt", "http://roskazna.ru/gisgmp/xsd/Payment/2.1.1");
                xsn.Add("rfd", "http://roskazna.ru/gisgmp/xsd/Refund/2.1.1");
            }
            else

            if (obj is SubscriptionServiceRequest)
            {
                xsn.Add("ns1", "urn://roskazna.ru/gisgmp/xsd/services/SubscriptionService/2.1.1");
                xsn.Add("com", "http://roskazna.ru/gisgmp/xsd/Common/2.1.1");
                xsn.Add("sub", "http://roskazna.ru/gisgmp/xsd/Subscription/2.1.1");
            }
            else

            if (obj is ExportChargesResponse)
            {
                xsn.Add("ns0", "urn://roskazna.ru/gisgmp/xsd/services/export-charges/2.1.1");
                xsn.Add("com", "http://roskazna.ru/gisgmp/xsd/Common/2.1.1");
                xsn.Add("sc", "http://roskazna.ru/gisgmp/xsd/SearchConditions/2.1.1");
                xsn.Add("chg", "http://roskazna.ru/gisgmp/xsd/Charge/2.1.1");
                xsn.Add("org", "http://roskazna.ru/gisgmp/xsd/Organization/2.1.1");
            }
            else
            {
                return null;
            }

            return xsn;
        }
    }
}
