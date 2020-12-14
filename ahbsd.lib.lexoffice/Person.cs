using System.Text;

namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Klasse für eine Person.
    /// </summary>
    public class Person : IPerson
    {
        /// <summary>
        /// Salutation for the contact person with max length of 25 characters.
        /// </summary>
        private string _salutation;
        /// <summary>
        /// First name of the contact person.
        /// </summary>
        private string _firstName;
        /// <summary>
        /// Last name of the contact person.
        /// </summary>
        private string _lastName;

        #region Implementierung von IPerson
        /// <summary>
        /// Salutation for the contact person with max length of 25 characters.
        /// </summary>
        public string Salutation
        {
            get => _salutation;
            set
            {
                string tmp;

                if (value.Trim().Length > 25)
                {
                    tmp = string.Format("{0} ...", value.Trim().Substring(0, 21));
                }
                else
                {
                    tmp = value.Trim();
                }
                _salutation = tmp;
            }
        }

        /// <summary>
        /// First name of the contact person.
        /// </summary>
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value.Trim();
        }

        /// <summary>
        /// Last name of the contact person.
        /// </summary>
        public string LastName
        {
            get => _lastName;
            set => _lastName = value.Trim();
        }
        #endregion

        public Person()
        {
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(3);

            if (!string.IsNullOrEmpty(_salutation))
            {
                result.AppendFormat("{0} ", _salutation);
            }
            if (!string.IsNullOrEmpty(_firstName))
            {
                result.AppendFormat("{0} ", _firstName);
            }
            if (!string.IsNullOrEmpty(_lastName))
            {
                result.Append(_lastName);
            }

            return result.ToString();
        }
    }
}
