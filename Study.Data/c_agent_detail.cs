//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Study.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class c_agent_detail
    {
        public int c_id { get; set; }
        public System.Guid c_agent_detail_id { get; set; }
        public System.Guid c_member_id { get; set; }
        public Nullable<int> c_card_type { get; set; }
        public Nullable<int> c_agent_cost { get; set; }
        public Nullable<int> c_take_out { get; set; }
        public Nullable<System.DateTime> c_cashwithdrawal_date { get; set; }
        public System.DateTime c_db_create_date { get; set; }
        public int c_db_create_id { get; set; }
        public System.DateTime c_db_last_update_date { get; set; }
        public int c_db_last_update_id { get; set; }
        public int c_db_status { get; set; }
    }
}
