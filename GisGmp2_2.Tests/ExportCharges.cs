using GisGmp;
using GisGmp.Charge;
using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportCharges;
using System;
using System.Xml;
using Xunit;

namespace GisGmp2_2.Tests
{
    public class ExportCharges
    {
        static string pathRoot = @$"..\..\..\XmlDocument\{nameof(ExportCharges)}";

        [Fact]
        public void ExportChargesRequest()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "G_cfe0c895-b33d-33bc-28d8-697f21d9e561",
                Test_Timestamp = new DateTime(2020, 09, 30, 18, 13, 51),
                SenderIdentifier = "3eacb7",
                SenderRole = "1",
                //
                PageLength = 100,
                PageNumber = 1
            };

            //Act
            var request = gisgmp.CreateExportChargesRequest(
                chargesKind: ExportChargesKind.CHARGESTATUS,
                supplierBillID: new SupplierBillIDType[] { "32117072411021588933" }
                );
           
            //Assert              
            Assert.True(Tools.CheckObjToXml(request, $@"{nameof(ExportChargesRequest)}", pathRoot));
        }

        [Fact]
        public void ExportChargesResponse()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "I_66a12db2-8953-2155-1664-dd95394aadb4",
                RqId = "G_cfe0c895-b33d-33bc-28d8-697f21d9e561",
                Test_Timestamp = new DateTime(2020, 09, 30, 18, 13, 51),
                RecipientIdentifier = "3eacb7",
            };

            //Act
            var response = gisgmp.CreateExportChargesResponse(false,
                new ChargeInfo[]
                {
                    new ChargeInfo(
                        amountToPay: 0,
                        changeStatusInfo: new ChangeStatusInfo(meaning: "1"),
                        supplierBillID: "32117072411021588933",
                        billDate: new DateTime(2020, 09, 30, 14, 06, 30, 313, DateTimeKind.Local),
                        totalAmount: 500000,
                        purpose: "Плата за предоставление сведений из Единого государственного реестра недвижимости (ТЕСТОВЫЕ ДАННЫЕ!)",
                        kbk: "32111301031016000130",
                        oktmo: "45348000",
                        payee: new Payee()
                        {
                            Name = "ФГБУ «ФКП Росреестра» по г Москва",
                            Inn = "7705401341",
                            Kpp = "770542151",
                            OrgAccount = new OrgAccount(
                                bank: new BankType(
                                    bik: "024501901",
                                    correspondentBankAccount: "40102810045370000002"
                                    ),
                                accountNumber: "03100643000000019500"
                                ),
                        },
                        payer: new ChargePayer(
                            payerIdentifier: "1010000000008751379232",
                            payerName: "Тестовый плательщик"
                            ),
                        budgetIndex: new BudgetIndexType(
                            status: Status.Item01,
                            paytReason: PaytReason.Item0,
                            taxPeriod: "0",
                            taxDocNumber: "0",
                            taxDocDate: "0"
                            )
                        )
                    {
                        AcknowledgmentStatus = AcknowledgmentStatusType.Item1
                    }
                });

            //Assert    
            XmlDocument xmlDoc = default;
            Assert.Null(Record.Exception(() => xmlDoc = GisGmpBuilder.SerializerObject(response, true)));
            Assert.Null(Record.Exception(() => GisGmpBuilder.Deserialize<ExportChargesResponse>(xmlDoc)));

            Assert.True(Tools.CheckObjToXml(response, $@"{nameof(ExportChargesResponse)}", pathRoot));           
        }
    }
}
