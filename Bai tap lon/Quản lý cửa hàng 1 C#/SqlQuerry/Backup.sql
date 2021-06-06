--Xoa file backup
--USE qlbh
--GO
--IF EXISTS(SELECT NAME FROM sp_addumpdevice WHERE NAME='D:\qlbh_Backup')
--EXEC sp_dropdevice 'D:\qhbh_Backup'

--EXEC sp_helpdevice

--Tao file backup
--EXEC sp_addumpdevice 'disk','qhbh_Backup','D:\Program Files\Microsoft SQL Server\data\MSSQL\BACKUP\qhbh_Backup.BAK'
--EXEC sp_addumpdevice 'disk','qhbh_Backup','D:\qhbh_Backup.BAK'

--Thuc hien sao luu
BACKUP DATABASE qlbh TO DISK=N'D:\qlbh_saoluu'
WITH INIT

--Thuc hien khoi phuc
USE Northwind
RESTORE DATABASE qlbh
FROM DISK=N'D:\qlbh_saoluu'
WITH REPLACE