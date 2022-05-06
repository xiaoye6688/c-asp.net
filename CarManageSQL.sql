--判断是否存在CarManage数据库，如果存在则删除
if exists(select * from sys.databases where name='CarManage')
drop database CarManage
go
--创建数据库CarManage
create database CarManage
go
--使用CarManage
use CarManage
go
--表： CommunityInfo（小区信息表）
create table CommunityInfo
(
CId	int primary key identity(1,1),--小区编号	主键,自动增长列
CommunityName	nvarchar(50) not null--小区名称	不允许为空
)
go
--表：CarRecord（车辆出入记录表）
create table CarRecord
(
CarId	int primary key identity(1,1),--车辆记录编号	主键,自动增长列
Name	nvarchar(50) not null,--车主姓名	不允许为空
Mobile	nvarchar(11)	 not null,--车主联系电话	不允许为空
CarName	nvarchar(30) not null,--车辆名称	不允许为空
CarNo	nvarchar(20) not null,--车牌号	不允许为空
CarType	nvarchar(20) not null,--车型	不允许为空（轿车、SUV、跑车等等）
DriveTime datetime not null,--驶入/驶出时间	不允许为空
State	int not null,--进出状态 	值为1或2，分别表示：1：驶入  2：驶出
Type	int not null,--停车类型 	值为1或2，分别表示：1：已授权 2：临时停车
CId	int references CommunityInfo(CId)--小区编号 	外键，车辆出入小区所属小区编号
)
go
insert CommunityInfo values('万科城')
insert CommunityInfo values('升龙国际中心')
insert CommunityInfo values('碧桂园西湖')
insert CommunityInfo values('谦祥万和城')
insert CommunityInfo values('恒大绿洲')
go
insert CarRecord values('司腾','18678936732','大众辉腾','豫A88888','豪华轿车',GETDATE(),1,2,1)
insert CarRecord values('秦放','15878936731','劳斯莱斯','豫A66666','豪华轿车',GETDATE(),2,2,2)
insert CarRecord values('白金','18677756798','凯迪拉克','豫A55555','跑车',GETDATE(),1,1,3)
insert CarRecord values('白英','13478936831','宝马','豫A99999','SUV',GETDATE(),2,1,4)
insert CarRecord values('颜福瑞','15672736782','奥迪','豫A22222','豪华轿车',GETDATE(),1,2,5)
go
select * from CommunityInfo
select * from CarRecord