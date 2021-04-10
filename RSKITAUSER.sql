create table Login
( 
Id_User int primary key identity(1,1) not null, 
Nama_User varchar(50) NULL,
Email_User varchar(50) NOT NULL,
Password_User varchar(50) NOT NULL)
Profile_image VARCHAR(50) NULL)
Ttl_User date NULL,
Gender_User char(1) check(Gender_User='L' or Gender_User='P'),
No_User varchar (20) NULL,
Address_User varchar(200) NULL)

insert into Login values('admin', 'admin@mail.com', 'admin','admin.jpg')
insert into Login values('admin', 'admin@mail.com', 'admin')
insert into Login values('CMDR', 'cmdr@mail.com', 'admin','2000-02-02', 'L', '08190177013', 'Sol')
INSERT INTO Login VALUES ('resr','123','123','2000/12/20 00:00:00','L','123','123')

SELECT Nama_User from Login

UPDATE Login
SET profile_image = 'admin.jpg' 
WHERE Id_User = 1;

select * from Login where Email_User;

SELECT 
  SCHEMA_NAME(schema_id) AS [Schema], 
  name AS [Table]
FROM sys.tables
WHERE OBJECTPROPERTY(object_id, 'TableHasPrimaryKey') = 1
ORDER BY [Schema], [Table];
drop table Login


create table Pasien(
Id_user char(5) primary key not null, 
Nama_User varchar(50) NULL,
Email_User varchar(50) NULL,
Password_Userr varchar(50) NOT NULL,
Gender char(1) check(gender='L' or gender='P'),
TanggalLahir_User datetime NULL,
No_User varchar (20) NULL,
Address_User varchar(200) NULL)
drop table Pasien


create table RSProfile(
Id_rs char(5) primary key not null,
Nama_rs varchar(50) null,
Alamat_rs varchar(200) null,
Rate_rs DECIMAL (3,2) null,
RS_image VARCHAR(50) NOT NULL,
Id_doct char(5) foreign key references DoctProfile (Id_doct))

insert into RSProfile values('1', 'SCP Foundation','col 285 sector site-12', '5','RS1.jpg', '4')
insert into RSProfile values('2', 'Umbrella Corporation','Central England', '5','RS2.jpg', '2')
insert into RSProfile values('3', 'Rhodes Island','Lungmen, Ursus, Kadzel', '5','RS3.jpg', '3')
insert into RSProfile values('4', 'Dr.Zed Medical Clinic','Pandora, Santuary','5','RS5.jpg', '5')
select *  from RSProfile where Id_doct = '1'
SELECT * FROM RSProfile WHERE Nama_rs = 'Rhodes Island'

UPDATE RSProfile
SET Id_doct = '5' 
WHERE Id_rs = 4;
                      
drop table RSProfile

create table DoctProfile(
Id_doct char(5) primary key not null,
Nama_doct varchar(50) null,
Spesialis_doct varchar(50) null,
DR_image VARCHAR(50) NOT NULL,
Biaya_doct int not null)


Insert into DoctProfile values('1', 'Dr.Who?', 'Perjalanan Waktu','Dr1.jpg','98000')
Insert into DoctProfile values('2', 'Dr.Oswell E.Spencer', 'T-Virus','Dr2.jpg','125000')
Insert into DoctProfile values('3', 'Dr.Kaltsit', 'Oripathy','Dr3.jpg','50000')
Insert into DoctProfile values('4', 'Dr.Bright', 'Bioengineering and Abnormal Genetics','Dr4.jpg','120000')
Insert into DoctProfile values('5', 'Dr.Zed', 'Membuat Orang Tetap Hidup','Dr5.jpg','85000')


SELECT * FROM DoctProfile WHERE Id_doct = '3'
UPDATE DoctProfile
SET Spesialis_doct = 'Bioengineering' 
WHERE Id_doct = 4;
select * from DoctProfile
SELECT Biaya_doct FROM DoctProfile WHERE Id_doct = '1'

drop table DoctProfile
create table Jadwal_Konsultasi(
Id_jadwal int Primary key identity(1,1) not null,
ttl_konsult date not null,
Jam_Konsult varchar (50) not null
)
drop table Jadwal_Konsultasi
select * from Jadwal_Konsultasi

drop table Jadwal_Konsultasi
create table Pembayaran(
Kd_pembayaran int primary key identity(1,1) not null,
Total_pembayaran int null)


drop table Pembayaran

create table Pendaftaran(
Kd_antrian int primary key identity(1,1) not null,
Jam_konsultasi varchar(50) null,
Tgl_Konsultasi date null,
Id_user int foreign key references Login(Id_User),
Id_rs char(5) foreign key references RSProfile(Id_rs),
Id_doct char(5) foreign key references DoctProfile(Id_doct))

select * from pendaftaran

drop table Pendaftaran