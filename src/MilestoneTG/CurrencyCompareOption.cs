namespace MilestoneTG
{
    /// <summary>
    /// Used to indicate how <see cref="Currency"/> should be compared.
    /// </summary>
    public enum CurrencyCompareOption
    {
        /// <summary>
        /// Include the ISO4217 code when comparing currencies.
        /// </summary>
        CodeAndValue,
        
        /// <summary>
        /// Compare only the decimal value, ignoring the ISO4217 code.
        /// </summary>
        ValueOnly
    }
}