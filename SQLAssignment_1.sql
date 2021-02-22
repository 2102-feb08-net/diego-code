-- DDL
-- Create Tables
CREATE TABLE Products(
	ProductId INT NOT NULL, 
	Name VARCHAR(100) NOT NULL, 
	Price NUMERIC(10,2) NOT NULL, 
	CONSTRAINT PK_ProductId PRIMARY KEY CLUSTERED (ProductId)
);
GO
CREATE TABLE Customers(
	CustomerId INT NOT NULL, 
	FirstName VARCHAR(100) NOT NULL, 
	LastName VARCHAR(100) NOT NULL, 
	CardNumer BIGINT NOT NULL
	CONSTRAINT PK_CustomerId PRIMARY KEY CLUSTERED(CustomerId)
);
GO
CREATE TABLE Orders(
	OrderId INT NOT NULL, 
	ProductId INT NOT NULL, 
	CustomerId INT NOT NULL
	CONSTRAINT PK_OrderId PRIMARY KEY  NONCLUSTERED (OrderId)
);
GO
-- Add Foreign Keys to Orders
ALTER TABLE Customers ADD CONSTRAINT FK_CustomerId
	FOREIGN KEY (CustomerId) REFERENCES Customers (CustomerId) ON DELETE CASCADE ON UPDATE NO ACTION;
GO
ALTER TABLE Customers ADD CONSTRAINT FK_ProductId
	FOREIGN KEY (ProductId) REFERENCES Products (ProductId) ON DELETE CASCADE ON UPDATE NO ACTION;
GO

--DML
-- Insert data
-- 1.
INSERT INTO Products VALUES (1, 'Poki Classic', 2.99);
INSERT INTO Products VALUES (2, 'Pokemon Red', 5.99);
INSERT INTO Products VALUES (3, 'Logitech Mouse', 6.99);
GO
INSERT INTO Customers VALUES (1, 'James', 'Fields', 123454326543);
INSERT INTO Customers VALUES (2, 'Carlos', 'Blue', 123454323065);
INSERT INTO Customers VALUES (3, 'Joseph', 'Joestar', 123454320021);
GO
INSERT INTO Orders VALUES (1, 1, 2);
INSERT INTO Orders VALUES (2, 3, 1);
INSERT INTO Orders VALUES (3, 2, 3);
GO

--2. 
INSERT INTO Products VALUES (4, 'iPhone', 200.00);
GO
--3.
INSERT INTO Customers VALUES (4, 'Tina Smith', 218991733492);
GO
--4.
INSERT INTO Orders VALUES (5, 4, 4);
GO

--5.
SELECT * 
FROM Orders INNER JOIN Customers ON Customers.CustomerId = Orders.CustomerId
WHERE Customers.FirstName = 'Tina' AND Customers.LastName = 'Smith'
GROUP BY Orders.OrderId;

--6.
SELECT SUM(Orders.OrderId * Products.Price)
FROM Orders INNER JOIN Products ON Products.ProductId = Orders.OrderId
WHERE Products.Name = 'iPhone';