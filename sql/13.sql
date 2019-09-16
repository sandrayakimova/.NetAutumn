SELECT CustomerID,ShipCountry, UnitPrice*(1-Discount) as OrderPrice
FROM northwind.orders,`northwind`.`order details` 
where OrderDate>='1994-08-01 00:00:00' and ShipCountry in ('Argentina','Brazil','Colombia','Peru','Venezuela','Chile','Ecuador','Bolivia','Paraguay','Uruguay','Guyana','Suriname') 
order by OrderPrice desc
limit 3;