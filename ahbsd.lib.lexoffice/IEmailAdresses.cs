using System;
using System.Collections.Generic;

namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Interface für Emailadressen
    /// </summary>
    /// <remarks>
    /// Please note that it's only possible to create and change contacts with a
    /// maximum of one entry in each of the below described lists. It's possible
    /// to retrieve contacts with more than one entry in the lists, but it's not
    /// possible to update such a contact via the REST API.
    /// </remarks>
    public interface IEmailAdresses
    {
        /// <summary>
        /// Gibt eine Liste von Buiseness-Emailadressen zurück.
        /// </summary>
        /// <value>Eine Liste von Buiseness-Emailadressen.</value>
        /// <remarks>
        /// A list of email addresses. Each entry is of type string and contains
        /// an email address.
        /// </remarks>
        List<string> Business { get; }
        /// <summary>
        /// Gibt eine Liste von Office-Emailadressen zurück.
        /// </summary>
        /// <value>Eine Liste von Office-Emailadressen.</value>
        /// <remarks>
        /// A list of email addresses. Each entry is of type string and contains
        /// an email address.
        /// </remarks>
        List<string> Office { get; }
        /// <summary>
        /// Gibt eine Liste von Privat-Emailadressen zurück.
        /// </summary>
        /// <value>Eine Liste von Privat-Emailadressen.</value>
        /// <remarks>
        /// A list of email addresses. Each entry is of type string and contains
        /// an email address.
        /// </remarks>
        List<string> Private { get; }
        /// <summary>
        /// Gibt eine Liste von anderen Emailadressen zurück.
        /// </summary>
        /// <value>Eine Liste von anderen Emailadressen.</value>
        /// <remarks>
        /// A list of email addresses. Each entry is of type string and contains
        /// an email address.
        /// </remarks>
        List<string> Other { get; }
    }
}
