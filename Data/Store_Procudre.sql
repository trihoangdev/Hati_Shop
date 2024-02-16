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
	@AvatarPath nvarchar(MAX),
	@Revenue int,
	@Rank nvarchar(50)
AS
BEGIN
    INSERT Customer (Id,Username,Password,FullName,Gender,BirthDate,PhoneNumber,Email,Address,AvatarPath, Revenue, Rank)
	VALUES (@Id,@Username,@Password, @FullName,@Gender,@BirthDate,@PhoneNumber,@Email,@Address,@AvatarPath,@Revenue,@Rank)
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

--Tạo mới sản phẩm
CREATE PROC CreateNewProduct
	@Id varchar(50),
	@Name nvarchar(100),
	@Price int,
	@Type nvarchar(50),
	@Quantity int,
	@Size nvarchar(10),
	@Info nvarchar(MAX),
	@AvatarPath nvarchar(MAX)
AS
BEGIN
	INSERT Product(Id,Name,Price,Type,Quantity,Size,Info,AvatarPath)
	VALUES(@Id,@Name,@Price,@Type,@Quantity,@Size,@Info,@AvatarPath)
END;

--Kiểm tra login của nhân viên và quản lý
CREATE PROCEDURE CheckLogin
	@Username varchar(50),
	@Password varchar(100),
	@Role nvarchar(50)
AS
BEGIN
    SELECT 
		Username,
		Password
		Role
	FROM 
		Staff
	WHERE
		Username = @Username
		AND
		Password = @Password
		AND 
		Role = @Role
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

--Đọc các thông tin về sản phẩm
CREATE PROC LoadProduct
AS
BEGIN
	SELECT
		Id, Name,Price,Type,Quantity,Size,Info,AvatarPath
	FROM Product
END;


--Sửa thông tin cá nhân của Nhân viên
CREATE PROC EditStaffInfo
	@Id varchar(50),
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
UPDATE Staff
	SET
		FullName = @FullName,
		Gender = @Gender,
		BirthDate = @BirthDate,
		PhoneNumber = @PhoneNumber,
		Email = @Email,
		Address = @Address,
		AvatarPath = @AvatarPath,
		Role = @Role
	WHERE 
		Id = @Id
END

--Sửa thông tin cá nhân của Khách hàng
CREATE PROC EditCustomerInfo
	@Id varchar(50),
	@FullName nvarchar(50),
	@Gender nvarchar(4),
	@BirthDate datetime,
	@PhoneNumber varchar(10),
	@Email varchar(100),
	@Address nvarchar(200),
	@AvatarPath nvarchar(MAX),
	@Revenue int,
	@Rank nvarchar(50)
AS
BEGIN
UPDATE Customer
	SET
		FullName = @FullName,
		Gender = @Gender,
		BirthDate = @BirthDate,
		PhoneNumber = @PhoneNumber,
		Email = @Email,
		Address = @Address,
		AvatarPath = @AvatarPath,
		Revenue = @Revenue,
		Rank = @Rank
	WHERE 
		Id = @Id
END

--Sửa thông tin sản phẩm
CREATE PROC EditProductInfo
	@Id varchar(50),
	@Name nvarchar(100),
	@Price int,
	@Type nvarchar(50),
	@Quantity int,
	@Size nvarchar(10),
	@Info nvarchar(MAX),
	@AvatarPath nvarchar(MAX)
AS
BEGIN
	UPDATE Product
	SET
		Name = @Name,
		Price = @Price,
		Type = @Type,
		Quantity = @Quantity,
		Size = @Size,
		Info = @Info,
		AvatarPath = @AvatarPath
	WHERE
		Id = @Id
END;

--Xoá nhân viên khỏi danh sách thông qua username
CREATE PROC RemoveStaffByUsername
	@Username varchar(50)
AS
BEGIN
	DELETE FROM Staff
	WHERE Username = @Username
END

--Đổi mật khẩu của nhân viên
CREATE PROC EditStaffPassword
	@Username varchar(50),
	@Password varchar(100)
AS
BEGIN
	UPDATE Staff
	SET
		Password = @Password
	WHERE 
		Username = @Username
END

--Tìm theo tên
CREATE PROC FindByName
	@Fullname nvarchar(50),
	@Table varchar(50)
AS
BEGIN
	IF @Table = 'Staff'
	BEGIN
		SELECT
			Id, Username, Password, Fullname, Gender, BirthDate, PhoneNumber, Email, Address, AvatarPath, Role
		FROM 
			Staff
		WHERE
			Fullname LIKE N'%' + @Fullname + '%'
	END
	ELSE IF @Table = 'Customer'
	BEGIN
		SELECT
			Id, Username, Password, Fullname, Gender, BirthDate, PhoneNumber, Email, Address, AvatarPath,Revenue,Rank
		FROM 
			Customer
		WHERE
			Fullname LIKE N'%' + @Fullname + '%'
	END
END

--Tìm theo năm sinh
CREATE PROC FindByBirthDate
	@BirthDate nvarchar(50),
	@Table varchar(50)
AS
BEGIN
	IF @Table = 'Staff'
	BEGIN
		SELECT
			Id, Username, Password, Fullname, Gender, BirthDate, PhoneNumber, Email, Address, AvatarPath, Role
		FROM 
			Staff
		WHERE
			YEAR(BirthDate) = @BirthDate
	END
	ELSE IF @Table = 'Customer'
	BEGIN
		SELECT
			Id, Username, Password, Fullname, Gender, BirthDate, PhoneNumber, Email, Address, AvatarPath, Revenue, Rank
		FROM 
			Customer
		WHERE
			YEAR(BirthDate) = @BirthDate
	END
END


--Tìm theo giới tính
CREATE PROC FindByGender
	@Gender nvarchar(4),
	@Table varchar(50)
AS
BEGIN
	IF @Table = 'Staff'
	BEGIN
		SELECT
			Id, Username, Password, Fullname, Gender, BirthDate, PhoneNumber, Email, Address, AvatarPath, Role
		FROM 
			Staff
		WHERE
			Gender = @Gender
	END
	ELSE IF @Table = 'Customer'
	BEGIN
		SELECT
			Id, Username, Password, Fullname, Gender, BirthDate, PhoneNumber, Email, Address, AvatarPath, Revenue, Rank
		FROM 
			Customer
		WHERE
			Gender = @Gender
	END
END

--Tìm theo username
CREATE PROC FindByUsername
	@Username varchar(50),
	@Table varchar(50)
AS
BEGIN
	IF @Table = 'Staff'
	BEGIN
		SELECT
			Id, Username, Password, Fullname, Gender, BirthDate, PhoneNumber, Email, Address, AvatarPath, Role
		FROM 
			Staff
		WHERE
			Username LIKE N'%' + @Username + '%'
	END
	ELSE IF @Table = 'Customer'
	BEGIN
		SELECT
			Id, Username, Password, Fullname, Gender, BirthDate, PhoneNumber, Email, Address, AvatarPath, NULL AS Revenue, NULL AS Rank
		FROM 
			Customer
		WHERE
			Username LIKE N'%' + @Username + '%'
	END
END

--Tìm theo chức vụ
CREATE PROC FindByRole
	@Role nvarchar(50),
	@Table varchar(50)
AS
BEGIN
	IF @Table = 'Staff'
	BEGIN
		SELECT
			Id, Username, Password, Fullname, Gender, BirthDate, PhoneNumber, Email, Address, AvatarPath, Role
		FROM 
			Staff
		WHERE
			Role = @Role
	END
END

