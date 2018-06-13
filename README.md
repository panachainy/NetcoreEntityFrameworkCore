# DotNetCore 2.1
## General Command
### Create WebMVC
```
dotnet new mvc
```
### Create WebAPI
```
dotnet new webapi
```

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

### เชื่อม Database with vscode efcore
แบบปกติ
```
dotnet ef dbcontext scaffold "Server=_ServerName_;Database=_DatabaseName_;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models/DB
```
 
แบบ Server จริง
```
dotnet ef dbcontext scaffold "data source=_serverhost_; initial catalog=_databasename_; persist security info=True; user id=_idDatabase_; password=_pass_; multipleactiveresultsets=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models/DB 
```

### Migration
```
dotnet ef migration add init_Database //init_Database เปลี่ยนเป็นชื่อต่างๆได้ 
```

update ef **จะมีปัญหา เจอ Model ซ้ำ ให้ลบข้อมูลใน method "Up" แล้วทำการอัพเดทใหม่
```
dotnet ef database update 
```

อัพเดท Table ผ่าน Code (Code First)
- แก้ Code บน vscode ก่อน (เพิ่ม column ใน model)
```
dotnet ef migrations add update_product_model
dotnet ef database update 
```
 
Roleback efcore (ย้อนกลับไป Migrate ที่ต้องการ)
```
dotnet ef database update _______ //ชื่อ Migrate ที่ตั้งไว้
```

Delete Migration (ตัวล่าสุด)
```
dotnet ef migrations remove
```

## FIX SQL SERVER


* [SQLSERVER 2008](https://blogs.msdn.microsoft.com/walzenbach/2010/04/14/how-to-enable-remote-connections-in-sql-server-2008/) - Fix Remote Local

## Contact ME
* [Medium](https://medium.com/@panachai.ny) - Blog
* [Github](https://github.com/panachai) - Repository Public
* [Facebook](https://www.facebook.com/panachaiNY) - Social
* [Gmail](https://mail.google.com/mail?view=cm&tf=0+&to=panachai.ny@gmail.com+&su=ContactfromGithub+&body=ใส่เนื้อหา) - panachai.ny@gmail.com