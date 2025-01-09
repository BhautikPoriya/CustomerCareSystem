using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CustomerCareSystem.Models.Domain
{
    public class ExecutiveLogin
    {
        [Key]
        public int Id { get; set; }

        public string User { get; set; }

        public string Password { get; set; }

        public Type QueryType { get; set; }
    }
}
