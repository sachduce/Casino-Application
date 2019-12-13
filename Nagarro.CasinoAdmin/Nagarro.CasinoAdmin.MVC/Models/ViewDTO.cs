using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nagarro.CasinoAdmin.MVC.Models
{
    public class ViewDTO
    {      
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Contact { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public byte[] CopyOfId { get; set; }
        public int AccountBalance { get; set; }
        public int BlockedAmount { get; set; }
        public string UniqueId { get; set; }
    }
}