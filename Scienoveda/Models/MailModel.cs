using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scienoveda.Models
{
    public class MailModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Name { get; set; }
    }
}