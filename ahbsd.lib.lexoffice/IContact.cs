using System;
using System.Collections.Generic;

namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Interface für LexOffice Contact
    /// </summary>
    public interface IContact
    {
        /// <summary>
        /// Gibt die UID des Kontakts zurück oder setzt sie.
        /// </summary>
        /// <value>UID des Kontakts.</value>
        /// <remarks>
        /// Unique id of the contact generated on creation by lexoffice.
        /// </remarks>
        Guid Id { get; set; }
        /// <summary>
        /// Gibt die UID der Organisation zurück oder setzt sie.
        /// </summary>
        /// <value>UID der Organisation</value>
        /// <remarks>
        /// Unique id of the organization the contact belongs to.
        /// </remarks>
        Guid OrganizationId { get; set; }
        /// <summary>
        /// Gibt die Versionsnummer zurück.
        /// </summary>
        /// <value>Die Versionnummer.</value>
        /// <remarks>
        /// Version (revision) number which will be increased on each change to
        /// handle optimistic locking. Read-only.
        /// </remarks>
        int Version { get; }
        /// <summary>
        /// Gibt die Rollen zurück.
        /// </summary>
        /// <value>Die Rollen.</value>
        /// <remarks>
        /// Defines contact roles and supports further contact information. For
        /// object details see <see cref="IRoles"/>.
        /// </remarks>
        Roles Roles { get; }
        /// <summary>
        /// Gibt die Firma zurück oder setzt sie.
        /// </summary>
        /// <value>Die Firma.</value>
        /// <remarks>
        /// Company related information. For details see <see cref="ICompany"/>.
        /// </remarks>
        Company Company { get; set; }
        /// <summary>
        /// Gibt eine individuelle Person zurück oder setzt sie.
        /// </summary>
        /// <value>Eine individuelle Person.</value>
        /// <remarks>
        /// Individual person related information.
        /// For details see <see cref="IPerson"/>.
        /// </remarks>
        Person Person { get; set; }
        /// <summary>
        /// Gibt eine Adressenliste zurück.
        /// </summary>
        /// <value>Adressenliste.</value>
        /// <remarks>
        /// Addresses (e.g. billing and shipping address(es)) for the contact.
        /// Contains a list for each address type.
        /// For details see <see cref="IAdresses"/>.
        /// </remarks>
        Adresses Adresses { get; }
        /// <summary>
        /// Gibt eine <see cref="IXRechnung"/> zurück.
        /// </summary>
        /// <value>Eine XRechnung.</value>
        /// <remarks>XRechnung related properties of the contact</remarks>
        XRechnung XRechnung { get; set; }
        /// <summary>
        /// Gibt eine Emailadressliste zurück.
        /// </summary>
        /// <value>Eine Emailadressliste</value>
        /// <remarks>
        /// Email addresses for the contact. Contains a list for each EMail
        /// type. For details see <see cref="IEmailAdresses"/>.
        /// </remarks>
        EmailAdresses EmailAddresses { get; }
        /// <summary>
        /// Gibt eine Telefonliste zurück.
        /// </summary>
        /// <value>Eine Telephonliste.</value>
        /// <remarks>
        /// Phone numbers for the contact. Contains a list for each PhoneNumber
        /// type. For details see below.
        /// </remarks>
        PhoneNumbers PhoneNumbers { get; }
        /// <summary>
        /// Gibt eine Notiz zurück oder setzt sie.
        /// </summary>
        /// <value>Eine Notiz.</value>
        /// <remarks>
        /// A note to the contact. This is just an additional information.
        /// </remarks>
        string Note { get; set; }
        /// <summary>
        /// Gibt zurück, ob der Kontakt archiviert ist oder nicht.
        /// </summary>
        /// <value>Ist der Kontakt archiviert oder nicht.</value>
        /// <remarks>
        /// Archived flag of the contact.
        /// Read-only.
        /// </remarks>
        bool Archived { get; }
    }
}
