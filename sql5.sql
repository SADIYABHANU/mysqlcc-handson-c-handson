create database inox;
use inox;
 create table t_hall_details
 (
 hall_id varchar(10) primary key,
 hall_name varchar(25),
 city varchar(20),
 hall_type varchar(10),
 capacity int(10),
 cost_perday int(10)
 );
 create  table t_customer_details
 (
 customer_id varchar(10) primary key,
 customer_name varchar(20),
 mobile_no int(11),
 customer_city varchar(20)
 );
 create table t_hall_booking
 (
 hall_id varchar(10) primary key,
 customer_id varchar(10),
 event_name varchar(20),
 event_date date
 );
 
 
 /*
  alter table t_hall_booking
  add foregin key(hall_id) references t_hall _details(hall_id),
  add foregin key(customer_id) references t_customer_details(customer_id);
  
 