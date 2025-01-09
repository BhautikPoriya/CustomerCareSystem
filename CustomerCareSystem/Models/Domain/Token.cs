namespace CustomerCareSystem.Models.Domain
{
    public class Token
    {
        /// <summary>
        /// Gets or sets the token id
        /// </summary>
        public Guid TokenId { get; set; }

        /// <summary>
        /// Gets or sets the type
        /// </summary>
        public Type Type {  get; set; }

        /// <summary>
        /// Gets or sets the customer name
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the mobile number
        /// </summary>
        public string Mobile {  get; set; }

        /// <summary>
        /// Gets or sets the status 
        /// </summary>
        public Status Status { get; set; }
    }
}
