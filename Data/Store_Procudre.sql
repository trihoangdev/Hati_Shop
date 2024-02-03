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
	@AvatarPath nvarchar(MAX),
	@Role nvarchar(50)
AS
BEGIN
    INSERT Staff (Id,Username,Password,FullName,Gender,BirthDate,PhoneNumber,Email,Address,AvatarPath, Role)
	VALUES (@Id,@Username,@Password, @FullName,@Gender,@BirthDate,@PhoneNumber,@Email,@Address,@AvatarPath,@Role)
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

--Đọc các thông tin về username
CREATE PROCEDURE LoadUsername
AS
BEGIN
	SELECT 
		Username
	FROM 
		Staff
	UNION
	SELECT 
		Username
	FROM 
		Customer
END;

--Đọc các thông tin về email
CREATE PROCEDURE LoadEmail
AS
BEGIN
	SELECT 
		Email
	FROM 
		Staff
	UNION
	SELECT 
		Email
	FROM 
		Customer
END;

--Đọc các thông tin về SĐT
CREATE PROCEDURE LoadPhone
AS
BEGIN
	SELECT 
		PhoneNumber
	FROM 
		Staff
	UNION
	SELECT 
		PhoneNumber
	FROM 
		Customer
END;

--Đọc các thông tin về Customer
CREATE PROC LoadCustomer
AS
BEGIN
	SELECT 
		Id,
		Username,
		Password,
		FullName,
		Gender,
		BirthDate,
		PhoneNumber,
		Email,
		Address,
		AvatarPath,
		Revenue,
		Rank
	FROM 
		Customer
END


--Đọc các thông tin về Staff
CREATE PROC LoadStaff
AS
BEGIN
	SELECT 
		Id,
		Username,
		Password,
		FullName,
		Gender,
		BirthDate,
		PhoneNumber,
		Email,
		Address,
		AvatarPath,
		Role
	FROM 
		Staff
END
