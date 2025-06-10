use Recruitment

select * 
from ExternalCandidate

select cCandidateCode,vFirstName,vLastName,sitestscore
from ExternalCandidate

select cCandidateCode,vFirstName+vLastName,sitestscore
from ExternalCandidate
-- computed col with col heading
SELECT ccandidateCode, 'Name'=vFirstName+space(1)+vLastNAme, siTestScore
FROM externalcandidate

SELECT ccandidateCode, CandidateName=vFirstName+space(1)+vLastNAme, siTestScore
FROM externalcandidate

SELECT ccandidateCode, 'Candidate Name'=vFirstName+space(1)+vLastNAme, siTestScore
FROM externalcandidate

SELECT ccandidateCode, vFirstName+space(1)+vLastNAme 'Candidate Name' , siTestScore
FROM externalcandidate


--literal concatinated with col values
select 'names' + vfirstname,vlastname
from ExternalCandidate

--Arthmatic operations on col data
select ccandidatecode,vfirstname,vfirstname+vlastname,sitestscore,'newmarks'=sitestscore+10
from ExternalCandidate

---syntax check
---resource check
---performance optimization resources --index
---execution plan
---execute


---where clause
--note mssql is caseinsesitive by default
select ccandidatecode,vfirstname,vlastname,sitestscore
from ExternalCandidate
where vfirstname ='angela'

select ccandidatecode,vfirstname,vlastname,sitestscore
from ExternalCandidate
where ccandidatecode='000101'

select ccandidatecode,vfirstname,vlastname,sitestscore
from ExternalCandidate
where sitestscore=80

--<,>, <= ,>=,=, != ,<>
-- only one value is allowed on right hand side of the comparison operator
SELECT ccandidateCode, vFirstName, vLastNAme, siTestScore
FROM externalcandidate
where sitestscore>80 and sitestscore<90

select * from ExternalCandidate

-- get all candidates from the city Norton and Mentor

select * from ExternalCandidate
where ccity='Mentor' or ccity='Norton' 

select * from ExternalCandidate
where ccity='Norton' or ccity='Mentor'

--get all candidates from norton city with score grater than 90

select * from ExternalCandidate
where cCity='norton' and sitestscore<=90


-- 22+1
select * from ExternalCandidate
where ccity='Norton' and sitestscore<90

select * from ExternalCandidate
where not ccity='Norton'

select * from ExternalCandidate
where ccity != 'Norton'

-- between , in
select * from ExternalCandidate
where ccity='Norton' or ccity='Mentor' or ccity='Dublin' or ccity='seattle'

select * from ExternalCandidate
where ccity in( 'Norton' , 'Mentor' , 'Dublin' , 'seattle' )

select * from ExternalCandidate
where sitestscore>=80 and sitestscore <= 90

select * from ExternalCandidate
where sitestscore between 80 and 90

--like

select * from ExternalCandidate
where vaddress like '%street%'

select * from ExternalCandidate
where vaddress like '%street'

--candidates whose firstname starts wwith any letter
select * from ExternalCandidate
where vfirstname like 'a%'

--candidates whose code starts or ends with any number

select * from ExternalCandidate
where cCandidateCode like '%1_'

select * from ExternalCandidate
where cCandidateCode like '%1[268]'

select * from ExternalCandidate
where cCandidateCode like '%1[2-3]'

--candidates

select * from ExternalCandidate
where vfirstname like '[jab]%[ayh]'
SELECT DISTINCT ccity, cstate FROM ExternalCandidate
--null
select * from ExternalCandidate
where vEmailId is not null

--distinct
--distinct keyword can be used only once
--should be used immediately after select (first col)

select distinct ccity,cstate from ExternalCandidate
select distinct cstate ,ccity from ExternalCandidate

---order by

select * from ExternalCandidate

select cstate,ccity,ccandidatecode,vfirstname,vlastname,sitestscore 
from ExternalCandidate
order by cState,cCity,ccandidatecode

EXEC sp_help externalcandidate; 

create index idxstateexcan on externalcandidate(cstate,ccity)
SELECT cState 
FROM ExternalCandidate;
drop index idxstateexcan on externalcandidate

select cstate,ccity,ccandidatecode,vfirstname,vlastname,sitestscore 
from ExternalCandidate
order by cState,ccity desc

select ccandidatecode,vfirstname,sitestscore 
from ExternalCandidate
order by siTestScore desc

select top 10 percent ccandidatecode,vfirstname,sitestscore
from ExternalCandidate
order by sitestscore desc

select top 5 ccandidatecode,vfirstname,sitestscore
from ExternalCandidate
order by sitestscore desc

select top 5 ccandidatecode,vfirstname,sitestscore
from ExternalCandidate
order by sitestscore
--min max avg count

select sitestscore from ExternalCandidate

select max=max(sitestscore),min=min(sitestscore),count=count(sitestscore) from ExternalCandidate

select count=count(ccandidatecode),count(vemailid) from ExternalCandidate
select count=count(*) from ExternalCandidate

---group by
select cstate , 'no of candidates' = count(ccandidatecode) ,max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from ExternalCandidate
where cstate in ('nevada','ohio','texas') and siTestScore>70
group by cState

select cstate , 'no of candidates' = count(ccandidatecode) ,max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from ExternalCandidate
where siTestScore>70
group by cstate 
having cstate in ('nevada','ohio','texas')

select cstate , 'no of candidates' = count(ccandidatecode) ,max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from ExternalCandidate
where cstate in ('nevada','ohio','texas')
group by cState
having count(ccandidatecode)>2

select *from ExternalCandidate
order by cState

select cstate,'no of candidates' = count(ccandidatecode)
from ExternalCandidate
group by cState

select cstate , 'no of candidates' = count(ccandidatecode) ,max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from ExternalCandidate
group by cState

select cstate ,cCity, 'no of candidates' = count(ccandidatecode) ,max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from ExternalCandidate
group by cState,cCity

---need for having

select cstate , 'no of candidates' = count(ccandidatecode) ,max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from ExternalCandidate
where sitestscore>80
group by cState
having count(ccandidatecode)>=2

select cstate , 'no of candidates' = count(ccandidatecode) ,max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from ExternalCandidate
group by cState
having avg(sitestscore)>=70


-----difference b/w having and where


select cstate , 'no of candidates' = count(ccandidatecode) ,max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from ExternalCandidate
group by cState
having cstate in ('nevada','ohio','texas')

select cstate , 'no of candidates' = count(ccandidatecode) ,max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from ExternalCandidate
where cstate in ('nevada','ohio','texas')
group by cState
SELECT * FROM ExternalCandidate;

SELECT * FROM RecruitmentAgencies;
SELECT cCandidateCode, vFirstName, vLastName, cAgencyCode
FROM ExternalCandidate  
WHERE cAgencyCode IS NOT NULL;
SELECT cCandidateCode, vFirstName, cName
FROM ExternalCandidate
INNER JOIN RecruitmentAgencies
ON ExternalCandidate.cAgencyCode = RecruitmentAgencies.cAgencyCode;
--get all candidate code and name with position name they have applied for
SELECT 
    ec.cCandidateCode,
    ec.vFirstName,
    p.vDescription AS PositionName
FROM ExternalCandidate ec
INNER JOIN Position p ON ec.cPositionCode = p.cPositionCode
ORDER BY ec.vLastName, ec.vFirstName;
--get all candidate code and name with name of there contractor

select ccandidatecode,vfirstname,cName
from ExternalCandidate
join ContractRecruiter
on ExternalCandidate.cContractRecruiterCode=ContractRecruiter.cContractRecruiterCode

--get all candidate code and name with the collage name
select ccandidatecode,vfirstname,cCollegeName
from ExternalCandidate
join College
on ExternalCandidate.cCollegeCode=College.cCollegeCode

select ccandidatecode, vfirstname, 
       'Candidate phone' = ExternalCandidate.cphone, 
       cname, 
       'Recruiter phone' = RecruitmentAgencies.cphone
from ExternalCandidate
join RecruitmentAgencies
on ExternalCandidate.cAgencyCode = RecruitmentAgencies.cAgencyCode
select ccandidatecode, vfirstname, cname, RecruitmentAgencies.cphone
from ExternalCandidate
join RecruitmentAgencies
on ExternalCandidate.cAgencyCode = RecruitmentAgencies.cAgencyCode
select ccandidatecode, vfirstname, cname, r.cphone
from ExternalCandidate e
join RecruitmentAgencies r
on e.cAgencyCode = r.cAgencyCode

---left join 
select ccandidatecode,vfirstname,cname,r.cphone
from ExternalCandidate e left outer join RecruitmentAgencies r
on e.cAgencyCode=r.cAgencyCode

---right join
select ccandidatecode,vfirstname,cname,r.cphone
from ExternalCandidate e right outer join RecruitmentAgencies r
on e.cAgencyCode=r.cAgencyCode
--get all candidate code and name with position name they have applied for show all data from externalcandidate table
select ccandidatecode,vfirstname ,vDescription
from ExternalCandidate left outer join Position
on ExternalCandidate.cPositionCode=Position.cPositionCode

--get all candidate code and name with name of there contractor show all data from both the table
select ccandidatecode,vfirstname,cName
from ExternalCandidate full join ContractRecruiter
on ExternalCandidate.cContractRecruiterCode=ContractRecruiter.cContractRecruiterCode

--get all candidate code and name with the collage name show all data from college table
select ccandidatecode,vfirstname,cCollegeName
from ExternalCandidate right outer join College
on ExternalCandidate.cCollegeCode=College.cCollegeCode

update employee
set cSupervisorCode='000001'
where cEmployeecode like '%[5-9]'

update employee
set cSupervisorCode='000002'
where cEmployeecode like '%[3-4]'

update employee
set cSupervisorCode='000001'
where cEmployeecode like '%[2]'

update employee
set cSupervisorCode='000003'
where cEmployeecode like '%1[1-2]'
select 
  "Employee" = emp.vFirstName + space(1) + emp.vLastName, 
  "Superior" = supr.vFirstName + space(1) + supr.vLastName
from employee emp
join employee supr
on emp.cSupervisorCode = supr.cEmployeeCode;

select ccandidatecode,p.cpositioncode
from ExternalCandidate e
cross join Position p
order by cCandidateCode

--Subquery
--get all candidates having same rating as that of 'Angela'
select cRating from ExternalCandidate
where vFirstName = 'Angela';

select cCandidatecode, vfirstname, vlastname
from ExternalCandidate
where cRating = 8;

select cCandidatecode, vfirstname, vlastname
from ExternalCandidate
where cRating = (
    select cRating from ExternalCandidate 
    where vFirstName = 'Angela'
);

--join substitute
select e.cCandidatecode, e.vfirstname, e.vlastname
from ExternalCandidate e
join ExternalCandidate o
on e.cRating = o.cRating
where o.vFirstName = 'Angela';

select cCandidatecode, vfirstname, vlastname
from ExternalCandidate
where cRating = (
    select cRating from ExternalCandidate 
    where vFirstName = 'Angela'

);
SELECT cCandidatecode, vfirstname, vlastname, cRating
FROM ExternalCandidate
WHERE cRating IN (
    SELECT cRating
    FROM ExternalCandidate
    WHERE vFirstName IN ('David', 'Angela')
);
SELECT *
FROM ExternalCandidate
WHERE sitestscore > ALL (
    SELECT sitestscore
    FROM ExternalCandidate
    WHERE vfirstname IN ('Angela', 'Barbara')
);
SELECT *
FROM ExternalCandidate
WHERE sitestscore > (
    SELECT MAX(sitestscore)
    FROM ExternalCandidate
    WHERE vfirstname IN ('Angela', 'Barbara')
);
SELECT *
FROM ExternalCandidate
WHERE sitestscore > ANY (
    SELECT sitestscore
    FROM ExternalCandidate
    WHERE vfirstname IN ('Angela', 'Barbara')
);
SELECT *
FROM ExternalCandidate
WHERE sitestscore > (
    SELECT MIN(sitestscore)
    FROM ExternalCandidate
    WHERE vfirstname IN ('Angela', 'Barbara')
);
select e.ccandidatecode,e.vfirstname,e.vlastname
from ExternalCandidate e
join ExternalCandidate o
on e.cRating=o.cRating
where o.vFirstName='angela'

select e.ccandidatecode,e.vfirstname,e.vlastname,o.cRating
from ExternalCandidate e
join ExternalCandidate o
on e.cRating=o.cRating
where o.vFirstName='david' or o.vFirstName='angela'

--all
select * from ExternalCandidate
where sitestscore>
(select max(sitestscore) from ExternalCandidate
where vfirstname='angela' or vfirstname='barbara')

select * from ExternalCandidate
where sitestscore>all
(select sitestscore from ExternalCandidate
where vfirstname='angela' or vfirstname='barbara')


-- any: min – checks if sitestscore is greater than any one of the values (minimum also works here as lowest threshold)
select * from ExternalCandidate
where sitestscore > any (
    select sitestscore 
    from externalcandidate 
    where vFirstname = 'Angela' or vFirstname = 'Barbara'  -- any of the scores (either Angela's or Barbara's)
)

-- equivalent logic using MIN instead of ANY: checks if sitestscore is greater than the lowest of Angela/Barbara
select * from ExternalCandidate
where sitestscore > (
    select min(sitestscore) 
    from externalcandidate 
    where vFirstname = 'Angela' or vFirstname = 'Barbara'  -- gets the minimum sitestscore of Angela and Barbara
)


----------------- HOMEWORK START -----------------

-- get all candidates whose sitestscore is less than the smallest (MIN) of Angela or Barbara
select * from ExternalCandidate
where sitestscore < (
    select min(sitestscore)
    from ExternalCandidate
    where vFirstname = 'Angela' or vFirstname = 'Barbara'  -- gets lowest score between Angela and Barbara
)

-- same logic using ALL keyword (sitestscore should be less than both Angela and Barbara)
select * from ExternalCandidate
where sitestscore < all (
    select sitestscore
    from ExternalCandidate
    where vFirstname = 'Angela' or vFirstname = 'Barbara'  -- both values must be greater than current
)

-- get all candidates whose sitestscore is less than the maximum of Angela or Barbara
select * from ExternalCandidate
where sitestscore < (
    select max(sitestscore)
    from ExternalCandidate
    where vFirstname = 'Angela' or vFirstname = 'Barbara'  -- gets highest score between Angela and Barbara
)

-- same logic using ANY keyword (sitestscore should be less than at least one of Angela or Barbara)
select * from ExternalCandidate
where sitestscore < any (
    select sitestscore
    from ExternalCandidate
    where vFirstname = 'Angela' or vFirstname = 'Barbara'  -- even one match is enough
)

----------------- HOMEWORK END -----------------


--exists

select * from ExternalCandidate
where exists(select* from position where cpositioncode is null)

select * from ExternalCandidate
where exists(select* from Position where vFirstName='angela') and vFirstName='angela'

select * from ExternalCandidate where exists(
select * from ContractRecruiter where cName='John smith')


--select into  
--Only data and structure of table is copied to create new table  
--Constraint keys and indexes are lost in the new table

-- Create a new table newexcandidate with all data copied from externalcandidate
select * into newexcandidate  
from externalcandidate  

-- View all data from the newly created table
select * from newexcandidate  

-- Create a new table newexscore with selected columns and only rows where cState = 'Georgia'
select cCandidatecode, vFirstname, vLastname, sitestscore  
into newexscore  
from externalcandidate  
where cState = 'Georgia'  

-- Show structure and metadata of the newexscore table (only works in SQL Server)
sp_help newexscore  

-- View data from the newexscore table
select * from newexscore



-- UNION

-- union
select vFirstName, vLastName, cPhone
from ExternalCandidate
union
select vFirstName, vLastName, cPhone
from Employee

-- union all
select vFirstName, vLastName, cPhone
from ExternalCandidate
union all
select vFirstName, vLastName, cPhone
from Employee
order by vFirstName, vLastName

--number of column mismatch so Error
-- This will cause an error because the number of columns in both SELECT statements is not the same
select 'name'=vFirstname + vLastname, cphone  
from ExternalCandidate  
union all  
select cname  
from ContractRecruiter  


--datatype of column mismatch so Error  
-- This will cause an error because the data types of the columns in both SELECT statements are different  
select 'name'=vFirstname + vLastname, siTestScore  
from ExternalCandidate  
union all  
select cname, mTotalPaid  
from ContractRecruiter  


-- View all records from the ContractRecruiter table  
select * from ContractRecruiter  


--intersect  
-- This will return only the rows that are present in both ExternalCandidate and Employee tables  
SELECT vFirstName, vLastName, cphone FROM ExternalCandidate  
INTERSECT  
SELECT vFirstName, vLastName, cphone FROM Employee

-- Except
SELECT vFirstName, vLastName, cPhone FROM ExternalCandidate
except
SELECT vFirstName, vLastName, cPhone FROM Employee

create table ExternalCandidate2
(
    cCandidateCode     char(6) constraint Pk_ExternalCandidate2_ccandidatecode primary key
                       constraint eccd_ch check(cCandidateCode like('[0-9][0-9][0-9][0-9][0-9][0-9]')),
    
    vFirstName         varchar(20) not null,
    vLastName          varchar(20),
    
    cCity              char(20) default 'Mumbai' 
                       constraint ch_ccity check(cCity in ('Mumbai','Delhi','Hyderabad','Chennai','Bangalore')),
    
    cPhone             char(15) constraint ecp_ck1 check(cPhone like '([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),
    
    cPositionCode      char(4) constraint fk_position_cPositioncode references Position(cPositionCode),
    
    dDateOfApplication datetime,
    
    siPrevWorkExperience smallint constraint ch_workexp check(siPrevWorkExperience > 0),
    
    mPrevAnnualSalary  money,
    
    vEmailId           varchar(20) constraint ec_UK unique
);



-- Drop the ExternalCandidate2 table if it exists
drop table ExternalCandidate2;
delete ExternalCandidate2;

-- Display metadata about the ExternalCandidate2 table
sp_help ExternalCandidate2;
insert ExternalCandidate2
values (
    '000001',                 -- cCandidateCode
    'Beena',                  -- vFirstName
    'Shah',                   -- vLastName
    Default,                  -- cCity (uses default value 'Mumbai')
    '(123)123-1234',          -- cPhone
    '0001',                   -- cPositionCode
    '06/06/2025',             -- dDateOfApplication
    1,                        -- siPrevWorkExperience
    1000000,                  -- mPrevAnnualSalary
    'beelnaj@gmail.com'       -- vEmailId
);

-- Display all data from the ExternalCandidate2 table
select * from ExternalCandidate2;





-- UPDATE

-- Update all records where cCity is 'Norton1' and set it to 'Norton'
UPDATE ExternalCandidate
SET cCity = 'Norton'
WHERE cCity = 'Norton1';

-- Set siPrevWorkExperience to 10 for candidate with first name 'Angela'
UPDATE ExternalCandidate
SET siPrevWorkExperience = 10
WHERE vFirstName = 'Angela';

-- Decrease previous work experience by 1 for all candidates
UPDATE ExternalCandidate
SET siPrevWorkExperience = siPrevWorkExperience - 1;

-- Update salary of candidate code '000204' to match Angela’s salary
UPDATE ExternalCandidate
SET mPrevAnnualSalary = (
    SELECT mPrevAnnualSalary 
    FROM ExternalCandidate 
    WHERE vFirstName = 'Angela'
)
WHERE cCandidateCode = '000204';

SELECT * FROM ExternalCandidate




-- FUNCTIONS

select upper(vfirstname) from externalcandidate
select lower(vfirstname) from externalcandidate
select val='   123' from externalcandidate
select ltrim('   123') from externalcandidate
select 'a'=rtrim('   123         ') from externalcandidate
 
select len('   1 23         ') from externalcandidate
select len(vfirstname),vfirstname from externalcandidate
select vfirstname,patindex('%an%',vfirstname) from externalcandidate
select vfirstname,charindex('A',vfirstname) from externalcandidate
 
select vfirstname,substring(vfirstname,5,2) from externalcandidate
 
select vfirstname,reverse(substring(reverse(vfirstname),1,2)) 
from ExternalCandidate
select vfirstname,substring(vfirstname,len(vfirstname)-1,2)
from ExternalCandidate