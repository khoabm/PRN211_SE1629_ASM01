create database MemberManagement

use MemberManagement

create table Member(
	id int identity(1,1),
	email varchar(50),
	password varchar(30),
	member_name varchar(30),
	city varchar(30),
	country varchar(30)
)

insert into Member values('mem1', '123456', 'Khoa', 'HCM', 'Vietnam')
insert into Member values('mem2', '123456', 'Nguyen', 'HCM', 'Vietnam')
insert into Member values('mem3', '123456', 'Khai', 'HCM', 'Vietnam')
insert into Member values('mem4', '123456', 'Hoang', 'HCM', 'Vietnam')
insert into Member values('mem5', '123456', 'Nhat', 'HCM', 'Vietnam')

select * from Member