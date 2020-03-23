DROP TABLE  IF EXISTS tbl_toDoList;
DROP TABLE  IF EXISTS tbl_users;
DROP TABLE  IF EXISTS tbl_status;

CREATE TABLE tbl_users (
   u_idUser int IDENTITY (1,1) NOT NULL  PRIMARY KEY
  ,u_username varchar(16) NOT NULL
  ,u_fullname varchar(40) NOT NULL
  ,u_password varchar(200) NOT NULL
);

CREATE TABLE tbl_status (
   s_idStatus CHAR NOT NULL PRIMARY KEY
  ,s_description varchar(16) NOT NULL
);

CREATE TABLE tbl_toDoList (
   td_idToDoList int IDENTITY(1,1) NOT NULL PRIMARY KEY
  ,td_fk_idUser int
  ,td_description varchar(200)
  ,td_fk_idStatus CHAR NOT NULL
  ,CONSTRAINT FK_User   FOREIGN KEY (td_fk_idUser) REFERENCES tbl_Users(u_idUser)
  ,CONSTRAINT FK_Status FOREIGN KEY (td_fk_idStatus) REFERENCES tbl_status(s_idStatus)

);


INSERT INTO tbl_users (u_username, u_fullname, u_password)
	VALUES ( 'martin', 'Martin Molema',Hashbytes('SHA2_256', 'welkom'));
INSERT INTO tbl_users (u_username, u_fullname, u_password)
	VALUES ( 'piet', 'Pietje Puk',Hashbytes('SHA2_256', 'welkom'));

INSERT INTO tbl_status (s_idStatus, s_description) VALUES ('N','Nieuw');
INSERT INTO tbl_status (s_idStatus, s_description) VALUES ('G','Gereed')
INSERT INTO tbl_status (s_idStatus, s_description) VALUES ('P','Pending');
