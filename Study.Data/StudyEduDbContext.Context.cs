﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StudyEduEntities : DbContext
    {
        public StudyEduEntities()
            : base("name=StudyEduEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<c_agent> c_agent { get; set; }
        public virtual DbSet<c_agent_detail> c_agent_detail { get; set; }
        public virtual DbSet<c_collection> c_collection { get; set; }
        public virtual DbSet<c_course> c_course { get; set; }
        public virtual DbSet<c_course_selected> c_course_selected { get; set; }
        public virtual DbSet<c_course_sort> c_course_sort { get; set; }
        public virtual DbSet<c_member> c_member { get; set; }
        public virtual DbSet<c_payment> c_payment { get; set; }
        public virtual DbSet<t_course_detail> t_course_detail { get; set; }
        public virtual DbSet<t_dictionary> t_dictionary { get; set; }
        public virtual DbSet<t_map> t_map { get; set; }
        public virtual DbSet<t_news> t_news { get; set; }
        public virtual DbSet<c_log_sms> c_log_sms { get; set; }
        public virtual DbSet<c_member_login> c_member_login { get; set; }
    }
}
