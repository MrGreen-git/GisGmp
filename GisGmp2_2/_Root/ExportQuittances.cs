using GisGmp.Common;
using GisGmp.Quittance;
using GisGmp.SearchConditions;
using GisGmp.Services.ExportQuittances;
using System;

namespace GisGmp
{
    public partial class GisGmpBuilder
    {
        /// <summary>
        /// Запрос на предоставление информации о результатах квитирования | Фильтр "Начисление"
        /// </summary>
        /// <param name="quittancesKind">Тип запроса на предоставление информации</param>
        /// <param name="uin">УИН (кол-во объектов 1-100)</param>
        /// <param name="timeInterval">Временной интервал, за который запрашивается информация</param>
        /// <returns>CreateExportQuittancesRequest -> ObjectRequest | ExportQuittances -> IdMessageSMEV</returns>
        public ExportQuittancesRequest CreateExportQuittancesRequest(ExportQuittancesKind quittancesKind, SupplierBillIDType[] uin, TimeIntervalType timeInterval = default)
        {
            return new ExportQuittancesRequest(
                config: ExportRequestConfig,
                exportConditions: new QuittancesExportConditions(
                    kind: quittancesKind,
                    conditions: new ChargesConditionsType(
                        supplierBillID: uin,
                        timeInterval: timeInterval
                        )
                    )
                );
        }

        /// <summary>
        /// Запрос на предоставление информации о результатах квитирования | Фильтр "Время"
        /// </summary>
        /// <param name="quittancesKind">Тип запроса на предоставление информации</param>
        /// <param name="timeInterval">Временной интервал, за который запрашивается информация</param>
        /// <param name="beneficiary">ИНН и КПП получателя средств (кол-во объектов null, 1-10)</param>
        /// <param name="kbk">КБК (кол-во объектов null, 1-10)</param>
        /// <returns>CreateExportQuittancesRequest -> ObjectRequest | ExportQuittances -> IdMessageSMEV</returns>
        public ExportQuittancesRequest CreateExportQuittancesRequest(ExportQuittancesKind quittancesKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbk = default)
        {
            return new ExportQuittancesRequest(
                config: ExportRequestConfig,
                exportConditions: new QuittancesExportConditions(
                    kind: quittancesKind,
                    conditions: new TimeConditionsType(timeInterval, beneficiary, kbk)
                    )
                );
        }


        /// <inheritdoc cref="CreateExportQuittancesRequest(ExportQuittancesKind, SupplierBillIDType[], TimeIntervalType)"/>
        public string ExportQuittances(ExportQuittancesKind quittancesKind, SupplierBillIDType[] uin, TimeIntervalType timeInterval = default)
            => ReadyRequest(CreateExportQuittancesRequest(quittancesKind, uin, timeInterval));


        /// <inheritdoc cref="CreateExportQuittancesRequest(ExportQuittancesKind, TimeIntervalType, Beneficiary[], KBKType[])"/>
        public string ExportQuittances(ExportQuittancesKind quittancesKind, TimeIntervalType timeInterval, Beneficiary[] beneficiary = default, KBKType[] kbk = default)
            => ReadyRequest(CreateExportQuittancesRequest(quittancesKind, timeInterval, beneficiary, kbk));


        /// <summary>
        /// Ответ на запрос предоставления информации об уплате 
        /// </summary>
        /// <param name="hasMore"></param>
        /// <param name="quittance"></param>
        /// <returns></returns>
        public ExportQuittancesResponse CreateExportQuittancesResponse(bool hasMore, QuittanceType[] quittance)
        {
            return new ExportQuittancesResponse(
                config: ResponseConfig,
                hasMore: hasMore,
                quittance: quittance
                );
        }
    }
}
