use DetailsLoader;


create table Aadhardetails (
FirstName varchar(30),
LastName varchar(30),DOB varchar(30),Gender varchar(30),Age int,HouseNo int,Street varchar(30),Town varchar(30),
District varchar(30),State varchar(30),Pincode int,Mailid varchar(30)
,Mobno bigint,Aid bigint,Fingerprint image

);

create table Passportdetails(
FirstName varchar(30),
LastName varchar(30),DOB varchar(30),Gender varchar(30),Age int,HouseNo int,
Street varchar(30),Town varchar(30),District varchar(30),State varchar(30),Pincode int,Mailid varchar(30)
,Mobno bigint,Pid bigint,Fingerprint image);


select * from Aadhardetails;
select * from Passportdetails;

