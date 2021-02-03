using GisGmp;
using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Package;
using GisGmp.Refund;
using System;
using Xunit;

namespace GisGmp2_2.Tests
{
    public class ImportRefunds
    {
        static string pathRoot = $@"..\..\..\XmlDocument\{nameof(ImportRefunds)}";

        [Fact]
        public void ImportRefundsRequest()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "I_07d5a0d1-5183-4efc-86a8-93b4d341872c",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),
                SenderIdentifier = "3eb551",
                SenderRole = "3"
            };

            //Act
            var request = gisgmp.CreateImportRefundsRequest(
                importedRefundTypes: new ImportedRefundType[]
                { 
                    new ImportedRefundType(
                        id: "I_46488813-8080-49f4-b60f-7f87af897c6a"
                        )
                    { 
                        RefundId = "0410964930092020000000001",
                        RefundDocDate = new DateTime(day: 30, month: 09, year: 2020, hour: 14, minute: 06, second: 30, millisecond: 313, kind: DateTimeKind.Local),
                        BudgetLevel = BudgetLevel.Item1,
                        Kbk ="18811630020016000140",
                        Oktmo = "45381000",
                        RefundPayer = new RefundPayer(
                            codeUBP: "28519",
                            name: "Тестовый участник",
                            inn: "7706012716",
                            kpp: "770901011"
                            ),
                        RefundApplication = new RefundApplication(
                            appNum: "256894",
                            appDate: new DateTime(day: 30, month: 09, year: 2020),
                            paymentIdType: "10471020010005233009202000000012",
                            cashType: 1,
                            amount: 50000,
                            purpose: "Штраф за нарушение ПДД.Управление транспортным средством с нечитаемыми государственными регистрационными знаками"
                            ),
                        RefundBasis = new RefundBasis(
                            docKind: "Заявление",
                            docNumber: "235",
                            docDate: new DateTime(day: 30, month: 09, year: 2020)
                            ),
                        RefundPayee = new RefundPayee(
                            payerIdentifier: "1220000000007712579832",
                            name: "Тестовый получатель",
                            bankAccountNumber: new AccountType(
                                bank: new BankType(
                                    bik: "044552272",
                                    correspondentBankAccount: "30101810800000010022"
                                    )
                                )
                            )
                    }
                });

            //Assert              
            Assert.True(Tools.CheckObjToXml(request, $@"{nameof(ImportRefundsRequest)}", pathRoot));
        }

        [Fact]
        public void ImportRefundsResponse()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "I_c6609858-a388-4a14-9f73-d83377b571eb",
                RqId = "I_07d5a0d1-5183-4efc-86a8-93b4d341872c",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),
                RecipientIdentifier = "3eb551"
            };

            //Act
            var response = gisgmp.CreateImportRefundsResponse(
                importProtocol: new ImportProtocolType[]
                { 
                    new ImportProtocolType(
                        entityID: "I_46488813-8080-49f4-b60f-7f87af897c6a",
                        code: "0",
                        description: "Успешно (ТЕСТОВЫЕ ДАННЫЕ!)"
                        )
                });

            //Assert              
            Assert.True(Tools.CheckObjToXml(response, $@"{nameof(ImportRefundsResponse)}", pathRoot));
        }
    }
}