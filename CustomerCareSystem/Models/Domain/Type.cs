using System.ComponentModel;

namespace CustomerCareSystem.Models.Domain
{
    /// <summary>
    /// Represent the type enumeration
    /// </summary>
    public enum Type
    {
        /// <summary>
        /// General
        /// </summary>
        [Description("General")]
        General = 0,

        /// <summary>
        /// Repair
        /// </summary>
        [Description("Repair")]
        Repair = 1,

        /// <summary>
        /// Return
        /// </summary>
        [Description("Return")]
        Return = 2,

        /// <summary>
        /// New product inquiry
        /// </summary>
        [Description("New Product Inquiry")]
        NewProductInquiry = 3,
    }
}
