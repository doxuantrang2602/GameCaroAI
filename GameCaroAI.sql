create database GameCaroAI
go
use GameCaroAI
go

create table Rules
(
	RuleID nvarchar(20) not null,
	RuleName nvarchar(100),
	constraint PK_Rules primary key(RuleID)
)
go

-- Chưa thêm rì
