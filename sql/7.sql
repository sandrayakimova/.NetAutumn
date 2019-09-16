SELECT  count(*), City
 FROM northwind.customers
 where Country= 'Sweden' or Country='Norway' or Country='Denmark'
 group by City
