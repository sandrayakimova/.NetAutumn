SELECT CustomerID, sum(Freight)
 FROM northwind.orders  
 where Month(RequiredDate)=7 and Year(RequiredDate)=1996 and day(RequiredDate>=15)
 group by CustomerID   
 having sum(Freight)>=avg(Freight)
 order by sum(Freight)