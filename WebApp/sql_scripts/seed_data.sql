
INSERT INTO Country(name) VALUES('Россия');
INSERT INTO Country(name) VALUES('Америка');
INSERT INTO Country(name) VALUES('Англия');
INSERT INTO Country(name) VALUES('Германия');
INSERT INTO Country(name) VALUES('Франция');

INSERT INTO Authors(id, Name, Surname, CountryId) VALUES(1, "Антон Павлович","Чехов",1);
INSERT INTO Authors(id, Name, Surname, CountryId) VALUES(2, "Федор Михайлович","Достоевский",1);
INSERT INTO Authors(id, Name, Surname, CountryId) VALUES(3, "Лев Николаевич","Толстой",1);
INSERT INTO Authors(id, Name, Surname, CountryId) VALUES(4, "Джек","Лондон",2);
INSERT INTO Authors(id, Name, Surname, CountryId) VALUES(5, "Марк","Твен",2);
INSERT INTO Authors(id, Name, Surname, CountryId) VALUES(6, "Чарльз","Диккенс",3);
INSERT INTO Authors(id, Name, Surname, CountryId) VALUES(7, "Агата","Кристи",3);
INSERT INTO Authors(id, Name, Surname, CountryId) VALUES(8, "Франц","Кафка",4);
INSERT INTO Authors(id, Name, Surname, CountryId) VALUES(9, "Эрих Мария","Ремарк",4);
INSERT INTO Authors(id, Name, Surname, CountryId) VALUES(10, "Жюль","Верн",5);
INSERT INTO Authors(id, Name, Surname, CountryId) VALUES(11, "Фредерик","Бегбедер",5);

INSERT INTO Books(Id, Title, Date, AuthorId) VALUES(1, "Вишневый сад", "26.12.2019", 1);
INSERT INTO Books(Id, Title, Date, AuthorId) VALUES(2, "Чайка", "27.12.2019", 1);
INSERT INTO Books(Id, Title, Date, AuthorId) VALUES(3, "Идиот", "24.12.2019", 2);
INSERT INTO Books(Id, Title, Date, AuthorId) VALUES(4, "Война и мир", "24.12.2019", 3);
INSERT INTO Books(Id, Title, Date, AuthorId) VALUES(5, "Белый клык", "20.12.2019", 4);
INSERT INTO Books(Id, Title, Date, AuthorId) VALUES(6, "Приключения Тома Сойера", "24.12.2019", 5);
INSERT INTO Books(Id, Title, Date, AuthorId) VALUES(7, "Рождественская история", "24.12.2019", 6);
INSERT INTO Books(Id, Title, Date, AuthorId) VALUES(8, "Эркуюль Пуаро", "24.12.2019", 7);
INSERT INTO Books(Id, Title, Date, AuthorId) VALUES(9, "Замок", "24.12.2019", 8);
INSERT INTO Books(Id, Title, Date, AuthorId) VALUES(10, "На западном фронте без перемен", "24.12.2019", 9);
INSERT INTO Books(Id, Title, Date, AuthorId) VALUES(11, "Таинственный остров", "24.12.2019", 10);
INSERT INTO Books(Id, Title, Date, AuthorId) VALUES(12, "99 франков", "24.12.2019", 11);
