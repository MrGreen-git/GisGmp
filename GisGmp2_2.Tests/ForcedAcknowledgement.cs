using GisGmp;
using GisGmp.Common;
using GisGmp.Quittance;
using GisGmp.Services.ForcedAcknowledgement;
using System;
using Xunit;

namespace GisGmp2_2.Tests
{
    public class ForcedAcknowledgement
    {
        static string pathRoot = $@"..\..\..\XmlDocument\{nameof(ForcedAcknowledgement)}";

        [Fact]
        public void ForcedAcknowledgementRequest()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "G_e5c906a5-0ceb-4320-97e5-233f32dd8925",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 51),
                SenderIdentifier = "3eb551",
                SenderRole = "3"
            };

            //Act
            var request = gisgmp.CreateForcedAcknowledgementRequest(
                new Reconcile(                    
                    supplierBillId: "18817072711544879499",
                    paymentId: new PaymentIdType[] { "10471020010005233009202000000001" }
                    )
                );

            //Assert              
            Assert.True(Tools.CheckObjToXml(request, $@"{nameof(ForcedAcknowledgementRequest)}", pathRoot));
        }

        [Fact]
        public void ForcedAcknowledgementResponse()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "G_52858add-199d-4d20-b1de-ed324630232a",
                RqId = "G_e5c906a5-0ceb-4320-97e5-233f32dd8925",
                Test_Timestamp = new DateTime(day: 30, month: 09, year: 2020, hour: 18, minute: 14, second: 21),
                RecipientIdentifier = "3eb551"
            };

            //Act
            var response = gisgmp.CreateForcedAcknowledgementResponse(
                quittances:
                new QuittanceType[]
                {
                    new QuittanceType(
                        supplierBillID: "18817072711544879499",
                        creationDate: new DateTime(day: 30, month: 09, year: 2020, hour: 18, minute: 13, second: 56, millisecond: 284, kind: DateTimeKind.Local),
                        billStatus: AcknowledgmentStatusType.Item5,
                        paymentId: "10471020010005233009202000000001"
                        )
                    { 
                        TotalAmount = 50000,
                        Balance = 0,
                        PaymentId = "10471020010005233009202000000001",
                        AmountPayment = 50000
                    }
                });

            //Assert              
            Assert.True(Tools.CheckObjToXml(response, $@"{nameof(ForcedAcknowledgementResponse)}", pathRoot));
        }
    }
}