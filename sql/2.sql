SELECT 
EmployeeID
 FROM northwind.employees
 where HireDate=(select max(HireDate) from northwind.employees)