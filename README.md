TrainNetCore2_1
# DotNetCore 2.1 
## General Command 
create -> dotnet new mvc
 
## Nuget

### EF Core
```
dotnet add package Microsoft.EntityFrameworkCore.Tools.DotNet 
```
### EF Core Design
```
dotnet add package Microsoft.EntityFrameworkCore.Design
```
 
### EF Resotre อัพเดทหลังเพิ่ม Package
```
dotnet restore 
```

## Entity Framwork Core 2.1 Command 
เชื่อม Database with vscode efcore{ 
//แบบปกติ 
-> dotnet ef dbcontext scaffold "Server=DESKTOP-ASDASD\SQLEXPRESS;Database=TEST;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models 
 
//แบบเชื่อม Server จริง 
-> dotnet ef dbcontext scaffold "data source=_serverhost_; initial catalog=_databasename_; persist security info=True; user id=_idDatabase_; password=_pass_; multipleactiveresultsets=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models/DB 
} 
 
น่าจะเป็น Backup -> dotnet ef migration add init_Database //init_Database เปลี่ยนเป็นชื่อต่างๆได้ 
 
update ef -> dotnet ef database update 
**จะมีปัญหา เจอ Model ซ้ำ ให้ลบข้อมูลใน method "Up" แล้วทำการอัพเดทใหม่ 
 
อัพเดท Table ผ่าน Code (Code First){ 
-> แก้ Code บน vscode ก่อน (เพิ่ม column ใน model) 
-> dotnet ef migrations add update_product_model //update_product_model *can change 
-> dotnet ef database update 
} 
 
Roleback efcore (ย้อนกลับไป Migrate ที่ต้องการ) -> dotnet ef database update _______ //ชื่อ Migrate ที่ตั้งไว้ 
Delete Migration (ตัวล่าสุด)-> dotnet ef migrations remove

## FIX SQL SERVER
https://blogs.msdn.microsoft.com/walzenbach/2010/04/14/how-to-enable-remote-connections-in-sql-server-2008/
