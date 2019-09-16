SELECT CompanyName
FROM `northwind`.`customers`
where City='Berlin' or City='London' or City='Madrid' or City='Bruxelles' or City='Paris'
order by CustomerID desc;
