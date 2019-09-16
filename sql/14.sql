SELECT DISTINCT CompanyName,min(UnitPrice) as MinPrize ,max(UnitPrice) as MaxPrice
FROM `northwind`.`products` AS p        
INNER JOIN `northwind`.`suppliers` AS s ON p.SupplierID = s.SupplierID
group by CompanyName 
ORDER BY s.CompanyName;