create database LibrarySystemManagement;
use LibrarySystemManagement;

CREATE TABLE tblRole (
	Role_id bigint PRIMARY KEY NOT NULL,
	Role_name VARCHAR(50) NULL
	);
CREATE TABLE tblUser (
	User_id bigint PRIMARY KEY NOT NULL,
	Role_id bigint NOT NULL,
	Username VARCHAR(100) NULL,
	Password VARCHAR(100) NULL,
	FirstName NVARCHAR(100) NULL,
	LastName NVARCHAR(100) NULL,
	Phone VARCHAR(100) NULL,
	DoB datetime NULL, 
	Gender NVARCHAR(50) NULL,
	Status bit NULL,
	FOREIGN KEY (Role_id) REFERENCES tblRole(Role_id)
	);
CREATE TABLE tblCategory(
	Category_id bigint PRIMARY KEY NOT NULL,
	Category_name NVARCHAR(255) NULL,
	Quantity int NULL,
	Status int NULL
	);
CREATE TABLE tblBook (
	Book_id bigint PRIMARY KEY NOT NULL,
	Category_id bigint NOT NULL,
	Book_name NVARCHAR(255) NULL,
	Author NVARCHAR(100) NULL,
	Description NVARCHAR(255) NULL,
	Status VARCHAR(100) NULL,
	FOREIGN KEY (Category_id) REFERENCES tblCategory(Category_id)
	);
CREATE TABLE tblBooking (
	Booking_id bigint PRIMARY KEY NOT NULL,
	Book_id bigint NOT NULL,
	User_id bigint NOT NULL,
	Booking_day datetime NULL,
	Expired_day datetime NULL,
	FOREIGN KEY (Book_id) REFERENCES tblBook(Book_id),
	FOREIGN KEY (User_id) REFERENCES tblUser(User_id)
	);
INSERT INTO tblRole (Role_id, Role_name) VALUES
(1, 'Admin'),
(2, 'Librarian'),
(3, 'Customer');

-- Insert sample categories
INSERT INTO tblCategory (Category_id, Category_name, Quantity, Status) VALUES
(1, 'JPD 113', 5, 5),
(2, 'JPD 123', 5, 5),
(3, 'MAS291', 5, 5),
(4, 'PRN211', 5, 5),
(5, 'PRJ301', 5, 5);

-- Insert sample users
-- (You should replace this with actual user data)
INSERT INTO tblUser (User_id, Role_id, Username, Password, FirstName, LastName, Phone, DoB, Gender, Status) VALUES
-- Admins
(1, 1, 'admin1', '1', 'Admin', 'A', '123456789', NULL, 'Male', 1),
(2, 1, 'admin2', '2', 'Admin', 'B', '987654321', NULL, 'Female', 1),
-- Librarians
(3, 2, 'librarian1', '1', 'Librarian', 'A', '111111111', NULL, 'Male', 1),
(4, 2, 'librarian2', '2', 'Librarian', 'B', '222222222', NULL, 'Female', 1),
(5, 2, 'librarian3', '3', 'Librarian', 'C', '333333333', NULL, 'Male', 1),
-- Customers
(6, 3, 'customer1', '1', 'Customer', 'A', '444444444', NULL, 'Female', 1),
(7, 3, 'customer2', '2', 'Customer', 'B', '555555555', NULL, 'Male', 1),
(8, 3, 'customer3', '3', 'Customer', 'C', '666666666', NULL, 'Female', 1),
(9, 3, 'customer4', '4', 'Customer', 'D', '777777777', NULL, 'Male', 1),
(10, 3, 'customer5', '5', 'Customer', 'E', '888888888', NULL, 'Female', 1);