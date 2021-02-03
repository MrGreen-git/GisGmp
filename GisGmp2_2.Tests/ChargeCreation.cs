using GisGmp;
using GisGmp.Charge;
using GisGmp.Common;
using GisGmp.Organization;
using System;
using Xunit;

namespace GisGmp2_2.Tests
{
    public class ChargeCreation
    {        
        static string pathRoot = $@"..\..\..\XmlDocument\{nameof(ChargeCreation)}";

        [Fact]
        public void ChargeCreationRequest()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "I_cf64ff59-fba3-49b5-977e-eeb035d012a3",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),
                SenderIdentifier = "3eb715",
                SenderRole = "17",
            };

            //Act
            var request = gisgmp.CreateImportChargesTemplateRequest(
                new ChargeTemplateType(
                    billDate: new DateTime(day: 30, month: 09, year: 2020, hour: 14, minute: 06, second: 30, millisecond: 313, kind: DateTimeKind.Local),
                    totalAmount: 200000,
                    purpose: "Выдача национального водительского удостоверения на пластиковой основе (ТЕСТОВЫЕ ДАННЫЕ!)",
                    kbk: "18810807141011000110",
                    oktmo: "45381000",
                    payee: new Payee()
                    {
                        Name = "Министерство внутренних дел Российской Федерации",
                        Inn = "7706074737",
                        Kpp = "770601001",
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
                        payerIdentifier: "1240000000000431133252",
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
                    Origin = "TEMP",                    
                    Item = new MultiplierSize()
                    { 
                        Value = "0.7",
                        Expiry = "0"
                    }
                });

            //Assert              
            Assert.True(Tools.CheckObjToXml(request, $@"{nameof(ChargeCreationRequest)}", pathRoot));
        }

        [Fact]
        public void ChargeCreationResponse()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "ID000000000000000000000000000001",
                RqId = "I_cf64ff59-fba3-49b5-977e-eeb035d012a3",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 18, minute: 14, second: 29, millisecond: 337, kind: DateTimeKind.Local),
                RecipientIdentifier = "3eb715",
            };

            //Act
            var response = gisgmp.CreateImportChargesTemplateResponse(
                new ChargeType(
                    supplierBillID: "0355431000000000011629713",
                    billDate: new DateTime(day: 30, month: 09, year: 2020, hour: 14, minute: 06, second: 30, millisecond: 313, kind: DateTimeKind.Local),
                    totalAmount: 200000,
                    purpose: "Выдача национального водительского удостоверения на пластиковой основе (ТЕСТОВЫЕ ДАННЫЕ!)",
                    kbk: "18810807141011000110",
                    oktmo: "45381000",
                    payee: new Payee()
                    {
                        Name = "Министерство внутренних дел Российской Федерации",
                        Inn = "7706074737",
                        Kpp = "770601001",
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
                        payerIdentifier: "1240000000000431133252",
                        payerName: "Тестовый плательщик"
                        ),
                    budgetIndex: new BudgetIndexType(
                        status: Status.Item01,
                        paytReason: PaytReason.Item0,
                        taxPeriod: "0",
                        taxDocNumber: "01",
                        taxDocDate: "0"
                        )
                    )
                { 
                    Origin = "TEMP",
                    Item = new MultiplierSize()
                    { 
                        Value = "0.7",
                        Expiry = "0"
                    }
                });

            //Assert              
            Assert.True(Tools.CheckObjToXml(response, $@"{nameof(ChargeCreationResponse)}", pathRoot));
        }
    }
}
