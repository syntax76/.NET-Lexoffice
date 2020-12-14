using System.Collections.Generic;

namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Interface einer Firma.
    /// </summary>
    public interface ICompany
    {
        /// <summary>
        /// Gibt zurück, ob Steuerfreie Rechnungen zulässig sind oder nicht; oder setzt dies.
        /// </summary>
        /// <value><c>TRUE</c> wenn zulässig, ansonsten <c>FALSE</c>.</value>
        bool AllowTaxFreeInvoices { get; set; }
        /// <summary>
        /// Gibt den Firmennamen zurück oder setzt ihn.
        /// </summary>
        /// <value>Der Firmenname.</value>
        string Name { get; set; }
        /// <summary>
        /// Gibt die Steuernummer zurück oder setzt sie.
        /// </summary>
        /// <value>Die Steuernummer.</value>
        string TaxNumber { get; set; }
        /// <summary>
        /// Gibt die Umsatzsteuer-ID zurück oder setzt sie.
        /// </summary>
        /// <value>Die Umsatzsteuer-ID.</value>
        string VatRegistrationId { get; set; }
        /// <summary>
        /// Gibt eine Liste der Firmen-Kontaktpersonen zurück.
        /// </summary>
        /// <value>Eine Liste der Firmen-Kontaktpersonen.</value>
        List<CompanyContactPerson> ContactPersons { get; }
    }
}