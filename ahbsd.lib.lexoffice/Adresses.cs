using System;
using System.Collections.Generic;

namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Klasse für Rechnungs- und Versandadressen. Implementiert <see cref="IAdresses"/>.
    /// </summary>
    /// <remarks>Use this objects to provide billing and shipping information of a contact.
    /// Please note that it's only possible to create and change contacts with a maximum of one billing and/or one shipping address.
    /// It's possible to retrieve contacts with more than one billing and shipping address, but it's not possible to update such a contact via the REST API.
    /// </remarks>
    public class Adresses : IAdresses
    {
        #region Implementierung von IAdresses
        /// <summary>
        /// Gibt die Liste der Rechnungsadressen zurück.
        /// </summary>
        /// <value>Die Liste der Rechnungsadressen.</value>
        /// <remarks>A list of billing addresses. Each entry is an object of <see cref="IAdress"/>.</remarks>
        public List<Adress> Billing { get; }
        /// <summary>
        /// Gibt die Liste der Versandadressen zurück.
        /// </summary>
        /// <value>Die Liste der Versandadressen.</value>
        /// <remarks>A list of shipping addresses. Each entry is an object of <see cref="IAdress"/>.</remarks>
        public List<Adress> Shipping { get; }
        #endregion

        /// <summary>
        /// Konstruktor ohne Parameter.
        /// </summary>
        public Adresses()
        {
            Billing = new List<Adress>();
            Shipping = new List<Adress>();
        }

        /// <summary>
        /// Konstruktor mit Angabe eines Adress-Typs.
        /// </summary>
        /// <param name="t">Der Adress-Typ.</param>
        public Adresses(AdressType t)
        {
            switch (t)
            {
                case AdressType.Billing:
                    Billing = new List<Adress>();
                    Shipping = null;
                    break;
                case AdressType.Shipping:
                    Shipping = new List<Adress>();
                    Billing = null;
                    break;
                default:
                    Billing = new List<Adress>();
                    Shipping = new List<Adress>();
                    break;
            }
        }
    }
}
