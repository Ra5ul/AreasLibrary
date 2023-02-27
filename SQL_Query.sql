SELECT Products.name, Category.name
FROM Products LEFT JOIN  Category ON Products.id=Category.productId 
ORDER BY Products.name;

--Получение всех пар продукт-категория при неявном перекрестном соединении

SELECT * FROM Orders, Customers

--Получение всех пар продукт-категория при явном перекрестном соединении

SELECT * FROM Orders CROSS JOIN Customers



