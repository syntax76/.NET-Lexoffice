using System;
using System.Collections.Generic;

namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Klasse einer Firma.
    /// </summary>
    public class Company : ICompany
    {
        #region Implementierung von ICompany
        /// <summary>
        /// Gibt zurück, ob Steuerfreie Rechnungen zulässig sind oder nicht; oder setzt dies.
        /// </summary>
        /// <value><c>TRUE</c> wenn zulässig, ansonsten <c>FALSE</c>.</value>
        public bool AllowTaxFreeInvoices { get; set; }
        /// <summary>
        /// Gibt den Firmennamen zurück oder setzt ihn.
        /// </summary>
        /// <value>Der Firmenname.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gibt die Steuernummer zurück oder setzt sie.
        /// </summary>
        /// <value>Die Steuernummer.</value>
        public string TaxNumber { get; set; }
        /// <summary>
        /// Gibt die Umsatzsteuer-ID zurück oder setzt sie.
        /// </summary>
        /// <value>Die Umsatzsteuer-ID.</value>
        public string VatRegistrationId { get; set; }
        /// <summary>
        /// Gibt eine Liste der Firmen-Kontaktpersonen zurück.
        /// </summary>
        /// <value>Eine Liste der Firmen-Kontaktpersonen.</value>
        public List<CompanyContactPerson> ContactPersons { get; private set; }
        #endregion

        /// <summary>
        /// Konstruktor ohne Parameter.
        /// </summary>
        public Company()
        {
            ContactPersons = new List<CompanyContactPerson>();
        }
    }
}
