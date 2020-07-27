using GisGmp.Common;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportCharges;
using System;


namespace GisGmp.Service
{
    public partial class GISGMP_Dll
    {
        /// <summary>
        /// Запрос на предоставление необходимой для уплаты информации (начисления)
        /// </summary>
        /// <param name="chargesKind">Тип запроса на предоставление информации</param>
        /// <param name="uin">УИН (кол-во объектов 1-100)</param>
        /// <param name="timeInterval">Временной интервал, за который запрашивается информация</param>
        /// <returns>MessageId СМЭВ</returns>
        public string ExportCharges(ExportChargesKind chargesKind, UIN[] uin, TimeIntervalType timeInterval = null)
        {
            if (uin is null || uin.Length == 0 || uin.Length > 100)
                throw new Exception($"Недопустимое количество объектов 'UIN'; текущее значание: '{uin?.Length}'; диапазон 1-100");

            ExportChargesRequest request = new ExportChargesRequest(
                config: RequestConfig(),
                exportConditions: new ChargesExportConditions(
                    kind: chargesKind,
                    conditions: new ChargesConditionsType(
                        supplierBillID: uin.ToArrayString(),
                        timeInterval: timeInterval
                        )
                    )
                );

            return ReadyRequest(SerializerObject(request), request.Id);
        }

        /// <summary>
        /// Запрос на предоставление необходимой для уплаты информации (начисления)
        /// </summary>
        /// <param name="chargesKind">Тип запроса на предоставление информации</param>
        /// <param name="payerInnOrId">Идентификатор плательщика (кол-во объектов 1-100)</param>
        /// <param name="timeInterval">Временной интервал, за который запрашивается информация</param>
        /// <param name="kbk">КБК (кол-во объектов null, 1-10)</param>
        /// <returns>MessageId СМЭВ</returns>
        public string ExportCharges(ExportChargesKind chargesKind, IPayerInnOrId[] payerInnOrId, TimeIntervalType timeInterval = null, KBK[] kbk = null)
        {
            if (payerInnOrId is null || payerInnOrId.Length == 0 || payerInnOrId.Length > 100)
                throw new Exception($"Недопустимое количество объектов 'IPayerInnOrId'; текущее значание: '{payerInnOrId?.Length}'; диапазон 1-100");

            if (!(kbk is null) && (kbk.Length == 0 || kbk.Length > 10))
                throw new Exception($"Недопустимое количество объектов 'KBK'; текущее значание: {kbk.Length}; диапазон null, 1-10");

            ExportChargesRequest request = new ExportChargesRequest(
                config: RequestConfig(),
                exportConditions: new ChargesExportConditions(
                    kind: chargesKind,
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
        /// Запрос на предоставление необходимой для уплаты информации (начисления)
        /// </summary>
        /// <param name="chargesKind">Тип запроса на предоставление информации</param>
        /// <param name="timeInterval">Временной интервал, за который запрашивается информация</param>
        /// <param name="beneficiary">ИНН и КПП получателя средств (кол-во объектов null, 1-10)</param>
        /// <param name="kbk">КБК (кол-во объектов null, 1-10)</param>
        /// <returns>MessageId СМЭВ</returns>
        public string ExportCharges(ExportChargesKind chargesKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = null, KBK[] kbk = null)
        {
            if (!(beneficiary is null) && (beneficiary.Length == 0 || beneficiary.Length > 10))
                throw new Exception($"Недопустимое количество объектов 'Beneficiary'; текущее значание: {beneficiary.Length}; диапазон null, 1-10");

            if (!(kbk is null) && (kbk.Length == 0 || kbk.Length > 10))
                throw new Exception($"Недопустимое количество объектов 'KBK'; текущее значание: {kbk.Length}; диапазон null, 1-10");

            ExportChargesRequest request = new ExportChargesRequest(
                config: RequestConfig(),
                exportConditions: new ChargesExportConditions(
                    kind: chargesKind,
                    conditions: new TimeConditionsType(
                        timeInterval: timeInterval,
                        beneficiary: beneficiary,
                        kbkList: kbk.ToArrayString()
                        )
                    )
                );

            return ReadyRequest(SerializerObject(request), request.Id);
        }

        public ExportChargesResponse CreateExportChargesResponse(ResponseType responseConfig, bool hasMore, ChargeInfo[] chargeInfo = null)
        {
            return new ExportChargesResponse(
                config: responseConfig,
                hasMore: hasMore,
                chargeInfo: chargeInfo
                );
        }
    }
}
