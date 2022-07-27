insert into clientes values(1,'105440168','Maria','Rodriguez','F','2000-05-10');
insert into clientes values(2,'704560845','Manuel','Alvares','M','1999-03-26');
insert into clientes values(3,'204610842','Andrea','Araya','F','2005-03-15');
insert into clientes values(4,'404650106','Valeria','Alfaro','F','2002-06-30');
insert into clientes values(5,'304190674','Sebastian','Ruiz','M','1995-02-15');

insert into productos values (1,'Leche',1000);
insert into productos values (2,'Carne',3950);
insert into productos values (3,'Arroz',1500);
insert into productos values (4,'Frijoles',1100);
insert into productos values (5,'Atun',500);

insert into compras values (1,1,current_date);
insert into compras values (2,5,current_date);
insert into compras values (3,4,current_date);
insert into compras values (4,2,current_date);
insert into compras values (5,3,current_date);

select * from productos;
select * from clientes;
select * from compras;
