using GisGmp.Common;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportRefunds;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary>
        /// Запрос на предоставление информации о возврате
        /// </summary>
        /// <param name="refundsKind">Тип запроса на предоставление информации</param>
        /// <param name="uip">УИП (кол-во объектов 1-100)</param>
        /// <returns>MessageId СМЭВ</returns>
        public ExportRefundsRequest CreateExportRefundsRequest(ExportRefundsKind refundsKind, UIP[] uip)
        {
            return new ExportRefundsRequest(
                config: ExportRequestConfig,
                exportConditions: new RefundsExportConditions(
                    kind: refundsKind,
                    conditions: new PaymentsConditionsType(uip)
                    )
                );
        }

        /// <summary>
        /// Запрос на предоставление информации о возврате
        /// </summary>
        /// <param name="refundsKind">Тип запроса на предоставление информации</param>
        /// <param name="payerInnOrId">Идентификатор плательщика (кол-во объектов 1-100)</param>
        /// <param name="timeInterval">Временной интервал, за который запрашивается информация</param>
        /// <param name="kbk">КБК (кол-во объектов null, 1-10)</param>
        /// <returns>MessageId СМЭВ</returns>
        public ExportRefundsRequest CreateExportRefundsRequest(ExportRefundsKind refundsKind, IPayerInnOrId[] payerInnOrId, TimeIntervalType timeInterval = null, KBKType[] kbk = null)
        {
            throw new NotImplementedException();
            //return new ExportRefundsRequest(
            //    config: ExportRequestConfig(),
            //    exportConditions: new RefundsExportConditions(
            //        kind: refundsKind,
            //        conditions: new PayersConditionsType(payerInnOrId, timeInterval, kbk)
            //        )
            //    );
        }

        /// <summary>
        /// Запрос на предоставление информации о возврате
        /// </summary>
        /// <param name="refundsKind">Тип запроса на предоставление информации</param>
        /// <param name="timeInterval">Временной интервал, за который запрашивается информация</param>
        /// <param name="beneficiary">ИНН и КПП получателя средств (кол-во объектов null, 1-10)</param>
        /// <param name="kbk">КБК (кол-во объектов null, 1-10)</param>
        /// <returns>MessageId СМЭВ</returns>
        public ExportRefundsRequest CreateExportRefundsRequest(ExportRefundsKind refundsKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = null, KBKType[] kbk = null)
        {
            return new ExportRefundsRequest(
                config: ExportRequestConfig,
                exportConditions: new RefundsExportConditions(
                    kind: refundsKind,
                    conditions: new TimeConditionsType(timeInterval, beneficiary, kbk)
                    )
                );
        }

        /// <summary>
        /// Запрос на предоставление информации о возврате
        /// </summary>
        /// <param name="refundsKind">Тип запроса на предоставление информации</param>
        /// <param name="uir">УИВ(кол-во объектов 1-100)</param>
        /// <returns>MessageId СМЭВ</returns>
        public ExportRefundsRequest CreateExportRefundsRequest(ExportRefundsKind refundsKind, UIR[] uir)
        {
            return new ExportRefundsRequest(
                config: ExportRequestConfig,
                exportConditions: new RefundsExportConditions(
                    kind: refundsKind,
                    conditions: new RefundsConditionsType(uir)
                    )
                );
        }

        /// <summary/>
        public string ExportRefunds(ExportRefundsKind refundsKind, UIP[] uip)
            => ReadyRequest(CreateExportRefundsRequest(refundsKind, uip));

        /// <summary/>
        public string ExportRefunds(ExportRefundsKind refundsKind, IPayerInnOrId[] payerInnOrId, TimeIntervalType timeInterval = null, KBKType[] kbk = null)
            => ReadyRequest(CreateExportRefundsRequest(refundsKind, payerInnOrId, timeInterval, kbk));

        /// <summary/>
        public string ExportRefunds(ExportRefundsKind refundsKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = null, KBKType[] kbk = null)
            => ReadyRequest(CreateExportRefundsRequest(refundsKind, timeInterval, beneficiary, kbk));

        /// <summary/>
        public string ExportRefunds(ExportRefundsKind refundsKind, UIR[] uir)
            => ReadyRequest(CreateExportRefundsRequest(refundsKind, uir));

        /// <summary/>
        public ExportRefundsResponse CreateExportRefundsResponse(bool hasMore, Services.ExportRefunds.Refund[] refund)
        {
            return new ExportRefundsResponse(
                config: ResponseConfig,
                hasMore: hasMore,
                refund: refund
                );
        }
    }
}