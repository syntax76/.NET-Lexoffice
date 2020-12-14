using System;
using System.Collections.Generic;

namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Klasse für Emailadressen
    /// </summary>
    /// <remarks>
    /// Please note that it's only possible to create and change contacts with a
    /// maximum of one entry in each of the below described lists. It's possible
    /// to retrieve contacts with more than one entry in the lists, but it's not
    /// possible to update such a contact via the REST API.
    /// </remarks>
    public class EmailAdresses : IEmailAdresses
    {
        /// <summary>
        /// Eine Liste von Buiseness-Emailadressen.
        /// </summary>
        List<string> _business;
        /// <summary>
        /// Eine Liste von Office-Emailadressen.
        /// </summary>
        List<string> _office;
        /// <summary>
        /// Eine Liste von Privat-Emailadressen.
        /// </summary>
        List<string> _private;
        /// <summary>
        /// Eine Liste von anderen Emailadressen.
        /// </summary>
        List<string> _other;

        #region Implementierung von IEmailAdresses
        /// <summary>
        /// Gibt eine Liste von Buiseness-Emailadressen zurück.
        /// </summary>
        /// <value>Eine Liste von Buiseness-Emailadressen.</value>
        /// <remarks>
        /// A list of email addresses. Each entry is of type string and contains
        /// an email address.
        /// </remarks>
        public List<string> Business => _business;
        /// <summary>
        /// Gibt eine Liste von Office-Emailadressen zurück.
        /// </summary>
        /// <value>Eine Liste von Office-Emailadressen.</value>
        /// <remarks>
        /// A list of email addresses. Each entry is of type string and contains
        /// an email address.
        /// </remarks>
        public List<string> Office => _office;
        /// <summary>
        /// Gibt eine Liste von Privat-Emailadressen zurück.
        /// </summary>
        /// <value>Eine Liste von Privat-Emailadressen.</value>
        /// <remarks>
        /// A list of email addresses. Each entry is of type string and contains
        /// an email address.
        /// </remarks>
        public List<string> Private => _private;
        /// <summary>
        /// Gibt eine Liste von anderen Emailadressen zurück.
        /// </summary>
        /// <value>Eine Liste von anderen Emailadressen.</value>
        /// <remarks>
        /// A list of email addresses. Each entry is of type string and contains
        /// an email address.
        /// </remarks>
        public List<string> Other => _other;
        #endregion

        public EmailAdresses()
        {
            _business = new List<string>();
            _office = new List<string>();
            _private = new List<string>();
            _other = new List<string>();
        }
    }
}
