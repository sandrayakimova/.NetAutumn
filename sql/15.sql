select Concat(e.FirstName,e.LastName) as Empoyer,c.CompanyName as Customer
from `northwind`.`customers` as c,`northwind`.`employees` as e,`northwind`.`shippers` as s,`northwind`.`suppliers` as ss
where c.City='London' and s.CompanyName='Speedy Express'and  ss.City='London';
