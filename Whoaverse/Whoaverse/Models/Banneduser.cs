//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Whoaverse.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Banneduser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public System.DateTime Date_banned { get; set; }
        public string Reason { get; set; }
        public string Banned_by { get; set; }
    }
}
