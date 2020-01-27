using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesClub{
    public class Client{
        public int ClientID{get; set;}
        public string ClientName{get;set;}
        public string ClientBussiness {get;set;}
    }
}