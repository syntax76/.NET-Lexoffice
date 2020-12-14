using System.Text;

namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Klasse für eine Firmen Kontaktperson.
    /// </summary>
    public class CompanyContactPerson : Person, ICompanyContactPerson
    {
        
        /// <summary>
        /// Email address of the contact person.
        /// </summary>
        private string _emailAddress;
        /// <summary>
        /// Phone number of the contact person.
        /// </summary>
        private string _phoneNumber;

        #region Implementierung von ICompanyContactPerson
        /// <summary>
        /// Flags if contact person is the primary contact person. Primary contact persons are shown on vouchers. Default is <c>false</c>.
        /// </summary>
        public bool Primary { get; set; }

        /// <summary>
        /// Email address of the contact person.
        /// </summary>
        public string EmailAddress
        {
            get => _emailAddress;
            set => _emailAddress = value.Trim();
        }

        /// <summary>
        /// Phone number of the contact person.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value.Trim();
        }
        #endregion


        public CompanyContactPerson()
        {
            Primary = false;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(3);
            string tmp = base.ToString();

            if (!string.IsNullOrEmpty(tmp))
            {
                result.AppendLine(tmp);
            }
            if (!string.IsNullOrEmpty(_emailAddress))
            {
                result.AppendFormat("Email: {0}", _emailAddress);
                result.AppendLine();
            }
            if (!string.IsNullOrEmpty(_phoneNumber))
            {
                result.AppendFormat("Tel.: {0}", _phoneNumber);
                result.AppendLine();
            }


            return result.ToString();
        }
    }
}
