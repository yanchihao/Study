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
    
    public partial class c_member
    {
        public int c_id { get; set; }
        public System.Guid c_member_id { get; set; }
        public string c_login_name { get; set; }
        public string c_login_password { get; set; }
        public byte c_gender { get; set; }
        public int c_custom_type { get; set; }
        public string c_tel_num { get; set; }
        public string c_email { get; set; }
        public Nullable<int> c_provice_id { get; set; }
        public Nullable<int> c_city_id { get; set; }
        public Nullable<int> c_area_id { get; set; }
        public string c_address { get; set; }
        public string c_head_phone { get; set; }
        public System.DateTime c_valid_date { get; set; }
        public Nullable<int> c_learb_day { get; set; }
        public Nullable<System.Guid> c_refereer { get; set; }
        public Nullable<System.DateTime> c_reset_date { get; set; }
        public Nullable<System.DateTime> c_activation_date { get; set; }
        public System.DateTime c_db_create_date { get; set; }
        public int c_db_create_id { get; set; }
        public System.DateTime c_db_last_update_date { get; set; }
        public int c_db_last_update_id { get; set; }
        public int c_db_status { get; set; }
    }
}
