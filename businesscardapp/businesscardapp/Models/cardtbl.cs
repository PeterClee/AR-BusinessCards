//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace businesscardapp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class cardtbl
    {
        public int cardid { get; set; }
        public int userid { get; set; }
        public string cardcontent { get; set; }
    
        public virtual usertbl usertbl { get; set; }
    }
}
