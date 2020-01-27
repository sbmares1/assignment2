using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesClub.Models{
    public class Member{
        public int memberId {get;set;}
        public string firstName{get;set;}
        public string lastName{get;set;}
        public DateTime JoinDate{get;set;}
    }
}