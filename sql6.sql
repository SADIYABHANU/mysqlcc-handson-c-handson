create database MOBILE;
use MOBILE;
create table customer;
(
phone_number varchar(10) primary key,
customer_name varchar(20),
email_id varchar(35),
addresss varchar(50)
);
create table subscription;
(
phone_number varchar(10) foreign key,
plan_amount int(6) foreign key,
recharge_date date,
expiry_date date
);
create table plan;
(
plan_amount int(6) primary key,
validity_indays int(4),
local_voice_inmins_perday_sn int(3),
local_voice_inmins_perday_on int(3),
std_voice_inmins_perday_sn int(3),
std_voice_inmins_perday_sn int(3),
data_ingb_perday double(3,1),
sms_perday int(3),
plan_type varchar(10)
);

/*Q6*/
select * from plan;

alter table subscription
add foreign key (phone_number) references customer(phone_number),
add foreign key (plan_amount) references plan(plan_amount);
 
