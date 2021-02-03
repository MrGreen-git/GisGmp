using GisGmp;
using GisGmp.Common;
using GisGmp.Services.ImportCertificates;
using System;
using System.Xml;
using Xunit;

namespace GisGmp2_2.Tests
{
    public class ImportCertificate
    {
        static string pathRoot = $@"..\..\..\XmlDocument\{nameof(ImportCertificate)}";

        [Fact]
        public void ImportCertificateRequest()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "I_6e188de4-8491-49ea-8ec6-a09a607d020a",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),
                SenderIdentifier = "3eb551",
                SenderRole = "3"
            };

            //Act
            var request = gisgmp.CreateImportCertificateRequest(
                new ImportCertificateEntryType[]
                {
                    new ImportCertificateEntryType(
                        id:  "I_6e188de4-8491-49ea-8ec6-a09a607d020a",
                        ownership: "3eb551"
                        )
                });

            //Assert 
            XmlDocument xmlDoc = default;
            Assert.Null(Record.Exception(() => xmlDoc = GisGmpBuilder.SerializerObject(request, true)));
            Assert.Null(Record.Exception(() => GisGmpBuilder.Deserialize<ImportCertificateRequest>(xmlDoc)));

            Assert.True(Tools.CheckObjToXml(request, $@"{nameof(ImportCertificateRequest)}", pathRoot));
        }

        [Fact]
        public void ImportCertificateResponse()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "G_3752f2cf-86f2-4214-afd0-1e21d80ef30d",
                RqId = "I_6e188de4-8491-49ea-8ec6-a09a607d020a",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),
                RecipientIdentifier = "3eb551"
            };

            //Act
            var response = gisgmp.CreateImportCertificateResponse(
                new ImportProtocolType[]
                {
                    new ImportProtocolType(
                        entityID: "I_6e188de4-8491-49ea-8ec6-a09a607d020a",
                        code: "0",
                        description: "Успешно (ТЕСТОВЫЕ ДАННЫЕ!)"
                        )
                });

            //Assert  
            XmlDocument xmlDoc = default;
            Assert.Null(Record.Exception(() => xmlDoc = GisGmpBuilder.SerializerObject(response, true)));
            Assert.Null(Record.Exception(() => GisGmpBuilder.Deserialize<ImportCertificateResponse>(xmlDoc)));

            Assert.True(Tools.CheckObjToXml(response, $@"{nameof(ImportCertificateResponse)}", pathRoot));
        }
    }
}