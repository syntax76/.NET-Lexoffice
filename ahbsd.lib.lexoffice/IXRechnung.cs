namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Contacts for German public authorities should be created with both of the following attributes set.
    /// This results in the generation of invoice documents conforming to the German XRechnung standard when creating invoices in lexoffice.
    /// </summary>
    /// <remarks>
    /// If a customer's <see cref="BuyerReference"/> is set, its <see cref="VendorNumberAtCustomer"/> needs to be set as well.
    /// </remarks>
    public interface IXRechnung
    {
        /// <summary>
        /// Gibt die Käufer Leitweg-ID zurück oder setzt sie.
        /// </summary>
        /// <value>Die Käufer Leitweg-ID.</value>
        /// <remarks>Customer's Leitweg-ID conforming to the German XRechnung system</remarks>
        string BuyerReference { get; set; }
        /// <summary>
        /// Gibt die Verkäufernummer zurück oder setzt sie.
        /// </summary>
        /// <value>Die Verkäufernummer.</value>
        /// <remarks>Your vendor number as used by the customer</remarks>
        string VendorNumberAtCustomer { get; set; }
    }
}
