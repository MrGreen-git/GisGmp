using System;
using System.Xml;
using GisGmp;
using GisGmp.Package;
using GisGmp.SearchConditions;
using GisGmp.Services.ImportCharges;

namespace App
{

 
   
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Тестирование");
            GisGmpBuilder gisgmp = new GisGmpBuilder
            {
                CallBackReadyRequest = new CallBackData(M1),                             
                SenderIdentifier = "ED343",
                SenderRole = "1",
                OriginatorId = "",
                PageNumber = 1,
                PageLength = 100
            };


            gisgmp.ExportCharges(ExportChargesKind.CHARGE, new SupplierBillIDType[] { "1234567890123456789012345"});

            
            //string guidSmev = gisgmp.ExportRefunds(ExportRefundsKind.REFUND, new UIP[] { });
            //gisgmp.ImportPayments(ImportedPaymentType)
            //GisGmpBuilder.ExportRefunds(config, ExportRefundsKind.REFUND, new UIP[] { });

            //XmlDocument doc = GisGmpBuilder.SerializerObject(gisgmp.CreateExportRefundsRequest(ExportRefundsKind.REFUND, new UIP[] { }));


            Console.ReadKey();
        }

        public static string M1(XmlDocument xmlDocument, string reference)
        {
            xmlDocument.Save(@"C:\Soft\1.xml");
            Console.WriteLine(xmlDocument.InnerXml);
            return "";
        }
    }
}
