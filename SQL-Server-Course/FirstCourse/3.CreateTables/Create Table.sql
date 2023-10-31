Use FaraDars

Create Table tblTest (
	ID int Identity(1,1)  Primary key ,
	Name nvarchar(50) not null,
	Family nvarchar(100) not null,
	Address nvarchar(max) null
)