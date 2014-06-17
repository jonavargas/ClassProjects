-- use master drop database RestaurantMenu
create database RestaurantMenu
go
use RestaurantMenu
go
-- drop table RestaurantCategory
create table RestaurantCategory(
	[Id] int identity, 
	[Name] varchar(150) not null default(''),
	[Description] text,
	CONSTRAINT pk_RestaurantCategoryId PRIMARY KEY (Id)
)
go
--drop table Restaurant
create table Restaurant(
	[Id] int identity,
	[Name] varchar(150) not null default(''),
	[RestaurantCategoryId] int not null,
	CONSTRAINT fk_Restaurant_RestaurantCategoryId FOREIGN KEY (RestaurantCategoryId) REFERENCES RestaurantCategory(Id),
	[Address] varchar(250) not null default(''),
	[Telephone] varchar(15) not null default(''),
	[Email] varchar(150) not null default(''),	
	CONSTRAINT pk_RestaurantId PRIMARY KEY (Id),	
)
go
-- drop table mealtype
create table MealType(
	[Id] int identity,
	[Name] varchar(150), 
	[Description] text,
	CONSTRAINT pk_MealType PRIMARY KEY(Id)
)
go
-- drop table meal
create table Meal(
	[Id] int identity,
	[RestaurantId] int not null,
	CONSTRAINT fk_Meal_RestaurantId FOREIGN KEY (RestaurantId) REFERENCES Restaurant(Id),
	[Name] varchar(150) not null default(''),
	[Price] decimal not null,
	[Description] text,
	[MealTypeId] int not null,
	CONSTRAINT fk_Meal_MealTypeId FOREIGN KEY (MealTypeId) REFERENCES MealType(Id),
	CONSTRAINT pk_Meal PRIMARY KEY (Id)
)

select * from RestaurantCategory

insert into RestaurantCategory values('Italiano','Pastas,Pizza,Quesos y Vinos.');

insert into RestaurantCategory values('Japones','Sushi, Tempuras, Teriyaki y Sopas.');

insert into RestaurantCategory values('Peruano','Ceviche ,Pizza,Quesos y Vinos.');

insert into RestaurantCategory values('Americano','Hamburguesas ,Papas Fritas y Nacho.');

insert into RestaurantCategory values('Comida Rápida','Tacos ,Hamburguesas,Sandwich y Papas.');

insert into RestaurantCategory values('Bar','Chifrijo ,Hamburguesas,Bocas y Vinos.');

insert into RestaurantCategory values('Comida tipica','Casados ,Hamburguesas,Arroces.');

insert into RestaurantCategory values('Comida general','Casados ,Hamburguesas,Arroces,Tacos,Hotdogs,Postres.');

