using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Interface für Rollen
    /// </summary>
    public interface IRoles
    {
        /// <summary>
        /// Gibt den Verkäufer zurück oder setzt ihn.
        /// </summary>
        /// <value>Der Verkäufer.</value>
        Vendor Vendor { get; set; }
        /// <summary>
        /// Gibt den Kunden zurück oder setzt ihn.
        /// </summary>
        /// <value>Der Kunde</value>
        Customer Customer { get; set; }
    }

    /// <summary>
    /// Interface für eine Rolle.
    /// </summary>
    public interface IRole
    {
        /// <summary>
        /// Gibt die Nummer zurück oder setzt sie.
        /// </summary>
        /// <value>Die Nummer.</value>
        int Number { get; set; }
        /// <summary>
        /// Gibt einen String zurück, der das Objekt darstellt.
        /// </summary>
        /// <returns>Ein String, der das Objekt darstellt.</returns>
        string ToString();
    }

    /// <summary>
    /// Abstrakte Klasse für eine Rolle.
    /// </summary>
    public abstract class Role : IRole, IEquatable<IRole>
    {
        #region implementation of IRole
        /// <summary>
        /// Gibt die Nummer zurück oder setzt sie.
        /// </summary>
        /// <value>Die Nummer.</value>
        public int Number { get; set; }
        #endregion

        /// <summary>
        /// Konstruktor ohne Parameter.
        /// </summary>
        /// <remarks>Number wird auf -1 gesetzt.</remarks>
        protected Role()
        {
            Number = -1;
        }

        /// <summary>
        /// Konstruktor mit Angabe einer Nummer.
        /// </summary>
        /// <param name="nr">Die Nummer</param>
        protected Role(int nr)
        {
            Number = nr;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as IRole);
        }

        public bool Equals(IRole other)
        {
            return other != null &&
                   Number == other.Number;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Number);
        }

        public static bool operator ==(Role left, Role right)
        {
            return EqualityComparer<IRole>.Default.Equals(left, right);
        }

        public static bool operator !=(Role left, Role right)
        {
            return !(left == right);
        }

        protected string ToStringBase(string classname)
        {
            return string.Format("{1} #{0}", Number, classname.Trim());
        }
    }

    /// <summary>
    /// Klasse mehrerer Rollen.
    /// </summary>
    public class Roles : IRoles, IEquatable<Roles>
    {
        private IRole[] roleS;

        public Roles()
        {
            roleS = new IRole[2];
            roleS[0] = null;
            roleS[1] = null;
        }

        #region Implementierung von IRoles
        /// <summary>
        /// Gibt den Verkäufer zurück oder setzt ihn.
        /// </summary>
        /// <value>Der Verkäufer.</value>
        public Vendor Vendor
        {
            get => (Vendor)roleS[0];
            set
            {
                roleS[0] = value;
            }
        }

        /// <summary>
        /// Gibt den Kunden zurück oder setzt ihn.
        /// </summary>
        /// <value>Der Kunde</value>
        public Customer Customer
        {
            get => (Customer)roleS[1];
            set
            {
                roleS[1] = value;
            }
        }
        #endregion

        public override bool Equals(object obj)
        {
            return Equals(obj as Roles);
        }

        public bool Equals(Roles other)
        {
            return other != null &&
                   EqualityComparer<IRole[]>.Default.Equals(roleS, other.roleS);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(roleS);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (roleS[0] != null)
            {
                result.AppendLine(roleS[0].ToString());
            }
            if (roleS[1] != null)
            {
                result.AppendLine(roleS[1].ToString());
            }

            return result.ToString();
        }

        public static bool operator ==(Roles left, Roles right)
        {
            return EqualityComparer<Roles>.Default.Equals(left, right);
        }

        public static bool operator !=(Roles left, Roles right)
        {
            return !(left == right);
        }
    }

    /// <summary>
    /// Kunden-Klasse.
    /// </summary>
    /// <remarks>Wird so benötigt, damit die JSON-Umsetzung funktioniert.</remarks>
    public class Customer : Role, IRole
    {
        /// <summary>
        /// Konstruktor ohne Parameter
        /// </summary>
        public Customer()
            : base()
        { }

        public override string ToString()
        {
            return ToStringBase("Customer");
        }

        
    }

    /// <summary>
    /// Verkäufer-Klasse.
    /// </summary>
    /// <remarks>Wird so benötigt, damit die JSON-Umsetzung funktioniert.</remarks>
    public class Vendor : Role, IRole
    {
        /// <summary>
        /// Konstruktor ohne Parameter
        /// </summary>
        public Vendor()
            : base()
        { }

        public override string ToString()
        {
            return ToStringBase("Vendor");
        }
    }
}
