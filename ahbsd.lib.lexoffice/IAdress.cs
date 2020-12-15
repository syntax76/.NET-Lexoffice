using System;
using System.Collections.Generic;

namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Interface für Rechnungs- und Versandadressen.
    /// </summary>
    /// <remarks>Use this objects to provide billing and shipping information of a contact.
    /// Please note that it's only possible to create and change contacts with a maximum of one billing and/or one shipping address.
    /// It's possible to retrieve contacts with more than one billing and shipping address, but it's not possible to update such a contact via the REST API.
    /// </remarks>
    public interface IAddresses
    {
        /// <summary>
        /// Gibt die Liste der Rechnungsadressen zurück.
        /// </summary>
        /// <value>Die Liste der Rechnungsadressen.</value>
        /// <remarks>A list of billing addresses. Each entry is an object of <see cref="IAddress"/>.</remarks>
        List<Address> Billing { get; }
        /// <summary>
        /// Gibt die Liste der Versandadressen zurück.
        /// </summary>
        /// <value>Die Liste der Versandadressen.</value>
        /// <remarks>A list of shipping addresses. Each entry is an object of <see cref="IAddress"/>.</remarks>
        List<Address> Shipping { get; }
    }

    /// <summary>
    /// Interface für eine Adresse.
    /// </summary>
    public interface IAddress
    {
        /// <summary>
        /// Gibt zusätzliche Adress-Informationen zurück oder setzt sie.
        /// </summary>
        /// <value>Zusätzliche Adress-Informationen.</value>
        /// <remarks>Additional address information.</remarks>
        string Supplement { get; set; }
        /// <summary>
        /// Gibt Straße und Hausnummer zurück oder setzt sie.
        /// </summary>
        /// <value>Straße und Hausnummer</value>
        /// <remarks>Street with Street number.</remarks>
        string Street { get; set; }
        /// <summary>
        /// Gibt die PLZ zurück oder setzt sie.
        /// </summary>
        /// <value>Die PLZ.</value>
        /// <remarks>Zip code</remarks>
        string Zip { get; set; }
        /// <summary>
        /// Gibt die Stadt zurück oder setzt sie.
        /// </summary>
        /// <value>Die Stadt.</value>
        /// <remarks>City</remarks>
        string City { get; set; }
        /// <summary>
        /// Gibt den Ländercode zurück oder setzt ihn.
        /// </summary>
        /// <value>Der Ländercode.</value>
        /// <remarks>Country code in the format of ISO 3166 alpha2 (e.g. DE is used for germany).</remarks>
        string CountryCode { get; set; }
    }

    /// <summary>
    /// Adress-Typ.
    /// </summary>
    public enum AdressType
    {
        /// <summary>
        /// Versandadresse
        /// </summary>
        Shipping = 1,
        /// <summary>
        /// Rechnungsadresse
        /// </summary>
        Billing = 2,
        /// <summary>
        /// Beide Typen.
        /// </summary>
        Both = Shipping & Billing,
    }

}
