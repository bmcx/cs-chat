CREATE PROC UserAdd
@FirstName  varcha(50),
@LastName	varcha(50),
@Email		varcha(250),
@Password	Varcha(50),
@Repassword	Varcha(50)
AS
	INSERT INTO dataSignup(FirstName,LastName,Email,Password,RePassword)
	VALUES (@FirstNAme,@LastName,@Email,@Password,@RePassowrd)
				
