SELECT EmployeeID
FROM northwind.employees
where HireDate=
(select max(HireDate) FROM northwind.employees where HireDate<(select max(HireDate) FROM northwind.employees));

