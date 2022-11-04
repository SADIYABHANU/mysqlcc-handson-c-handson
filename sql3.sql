create database HMSystem;
use HMSystem;
create table t_patient
(
 patient_id varchar(10) primary key,
 patient_name varchar(30),
 gender char(2),
 ailment varchar(20),
 doctor_id int(11) 
 );
 create table t_doctor
 (
 doctor_id int(11) primary key,
 doctor_name varchar(25),
 mobile_no int(11),
 email varchar(30),
 specialization varchar(10),
 fees int(7)
 );
 create table t_hospital
 (
 available_doctor int(11) primary key,
 shift_time varchar(20)
 );

alter table t_hospital
add foreign key (available_doctor)references t_doctor(doctor_id);

