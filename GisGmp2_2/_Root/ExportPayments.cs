using GisGmp.Common;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportPayments;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary>
        /// Запрос на предоставление информации об уплате | Фильтр "Начисление"
        /// </summary>
        /// <param name="paymentsKind">Тип запроса на предоставление информации</param>
        /// <param name="uin">УИН (кол-во объектов 1-100)</param>
        /// <param name="timeInterval">Временной интервал, за который запрашивается информация</param>
        /// <returns>CreateExportPaymentsRequest -> ObjectRequest | ExportPayments -> IdMessageSMEV</returns>
        public ExportPaymentsRequest CreateExportPaymentsRequest(ExportPaymentsKind paymentsKind, SupplierBillIDType[] uin, TimeIntervalType timeInterval = default)
        {
            return new ExportPaymentsRequest(
                config: ExportRequestConfig,
                exportConditions: new PaymentsExportConditions(
                    kind: paymentsKind,
                    conditions: new ChargesConditionsType(
                        supplierBillID: uin,
                        timeInterval: timeInterval
                        )
                    )
                );
        }

        //TODO исправить
        /// <summary>
        /// Запрос на предоставление информации об уплате
        /// </summary>
        /// <param name="paymentsKind">Тип запроса на предоставление информации</param>
        /// <param name="payerInnOrId">Идентификатор плательщика (кол-во объектов 1-100)</param>
        /// <param name="timeInterval">Временной интервал, за который запрашивается информация</param>
        /// <param name="kbk">КБК (кол-во объектов null, 1-10)</param>
        /// <returns>CreateExportPaymentsRequest -> ObjectRequest | ExportPayments -> IdMessageSMEV</returns>
        public ExportPaymentsRequest CreateExportPaymentsRequest(ExportPaymentsKind paymentsKind, IPayerInnOrId[] payerInnOrId, TimeIntervalType timeInterval = default, KBKType[] kbk = default)
        {
            throw new NotImplementedException();
            //return new ExportPaymentsRequest(
            //    config: ExportRequestConfig(),
            //    exportConditions: new PaymentsExportConditions(
            //        kind: paymentsKind,
            //        conditions: new PayersConditionsType(payerInnOrId, timeInterval, kbk)
            //        )
            //    );
        }

        /// <summary>
        /// Запрос на предоставление информации об уплате | Фильтр "Платеж"
        /// </summary>
        /// <param name="paymentsKind">Тип запроса на предоставление информации</param>
        /// <param name="uip">УИП (кол-во объектов 1-100)</param>
        /// <returns>CreateExportPaymentsRequest -> ObjectRequest | ExportPayments -> IdMessageSMEV</returns>
        public ExportPaymentsRequest CreateExportPaymentsRequest(ExportPaymentsKind paymentsKind, UIP[] uip)
        {
            return new ExportPaymentsRequest(
                config: ExportRequestConfig,
                exportConditions: new PaymentsExportConditions(
                    kind: paymentsKind,
                    conditions: new PaymentsConditionsType(uip)
                    )
                );
        }

        /// <summary>
        /// Запрос на предоставление информации об уплате | Фильтр "Время"
        /// </summary>
        /// <param name="paymentsKind">Тип запроса на предоставление информации</param>
        /// <param name="timeInterval">Временной интервал, за который запрашивается информация</param>
        /// <param name="beneficiary">ИНН и КПП получателя средств (кол-во объектов null, 1-10)</param>
        /// <param name="kbk">КБК (кол-во объектов null, 1-10)</param>
        /// <returns>CreateExportPaymentsRequest -> ObjectRequest | ExportPayments -> IdMessageSMEV</returns>
        public ExportPaymentsRequest CreateExportPaymentsRequest(ExportPaymentsKind paymentsKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbk = default)
        {
            return new ExportPaymentsRequest(
                config: ExportRequestConfig,
                exportConditions: new PaymentsExportConditions(
                    kind: paymentsKind,
                    conditions: new TimeConditionsType(timeInterval, beneficiary, kbk)
                    )
                );
        }


        /// <inheritdoc cref="CreateExportPaymentsRequest(ExportPaymentsKind, SupplierBillIDType[], TimeIntervalType)"/>
        public string ExportPayments(ExportPaymentsKind paymentsKind, SupplierBillIDType[] uin, TimeIntervalType timeInterval = default)
            => ReadyRequest(CreateExportPaymentsRequest(paymentsKind, uin, timeInterval));


        /// <summary/>
        public string ExportPayments(ExportPaymentsKind paymentsKind, IPayerInnOrId[] payerInnOrId, TimeIntervalType timeInterval = default, KBKType[] kbk = default)
            => ReadyRequest(CreateExportPaymentsRequest(paymentsKind, payerInnOrId, timeInterval, kbk));


        /// <inheritdoc cref="CreateExportPaymentsRequest(ExportPaymentsKind, UIP[])"/>
        public string ExportPayments(ExportPaymentsKind paymentsKind, UIP[] uip)
            => ReadyRequest(CreateExportPaymentsRequest(paymentsKind, uip));


        /// <inheritdoc cref="CreateExportPaymentsRequest(ExportPaymentsKind, TimeIntervalType, Beneficiary[], KBKType[])"/>
        public string ExportPayments(ExportPaymentsKind paymentsKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbk = default)
            => ReadyRequest(CreateExportPaymentsRequest(paymentsKind, timeInterval, beneficiary, kbk));


        /// <summary>
        /// Извещение о приеме к исполнению распоряжения (платеж)
        /// </summary>
        /// <param name="hasMore">Признак конца выборки | required: true</param>
        /// <param name="paymentInfo">Извещение о приеме к исполнению распоряжения (платеж) | required: false, min: 0, max: 100</param>
        /// <returns>ObjectResponse</returns>
        public ExportPaymentsResponse CreateExportPaymentsResponse(bool hasMore, PaymentInfo[] paymentInfo = default)
        {
            return new ExportPaymentsResponse(
                config: ResponseConfig,
                hasMore: hasMore,
                paymentInfo: paymentInfo
                );
        }
    }
}
