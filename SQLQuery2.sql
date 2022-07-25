--select komutu bir veriyi çekmek için kullanılır
Select ContactName,CompanyName,City from Customers

-- kullanıcıları seç,
Select*from Customers where City='Berlin'

Select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products where CategoryID=1 or CategoryID=3

-- order by sırala demek.
-- kategori ıd ve ürün ismine göre sırala
select * from Products order by  CategoryID,ProductName

-- fiyata göre sırala

select * from Products order by UnitPrice asc -- ascending (artan) sırala

select * from Products order by UnitPrice desc -- descending (azalan) sırala

select count(*) Adet  from Products where CategoryID=1


-- hangi kategoride kaç farklı ürün var
-- group by kullanılırken kategori ettiğiniz kısım yazılır
-- her bir eleman için adet bilgisi alınır. count adet bilgisini verir.
-- group by da koşuş having ile yazılır
select CategoryId, count(*) Adet from  Products group by CategoryID having count(*)<10

