




-- 🔹 SQL SELECT SYNTAX:
-- SELECT column1, column2, ...
-- FROM table_name
-- [WHERE condition]
-- [GROUP BY column1, column2, ...]
-- [HAVING group_condition]
-- [ORDER BY column1, column2, ... [ASC|DESC]]

-- 🔹 Operators:
--   ➕ Arithmetic: +, -, *, /
--   🔁 Comparison: =, !=, <>, <, <=, >,
--   🧠 Logical: AND, OR, NOT
--   🧮 Range: BETWEEN ... AND ...
--   📋 List: IN (...)
--   🔍 Pattern: LIKE 'pattern'
--   🚫 NULL Check: IS NULL, IS NOT NULL

-- 🔹 Functions:
--   🔤 Text: UPPER(), LOWER(), LEN(), LEFT(), RIGHT()
--   🔢 Numbers: ROUND(), CEILING(), FLOOR()
--   📅 Dates: GETDATE(), DATEADD(), DATEDIFF(), YEAR(), MONTH(), DAY()
--   🔄 Conversion: CAST(), CONVERT()
--   ⚙️ Conditional: CASE, IIF()
--   ⚙️ Group Functions: Count() ,Max() ,Min() ,Sum() ,AVG()


select e.employee_id asEmp_Code , e.first_name as Emp_Name , e.department_id as Emp_Dept , 
	   m.first_name +' '+ m.last_name as Manager_Name 
from employees e join employees m on e.manager_id=m.employee_id


select e.employee_id as Emp# , e.last_name as EMp_Name , e.department_id as Emp_Department ,
	   m.first_name+' '+ m.last_name as Manager_Name 
from employees e join employees m on e.manager_id=m.employee_id


select last_name , salary * 12 as annualSAlary 
from employees

select last_name , salary * 12 as annualSAlary 
from employees
where salary >= 5000 and salary <= 8000


select last_name , salary * 12 as annualSAlary 
from employees
where salary between 5000 and 8000

select *
from employees
where department_id =  30 or 
	  department_id =  60 or
	  department_id =  90

select *
from employees
where department_id in(30,60,90)
-------------------------------------------------------------
select * 
from employees
order by hire_date

select * 
from employees

select * 
from departments

select * 
from locations

select e.employee_id , e.last_name , e.job_id , d.department_name , l.city , l.street_address
from employees e , departments d , locations l
where e.department_id =d.department_id
 and  d.location_id=l.location_id

select e.employee_id , e.last_name , e.job_id , d.department_name , l.city , l.street_address
from employees e inner join  departments d  on  e.department_id = d.department_id
				 join        locations   l  on  d.location_id=l.location_id
 
 select e.employee_id , e.last_name , e.job_id , d.department_name  
from employees e inner join  departments d  on  e.department_id = d.department_id
		 

select e.employee_id , e.last_name , e.job_id , d.department_name  
from employees e left join  departments d  on  e.department_id = d.department_id
		 
select e.employee_id , e.last_name , e.job_id , d.department_name  
from employees e right join  departments d  on  e.department_id = d.department_id


select e.employee_id , e.last_name , e.job_id , d.department_name  
from employees e full outer join  departments d  on  e.department_id = d.department_id

select emp.employee_id as Emp_Code , emp.last_name as Emp_NAme , emp.job_id as Emp_Job,
	   mang.last_name
from employees emp  join  employees mang  on  emp.manager_id = mang.employee_id


 select  e.last_name ,d.department_name  
from employees e Cross join  departments d 

--🔍 Task:
--Write a SQL query to retrieve, for each job title, 
--the job ID, the number of employees in that job, 
--the total salary, the highest salary, the lowest salary, and the average salary.
--The query should only consider jobs with IDs in the
-- list: 'IT_PROG', 'SA_MAN', 'FI_ACCOUNT', 'HR_REP', and 'AD_VP'. 
-- Additionally, include only those job titles where the total salary exceeds 5,000.
--Finally, the result should be sorted in ascending order based on the total salary.

select job_id, count(*) as Number_Of_Employees ,
			   sum(salary) as Total_SAlary ,
			   MAX(salary) as Highest_SAlary ,
			   min(salary) as lowest_SAlary ,
			   avg(salary) as avg_SAlary 
from employees 
where job_id in ( 'IT_PROG', 'SA_MAN', 'FI_ACCOUNT', 'HR_REP',  'AD_VP') 
group by job_id
having sum(salary) > 5000
order by Total_SAlary

select year(hire_date) as Hire_year ,count(*) as NumberOFHiredEmployees, 
									 sum(salary) as Total_SAlary ,
									 MAX(salary) as Highest_SAlary ,
									 min(salary) as lowest_SAlary ,
			                         avg(salary) as avg_SAlary 
from employees 
where dateDiff(year,hire_date , GetDate())>25
group by year(hire_date)
having count(*)>5
order by  Hire_year

-- 🟡 INTERMEDIATE LEVEL TASKS
------------------------------------------------------------
-- Task 10: Use variables in a query
Declare @job Nvarchar(20)='it_prog'
select *
from employees 
where job_id = @job

-- Task 11: Use BETWEEN with variables
Declare @high_Salary int = 8000
Declare @low_Salary  int = 5000

select * 
from employees
where salary between @low_Salary and @high_Salary

-- Task 12: Use string functions
select last_name , upper (last_name ) as Capital_Case , lower (last_name ) as Small_Case , LEN(last_name)
from employees 

-- Task 13: Use GROUP BY
select Department_Id , count(*)as NumberOF_departmentEmployees 
from employees 
where salary >=10000
group by Department_Id
 

-- Task 14: Use HAVING to filter groups
select Department_Id , count(*)as NumberOF_departmentEmployees 
from employees 
where salary >=10000
group by Department_Id
having  count(*)>10

-- Task 15: Use CASE to categorize results
select last_name , case 
						when salary between 10000 and 14999 then 'Normal Salary'
						when salary between 15000 and 20000 then 'High Salary'
						else 'very High Salary '
					End as Salary_level 
from Employees 
where salary >=10000
order by salary

-- Task 18: Use IIF for conditional output
select last_name , iif(salary >= 15000,'High Salary', 'Normal Salary' )
from Employees 
--where salary >=10000
order by salary

-- Task 18.1: Apply IIF on commission_pct
select  last_name , IIf(commission_pct is null , 'No Commission ', 'Has Commission') as Commission_Status
from Employees 

-- Task 16: Use date functions
select           year(getDate()) as CurrentYear ,  last_name, year(hire_date) as Hire_Year  , 
				 dateDiff(year, hire_date , getDate())as worked_year
from employees 
order by worked_year

-- Task 17: Use CAST and CONVERT
select last_name ,cast( salary  as varchar) + ' $' as Salary  ,convert (varchar(10),  hire_date , 105) AS Formatted_HireDAte
from employees 
order by salary

------------------------------------------------------------
-- 🔴 ADVANCED LEVEL TASKS (JOINS & MULTI-TABLE)
------------------------------------------------------------

-- Task 19: Use INNER JOIN to combine employees with departments
select *
from employees e join departments d on e.department_id = d.department_id

select e.last_name , d.department_name
from employees e inner join departments d on e.department_id = d.department_id

-- Task 20: Use CROSS JOIN to show all employee-job combinations
select e.last_name ,  j.job_title
from employees e cross join jobs j

-- Task 21: Use JOIN with three tables
select * from  Employees 
select * from departments
select * from  locations

select e.last_name , d.department_name , L.city , l.street_address
from employees e join departments d on e.department_id = d.department_id
				 join locations l   on d.location_id   = l.location_id 

-- Task 22: Use SELF JOIN to show employees with their managers
select * from employees  
select * from employees  

select e.last_name as Emp_Name , m.first_name +' '+m.last_name as Manger_Name
from employees e join employees m on e.manager_id= m.employee_id

-- Task 23: Use LEFT, RIGHT, FULL OUTER JOINs
select e.last_name , d.department_name  
from employees e left join departments d on e.department_id = d.department_id
				 
select e.last_name , d.department_name  
from employees e right join departments d on e.department_id = d.department_id

select e.last_name , d.department_name  
from employees e full outer join departments d on e.department_id = d.department_id
-- Task 24: Use WHERE with complex logic (AND/OR)
select last_name , department_name , salary
from employees e join departments d on e.department_id = d.department_id
where job_id like '%man' and salary >=10000
order by Salary

------------------------------------------------------------
-- 🧠 QUESTIONS & EXERCISES – BEGINNER LEVEL
------------------------------------------------------------

-- Q1: Show full name and salary of each employee
-- Q2: Show job ID and salary > 5000 for IT_PROG
-- Q3: Show employees hired after 2007, sorted by hire date desc
------------------------------------------------------------
-- 🧠 QUESTIONS & EXERCISES – INTERMEDIATE LEVEL
------------------------------------------------------------
-- Q4: Show department ID and avg salary for depts with avg > 6000
-- Q5: Show job ID and count of employees per job
-- Q6: Categorize salary levels using CASE (High, Medium, Low)
------------------------------------------------------------
-- 🧠 QUESTIONS & EXERCISES – ADVANCED LEVEL (JOINS)
------------------------------------------------------------
-- Q1: Show employees with their department names
-- Q2: Show employees with their manager names
-- Q3: Show departments that have no employees
select * from departments
select Distinct department_id from employees 

select department_name 
from departments d left  join employees e on d.department_id= e.department_id
where e.employee_id is null

-- Q4: Show employees with department name and city
-- Q5: Use CROSS JOIN to show all employee-job combinations
-- Q6: Show employees working in city ‘Toronto’
select * from employees 
select * from departments
select * from locations

select e.last_name , l.city
from employees e join departments d on e.department_id = d.department_id
				 join locations l   on d.location_id   = l.location_id
where l.city = 'Toronto'

-- Q7: Show employees with salary > 12000
-- Q8: Show employees with salary NOT BETWEEN 5000 AND 12000
select last_name , salary 
from employees
where salary not BETWEEN 5000 AND 12000
-- Q9: Show employees in certain jobs, excluding some salaries
select last_Name , Salary , Job_id
from employees 
where job_id in ('it_prog', 'ad_vp')
and salary not in (4200, 4300,4800)

-- Q10: Show last names starting with J, A, or M (uppercase + length)
select UPPER(last_name ) as Upper_Name , len(last_name )as Name_length 
from employees
where last_name like 'J%' 
   or last_name like 'A%' 
   or last_name like 'M%' 

-- Q11: Show department address details using LOCATIONS
------------------------------------------------------------
 -- select All Employees Date whoes salary > 9600( Fox' Salary) 
 
 select lasT_name , hire_date , job_id , salary 
 from employees 
 where salary > ( select salary
				  from  employees
				  where last_name = 'Fox')
order by salary

--- make Query about Employees Data whoes work the same job of Employee _id 141
select *
from employees 
where job_id =(select job_id
				from employees
				where employee_id=141
				)
-------------------------------

select * from employees
where job_id=(select job_id 
from employees 
where employee_id=141)

--- select all employee Data whose get Salaries More than the Avrage Salary in the Company 
select * 
from employees
where salary > (select AVG(salary )
				from employees) 
------------------------------------------------------------------------------------
-- select all employee date whose work as 'Sales Manager'
select * 
from employees 
where job_id = (select job_id 
from Jobs 
where job_title = 'Sales Manager')

























