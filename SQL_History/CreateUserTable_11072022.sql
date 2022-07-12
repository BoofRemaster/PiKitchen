create table tblUser (
	UserId int not null primary key identity,
	FirstName varchar (50) not null,
	LastName varchar (50) not null,
	CreatedAt datetime not null default current_timestamp
	)