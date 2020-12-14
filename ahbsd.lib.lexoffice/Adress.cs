using System;
using System.Collections.Generic;
using System.Text;

namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Klasse für eine Adresse
    /// </summary>
    public class Adress : IAdress, IEquatable<Adress>
    {
        #region IMplementierung vom IAdress
        /// <summary>
        /// Gibt zusätzliche Adress-Informationen zurück oder setzt sie.
        /// </summary>
        /// <value>Zusätzliche Adress-Informationen.</value>
        /// <remarks>Additional address information.</remarks>
        public string Supplement { get; set; }
        /// <summary>
        /// Gibt Straße und Hausnummer zurück oder setzt sie.
        /// </summary>
        /// <value>Straße und Hausnummer</value>
        /// <remarks>Street with Street number.</remarks>
        public string Street { get; set; }
        /// <summary>
        /// Gibt die PLZ zurück oder setzt sie.
        /// </summary>
        /// <value>Die PLZ.</value>
        /// <remarks>Zip code</remarks>
        public string Zip { get; set; }
        /// <summary>
        /// Gibt die Stadt zurück oder setzt sie.
        /// </summary>
        /// <value>Die Stadt.</value>
        /// <remarks>City</remarks>
        public string City { get; set; }
        /// <summary>
        /// Gibt den Ländercode zurück oder setzt ihn.
        /// </summary>
        /// <value>Der Ländercode.</value>
        /// <remarks>Country code in the format of ISO 3166 alpha2 (e.g. DE is used for germany).</remarks>
        public string CountryCode { get; set; }
        #endregion

        /// <summary>
        /// Konstruktor ohne Parameter.
        /// </summary>
        public Adress()
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Adress);
        }

        public bool Equals(Adress other)
        {
            return other != null &&
                   Supplement == other.Supplement &&
                   Street == other.Street &&
                   Zip == other.Zip &&
                   City == other.City &&
                   CountryCode == other.CountryCode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Supplement, Street, Zip, City, CountryCode);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (!string.IsNullOrEmpty(Street))
            {
                result.AppendLine(Street);
            }
            if (!string.IsNullOrEmpty(Supplement))
            {
                result.AppendLine(Supplement);
            }
            if (!string.IsNullOrEmpty(CountryCode))
            {
                result.AppendFormat("{0} ", CountryCode.Trim());
            }
            if (!string.IsNullOrEmpty(Zip))
            {
                result.AppendFormat("{0} ", Zip.Trim());
            }
            if (!string.IsNullOrEmpty(City))
            {
                result.AppendLine(City.Trim());
            }

            return result.ToString();
        }

        public static bool operator ==(Adress left, Adress right)
        {
            return EqualityComparer<Adress>.Default.Equals(left, right);
        }

        public static bool operator !=(Adress left, Adress right)
        {
            return !(left == right);
        }
    }
}
