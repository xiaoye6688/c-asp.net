--�ж��Ƿ����CarManage���ݿ⣬���������ɾ��
if exists(select * from sys.databases where name='CarManage')
drop database CarManage
go
--�������ݿ�CarManage
create database CarManage
go
--ʹ��CarManage
use CarManage
go
--�� CommunityInfo��С����Ϣ��
create table CommunityInfo
(
CId	int primary key identity(1,1),--С�����	����,�Զ�������
CommunityName	nvarchar(50) not null--С������	������Ϊ��
)
go
--��CarRecord�����������¼��
create table CarRecord
(
CarId	int primary key identity(1,1),--������¼���	����,�Զ�������
Name	nvarchar(50) not null,--��������	������Ϊ��
Mobile	nvarchar(11)	 not null,--������ϵ�绰	������Ϊ��
CarName	nvarchar(30) not null,--��������	������Ϊ��
CarNo	nvarchar(20) not null,--���ƺ�	������Ϊ��
CarType	nvarchar(20) not null,--����	������Ϊ�գ��γ���SUV���ܳ��ȵȣ�
DriveTime datetime not null,--ʻ��/ʻ��ʱ��	������Ϊ��
State	int not null,--����״̬ 	ֵΪ1��2���ֱ��ʾ��1��ʻ��  2��ʻ��
Type	int not null,--ͣ������ 	ֵΪ1��2���ֱ��ʾ��1������Ȩ 2����ʱͣ��
CId	int references CommunityInfo(CId)--С����� 	�������������С������С�����
)
go
insert CommunityInfo values('��Ƴ�')
insert CommunityInfo values('������������')
insert CommunityInfo values('�̹�԰����')
insert CommunityInfo values('ǫ����ͳ�')
insert CommunityInfo values('�������')
go
insert CarRecord values('˾��','18678936732','���ڻ���','ԥA88888','�����γ�',GETDATE(),1,2,1)
insert CarRecord values('�ط�','15878936731','��˹��˹','ԥA66666','�����γ�',GETDATE(),2,2,2)
insert CarRecord values('�׽�','18677756798','��������','ԥA55555','�ܳ�',GETDATE(),1,1,3)
insert CarRecord values('��Ӣ','13478936831','����','ԥA99999','SUV',GETDATE(),2,1,4)
insert CarRecord values('�ո���','15672736782','�µ�','ԥA22222','�����γ�',GETDATE(),1,2,5)
go
select * from CommunityInfo
select * from CarRecord