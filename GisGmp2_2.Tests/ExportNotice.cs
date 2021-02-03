using GisGmp;
using GisGmp.Common;
using GisGmp.NoticeCharge;
using GisGmp.Organization;
using GisGmp.Services.ExportNotice;
using System;
using Xunit;

namespace GisGmp2_2.Tests
{
    public class ExportNotice
    {
        static string pathRoot = @$"..\..\..\XmlDocument\{nameof(ExportNotice)}";

        #region КП1
        [Fact]
        public void ExportNoticeRequest1()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "G_e1ed8ef7-19a6-44b9-ac0b-34a0e20b09bd",
                Test_Timestamp = new DateTime(2020, 09, 30, 13, 12, 43, 696, DateTimeKind.Local),
                RecipientIdentifier = "3eb6e5",

            };

            //Act
            var request = gisgmp.CreateExportNoticeRequest(
                new NoticeCharge[]
                { 
                    new NoticeCharge(
                        supplierBillID: "88818012505024915378",
                        billDate: new DateTime(day: 30, month: 09, year: 2020, hour: 10, minute: 12, second: 30, millisecond: 313, kind: DateTimeKind.Local),
                        totalAmount: 5000,
                        purpose: "test",
                        kbk: "32111301031016000130",
                        name: "ФГБУ «ФКП Росреестра» по г Москва",
                        payer: new NoticeChargeTypePayer() { PayerIdentifier = "1220000000007712579832", payerName = "Тестовый плательщик" },
                        changeStatusInfo: new ChangeStatusInfo(meaning: "1")
                        )                   
                },
                new Destination(recipientIdentifier: "3eb6e5", routingCode: "45382000")
                );

            //Assert              
            Assert.True(Tools.CheckObjToXml(request, $@"{nameof(ExportNoticeRequest1)}", pathRoot));
        }

        [Fact]
        public void ExportNoticeResponse1()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "G_327e3906-5a3d-4c79-98f8-18bdd3f7228b",
                RqId = "G_e1ed8ef7-19a6-44b9-ac0b-34a0e20b09bd",
                Test_Timestamp = new DateTime(2020, 09, 30, 13, 15, 47),
                RecipientIdentifier = "3eb6e5",
            };

            //Act
            var response = gisgmp.CreateExportNoticeResponse("45382000", true);
            
            //Assert              
            Assert.True(Tools.CheckObjToXml(response, $@"{nameof(ExportNoticeResponse1)}", pathRoot));
        }
        #endregion

        #region КП2
        [Fact]
        public void ExportNoticeRequest2()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "G_c26e88cb-3a4f-4a36-81af-17ffcccfe16e",
                Test_Timestamp = new DateTime(2020, 09, 30, 19, 44, 47, 032, DateTimeKind.Local),
                RecipientIdentifier = "3eb6e5"
            };

            //Act
            var request = gisgmp.CreateExportNoticeRequest(
                new NoticePayment[]
                {
                    new NoticePayment(
                        changeStatusInfo:new ChangeStatusInfo(meaning: "1"),
                        paymentId: "10445252250000013009202061716434",
                        paymentDate: new DateTime(2020, 09, 30, 14, 06, 30, 313, DateTimeKind.Local),
                        paymentOrg: new PaymentOrgType(
                            bank: new BankType(
                                name: "Отделение Московского банка ПАО Сбербанк",
                                bik: "044525225"
                                )
                            ),
                        payee: new Payee()
                        {
                            Inn = "8888888004",
                            Kpp = "888888800",
                            Name = "АН 1роль",
                            OrgAccount = new OrgAccount(
                                bank: new BankType(
                                    bik: "024501901",
                                    correspondentBankAccount: "40102810045370000002"
                                    ),
                                accountNumber: "03252643000000079500"
                                )
                        },
                        purpose: "test",
                        amount: 20,
                        transKind: TransKindType.Item01
                        )
                    { 
                        Kbk = "88888880000000001140",
                        Oktmo = "88888000",
                        ReceiptDate = new DateTime(2020, 09, 30),
                        SupplierBillID = "88818012420345815071",
                        BudgetIndex = new BudgetIndexType(
                            status: Status.Item24,
                            paytReason: PaytReason.Item0,
                            taxDocDate: "0",
                            taxDocNumber: "0",
                            taxPeriod: "0"
                            )
                    }
                },
                new Destination(recipientIdentifier: "3eb6e5", routingCode: "45382000")
                );

            //Assert              
            Assert.True(Tools.CheckObjToXml(request, $@"{nameof(ExportNoticeRequest2)}", pathRoot));
        }

        [Fact]
        public void ExportNoticeResponse2()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "G_bd3f8d23-c27c-4838-b2cf-80b3d99fdc52",
                RqId = "G_c26e88cb-3a4f-4a36-81af-17ffcccfe16e",
                Test_Timestamp = new DateTime(2020, 09, 30, 19, 45, 47),
                RecipientIdentifier = "3eb6e5",
            };

            //Act
            var response = gisgmp.CreateExportNoticeResponse("45382000", true);

            //Assert              
            Assert.True(Tools.CheckObjToXml(response, $@"{nameof(ExportNoticeResponse2)}", pathRoot));
        }
        #endregion

        #region КП3
        [Fact]
        public void ExportNoticeRequest3()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "G_554d04cb-5be6-4372-be84-2ffbfbc42264",
                Test_Timestamp = new DateTime(2020, 09, 30, 19, 27, 15, 425, DateTimeKind.Local),
                RecipientIdentifier = "3eb6e5"
            };

            //Act
            var request = gisgmp.CreateExportNoticeRequest(
                new NoticeQuittance[]
                {
                    new NoticeQuittance(
                        supplierBillID: "88818012420345815071",
                        creationDate: new DateTime(2020, 09, 30, 19, 26, 49, DateTimeKind.Local),
                        billStatus: AcknowledgmentStatusType.Item2,
                        paymentId: "10445252250000013009202061716434"
                        )
                    {                       
                        TotalAmount = 5000,
                        Balance = 4940,                      
                        IsRevoked = false,                      
                        AmountPayment = 60                    
                    }
                },
                new Destination(recipientIdentifier: "3eb6e5", routingCode: "45382000")
                );

            //Assert              
            Assert.True(Tools.CheckObjToXml(request, $@"{nameof(ExportNoticeRequest3)}", pathRoot));
        }

        [Fact]
        public void ExportNoticeResponse3()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "G_4a2c00d9-f3f8-48e9-a6d9-3e9da1c87081",
                RqId = "G_554d04cb-5be6-4372-be84-2ffbfbc42264",
                Test_Timestamp = new DateTime(2020, 09, 30, 19, 30, 47),
                RecipientIdentifier = "3eb6e5",
            };

            //Act
            var response = gisgmp.CreateExportNoticeResponse("45382000", true);

            //Assert              
            Assert.True(Tools.CheckObjToXml(response, $@"{nameof(ExportNoticeResponse3)}", pathRoot));
        }
        #endregion
    }
}
