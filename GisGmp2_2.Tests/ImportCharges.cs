using GisGmp;
using GisGmp.Charge;
using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Package;
using System;
using Xunit;

namespace GisGmp2_2.Tests
{
    public class ImportCharges
    {
        static string pathRoot = $@"..\..\..\XmlDocument\{nameof(ImportCharges)}";

        [Fact]
        public void ImportChargesRequest()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "G_fce0c544-b08d-44bc-83d8-738f10e9d068",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 15, minute: 27, second: 53, millisecond: 045, kind: DateTimeKind.Local),
                SenderIdentifier = "3eacb7",
                SenderRole = "1"
            };

            //Act
            var request = gisgmp.CreateImportChargesRequest(
                importedChargeTypes:
                new ImportedChargeType[]
                {
                    new ImportedChargeType(
                        id: "I_54a59db2-3845-4915-8770-dd95394aadb4",
                        supplierBillID: "32116102414550976332",
                        billDate: new DateTime(day: 30, month: 09, year: 2020, hour: 14, minute: 06, second: 30, millisecond: 313, kind: DateTimeKind.Local),
                        totalAmount: 500000,
                        purpose: "Плата за предоставление сведений из Единого государственного реестра недвижимости",
                        kbk: "32111301031016000130",
                        oktmo: "45348000",
                        payee: new Payee()
                        {
                            Name = "ФГБУ «ФКП Росреестра» по г Москва",
                            Inn = "7705401341",
                            Kpp = "770542151",
                            Ogrn = "7723819340452",
                            OrgAccount = new OrgAccount(
                                bank: new BankType(
                                    name: "ОПЕРАЦИОННЫЙ ДЕПАРТАМЕНТ БАНКА РОССИИ//Межрегиональное операционное управление Федерального казначейства г. Москва",
                                    bik: "024501901",
                                    correspondentBankAccount: "40102810045370000002"
                                    ),
                                accountNumber: "03100643000000019500"
                                )
                        },
                        payer: new ChargePayer(
                            payerIdentifier: "1220000000007712579832",
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
                        OriginatorId = "3eb5fa", 
                    }
                });

            //Assert              
            Assert.True(Tools.CheckObjToXml(request, $@"{nameof(ImportChargesRequest)}", pathRoot));
        }

        [Fact]
        public void ImportChargesResponse()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "I_36a89db2-3845-4915-1234-dd95394aadb4",
                RqId = "G_fce0c544-b08d-44bc-83d8-738f10e9d068",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 15, minute: 28, second: 43, millisecond: 045, kind: DateTimeKind.Local),
                RecipientIdentifier = "3eacb7",
            };

            //Act
            var response = gisgmp.CreateImportChargesResponse(
                importProtocol:
                new ImportProtocolType[]
                { 
                    new ImportProtocolType(
                        entityID: "I_54a59db2-3845-4915-8770-dd95394aadb4",
                        code: "0",
                        description: "Успешно (ТЕСТОВЫЕ ДАННЫЕ!)"
                        )
                });

            //Assert              
            Assert.True(Tools.CheckObjToXml(response, $@"{nameof(ImportChargesResponse)}", pathRoot));
        }
    }
}