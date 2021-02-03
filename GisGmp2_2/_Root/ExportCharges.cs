using GisGmp.Common;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportCharges;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary>
        /// Запрос на предоставление необходимой для уплаты информации (начисления) | Фильтр "Начисление"
        /// </summary>
        /// <param name="chargesKind">Тип запроса на предоставление информации</param>
        /// <param name="supplierBillID">УИН (кол-во объектов 1-100)</param>
        /// <param name="timeInterval">Временной интервал, за который запрашивается информация</param>
        /// <param name="esiaUserInfo">Информация, подтверждающая аутентификацию плательщика (пользователя) в ЕСИА | requred: false</param>
        /// <param name="external">Признак предоставляемой информации | requred: false</param>
        /// <returns>CreateExportChargesRequest -> ObjectRequest | ExportCharges -> IdMessageSMEV </returns>            
        public ExportChargesRequest CreateExportChargesRequest(ExportChargesKind chargesKind, SupplierBillIDType[] supplierBillID, TimeIntervalType timeInterval = default, EsiaUserInfoType esiaUserInfo = default, External? external = default)
        {
            return new ExportChargesRequest(
                config: ExportRequestConfig,
                exportConditions: new ChargesExportConditions(
                    kind: chargesKind,
                    conditions: new ChargesConditionsType(
                        supplierBillID: supplierBillID,
                        timeInterval: timeInterval
                        )
                    ),
                esiaUserInfo: esiaUserInfo,
                external: external
                );
        }

        //TODO исправить запрос
        /// <summary>
        /// Запрос на предоставление необходимой для уплаты информации (начисления)
        /// </summary>
        /// <param name="chargesKind">Тип запроса на предоставление информации</param>
        /// <param name="payerInnOrId">Идентификатор плательщика (кол-во объектов 1-100)</param>
        /// <param name="timeInterval">Временной интервал, за который запрашивается информация</param>
        /// <param name="kbk">КБК (кол-во объектов null, 1-10)</param>
        /// <returns>MessageId СМЭВ</returns>
        public ExportChargesRequest CreateExportChargesRequest(ExportChargesKind chargesKind, IPayerInnOrId[] payerInnOrId, TimeIntervalType timeInterval = null, KBKType[] kbk = null)
        {
            //return new ExportChargesRequest(
            //    config: ExportRequestConfig(),
            //    exportConditions: new ChargesExportConditions(
            //        kind: chargesKind,
            //        conditions: new PayersConditionsType(payerInnOrId, timeInterval, kbk)
            //        )
            //    );

            throw new NotImplementedException();
        }


        /// <summary>
        /// Запрос на предоставление необходимой для уплаты информации (начисления) | Фильтр "Время"
        /// </summary>
        /// <param name="chargesKind">Тип запроса на предоставление информации</param>
        /// <param name="timeInterval">Временной интервал, за который запрашивается информация</param>
        /// <param name="beneficiary">ИНН и КПП получателя средств (кол-во объектов null, 1-10)</param>
        /// <param name="kbk">КБК (кол-во объектов null, 1-10)</param>
        /// <param name="esiaUserInfo">Информация, подтверждающая аутентификацию плательщика (пользователя) в ЕСИА | requred: false</param>
        /// <param name="external">Признак предоставляемой информации | requred: false</param>
        /// <returns>MessageId СМЭВ</returns>
        public ExportChargesRequest CreateExportChargesRequest(ExportChargesKind chargesKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbk = default, EsiaUserInfoType esiaUserInfo = default, External? external = default)
        {
            return new ExportChargesRequest(
                config: ExportRequestConfig,
                exportConditions: new ChargesExportConditions(
                    kind: chargesKind,
                    conditions: new TimeConditionsType(timeInterval, beneficiary, kbk)
                    ),
                esiaUserInfo: esiaUserInfo,
                external: external
                );           
        }

        /// <inheritdoc cref="CreateExportChargesRequest(ExportChargesKind, SupplierBillIDType[], TimeIntervalType, EsiaUserInfoType, External?)"/>
        public string ExportCharges(ExportChargesKind chargesKind, SupplierBillIDType[] supplierBillID, TimeIntervalType timeInterval = default, EsiaUserInfoType esiaUserInfo = default, External? external = default)
            => ReadyRequest(CreateExportChargesRequest(chargesKind, supplierBillID, timeInterval, esiaUserInfo, external));

        /// <summary/>
        public string ExportCharges(ExportChargesKind chargesKind, IPayerInnOrId[] payerInnOrId, TimeIntervalType timeInterval = null, KBKType[] kbk = null)
            => ReadyRequest(CreateExportChargesRequest(chargesKind, payerInnOrId, timeInterval, kbk));

        /// <inheritdoc craf="CreateExportChargesRequest(ExportChargesKind, TimeIntervalType, Beneficiary[], KBKType[], EsiaUserInfoType, External?)" />
        public string ExportCharges(ExportChargesKind chargesKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = null, KBKType[] kbk = null)
            => ReadyRequest(CreateExportChargesRequest(chargesKind, timeInterval, beneficiary, kbk));


        /// <summary>
        /// Ответ на запрос предоставления необходимой для уплаты информации (начисления)
        /// </summary>
        /// <param name="hasMore">Признак окончания выборки | required: true</param>
        /// <param name="chargeInfo">Извещение о начислении | required: false, min: 0, max: 100</param>
        /// <param name="needReRequest">Признак необходимости направления повторного запроса | required: false</param>
        /// <returns>ObjectResponse</returns>
        public ExportChargesResponse CreateExportChargesResponse(bool hasMore, ChargeInfo[] chargeInfo = default, bool? needReRequest = default)
        {
            return new ExportChargesResponse(
                config: ResponseConfig,
                hasMore: hasMore,
                chargeInfo: chargeInfo,
                needReRequest: needReRequest
                );
        }
    }
}