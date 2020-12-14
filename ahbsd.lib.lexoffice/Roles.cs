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
        Vendor Vendor { get; set; }
        Customer Customer { get; set; }
    }

    public interface IRole
    {
        int Number { get; set; }
        string ToString();
    }

    /// <summary>
    /// Struktur mehrerer Rollen.
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

        public Vendor Vendor
        {
            get => (Vendor)roleS[0];
            set
            {
                roleS[0] = value;
            }
        }

        public Customer Customer
        {
            get => (Customer)roleS[1];
            set
            {
                roleS[1] = value;
            }
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Roles);
        }

        public bool Equals(Roles other)
        {
            return other != null &&
                   EqualityComparer<IRole[]>.Default.Equals(roleS, other.roleS) &&
                   EqualityComparer<Vendor>.Default.Equals(Vendor, other.Vendor) &&
                   EqualityComparer<Customer>.Default.Equals(Customer, other.Customer);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(roleS, Vendor, Customer);
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

    public class Customer : IRole, IEquatable<Customer>
    {
        public int Number { get; set; }

        public Customer()
        {
            Number = -1;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Customer);
        }

        public bool Equals(Customer other)
        {
            return other != null &&
                   Number == other.Number;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Number);
        }

        public override string ToString()
        {
            return string.Format("Customer #{0}", Number);
        }

        public static bool operator ==(Customer left, Customer right)
        {
            return EqualityComparer<Customer>.Default.Equals(left, right);
        }

        public static bool operator !=(Customer left, Customer right)
        {
            return !(left == right);
        }
    }

    public class Vendor : IRole, IEquatable<Vendor>
    {
        public int Number { get; set; }

        public Vendor()
        {
            Number = -1;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Vendor);
        }

        public bool Equals(Vendor other)
        {
            return other != null &&
                   Number == other.Number;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Number);
        }

        public override string ToString()
        {
            return string.Format("Vendor #{0}", Number);
        }

        public static bool operator ==(Vendor left, Vendor right)
        {
            return EqualityComparer<Vendor>.Default.Equals(left, right);
        }

        public static bool operator !=(Vendor left, Vendor right)
        {
            return !(left == right);
        }
    }
}
