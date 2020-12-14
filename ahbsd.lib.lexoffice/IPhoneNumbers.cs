using System;
using System.Collections.Generic;

namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Interface für Telephonnummern.
    /// </summary>
    /// <remarks>
    /// Please note that it's only possible to create and change contacts with a
    /// maximum of one entry in each of the below described lists. It's possible
    /// to retrieve contacts with more than one entry in the lists, but it's not
    /// possible to update such a contact via the REST API.
    /// </remarks>
    public interface IPhoneNumbers
    {
        /// <summary>
        /// Gibt eine Liste von Business-Telephonnummern zurück.
        /// </summary>
        /// <value>Eine Liste von Business-Telephonnummern.</value>
        /// <remarks>
        /// A list of phone numbers. Each entry is of type string and contains a
        /// phone number.
        /// </remarks>
        List<string> Business { get; }
        /// <summary>
        /// Gibt eine Liste von Office-Telephonnummern zurück.
        /// </summary>
        /// <value>Eine Liste von Office-Telephonnummern.</value>
        /// <remarks>
        /// A list of phone numbers. Each entry is of type string and contains a
        /// phone number.
        /// </remarks>
        List<string> Office { get; }
        /// <summary>
        /// Gibt eine Liste von Mobil-Telephonnummern zurück.
        /// </summary>
        /// <value>Eine Liste von Mobil-Telephonnummern.</value>
        /// <remarks>
        /// A list of phone numbers. Each entry is of type string and contains a
        /// phone number.
        /// </remarks>
        List<string> Mobile { get; }
        /// <summary>
        /// Gibt eine Liste von Privat-Telephonnummern zurück.
        /// </summary>
        /// <value>Eine Liste von Privat-Telephonnummern.</value>
        /// <remarks>
        /// A list of phone numbers. Each entry is of type string and contains a
        /// phone number.
        /// </remarks>
        List<string> Private { get; }
        /// <summary>
        /// Gibt eine Liste von FAX-Nummern zurück.
        /// </summary>
        /// <value>Eine Liste von FAX-Nummern.</value>
        /// <remarks>
        /// A list of phone numbers. Each entry is of type string and contains a
        /// phone number.
        /// </remarks>
        List<string> Fax { get; }
        /// <summary>
        /// Gibt eine Liste von anderen Telephonnummern zurück.
        /// </summary>
        /// <value>Eine Liste von anderen Telephonnummern.</value>
        /// <remarks>
        /// A list of phone numbers. Each entry is of type string and contains a
        /// phone number.
        /// </remarks>
        List<string> Other { get; }
    }
}
