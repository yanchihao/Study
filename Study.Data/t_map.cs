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
    
    public partial class t_map
    {
        public int c_id { get; set; }
        public System.Guid c_guid_id { get; set; }
        public Nullable<int> c_parent_id { get; set; }
        public string c_code { get; set; }
        public string c_name { get; set; }
        public string c_desc { get; set; }
        public int c_type { get; set; }
        public int c_sort { get; set; }
        public System.DateTime c_db_create_date { get; set; }
        public int c_db_create_id { get; set; }
        public System.DateTime c_db_last_update_date { get; set; }
        public int c_db_last_update_id { get; set; }
        public int c_db_status { get; set; }
    }
}