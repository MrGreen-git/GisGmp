using GisGmp;
using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Package;
using GisGmp.Payment;
using System;
using Xunit;

namespace GisGmp2_2.Tests
{
    public class ImportPayments
    {
        static string pathRoot = $@"..\..\..\XmlDocument\{nameof(ImportPayments)}";

        [Fact]
        public void ImportPaymentsRequest()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "I_13032ed0-4a7a-49ed-ad46-2a7206d3bca7",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),
                SenderIdentifier = "3eb646",
                SenderRole = "9"
            };

            //Act
            var request = gisgmp.CreateImportPaymentsRequest(
                importedPaymentTypes:
                new ImportedPaymentType[]
                {
                    new ImportedPaymentType(
                        id: "I_09bcf2c6-a08a-4ea2-959d-8e198ba689d9"
                        )
                    {
                        PaymentId = "10471020010005233009202000000001",
                        Purpose = "Штраф",
                        Kbk = "18811630020016000140",
                        Oktmo = "45348000",
                        SupplierBillID = "18817072416285972102",
                        Amount = 50000,
                        PaymentDate = new DateTime(day: 30, month: 09, year: 2020, hour: 14, minute: 06, second: 30, millisecond: 313, kind: DateTimeKind.Local),
                        TransKind = TransKindType.Item01,
                        PaymentOrg = new PaymentOrgType(
                            bank: new BankType(bik: "047252006")
                            ),
                        Payer = new PaymentPayer(
                            payerIdentifier: "1010000000003751379232", 
                            payerName: "Тестовый плательщик"
                            ),
                        Payee = new Payee()
                        {
                            Name = "УВД по ЦАО ГУ МВД России по г. Москве",
                            Inn = "7706012716",
                            Kpp = "770901011",
                            OrgAccount = new OrgAccount(
                                bank: new BankType(
                                    bik: "024501901",
                                    correspondentBankAccount: "40102810045370000002"
                                    ),
                                accountNumber:  "03100643000000019500"
                                )
                        },
                        BudgetIndex = new BudgetIndexType(
                            status: Status.Item01,
                            paytReason: PaytReason.Item0,
                            taxPeriod: "0",
                            taxDocNumber: "0",
                            taxDocDate: "0"
                            )
                    }
                });

            //Assert              
            Assert.True(Tools.CheckObjToXml(request, $@"{nameof(ImportPaymentsRequest)}", pathRoot));
        }

        [Fact]
        public void ImportPaymentsResponse()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "I_1aa5aaca-d28f-48b1-9b39-b3a5f16d4e5c",
                RqId = "I_13032ed0-4a7a-49ed-ad46-2a7206d3bca7",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),
                RecipientIdentifier = "3eb646"
            };

            //Act
            var response = gisgmp.CreateImportPaymentsResponse(
                importProtocol: new ImportProtocolType[]
                { 
                    new ImportProtocolType(
                        entityID: "I_09bcf2c6-a08a-4ea2-959d-8e198ba689d9",
                        code: "0",
                        description: "Успешно (ТЕСТОВЫЕ ДАННЫЕ!)"
                        )
                });

            //Assert              
            Assert.True(Tools.CheckObjToXml(response, $@"{nameof(ImportPaymentsResponse)}", pathRoot));
        }
    }
}