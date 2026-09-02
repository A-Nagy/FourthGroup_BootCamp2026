/*
=====================================================
Data Manipulation Language (DML) in SQL Server
=====================================================
Main Commands         :   insert               Update               Delete 					

1. INSERT:
----------
Used to add new records to a table.

Syntax:
 INSERT INTO table_name (column1, column2, ...)
				 VALUES ( value1, value2, . ..);

2. UPDATE:
----------
Used to modify existing records.

Syntax:
    UPDATE table_name
    SET column1 = value1, column2 = value2, ...
    WHERE condition;

3. DELETE:
----------
Used to remove one or more records.
Syntax:
 DELETE FROM table_name
 WHERE condition;
*/ 
insert Into MyEmps(Emp_ID,Emp_name,Salary)
			values(1     , 'ahmed', 3500 )

insert Into MyEmps(Salary,Emp_name,Emp_ID)
			values( 3500 , 'ahmed',  2   )

insert Into MyEmps(Emp_ID,Salary) -- Not Null Error 
			values(2    , 3500 )

insert into mydepts ( dept_id , dept_name )
			 values ( 2       , 'IT'      )   ,
			        ( 3       , 'Full-Stack') ,
			        ( 4       , 'Back-End'  ) ,
			        ( 5       , 'Front-End' ) 
--------------------------------------------------------
insert Into MyEmps
			values(3,'ahmad',null,null,null)
insert Into MyEmps
			values(4,'ahmad',null,'',null)
insert Into MyEmps
			values(5,'ahmad',null,null)
----------------------------------------------------------
update MyEmps 
set salary = 3800 ,  emp_name = 'hassan' 

update MyEmps 
set salary = 3900 
where Emp_ID in (3,4)

update MyEmps 
set Dept_ID = 2 
where Emp_ID in (3,4)
----------------------------------------------------------
Delete from MyDepts 
where Dept_ID = 2

Delete from MyEmps
where hire_date is null 

-----------------------------------------------------------

Select * from MyEmps
Select * from MyDepts
Select max(emp_id) from MyEmps

Exec sp_helpconstraint 'courses'
Exec sp_help 'courses'
 