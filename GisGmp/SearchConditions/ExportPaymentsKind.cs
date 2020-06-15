namespace GisGmp.SearchConditions
{
    /// <summary>
    /// Тип запроса на предоставление информации об уплате
    /// </summary>
    public enum ExportPaymentsKind
    {
        /// <summary>
        /// Все активные (неаннулированные) платежи
        /// </summary>
        PAYMENT,

        /// <summary>
        /// Все платежи, имеющие статус уточнения (ChangeStatus@meaning имеет значение «2») или статус аннулирования (ChangeStatus@meaning имеет значение «3»)
        /// </summary>
        PAYMENTMODIFIED,

        /// <summary>
        /// Все активные (неаннулированные) платежи, для которых в системе отсутствуют соответствующие начисления (не создана ни одна квитанция)
        /// </summary>
        PAYMENTUNMATCHED,

        /// <summary>
        /// Аннулированные платежи (ChangeStatus@meaning имеет значение «3»)
        /// </summary>
        PAYMENTCANCELLED,

        /// <summary>
        /// Запрос платежей по связанным начислениям (используется только ФССП)
        /// </summary>
        PAYMENTMAINCHARGE
    }
}
