/*
SQl 
1- DQl : Select 
2- DDL : Create -  Alter -  Drop 
3- DmL : Insert - Update - Delete 

DDl : Data Definition Language
Tables
1. CREATE TABLE:
---------------
Syntax:
   CREATE TABLE table_name (
       column_name datatype [CONSTRAINT constraint_name constraint_type],
       ...,
       [CONSTRAINT constraint_name constraint_type]
   );

Naming Rules:
    - Maximum 128 characters.
    - Can include A-Z, a-z, 0-9 , _ 
    - Must begin with a letter.
    - Must not be a reserved keyword.

Common Datatypes in SQL Server:
    - Numeric: INT , REAL , DECIMAL (6,2)  9999.99
    - Text: CHAR(n), VARCHAR(n)  
    - Date/Time: DATE, DATETIME, SMALLDATETIME, TIME

   Constraint Types:
    - PRIMARY KEY  :pk 
    - UNIQUE       :uk
    - NOT NULL     :nk  
    - CHECK (condition) :ck  
    - FOREIGN KEY REFERENCES other_table(column)  : fk


2. ALTER TABLE: Add  Alter  Drop 
-------------- 
Syntax Overview:
	ALTER TABLE table_name
		-- Add a new column
ex : ALTER TABLE table_name ADD column_name datatype [CONSTRAINT constraint_name constraint_type] ;
        -- Add a constraint
ex : ALTER TABLE table_name ADD CONSTRAINT constraint_name constraint_type;
	    -- Alter column datatype or nullability
ex:  ALTER TABLE table_name ALTER COLUMN column_name new_datatype;
       -- Drop a column
ex:  ALTER TABLE table_name DROP COLUMN column_name;
	   -- Drop a constraint
ex:  ALTER TABLE table_name DROP CONSTRAINT constraint_name;

3. DROP TABLE:
--------------
Syntax:
    DROP TABLE table_name;

ex: DROP TABLE Employees;

notes : - SQL Server automatically removes constraints and Data  with the table.
*/

CREATE TABLE Employees3 (
       emp_id   int constraint Emp_Emp_Id_PK primary key ,
       emp_name varchar(50) constraint Emp_emp_name_nk not null  ,     
   );

CREATE TABLE Employees4 (
       trvel_num  int    ,
	   travel_date Date  ,
       emp_name varchar(50) , 
	   constraint Emp_Emp_Id_PK primary key(trvel_num,travel_date)
);
 
create table Employees22(
emp_id   int primary key ,
emp_name varchar(50) not null )

alter table Employees22 add email varchar(100) ;
alter table Employees22 add phone varchar(16) not null ;
alter table Employees22 add emp_address varchar(250) constraint Emp22_emp_address_nk not null ;

alter table Employees22 add constraint Emp22_email_uk unique(email)  ;

alter table Employees22 alter column email varchar(150) ; 

alter table Employees22 drop constraint Emp22_email_uk

alter table Employees22 drop column email;

 
drop table Employees2
drop table Employees22
drop table Employees3


 
 --Q1 : Create Table MyDepts As Following : 
    --	Dept_ID   int          --> primary Key
	--	Dept_name varchar(100) --> not Null 

 create table MyDepts (
 Dept_ID   int primary Key , 
 Dept_name varchar(100) not Null);
 
--Q2 : Create Table MyEmps As Following : 
	    --	Emp_ID    int           --> primary Key
		--Emp_name  varchar(150)  --> not Null 
		--Salary    Deciml(8,2)   --> Check(salary>3000)
		--hire_date Date 
		--Dept_ID   int           --> Foreign key
create table MyEmps(
Emp_ID    int		   constraint my_emp_Emp_id_pk   primary Key        ,
Emp_name  varchar(150) constraint my_emp_Emp_name_nk not null           , 
Salary    Decimal(8,2) constraint my_emp_Salary_Ck   check(salary>3000) , 
hire_date date         constraint my_emp_H_date_Dk   default getDate()  ,
Dept_ID   int          constraint my_emp_Dept_Id_Fk  foreign key references MyDepts(Dept_ID)  
)

--Testing :
--insert into Employees22 values(1 ,'ahmad','ahmad@gamil .com','0000000', 'cairo')    -- add date 
--insert into Employees22 values(2 ,'ahmad','ahmad22@gamil .com','1111111','cairo')   -- pk 
--insert into Employees22 values(3 ,'ahmad',null,'0000000', 'cairo')                  -- nk 
--insert into Employees22 values(4 ,'ahmad','ahmad23@gamil .com','0000000', 'cairo')    -- uk 
--select * from Employees22
--delete from Employees22 
----------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------

--make table for myJob and his fields is 
--job_id ,
--Job_name ,
--Start_salary ,
--Max_salary 

 ----------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------
-------------------- Questions ------------------------
--* create courses table as follow:
--  cours_id     => pk
--  course_title => not null
--  price        => between 800 and 3000
--  start_date   => default value the date after 7 days
--  duration     => btw 12 and 120
		Create Table courses(
		cours_id      int           primary key                           , 
		course_title  varchar(100)  not null                              , 
		price         decimal(6,2)  check(price between 800 and 3000)     ,
		start_date    Date          default dateadd(day, 7 , getDate())   , 
		duration      int           check(duration between 12 and 120)
		);


--* create a projects table 
--  project_id => pk
--  project_name => not null
--  client_name => 
--  hour_rate => positive greater than 1
create table Projects (
project_id   int          primary key , 
project_name varchar(200) not null    ,
client_name  varchar(200)             ,
hour_rate    int          check(hour_rate>1)
);

--* create a tasks table
--  task_id => pk
--  description => max char 255
--  start_date => date
--  end_date => greater than start_date
--  project_id => foreign key
create table tasks
(
task_id     int          primary key				                 ,
description	varchar(255)							                 , 
start_date  date         not null									 ,
end_date    date	                                 				 , 
project_id  int          foreign key references  Projects(project_id),
constraint ceck_value_end_date check(end_date > start_date)	
)
