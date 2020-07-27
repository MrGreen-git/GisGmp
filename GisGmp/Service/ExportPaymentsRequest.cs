using GisGmp.Common;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportPayments;
using System;

namespace GisGmp.Service
{
    public partial class GISGMP_Dll
    {
        /// <summary>
        /// Запрос на предоставление информации об уплате
        /// </summary>
        /// <param name="paymentsKind">Тип запроса на предоставление информации</param>
        /// <param name="uin">УИН (кол-во объектов 1-100)</param>
        /// <param name="timeInterval">Временной интервал, за который запрашивается информация</param>
        /// <returns>MessageId СМЭВ</returns>
        public string ExportPayments(ExportPaymentsKind paymentsKind, UIN[] uin, TimeIntervalType timeInterval = null)
        {
            if (uin is null || uin.Length == 0 || uin.Length > 100)
                throw new Exception($"Недопустимое количество объектов 'UIN'; текущее значание: '{uin?.Length}'; диапазон 1-100");

            ExportPaymentsRequest request = new ExportPaymentsRequest(
                config: RequestConfig(),
                exportConditions: new PaymentsExportConditions(
                    kind: paymentsKind,
                    conditions: new ChargesConditionsType(
                        supplierBillID: uin.ToArrayString(),
                        timeInterval: timeInterval
                    )
                )
            );

            return ReadyRequest(SerializerObject(request), request.Id);
        }

        /// <summary>
        /// Запрос на предоставление информации об уплате
        /// </summary>
        /// <param name="paymentsKind">Тип запроса на предоставление информации</param>
        /// <param name="payerInnOrId">Идентификатор плательщика (кол-во объектов 1-100)</param>
        /// <param name="timeInterval">Временной интервал, за который запрашивается информация</param>
        /// <param name="kbk">КБК (кол-во объектов null, 1-10)</param>
        /// <returns>MessageId СМЭВ</returns>
        public string ExportPayments(ExportPaymentsKind paymentsKind, IPayerInnOrId[] payerInnOrId, TimeIntervalType timeInterval = null, KBK[] kbk = null)
        {
            if (payerInnOrId is null || payerInnOrId.Length == 0 || payerInnOrId.Length > 100)
                throw new Exception($"Недопустимое количество объектов 'IPayerInnOrId'; текущее значание: '{payerInnOrId?.Length}'; диапазон 1-100");

            if (!(kbk is null) && (kbk.Length == 0 || kbk.Length > 10))
                throw new Exception($"Недопустимое количество объектов 'KBK'; текущее значание: {kbk.Length}; диапазон null, 1-10");

            ExportPaymentsRequest request = new ExportPaymentsRequest(
                config: RequestConfig(),
                exportConditions: new PaymentsExportConditions(
                    kind: paymentsKind,
                    conditions: new PayersConditionsType(
                        items: payerInnOrId.ToArrayString(),
                        itemsElementName: payerInnOrId.ToArrayType(),
                        timeInterval: timeInterval,
                        kbklist: kbk.ToArrayString()
                    )
                )
            );

            return ReadyRequest(SerializerObject(request), request.Id);
        }

        /// <summary>
        /// Запрос на предоставление информации об уплате
        /// </summary>
        /// <param name="paymentsKind">Тип запроса на предоставление информации</param>
        /// <param name="uip">УИП (кол-во объектов 1-100)</param>
        /// <returns>MessageId СМЭВ</returns>
        public string ExportPayments(ExportPaymentsKind paymentsKind, UIP[] uip)
        {
            if (uip is null || uip.Length == 0 || uip.Length > 100)
                throw new Exception($"Недопустимое количество объектов 'UIN'; текущее значание: '{uip?.Length}'; диапазон 1-100");

            ExportPaymentsRequest request = new ExportPaymentsRequest(
                config: RequestConfig(),
                exportConditions: new PaymentsExportConditions(
                    kind: paymentsKind,
                    conditions: new PaymentsConditionsType(
                        uip: uip.ToArrayString()
                    )
                )
            );

            return ReadyRequest(SerializerObject(request), request.Id);
        }

        /// <summary>
        /// Запрос на предоставление информации об уплате
        /// </summary>
        /// <param name="paymentsKind">Тип запроса на предоставление информации</param>
        /// <param name="timeInterval">Временной интервал, за который запрашивается информация</param>
        /// <param name="beneficiary">ИНН и КПП получателя средств (кол-во объектов null, 1-10)</param>
        /// <param name="kbk">КБК (кол-во объектов null, 1-10)</param>
        /// <returns>MessageId СМЭВ</returns>
        public string ExportPayments(ExportPaymentsKind paymentsKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = null, KBK[] kbk = null)
        {
            if (!(beneficiary is null) && (beneficiary.Length == 0 || beneficiary.Length > 10))
                throw new Exception($"Недопустимое количество объектов 'Beneficiary'; текущее значание: {beneficiary.Length}; диапазон null, 1-10");

            if (!(kbk is null) && (kbk.Length == 0 || kbk.Length > 10))
                throw new Exception($"Недопустимое количество объектов 'KBK'; текущее значание: {kbk.Length}; диапазон null, 1-10");

            ExportPaymentsRequest request =  new ExportPaymentsRequest(
                config: RequestConfig(),
                exportConditions: new PaymentsExportConditions(
                    kind: paymentsKind,
                    conditions: new TimeConditionsType(
                        timeInterval: timeInterval,
                        beneficiary: beneficiary,
                        kbkList: kbk.ToArrayString()
                        )
                )
            );

            return ReadyRequest(SerializerObject(request), request.Id);
        }

        public static ExportPaymentsResponse CreateExportPaymentsResponse(ResponseType responseConfig, bool hasMore, PaymentInfoType[] paymentInfo = null)
        {
            return new ExportPaymentsResponse(
                config: responseConfig,
                hasMore: hasMore,
                paymentInfo: paymentInfo
                );
        }
    }
}
