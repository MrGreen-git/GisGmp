using GisGmp;
using GisGmp.Common;
using GisGmp.Quittance;
using GisGmp.SearchConditions;
using System;
using Xunit;

namespace GisGmp2_2.Tests
{
    public class ExportQuittances
    {
        static string pathRoot = $@"..\..\..\XmlDocument\{nameof(ExportQuittances)}";

        [Fact]
        public void ExportQuittancesRequest()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "G_327e3906-5a3d-4c79-98f8-18bdd3f7228b",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),
                SenderIdentifier = "3eacb7",
                SenderRole = "1",
                PageNumber = 1,
                PageLength = 100
            };

            //Act
            var request = gisgmp.CreateExportQuittancesRequest(
                quittancesKind: ExportQuittancesKind.QUITTANCE,
                uin: new SupplierBillIDType[] { new SupplierBillIDType("32117072411021588933") }
                );

            //Assert              
            Assert.True(Tools.CheckObjToXml(request, $@"{nameof(ExportQuittancesRequest)}", pathRoot));
        }

        [Fact]
        public void ExportQuittancesResponse()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "I_1cc3a1dc-263d-40ef-9f0a-51f8b51433a3",
                RqId = "G_327e3906-5a3d-4c79-98f8-18bdd3f7228b",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),
                RecipientIdentifier = "3eacb7"
            };

            //Act
            var response = gisgmp.CreateExportQuittancesResponse(
                hasMore: false,
                quittance:
                new QuittanceType[]
                {
                    new QuittanceType(
                        supplierBillID: "32117072411021588933",
                        creationDate: new DateTime(day: 30, month: 09, year: 2020, hour: 16, minute: 35, second: 56, millisecond: 284, kind: DateTimeKind.Local),
                        billStatus: AcknowledgmentStatusType.Item1,
                        paymentId: "10471020010005233009202000000001"
                        )
                    {
                        TotalAmount = 500000,
                        Balance = 0,
                        AmountPayment = 500000,
                        IsRevoked = false
                    }
                });

            //Assert              
            Assert.True(Tools.CheckObjToXml(response, $@"{nameof(ExportQuittancesResponse)}", pathRoot));
        }
    }
}