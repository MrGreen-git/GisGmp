using GisGmp;
using GisGmp.Common.Nsi;
using GisGmp.Services.ExportNoticeNSI;
using System;
using Xunit;

namespace GisGmp2_2.Tests
{
    public class ExportNoticeNSI
    {
        static string pathRoot = $@"..\..\..\XmlDocument\{nameof(ExportNoticeNSI)}";

        #region КП1
        [Fact]
        public void ExportNoticeNSIRequest1()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "G_30c7731b-739d-47bd-befd-86b50e800803",
                Test_Timestamp = new DateTime(day: 04, month: 06, year: 2020, hour: 12, minute: 13, second: 51, millisecond: 621, kind: DateTimeKind.Local),
                RecipientIdentifier = "3eb6e5",
            };

            //Act
            var request = gisgmp.CreateExportNoticeNSIRequest(
                new Destination(recipientIdentifier: "3637ed", routingCode: "45382000"),
                new NoticeNSI(
                    directoryCode: "UBP",
                    signAttachment: false,
                    payeeNSIInfoType: new PayeeNSIInfoType[]
                    {
                        new PayeeNSIInfoType(
                            name: "ФГБУ «ФКП Росреестра» по г Москва (Тестовые данные!)",
                            inn: "7705401341",
                            kpp: "770542151",
                            orgStatus: "1",
                            changeDate: new DateTime(day: 04, month: 06, year: 2020, hour: 12, minute: 10, second: 51)
                        )
                    }
                    )              
                );

            //Assert              
            Assert.True(Tools.CheckObjToXml(request, $@"{nameof(ExportNoticeNSIRequest1)}", pathRoot));
        }

        [Fact]
        public void ExportNoticeNSIResponse1()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "I555bfcc0-80b1-11ea-9aaa-00155d7a2500",
                RqId = "G_30c7731b-739d-47bd-befd-86b50e800803",
                Test_Timestamp = new DateTime(day: 04, month: 06, year: 2020, hour: 12, minute: 14, second: 52, millisecond: 685, kind: DateTimeKind.Local),
                RecipientIdentifier = "3637ed",
            };

            //Act
            var response = gisgmp.CreateExportNoticeNSIResponse(routingCode: "45382000", exportNoticeNSIConfirmation: true);

            //Assert              
            Assert.True(Tools.CheckObjToXml(response, $@"{nameof(ExportNoticeNSIResponse1)}", pathRoot));
        }
        #endregion

        #region КП2
        [Fact]
        public void ExportNoticeNSIRequest2()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "G_554d04cb-5be6-4372-be84-2ffbfbc42264",
                Test_Timestamp = new DateTime(day: 04, month: 06, year: 2020, hour: 12, minute: 13, second: 51, millisecond: 621, kind: DateTimeKind.Local),
                RecipientIdentifier = "3637ed",

            };

            //Act
            var request = gisgmp.CreateExportNoticeNSIRequest(
                new Destination(recipientIdentifier: "3637ed", routingCode: "45382000"),
                new NoticeNSI(
                    directoryCode: "OKTMO",
                    signAttachment: false,
                    oktmoNSIInfoType: new oktmoNSIInfoType[]
                    {
                        new oktmoNSIInfoType(
                            name: "город Каспийск (Тестовые данные!)",
                            oktmo: "82720000",
                            status: "1",
                            changeDate: new DateTime(day: 04, month: 06, year: 2020, hour: 12, minute: 10, second: 51)
                        )
                    }
                    )               
                );

            //Assert              
            Assert.True(Tools.CheckObjToXml(request, $@"{nameof(ExportNoticeNSIRequest2)}", pathRoot));
        }

        [Fact]
        public void ExportNoticeNSIResponse2()
        {
            //Arrange
            GisGmpBuilder gisgmp = new GisGmpBuilder()
            {
                TestEnable = true,
                //
                Test_Id = "G_4a2c00d9-f3f8-48e9-a6d9-3e9da1c87081",
                RqId = "G_554d04cb-5be6-4372-be84-2ffbfbc42264",
                Test_Timestamp = new DateTime(day: 04, month: 06, year: 2020, hour: 12, minute: 14, second: 52, millisecond: 685, kind: DateTimeKind.Local),
                RecipientIdentifier = "3637ed",
            };

            //Act
            var response = gisgmp.CreateExportNoticeNSIResponse(routingCode: "45382000", exportNoticeNSIConfirmation: true);

            //Assert              
            Assert.True(Tools.CheckObjToXml(response, $@"{nameof(ExportNoticeNSIResponse2)}", pathRoot));
        }
        #endregion
    }
}