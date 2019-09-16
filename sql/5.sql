SELECT CustomerID
 FROM northwind.orders
 where Month(RequiredDate)=9 and Year(RequiredDate)=1996;