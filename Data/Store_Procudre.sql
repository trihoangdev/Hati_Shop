--Tạo mới khách hàng
CREATE PROCEDURE CreateNewCustomer
	@Id varchar(50),
	@Username varchar(50),
	@Password varchar(100),
	@FullName nvarchar(50),
	@Gender nvarchar(4),
	@BirthDate datetime,
	@PhoneNumber varchar(10),
	@Email varchar(100),
	@Address nvarchar(200),
	@AvatarPath nvarchar(MAX)
AS
BEGIN
    INSERT Customer (Id,Username,Password,FullName,Gender,BirthDate,PhoneNumber,Email,Address,AvatarPath)
	VALUES (@Id,@Username,@Password, @FullName,@Gender,@BirthDate,@PhoneNumber,@Email,@Address,@AvatarPath)
END;

--Tạo mới nhân viên
CREATE PROCEDURE CreateNewStaff
	@Id varchar(50),
	@Username varchar(50),
	@Password varchar(100),
	@FullName nvarchar(50),
	@Gender nvarchar(4),
	@BirthDate datetime,
	@PhoneNumber varchar(10),
	@Email varchar(100),
	@Address nvarchar(200),
	@AvatarPath nvarchar(MAX)
AS
BEGIN
    INSERT Customer (Id,Username,Password,FullName,Gender,BirthDate,PhoneNumber,Email,Address,AvatarPath)
	VALUES (@Id,@Username,@Password, @FullName,@Gender,@BirthDate,@PhoneNumber,@Email,@Address,@AvatarPath)
END;

--Kiểm tra login
CREATE PROCEDURE CheckLogin
	@Username varchar(50),
	@Password varchar(100)
AS
BEGIN
    SELECT 
		Username,
		Password
	FROM Customer
	WHERE
		Username = @Username
		AND
		Password = @Password
END;

