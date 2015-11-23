//Create tables and contraints
CREATE TABLE CAMP
  (
    CampID      INTEGER NOT NULL,
    Description VARCHAR(200) ,
    MaxPerson   INTEGER NOT NULL ,
    Available BOOLEAN
  ) ; 
ALTER TABLE CAMP ADD CONSTRAINT CAMP_PK PRIMARY KEY ( CampID ) ;


CREATE TABLE CAMPING_RES
  (
    CampRes_No           INTEGER NOT NULL ,
    Start_Date           DATE NOT NULL ,
    End_Date             DATE NOT NULL ,
    Account_ID INTEGER NOT NULL ,
    CAMP_CampID          INTEGER NOT NULL
  ) ;
ALTER TABLE CAMPING_RES ADD CONSTRAINT CAMPING_RES_PK PRIMARY KEY ( CampRes_No ) ;


CREATE TABLE E_ACCOUNT
  (
    Account_ID                 INTEGER NOT NULL ,
    RFID_Code                   INTEGER,
    Balance                     DECIMAL (10,3) NOT NULL ,
    E_mail                    VARCHAR (30) NOT NULL ,
    First_Name                  VARCHAR (50) NOT NULL ,
    Last_Name                   VARCHAR (50) NOT NULL ,
    Phone                       CHAR (20) ,
    Payment_Status BOOLEAN NOT NULL ,
    Pay_InAdvance BOOLEAN NOT NULL
  ) ;
  ALTER TABLE E_ACCOUNT ADD CONSTRAINT E_ACCOUNT_PK PRIMARY KEY ( Account_ID ) ;

CREATE TABLE FOOD
  (
    Food_ID       INTEGER NOT NULL ,
    Food_Name     VARCHAR (100) NOT NULL ,
    Food_Quantity INTEGER NOT NULL ,
    Food_Price    DECIMAL (6,2) NOT NULL
  ) ;
ALTER TABLE FOOD ADD CONSTRAINT FOOD_PK PRIMARY KEY ( Food_ID ) ;

CREATE TABLE F_INVOICE
  (
    Food_InvoiceID       INTEGER NOT NULL ,
    SoldDate             DATE NOT NULL ,
    Account_ID          INTEGER NOT NULL
  ) ;
ALTER TABLE F_INVOICE ADD CONSTRAINT F_INVOICE_PK PRIMARY KEY ( Food_InvoiceID ) ;

CREATE TABLE FOOD_INVOICE
  (
    Quantity_Sold       INTEGER NOT NULL ,
    Food_InvoiceID   	INTEGER NOT NULL ,
    Food_ID             INTEGER NOT NULL
  ) ;
ALTER TABLE FOOD_INVOICE ADD CONSTRAINT FOOD_INVOICE_PK PRIMARY KEY ( Food_InvoiceID , Food_ID );

CREATE TABLE GROUPMEMBERS
  (
    GroupID                   INTEGER NOT NULL ,
    Co_email                  VARCHAR(20) NOT NULL ,
    CampRes_No                INTEGER NOT NULL ,
    Check_in BOOLEAN NOT NULL
  ) ;
ALTER TABLE GROUPMEMBERS ADD CONSTRAINT GROUP_PK PRIMARY KEY ( GroupID, Co_email ) ;

CREATE TABLE MATERIAL
  (
    Material_ID       INTEGER NOT NULL ,
    Name              VARCHAR (200) NOT NULL ,
    Deposit_Amount    DECIMAL (10,3) NOT NULL ,
    Loaning_Price     DECIMAL (10,3) NOT NULL ,
    Description       VARCHAR (50) ,
    Material_Quantity INTEGER NOT NULL
  ) ;
ALTER TABLE MATERIAL ADD CONSTRAINT MATERIAL_PK PRIMARY KEY ( Material_ID ) ;

CREATE TABLE M_INVOICE
  (
    Material_InvoiceID   INTEGER NOT NULL ,
    Start_Date           DATE NOT NULL,
    Account_ID          INTEGER NOT NULL
  ) ;
ALTER TABLE M_INVOICE ADD CONSTRAINT M_INVOICE_PK PRIMARY KEY ( Material_InvoiceID ) ;

CREATE TABLE MATERIAL_INVOICE
  (
    Material_Quantity            INTEGER NOT NULL ,
    Material_ID         INTEGER NOT NULL ,
    Material_InvoiceID INTEGER NOT NULL,
    End_Date             DATE 
  ) ;
ALTER TABLE MATERIAL_INVOICE ADD CONSTRAINT MATERIAL_INVOICE_PK PRIMARY KEY ( Material_ID, Material_InvoiceID ) ;


//Foreign keys
ALTER TABLE CAMPING_RES ADD CONSTRAINT CAMPING_RES_CAMP_FK FOREIGN KEY ( CAMP_CampID ) REFERENCES CAMP ( CampID ) ;

ALTER TABLE CAMPING_RES ADD CONSTRAINT CAMPING_RES_E_ACCOUNT_FK FOREIGN KEY ( Account_ID ) REFERENCES E_ACCOUNT ( Account_ID ) ;

ALTER TABLE FOOD_INVOICE ADD CONSTRAINT FOOD_INVOICE_FOOD_FK FOREIGN KEY ( Food_ID ) REFERENCES FOOD ( Food_ID ) ;

ALTER TABLE FOOD_INVOICE ADD CONSTRAINT FOOD_INVOICE_F_INVOICE_FK FOREIGN KEY (Food_InvoiceID ) REFERENCES F_INVOICE ( Food_InvoiceID) ;

ALTER TABLE F_INVOICE ADD CONSTRAINT F_INVOICE_E_ACCOUNT_FK FOREIGN KEY ( Account_ID ) REFERENCES E_ACCOUNT ( Account_ID ) ;

ALTER TABLE GROUPMEMBERS ADD CONSTRAINT GROUP_CAMPING_RES_FK FOREIGN KEY ( CampRes_No) REFERENCES CAMPING_RES ( CampRes_No ) ;

ALTER TABLE GROUPMEMBERS ADD CONSTRAINT GROUP_ACCOUNT_EMAIL_FK FOREIGN KEY ( E_mail ) REFERENCES E_ACCOUNT( E_mail) ; -- It's not working

ALTER TABLE GROUPMEMBERS ADD CONSTRAINT GROUP_CAMP_RES_FK FOREIGN KEY (CampRes_No  ) REFERENCES CAMPING_RES( CampRes_No ) ;

ALTER TABLE MATERIAL_INVOICE ADD CONSTRAINT MATERIAL_INVOICE_MATERIAL_FK FOREIGN KEY ( Material_ID ) REFERENCES MATERIAL ( Material_ID ) ;

ALTER TABLE MATERIAL_INVOICE ADD CONSTRAINT MATERIAL_INVOICE_M_INVOICE_FK FOREIGN KEY ( Material_InvoiceID ) REFERENCES M_INVOICE ( Material_InvoiceID ) ;

ALTER TABLE M_INVOICE ADD CONSTRAINT M_INVOICE_E_ACCOUNT_FK FOREIGN KEY ( Account_ID ) REFERENCES E_ACCOUNT ( Account_ID ) ;

//Drop foreign key constraints
ALTER TABLE CAMPING_RES DROP FOREIGN KEY CAMPING_RES_CAMP_FK;

ALTER TABLE CAMPING_RES DROP FOREIGN KEY CAMPING_RES_E_ACCOUNT_FK;

ALTER TABLE FOOD_INVOICE DROP FOREIGN KEY FOOD_INVOICE_FOOD_FK;

ALTER TABLE FOOD_INVOICE DROP FOREIGN KEY FOOD_INVOICE_F_INVOICE_FK;

ALTER TABLE F_INVOICE DROP FOREIGN KEY F_INVOICE_E_ACCOUNT_FK;

ALTER TABLE GROUPMEMBERS DROP FOREIGN KEY GROUP_CAMPING_RES_FK;

ALTER TABLE GROUPMEMBERS DROP FOREIGN KEY GROUP_CAMP_RES_FK;

ALTER TABLE MATERIAL_INVOICE DROP FOREIGN KEY MATERIAL_INVOICE_MATERIAL_FK;

ALTER TABLE MATERIAL_INVOICE DROP FOREIGN KEY MATERIAL_INVOICE_M_INVOICE_FK;

ALTER TABLE M_INVOICE DROP FOREIGN KEY M_INVOICE_E_ACCOUNT_FK;

//Insert data into Camp Table
INSERT INTO Camp(CampID, Description, MaxPerson, Available)
VALUES (1,'tentsplot, size: 5m x 5m', 5, false);
INSERT INTO Camp(CampID, Description, MaxPerson, Available)
VALUES (2,'Near by river, caravan, 5m x 2m', 4, true);
INSERT INTO Camp(CampID, Description, MaxPerson, Available)
VALUES (3,'Eco-cabin, 5m x 2m', 2, true);

//Insert data into E_Account
INSERT INTO E_Account(Account_ID,RFID_code,First_Name,Last_Name,Phone,E_mail,Balance,Payment_Status,Pay_InAdvance)
VALUES(1,null,'Martin', 'Tailor','062315298','martin@gmail.com', 0.0, false, false);
INSERT INTO E_Account(Account_ID,RFID_code,First_Name,Last_Name,Phone,E_mail,Balance,Payment_Status,Pay_InAdvance)
VALUES(2,null,'Ron', 'Williams','063789502','ron_will@gmail.com', 0.0, true, true);
INSERT INTO E_Account(Account_ID,RFID_code,First_Name,Last_Name,Phone,E_mail,Balance,Payment_Status,Pay_InAdvance)
VALUES(3,null,'Mike', 'Copperfield','06235603','Mike@gmail.com', 0.0, true, true);
INSERT INTO E_Account(Account_ID,RFID_code,First_Name,Last_Name,Phone,E_mail,Balance,Payment_Status,Pay_InAdvance)
VALUES(4,null,'Chris', 'Miller','06235963','Chirs@gmail.com', 0.0, false, false);
INSERT INTO E_Account(Account_ID,RFID_code,First_Name,Last_Name,Phone,E_mail,Balance,Payment_Status,Pay_InAdvance)
VALUES(5,null,'Norman', 'Devid','06621553','Devil@gmail.com', 0.0, false, false);
INSERT INTO E_Account(Account_ID,RFID_code,First_Name,Last_Name,Phone,E_mail,Balance,Payment_Status,Pay_InAdvance)
VALUES(6,null,'Joe', 'North','06233366','Joe@gmail.com', 0.0, true, true);
INSERT INTO E_Account(Account_ID,RFID_code,First_Name,Last_Name,Phone,E_mail,Balance,Payment_Status,Pay_InAdvance)
VALUES(7,null,'Alice', 'Simpson','06362145','AliceSim@gmail.com', 0.0, true, true);

//Insert data into Camping_res
INSERT INTO CAMPING_RES(CampRes_No, Account_ID, CAMP_CampID, Start_Date, End_Date) 
VALUES (1,2,1, STR_TO_DATE('31-10-2015', '%d-%m-%Y'), STR_TO_DATE('02-10-2015', '%d-%m-%Y'));
INSERT INTO CAMPING_RES(CampRes_No, Account_ID, CAMP_CampID, Start_Date, End_Date) 
VALUES (2,1,2, STR_TO_DATE('31-10-2015', '%d-%m-%Y'), STR_TO_DATE('03-10-2015', '%d-%m-%Y'));
INSERT INTO CAMPING_RES(CampRes_No, Account_ID, CAMP_CampID, Start_Date, End_Date) 
VALUES (3,3,3, STR_TO_DATE('01-11-2015', '%d-%m-%Y'), STR_TO_DATE('02-10-2015', '%d-%m-%Y'));

//Insert data into groupmembers
INSERT INTO GROUPMEMBERS (GroupID, Co_email, CampRes_No, Check_in) VALUES (1, 'Chirs@gmail.com', 1, false);
INSERT INTO GROUPMEMBERS (GroupID, Co_email, CampRes_No, Check_in) VALUES (1, 'Joe@gmail.com', 1, false);
INSERT INTO GROUPMEMBERS (GroupID, Co_email, CampRes_No, Check_in) VALUES (1, 'AliceSim@gmail.com', 1, false);
INSERT INTO GROUPMEMBERS (GroupID, Co_email, CampRes_No, Check_in) VALUES (1, 'ron_will@gmail.com', 1, false);
INSERT INTO GROUPMEMBERS (GroupID, Co_email, CampRes_No, Check_in) VALUES (2, 'Devil@gmail.com', 2, false);

//Insert data into food
INSERT INTO FOOD(Food_ID, Food_Name, Food_Quantity, Food_Price) VALUES (1,'Big Burger', 150, 5.50);
INSERT INTO FOOD(Food_ID, Food_Name, Food_Quantity, Food_Price) VALUES (2,'French Fries', 150, 5.00);
INSERT INTO FOOD(Food_ID, Food_Name, Food_Quantity, Food_Price) VALUES (3,'Chicken Burger', 15, 4.50);
INSERT INTO FOOD(Food_ID, Food_Name, Food_Quantity, Food_Price) VALUES (4,'Salads', 60, 2.50);
INSERT INTO FOOD(Food_ID, Food_Name, Food_Quantity, Food_Price) VALUES (5,'Heniken Beer', 250, 1.50);
INSERT INTO FOOD(Food_ID, Food_Name, Food_Quantity, Food_Price) VALUES (6,'Coca-cola', 550, 1.20);

//Insert data into f_invoice
INSERT INTO F_INVOICE(Food_InvoiceID, SoldDate, Account_ID) VALUES (1, STR_TO_DATE('02-11-2015', '%d-%m-%Y'), 1);
INSERT INTO F_INVOICE(Food_InvoiceID, SoldDate, Account_ID) VALUES (2, STR_TO_DATE('03-11-2015', '%d-%m-%Y'), 2);
INSERT INTO F_INVOICE(Food_InvoiceID, SoldDate, Account_ID) VALUES (3, STR_TO_DATE('04-11-2015','%d-%m-%Y'), 3);

//Insert data into food_invoice
INSERT INTO FOOD_INVOICE(Quantity_Sold, Food_InvoiceID, Food_ID) VALUES (2, 1, 1);
INSERT INTO FOOD_INVOICE(Quantity_Sold, Food_InvoiceID, Food_ID) VALUES (1, 1, 2);
INSERT INTO FOOD_INVOICE(Quantity_Sold, Food_InvoiceID, Food_ID) VALUES (2, 1, 6);

INSERT INTO FOOD_INVOICE(Quantity_Sold, Food_InvoiceID, Food_ID) VALUES (1, 2, 1);
INSERT INTO FOOD_INVOICE(Quantity_Sold, Food_InvoiceID, Food_ID) VALUES (2, 2, 3);
INSERT INTO FOOD_INVOICE(Quantity_Sold, Food_InvoiceID, Food_ID) VALUES (2, 2, 6);

//Insert data into MATERIAL
INSERT INTO Material(Material_ID, Name, Deposit_Amount, Loaning_Price, Description, Material_Quantity) 
VALUES (1,'USB Cable',1.00,1.50,'USB cable for charging phone',50);
INSERT INTO Material(Material_ID, Name, Deposit_Amount, Loaning_Price, Description, Material_Quantity) 
VALUES (2,'Charger for laptop',2.00,2.50,'',30);
INSERT INTO Material(Material_ID, Name, Deposit_Amount, Loaning_Price, Description, Material_Quantity) 
VALUES (3,'USB Device',1.00,1.50,'USB device, capacity 8GB',20);
INSERT INTO Material(Material_ID, Name, Deposit_Amount, Loaning_Price, Description, Material_Quantity) 
VALUES (4,'Camera',11.50,10.00,'Canon cammera, 8GB, 2000x5000 pixels',20);

//Insert data into M_Invoice
INSERT INTO M_INVOICE(Material_InvoiceID, Start_Date, Account_ID) 
VALUES (1,STR_TO_DATE('02-11-2015', '%d-%m-%Y'),1);
INSERT INTO M_INVOICE(Material_InvoiceID, Start_Date, Account_ID) 
VALUES (2,STR_TO_DATE('01-11-2015', '%d-%m-%Y'),2);
INSERT INTO M_INVOICE(Material_InvoiceID, Start_Date, Account_ID) 
VALUES (3,STR_TO_DATE('01-11-2015', '%d-%m-%Y'),3);

//Insert data into Material_Invoice
INSERT INTO MATERIAL_INVOICE (Material_Quantity, Material_ID, Material_InvoiceID, ReturnDate) VALUES (1, 1, 1, STR_TO_DATE('05-11-2015', '%d-%m-%Y'));
INSERT INTO MATERIAL_INVOICE (Material_Quantity, Material_ID, Material_InvoiceID, ReturnDate) VALUES (1, 1, 2, STR_TO_DATE('05-11-2015', '%d-%m-%Y'));
INSERT INTO MATERIAL_INVOICE (Material_Quantity, Material_ID, Material_InvoiceID, ReturnDate) VALUES (1, 2, 3, STR_TO_DATE('05-11-2015', '%d-%m-%Y'));
INSERT INTO MATERIAL_INVOICE (Material_Quantity, Material_ID, Material_InvoiceID, ReturnDate) VALUES (1, 4, 3, STR_TO_DATE('05-11-2015', '%d-%m-%Y'));
