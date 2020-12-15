using System;
using System.Collections.Generic;

namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Klasse für Rechnungs- und Versandadressen. Implementiert <see cref="IAddresses"/>.
    /// </summary>
    /// <remarks>Use this objects to provide billing and shipping information of a contact.
    /// Please note that it's only possible to create and change contacts with a maximum of one billing and/or one shipping address.
    /// It's possible to retrieve contacts with more than one billing and shipping address, but it's not possible to update such a contact via the REST API.
    /// </remarks>
    public class Addresses : IAddresses
    {
        #region Implementierung von IAdresses
        /// <summary>
        /// Gibt die Liste der Rechnungsadressen zurück.
        /// </summary>
        /// <value>Die Liste der Rechnungsadressen.</value>
        /// <remarks>A list of billing addresses. Each entry is an object of <see cref="IAddress"/>.</remarks>
        public List<Address> Billing { get; }
        /// <summary>
        /// Gibt die Liste der Versandadressen zurück.
        /// </summary>
        /// <value>Die Liste der Versandadressen.</value>
        /// <remarks>A list of shipping addresses. Each entry is an object of <see cref="IAddress"/>.</remarks>
        public List<Address> Shipping { get; }
        #endregion

        /// <summary>
        /// Konstruktor ohne Parameter.
        /// </summary>
        public Addresses()
        {
            Billing = new List<Address>();
            Shipping = new List<Address>();
        }

        /// <summary>
        /// Konstruktor mit Angabe eines Adress-Typs.
        /// </summary>
        /// <param name="t">Der Adress-Typ.</param>
        public Addresses(AdressType t)
        {
            switch (t)
            {
                case AdressType.Billing:
                    Billing = new List<Address>();
                    Shipping = null;
                    break;
                case AdressType.Shipping:
                    Shipping = new List<Address>();
                    Billing = null;
                    break;
                default:
                    Billing = new List<Address>();
                    Shipping = new List<Address>();
                    break;
            }
        }
    }
}
