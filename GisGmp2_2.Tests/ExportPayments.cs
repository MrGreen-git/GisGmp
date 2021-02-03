using GisGmp;
using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Payment;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportPayments;
using System;
using Xunit;
using ItemChoiceType = GisGmp.Services.ExportPayments.ItemChoiceType;

namespace GisGmp2_2.Tests
{
    public class ExportPayments
    {
        static string pathRoot = $@"..\..\..\XmlDocument\{nameof(ExportPayments)}";

        [Fact]
        public void ExportPaymentsRequest()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "G_a108e1f7-e0f0-48d2-8e80-b64a423efe4e",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),
                SenderIdentifier = "3eb646",
                SenderRole = "9",
                
                PageNumber = 1,
                PageLength = 100
            };

            //Act
            var request = gisgmp.CreateExportPaymentsRequest(
                paymentsKind: ExportPaymentsKind.PAYMENT,
                uin: new SupplierBillIDType[] { new SupplierBillIDType("32117072411021588933") }
                );
          
            //Assert              
            Assert.True(Tools.CheckObjToXml(request, $@"{nameof(ExportPaymentsRequest)}", pathRoot));
        }
      
        [Fact]
        public void ExportPaymentsResponse()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "I_17f81555-2452-42a3-8c8b-4679c2bdf2b7",
                RqId = "G_a108e1f7-e0f0-48d2-8e80-b64a423efe4e",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),
                RecipientIdentifier = "3eb646",
            };

            //Act
            var response = gisgmp.CreateExportPaymentsResponse(
                hasMore: false,
                paymentInfo: new PaymentInfo[]
                {
                    new PaymentInfo(
                        changeStatusInfo: new ChangeStatusInfo( meaning: "1"),
                        paymentId: "10471020010005233009202000000001",
                        paymentDate: new DateTime(day: 30, month: 09, year: 2020, hour: 14, minute: 06, second: 30, millisecond: 313, kind: DateTimeKind.Local),
                        paymentOrg: new PaymentOrgType(
                            bank: new BankType(bik: "047252006")
                            ),
                        payee: new Payee()
                        {
                            Name = "ФГБУ «ФКП Росреестра» по г Москва",
                            Inn = "7705401341",
                            Kpp = "770542151",
                            OrgAccount = new OrgAccount(
                                bank: new BankType(bik: "044525000"),
                                accountNumber: "40101810045250010041"
                                )
                        },
                        purpose: "ФГБУ «ФКП Росреестра» по г Москва (ТЕСТОВЫЕ ДАННЫЕ!)",
                        amount: 500000,
                        transKind: TransKindType.Item01
                    )
                    {
                        SupplierBillID = "32117072411021588933",
                        Kbk = "32111301031016000130",
                        Oktmo = "45348000",
                        Payer = new PaymentPayer(
                            payerIdentifier: "1010000000008751379232",
                            payerName: "Тестовый плательщик"                           
                        ),
                        BudgetIndex = new BudgetIndexType(
                            status: Status.Item01,
                            paytReason: PaytReason.Item0,
                            taxPeriod: "0",
                            taxDocNumber: "0",
                            taxDocDate: "0"
                            ),
                        AcknowledgmentInfo = new AcknowledgmentInfo(
                            supplierBillID: "32117072411021588933"
                            )
                    }
                }
                );
         
            //Assert              
            Assert.True(Tools.CheckObjToXml(response, $@"{nameof(ExportPaymentsResponse)}", pathRoot));
        }
    }
}