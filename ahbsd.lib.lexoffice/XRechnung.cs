using System;
namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Contacts for German public authorities should be created with both of the following attributes set.
    /// This results in the generation of invoice documents conforming to the German XRechnung standard when creating invoices in lexoffice.
    /// </summary>
    /// <remarks>
    /// If a customer's <see cref="BuyerReference"/> is set, its <see cref="VendorNumberAtCustomer"/> needs to be set as well.
    /// </remarks>
    public class XRechnung : IXRechnung
    {
        /// <summary>
        /// Die Käufer Leitweg-ID.
        /// </summary>
        string _buyerReference;
        /// <summary>
        /// Die Verkäufernummer.
        /// </summary>
        string _vendorNumberAtCustomer;

        #region Implementierung von IXRechnung
        /// <summary>
        /// Gibt die Käufer Leitweg-ID zurück oder setzt sie.
        /// </summary>
        /// <value>Die Käufer Leitweg-ID.</value>
        /// <remarks>Customer's Leitweg-ID conforming to the German XRechnung system</remarks>
        public string BuyerReference
        {
            get => _buyerReference;
            set
            {
                if (!string.IsNullOrEmpty(value) && !value.Trim().Equals(_buyerReference))
                {
                    _buyerReference = value.Trim();
                }
                else if (string.IsNullOrEmpty(value))
                {
                    _buyerReference = null;
                    _vendorNumberAtCustomer = null;
                }
            }
        }
        /// <summary>
        /// Gibt die Verkäufernummer zurück oder setzt sie.
        /// </summary>
        /// <value>Die Verkäufernummer.</value>
        /// <remarks>Your vendor number as used by the customer</remarks>
        /// <exception cref="Exception">Wenn <c>null</c> eingegeben wird, aber <see cref="BuyerReference"/> <c>nict null</c> ist.</exception>
        public string VendorNumberAtCustomer
        {
            get => _vendorNumberAtCustomer;
            set
            {
                if (!string.IsNullOrEmpty(value) && !value.Trim().Equals(_vendorNumberAtCustomer))
                {
                    _vendorNumberAtCustomer = value.Trim();
                }
                else if (string.IsNullOrEmpty(value) && string.IsNullOrEmpty(_buyerReference))
                {
                    _vendorNumberAtCustomer = null;
                }
                else
                {
                    InvalidException(_buyerReference, value);
                }
            }
        }
        #endregion

        /// <summary>
        /// Konstruktor mit Angabe der Käufer Leitweg-ID und der Verkäufernummer. 
        /// </summary>
        /// <param name="buyerReference">Die Käufer Leitweg-ID.</param>
        /// <param name="vendorNumberAtCustomer">Die Verkäufernummer.</param>
        /// <exception cref="Exception">Wenn für die Käufer Leitweg-ID <c>null</c> eingegeben wird, aber die Verkäufernummer <c>nict null</c> ist.</exception>
        public XRechnung(string buyerReference, string vendorNumberAtCustomer)
        {
            if (!string.IsNullOrEmpty(buyerReference) && !string.IsNullOrEmpty(vendorNumberAtCustomer))
            {
                _buyerReference = buyerReference.Trim();
                _vendorNumberAtCustomer = vendorNumberAtCustomer.Trim();
            }
            else if (string.IsNullOrEmpty(buyerReference))
            {
                _buyerReference = null;
                _vendorNumberAtCustomer = null;
            }
            else
            {
                InvalidException(buyerReference, vendorNumberAtCustomer);
            }
        }

        /// <summary>
        /// Wurf einer Exception, falls die Käufer Leitweg-ID <c>null</c> ist, die Verkäufernummer hingegen nicht.
        /// </summary>
        /// <param name="vnac">Die Käufer Leitweg-ID.</param>
        /// <param name="bnr">Die Verkäufernummer.</param>
        protected static void InvalidException(string vnac, string bnr)
        {
            if (string.IsNullOrEmpty(vnac.Trim()) && !string.IsNullOrEmpty(bnr.Trim()))
            {
#if DEBUG
                Exception e = new Exception(string.Format("Da die Käufer Leitweg-ID '{0}' ist, kann die Verkäufernummer NICHT NULL sein!", vnac));
                throw e;
#else
                throw new Exception(string.Format("Da die Käufer Leitweg-ID '{0}' ist, kann die Verkäufernummer NICHT NULL sein!", vnac));
#endif
            }
        }
    }
}
