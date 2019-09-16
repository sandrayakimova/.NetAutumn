SELECT prod.ProductName,prod.UnitsInStock,s.ContactName, s.Phone
 FROM northwind.products as prod,`northwind`.`categories` as cat,`northwind`.`suppliers` as s
 where (cat.CategoryName='Beverages' or cat.CategoryName='Seafood') and (prod.Discontinued=1) and (prod.ReorderLevel<20)
 order by prod.ReorderLevel;