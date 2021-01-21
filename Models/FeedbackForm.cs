using System;
using System.ComponentModel.DataAnnotations;

namespace justAPlayMVC.Models
{
    public class FeedbackForm
    {
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Telephone { get; set; }

        public string Message { get; set; }

        public string RedirectMe { get; set; }
    }
}
