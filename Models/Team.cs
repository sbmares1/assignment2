using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesClub{
    public class Team{
        public int teamId{get;set;}
        public string teamName{get;set;}
        public Array teamMembers{get;set;}
    }
}