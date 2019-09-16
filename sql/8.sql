SELECT Country, count(*)
FROM `northwind`.`customers`
group by Country  
 having count(*)>10
order by count(*) desc;