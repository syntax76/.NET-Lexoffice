namespace ahbsd.lib.lexoffice
{
    public interface ICompanyContactPerson : IPerson
    {
        /// <summary>
        /// Flags if contact person is the primary contact person. Primary contact persons are shown on vouchers. Default is <c>false</c>.
        /// </summary>
        bool Primary { get; set; }
        /// <summary>
        /// Email address of the contact person.
        /// </summary>
        string EmailAddress { get; set; }
        /// <summary>
        /// Phone number of the contact person.
        /// </summary>
        string PhoneNumber { get; set; }
    }
}