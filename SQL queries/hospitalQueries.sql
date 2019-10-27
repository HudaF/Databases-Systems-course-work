--1:
select count(Physician) 
as 'Physicians per department' 
from Affiliated_With
group by Department

--2:
Select Physician.Name as 'Physican name',Department.Name as 'Department name',PrimaryAffiliation
from Physician,Department,Affiliated_With
where EmployeeID= Physician
and DepartmentID = Department
and PrimaryAffiliation = 0

--3:
Select Physician.Name as 'Physican name', Position
from Physician, Department, Affiliated_With
where EmployeeID= Physician
and DepartmentID = Department
and Department.Name like 'Surgery'

--4: 
Select Name
from Physician, Trained_In, Undergoes
where (EmployeeID = Trained_In.Physician)
and EmployeeID= Undergoes.Physician
and (Undergoes.Date > CertificationExpires)

--5:
Select Name, "Procedure", Date, Patient, CertificationExpires
from Physician, Trained_In, Undergoes
where (EmployeeID = Trained_In.Physician)
and EmployeeID= Undergoes.Physician
and (Undergoes.Date > CertificationExpires)

--6:
Select count(Room.Number) as 'unavailable count', 
	(Select count(number) 
	from Room where Unavailable=1)
	 as 'available count'
from Room
where Unavailable = 0

--7(a):
Select Patient.Name, 
	(select Name from Physician
	 where EmployeeID = PCP) 
	as 'primary care'
from Patient,Prescribes
where PCP = Prescribes.Physician
and Patient.SSN = Patient

--7(b)
Select Patient.Name, 
	(select Name from Physician
	 where EmployeeID = PCP) 
	as 'primary care'
from Patient
where PCP not in (select Department.Head from Department)


--8:
select name, DATEDIFF(DAY,StartDate,EndDate) as 'StayDays' 
from stay,Patient
where SSN = Patient

--9:
select EmployeeID, 
	(select count(*) 
	from Appointment 
	where EmployeeID = Physician 
	and DATEPART(month,StartDate) = DATEPART(month,getdate()))
as 'AppointmentThisMonth' 
from Physician

--10:
select Patient.Name from Patient,"Procedure"
where 
	(select count([Procedure]) 
	from Undergoes where Code = Undergoes.[Procedure] 
	and SSN = Patient)>1

--11:
select treatment, name from Physician,Trained_In
where EmployeeID = Trained_In.Physician
and CertificationExpires > Dateadd(month,1, GETDATE())

--12:
select top 1 
	(select Physician.Name 
	from Physician 
	where Physician.EmployeeID = Physician)
from Physician,Trained_In
where Physician = EmployeeID
group by (Physician)
order by count(physician) desc

--13:
select Name,
	(select (COUNT(Physician)-1) 
	from Affiliated_With 
	where  DepartmentID= Department) 
	as 'UnderDepartmentHead'
from Department

--14:
select Name, 
(select count(stayID) 
	from Stay 
	where SSN = Patient) 
	as 'AdmissionCount', 
coalesce((select sum(DATEDIFF(day,startDate,EndDate))  
	from Stay 
	where Stay.Patient = Patient.SSN ),0)
	as 'DaysCount'
from Patient

--15:
select Name
from Patient,Stay
where (DATEDIFF(day,StartDate,EndDate))>10
and Patient=SSN

--16:
select
	(select Name from Patient where Patient = SSN) as 'PatientName',
	(select Name from [Procedure] where Code = Undergoes.[Procedure]) as 'ProcedureName',
	(select Name from Physician where EmployeeID = Undergoes.Physician ) as 'PhysicainName',
	(select room from Stay where Stay = StayID) as 'RoomID',
Date as 'Date'
from Undergoes
where DATEPART(day,GETDATE()) = DATEPART(day, Date)
