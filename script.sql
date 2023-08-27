create database C_SHARP_TEST;
use C_SHARP_TEST;

show tables;
create table items(
id INT not null PRIMARY key,
name VARCHAR(50) not null
);

insert into items (id, name) values(1, "Item 1");
select * from items;