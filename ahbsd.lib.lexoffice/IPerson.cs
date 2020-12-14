namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Interface für eine Person.
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// Salutation for the contact person with max length of 25 characters.
        /// </summary>
        string Salutation { get; set; }
        /// <summary>
        /// First name of the contact person.
        /// </summary>
        string FirstName { get; set; }
        /// <summary>
        /// Last name of the contact person.
        /// </summary>
        string LastName { get; set; }
    }
}
