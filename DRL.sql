CREATE TABLE PETOWNER
(
OWNERID int primary key,
NAME char(50),
SURNAME char(50),
STEERADDRESS char(100),
CITY char(100),
STATE char(10),
ZIPCODE int
);

CREATE TABLE PET
(
PETID char(10) primary key,
NAME char(20),
KIND char(10),
GENDER char(6),
AGE int
OWNERID int
);
CREATE TABLE procedureHistroy
(
petid char(10),
procedureDate date,
procedureType char(50),
description char(100)
);
/*2a*/
ALTER TABLE petowner
ALTER state
SET
default 'michigan';

/*2b*/
ALTER TABLE pet
ADD foreign key(ownerid) references petowner(ownerid);

/*2c*/
ALTER TABLE procedureHistroy
ADD foreign key(petid) references pet(petid);




