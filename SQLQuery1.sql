
create table t_news 
(
   c_id                 int                            not null,
   c_new_id             uniqueidentifier               not null,
   c_title              nvarchar(200)                  null,
   c_content            text                           null,
   c_desc               varchar(516)                   null,
   c_author             varchar(100)                   null,
   c_browse             int                            null,
   c_source             nvarchar(50)                   null,
   c_type               int                            null,
   c_sort               int                            null,
   c_db_create_date     date                           not null,
   c_db_create_id       int                            not null,
   c_db_last_update_date date                           not null,
   c_db_last_update_id  int                            not null,
   c_db_status          int                            not null,
   constraint PK_T_NEWS primary key clustered (c_new_id)
);

create table c_course_sort 
(
   c_id                 int                            not null,
   c_sort_id            uniqueidentifier               not null,
   parent_id                  int                            not null,
   class_name                 varchar(256)                   not null,
   c_img                varchar(516)                   null,
   describe                  varchar(516)                   null,
   sort                   int                            not null,
   c_db_create_date     date                           not null,
   c_db_create_id       int                            not null,
   c_db_last_update_date date                           not null,
   c_db_last_update_id  int                            not null,
   c_db_status          int                            not null,
   constraint PK_C_COURSE_SORT primary key clustered (c_sort_id)
);





create table c_member 
(
   c_id                 int                            not null,
   c_member_id          uniqueidentifier               not null,
   c_login_name         nvarchar(64)                   not null,
   c_login_password     nvarchar(64)                   not null,
   c_gender             tinyint                        not null,
   c_custom_type        int                            not null,
   c_tel_num            varchar(256)                   null,
   c_email              varchar(256)                   null,
   c_provice_id         int                            null,
   c_city_id            int                            null,
   c_area_id            int                            null,
   c_address            nvarchar(256)                  null,
   c_head_phone         varchar(516)                   null,
   c_valid_date         date                           not null,
   c_learb_day          int                            null,
   c_refereer           uniqueidentifier               null,
   c_reset_date         date                           null,
   c_activation_date    date                           null,
   c_db_create_date     date                           not null,
   c_db_create_id       int                            not null,
   c_db_last_update_date date                           not null,
   c_db_last_update_id  int                            not null,
   c_db_status          int                            not null,
   constraint PK_C_MEMBER primary key clustered (c_member_id)
);

create table t_map 
(
   c_id                 int                            not null,
   c_guid_id            uniqueidentifier               not null,
   c_parent_id          int                            null,
   c_code               varchar(256)                   not null,
   c_name               varchar(256)                   not null,
   c_desc               varchar(256)                   null,
   c_type               int                            not null,
   c_sort               int                            not null,
   c_db_create_date     date                           not null,
   c_db_create_id       int                            not null,
   c_db_last_update_date date                           not null,
   c_db_last_update_id  int                            not null,
   c_db_status          int                            not null,
   constraint PK_T_MAP primary key clustered (c_guid_id)
);


create table c_course 
(
   c_id                 int                            not null,
   c_course_id          uniqueidentifier               not null,
   c_sort_id            uniqueidentifier               not null,
   c_name               varchar(512)                   not null,
   c_type               int                            null,
   c_is_recommend       tinyint                        null,
   c_db_create_date     date                           not null,
   c_db_create_id       int                            not null,
   c_db_last_update_date date                           not null,
   c_db_last_update_id  int                            not null,
   c_db_status          int                            not null,
   constraint PK_C_COURSE primary key clustered (c_course_id)
);

create table t_course_detail 
(
   c_id                 int                            not null,
   c_guid_id            uniqueidentifier               not null,
   c_course_id          uniqueidentifier               null,
   c_titile             varchar(256)                   not null,
   c_main_speak         nvarchar(50)                   null,
   c_type               int                            null,
   c_country            uniqueidentifier               null,
   c_area               uniqueidentifier               null,
   c_language           uniqueidentifier               null,
   c_info               nvarchar(100)                  null,
   c_small_pic                   varchar(1000)                  not null,
   c_big_pic                   varchar(1000)                  null,
   c_db_create_date     date                           not null,
   c_db_create_id       int                            not null,
   c_db_last_update_date date                           not null,
   c_db_last_update_id  int                            not null,
   c_db_status          int                            not null,
   constraint PK_T_COURSE_DETAIL primary key clustered (c_guid_id)
);


create table c_collection 
(
   c_id                 int                            not null,
   c_collection_id      uniqueidentifier               not null,
   c_member_id          uniqueidentifier               not null,
   c_course_id          uniqueidentifier               not null,
   c_db_create_date     date                           not null,
   c_db_create_id       int                            not null,
   c_db_last_update_date date                           not null,
   c_db_last_update_id  int                            not null,
   c_db_status          int                            not null,
   constraint PK_C_COLLECTION primary key clustered (c_collection_id)
);




create table c_course_selected 
(
   c_id                 int                            not null,
   c_course_selected_id uniqueidentifier               not null,
   c_course_id          uniqueidentifier               not null,
   c_member_id          uniqueidentifier               null,
   c_db_create_date     date                           not null,
   c_db_create_id       int                            not null,
   c_db_last_update_date date                           not null,
   c_db_last_update_id  int                            not null,
   c_db_status          int                            not null,
   constraint PK_C_COURSE_SELECTED primary key clustered (c_course_selected_id)
);


create table t_dictionary 
(
   c_id                 int                            null,
   c_guid_id            uniqueidentifier               not null,
   c_namespace_id       uniqueidentifier               not null,
   c_code               varchar(256)                   null,
   c_name               varchar(256)                   not null,
   c_desc               varchar(516)                   null,
   c_sort               int                            not null,
   c_db_create_date     date                           not null,
   c_db_create_id       int                            not null,
   c_db_last_update_date date                           not null,
   c_db_last_update_id  int                            not null,
   c_db_status          int                            not null,
   constraint PK_T_DICTIONARY primary key clustered (c_guid_id)
);


create table c_agent 
(
   c_id                 int                            not null,
   c_agent_id           uniqueidentifier               not null,
   c_login_tel          nvarchar(50)                   not null,
   c_login_password     nvarchar(50)                   not null,
   c_name               nvarchar(50)                   not null,
   c_gender             tinyint                        not null,
   c_address            nvarchar(215)                  null,
   c_desc               nvarchar(516)                  null,
   c_recomender         varchar(215)                   null,
   c_db_create_date     date                           not null,
   c_db_create_id       int                            not null,
   c_db_last_update_date date                           not null,
   c_db_last_update_id  int                            not null,
   c_db_status          int                            not null,
   constraint PK_C_AGENT primary key clustered (c_agent_id)
);

create table c_agent_detail 
(
   c_id                 int                            not null,
   c_agent_detail_id    uniqueidentifier               not null,
   c_member_id          uniqueidentifier               not null,
   c_card_type          int                            null,
   c_agent_cost                int                          null,
   c_take_out                 int                        null,
   c_cashwithdrawal_date date                           null,
   c_db_create_date     date                           not null,
   c_db_create_id       int                            not null,
   c_db_last_update_date date                           not null,
   c_db_last_update_id  int                            not null,
   c_db_status          int                            not null,
   constraint PK_C_AGENT_DETAIL primary key clustered (c_agent_detail_id)
);



create table c_payment 
(
   c_id                 int                            not null,
   c_payment_id         uniqueidentifier               not null,
   c_payment_way        int                            not null,
   c_payment_amount     money                          not null,
   c_transaction_number varchar(256)                   not null,
   c_serial_number      varchar(256)                   not null,
   c_member_id          uniqueidentifier               not null,
   c_payment_date       date                           not null,
   c_order_number       varchar(256)                   null,
   c_db_create_date     date                           not null,
   c_db_create_id       int                            not null,
   c_db_last_update_date date                           not null,
   c_db_last_update_id  int                            not null,
   c_db_status          int                            not null,
   constraint PK_C_PAYMENT primary key clustered (c_payment_id)
);

create table c_member_login 
(
   c_id                 int                            not null,
   c_member_id          uniqueidentifier               not null,
   c_login_date         nvarchar(64)                   not null,
   c_login_status     nvarchar(64)                   not null,
c_login_ip     nvarchar(64)                   not null,
c_login_src     nvarchar(64)                   not null
);

create table c_log_sms 
(
   c_sms_id                 int                            not null,
   c_sms_type     nvarchar(1000) null,
   c_sms_userid     nvarchar(1000) null,
   c_sms_msg     nvarchar(1000) null,
   c_sms_phone     nvarchar(1000) null,
   c_sms_return_code     nvarchar(1000) null,
   c_sms_code     nvarchar(1000) null,
   c_sms_func     nvarchar(1000) null,
   c_sms_ip     nvarchar(1000) null
);