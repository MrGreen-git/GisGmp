using GisGmp;
using GisGmp.Common;
using GisGmp.Organization;
using GisGmp.Refund;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportRefunds;
using System;
using Xunit;

namespace GisGmp2_2.Tests
{
    public class ExportRefunds
    {
        static string pathRoot = $@"..\..\..\XmlDocument\{nameof(ExportRefunds)}";

        [Fact]
        public void ExportRefundsRequest()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "G_98c04cf8-d42a-4b60-a288-b62d86f4dba5",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),
                SenderIdentifier = "3eb551",
                SenderRole = "3",

                PageNumber = 1,
                PageLength = 100
            };

            //Act
            var request = gisgmp.CreateExportRefundsRequest(
                refundsKind: ExportRefundsKind.REFUND,
                uip: new UIP[] { new UIP("10471020010005233009202000000012") }
                );

            //Assert              
            Assert.True(Tools.CheckObjToXml(request, $@"{nameof(ExportRefundsRequest)}", pathRoot));
        }

        [Fact]
        public void ExportRefundsResponse()
        {            
            // Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "I_cf6899af-40c2-4e48-8f62-d666a6b4f63c",
                RqId = "G_98c04cf8-d42a-4b60-a288-b62d86f4dba5",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),
                RecipientIdentifier = "3eb551"
            };

            //Act
            var response = gisgmp.CreateExportRefundsResponse(
                hasMore: false, 
                refund: new Refund[]
                { 
                    new Refund(
                        changeStatusInfo: new ChangeStatusInfo(meaning: "1"),
                        refundId: "0410964930092020000000013",
                        refundDocDate: new DateTime(day: 30, month: 09, year: 2020, hour: 14, minute: 06, second: 30, millisecond: 313, kind: DateTimeKind.Local),
                        budgetLevel: BudgetLevel.Item1,
                        refundPayee: new RefundPayee(
                            payerIdentifier: "1220000000005512349832",
                            name: "Тестовый получатель",
                            bankAccountNumber: new AccountType(bank: new BankType(bik: "044552272"))
                            ),
                        refundApplication: new RefundApplication(
                            appNum: "987894",
                            appDate: new DateTime(day: 30, month: 09, year: 2020),
                            paymentIdType: "10471020010005233009202000000012",
                            cashType: 1,
                            amount: 300000,
                            purpose: "Штраф за нарушение ПДД (ТЕСТОВЫЕ ДАННЫЕ!)"
                            ),
                        refundBasis: new RefundBasis(
                            docKind: "Заявление",
                            docNumber: "331254",
                            docDate: new DateTime(day: 30, month: 09, year: 2020)
                            ),
                        refundPayer: new RefundPayer(
                            codeUBP: "28519",
                            name: "Тестовый участник",
                            inn: "7706012716",
                            kpp: "770901011"
                            )
                        )
                    { 
                        Kbk = "18811630020016000140",
                        Oktmo = "45381000"
                    }
                });

            //Assert              
            Assert.True(Tools.CheckObjToXml(response, $@"{nameof(ExportRefundsResponse)}", pathRoot));
        }
    }
}