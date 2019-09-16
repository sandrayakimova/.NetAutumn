SELECT  CustomerID, round(avg(Freight))
 FROM northwind.orders
 where ShipCountry='Canada' or ShipCountry='UK'    
 group by CustomerID
 having (avg(Freight)>=100) or (avg(Freight<10))
order by avg(Freight) desc;