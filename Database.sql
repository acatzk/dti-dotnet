CREATE DATABASE DailyTimeRecordPANDAN;

use DailyTimeRecordPANDAN;

CREATE TABLE Employee_tbl(
	ID_Number varchar(50) NOT NULL PRIMARY KEY,
	Password varchar(50) NOT NULL,
	Lastname varchar(50) NOT NULL,
	Firstname varchar(50) NOT NULL,
	Middle_Name varchar(50) NOT NULL,
	Gender varchar(20) NOT NULL,
	Position varchar(20) NOT NULL,
	Rank varchar(20),
	TypeOfAccount varchar(20) NOT NULL,
	Photo image NOT NULL,
	CONSTRAINT uni_Fullname UNIQUE(Lastname, Firstname, Middle_Name)
);

CREATE TABLE AttendanceRecords_tbl(
	ID_Number varchar(50) FOREIGN KEY REFERENCES Employee_tbl(ID_Number) NOT NULL,
	Dates varchar(50) NOT NULL,
	Morning_In time,
	Morning_Out time,
	Afternoon_In time,
	Afternoon_Out time,
	AM_TotalHours time,
	PM_TotalHours time,
	Total_Number_Hours time,
	DefaultUnderTime time DEFAULT '8:00:00',
	Undertime time
);




CREATE TABLE Daily_Log(
	Recordnum int identity (1,1) NOT NULL,
	Dates date not null,
	name varchar(50) not null,
	Time varchar(50) not null,
	Log_Status varchar(50) not null
);

CREATE TABLE Security_Admin(
	PassCode varchar(50) not null
);


select * from AttendanceRecords_tbl 

insert into Security_Admin values ('admin')


insert into AttendanceRecords_tbl values ('1511444-1', '6/4/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/5/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/6/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/7/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/8/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/11/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/12/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/13/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/14/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/15/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/18/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/19/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/20/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/21/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/22/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/25/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/26/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/27/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/28/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('1511444-1', '6/29/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')



insert into AttendanceRecords_tbl values ('admin', '7/2/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/3/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/4/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/5/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/6/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/9/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/10/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/11/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/12/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/13/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/16/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/17/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/18/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/19/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/20/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/23/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/24/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/25/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/26/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/27/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/30/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')
insert into AttendanceRecords_tbl values ('admin', '7/31/2018', '7:00:00', '12:00:00', '12:40:00', '5:00:00', '4:00:00', '4:00:00', '08:00:00', '08:00:00', '00:00:00')


select Dates from AttendanceRecords_tbl where Dates LIKE '7/%' AND Dates like '%/4/%' AND Dates LIKE '%/2018'

select Dates from AttendanceRecords_tbl where Dates like '%/4/%'

