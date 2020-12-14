using System;
using System.Collections.Generic;

namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Klasse für Telephonnummern.
    /// Implementiert <see cref="IPhoneNumbers"/>.
    /// </summary>
    /// <remarks>
    /// Please note that it's only possible to create and change contacts with a
    /// maximum of one entry in each of the below described lists. It's possible
    /// to retrieve contacts with more than one entry in the lists, but it's not
    /// possible to update such a contact via the REST API.
    /// </remarks>
    public class PhoneNumbers : IPhoneNumbers
    {
        /// <summary>
        /// Eine Liste von Business-Telephonnummern.
        /// </summary>
        List<string> _business;

        /// <summary>
        /// Eine Liste von Office-Telephonnummern.
        /// </summary>
        List<string> _office;

        /// <summary>
        /// Eine Liste von Mobil-Telephonnummern.
        /// </summary>
        List<string> _mobile;

        /// <summary>
        /// Eine Liste von Privat-Telephonnummern.
        /// </summary>
        List<string> _private;

        /// <summary>
        /// Eine Liste von FAX-Nummern.
        /// </summary>
        List<string> _fax;

        /// <summary>
        /// Eine Liste von anderen Telephonnummern.
        /// </summary>
        List<string> _other;




        #region Implementierung von IPhoneNumbers
        /// <summary>
        /// Gibt eine Liste von Business-Telephonnummern zurück.
        /// </summary>
        /// <value>Eine Liste von Business-Telephonnummern.</value>
        /// <remarks>
        /// A list of phone numbers. Each entry is of type string and contains a
        /// phone number.
        /// </remarks>
        public List<string> Business => _business;
        /// <summary>
        /// Gibt eine Liste von Office-Telephonnummern zurück.
        /// </summary>
        /// <value>Eine Liste von Office-Telephonnummern.</value>
        /// <remarks>
        /// A list of phone numbers. Each entry is of type string and contains a
        /// phone number.
        /// </remarks>
        public List<string> Office => _office;
        /// <summary>
        /// Gibt eine Liste von Mobil-Telephonnummern zurück.
        /// </summary>
        /// <value>Eine Liste von Mobil-Telephonnummern.</value>
        /// <remarks>
        /// A list of phone numbers. Each entry is of type string and contains a
        /// phone number.
        /// </remarks>
        public List<string> Mobile => _mobile;
        /// <summary>
        /// Gibt eine Liste von Privat-Telephonnummern zurück.
        /// </summary>
        /// <value>Eine Liste von Privat-Telephonnummern.</value>
        /// <remarks>
        /// A list of phone numbers. Each entry is of type string and contains a
        /// phone number.
        /// </remarks>
        public List<string> Private => _private;
        /// <summary>
        /// Gibt eine Liste von FAX-Nummern zurück.
        /// </summary>
        /// <value>Eine Liste von FAX-Nummern.</value>
        /// <remarks>
        /// A list of phone numbers. Each entry is of type string and contains a
        /// phone number.
        /// </remarks>
        public List<string> Fax => _fax;
        /// <summary>
        /// Gibt eine Liste von anderen Telephonnummern zurück.
        /// </summary>
        /// <value>Eine Liste von anderen Telephonnummern.</value>
        /// <remarks>
        /// A list of phone numbers. Each entry is of type string and contains a
        /// phone number.
        /// </remarks>
        public List<string> Other => _other;
        #endregion

        /// <summary>
        /// Konstruktor ohne Parameter.
        /// </summary>
        public PhoneNumbers()
        {
            _business = new List<string>();
            _office = new List<string>();
            _mobile = new List<string>();
            _private = new List<string>();
            _fax = new List<string>();
            _other = new List<string>();
        }
    }
}
