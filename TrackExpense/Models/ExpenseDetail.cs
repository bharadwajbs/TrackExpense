using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrackExpense.Models
{
    public class ExpenseDetail
    {
        [Required]
        [DisplayName("User Email")]
        public string UserEmail { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [DisplayName("Spent On")]
        public string ExpenseDescription { get; set; }

        [Required]
        public decimal Amount { get; set; }
    }
}
