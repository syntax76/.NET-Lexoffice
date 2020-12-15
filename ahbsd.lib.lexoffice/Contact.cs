using System;
using System.Text;

namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Klasse für LexOffice Contact
    /// </summary>
    public class Contact : IContact
    {

        #region Implementierung von IContact
        /// <summary>
        /// Gibt die UID des Kontakts zurück oder setzt sie.
        /// </summary>
        /// <value>UID des Kontakts.</value>
        /// <remarks>
        /// Unique id of the contact generated on creation by lexoffice.
        /// </remarks>
        public Guid Id { get; set; }
        /// <summary>
        /// Gibt die UID der Organisation zurück oder setzt sie.
        /// </summary>
        /// <value>UID der Organisation</value>
        /// <remarks>
        /// Unique id of the organization the contact belongs to.
        /// </remarks>
        public Guid OrganizationId { get; set; }
        /// <summary>
        /// Gibt die Versionsnummer zurück.
        /// </summary>
        /// <value>Die Versionnummer.</value>
        /// <remarks>
        /// Version (revision) number which will be increased on each change to
        /// handle optimistic locking. Read-only.
        /// </remarks>
        public int Version { get; set; }
        /// <summary>
        /// Gibt die Rollen zurück.
        /// </summary>
        /// <value>Die Rollen.</value>
        /// <remarks>
        /// Defines contact roles and supports further contact information. For
        /// object details see <see cref="IRoles"/>.
        /// </remarks>
        public Roles Roles { get; private set; }
        /// <summary>
        /// Gibt die Firma zurück oder setzt sie.
        /// </summary>
        /// <value>Die Firma.</value>
        /// <remarks>
        /// Company related information. For details see <see cref="ICompany"/>.
        /// </remarks>
        public Company Company { get; set; }
        /// <summary>
        /// Gibt eine individuelle Person zurück oder setzt sie.
        /// </summary>
        /// <value>Eine individuelle Person.</value>
        /// <remarks>
        /// Individual person related information.
        /// For details see <see cref="IPerson"/>.
        /// </remarks>
        public Person Person { get; set; }
        /// <summary>
        /// Gibt eine Adressenliste zurück.
        /// </summary>
        /// <value>Adressenliste.</value>
        /// <remarks>
        /// Addresses (e.g. billing and shipping address(es)) for the contact.
        /// Contains a list for each address type.
        /// For details see <see cref="IAddresses"/>.
        /// </remarks>
        public Addresses Addresses { get; private set; }
        /// <summary>
        /// Gibt eine <see cref="IXRechnung"/> zurück.
        /// </summary>
        /// <value>Eine XRechnung.</value>
        /// <remarks>XRechnung related properties of the contact</remarks>
        public XRechnung XRechnung { get; set; }
        /// <summary>
        /// Gibt eine Emailadressliste zurück.
        /// </summary>
        /// <value>Eine Emailadressliste</value>
        /// <remarks>
        /// Email addresses for the contact. Contains a list for each EMail
        /// type. For details see <see cref="IEmailAdresses"/>.
        /// </remarks>
        public EmailAdresses EmailAddresses { get; private set; }
        /// <summary>
        /// Gibt eine Telefonliste zurück.
        /// </summary>
        /// <value>Eine Telephonliste.</value>
        /// <remarks>
        /// Phone numbers for the contact. Contains a list for each PhoneNumber
        /// type. For details see below.
        /// </remarks>
        public PhoneNumbers PhoneNumbers { get; private set; }
        /// <summary>
        /// Gibt eine Notiz zurück oder setzt sie.
        /// </summary>
        /// <value>Eine Notiz.</value>
        /// <remarks>
        /// A note to the contact. This is just an additional information.
        /// </remarks>
        public string Note { get; set; }
        /// <summary>
        /// Gibt zurück, ob der Kontakt archiviert ist oder nicht.
        /// </summary>
        /// <value>Ist der Kontakt archiviert oder nicht.</value>
        /// <remarks>
        /// Archived flag of the contact.
        /// Read-only.
        /// </remarks>
        public bool Archived { get; set; }
        #endregion

        /// <summary>
        /// Konstruktor ohne Parameter.
        /// </summary>
        public Contact()
        {
            Roles = new Roles();
            Archived = false;
            Version = 1;
            Addresses = new Addresses();
            XRechnung = null;
            EmailAddresses = new EmailAdresses();
            PhoneNumbers = new PhoneNumbers();
            Note = string.Empty;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (Company != null)
            {
                result.AppendFormat("Company: {0}", Company.Name);
                
                if (Company.ContactPersons.Count > 0)
                {
                    result.AppendLine();
                }

                foreach (var person in Company.ContactPersons)
                {
                    result.AppendLine(person.ToString());
                }
            }
            else if (Person != null)
            {
                result.AppendFormat("Person: {0}", Person);
                result.AppendLine();
            }

            result.AppendFormat("Role(s): {0}", Roles);
            result.AppendLine();

            return result.ToString();
        }
    }
}
