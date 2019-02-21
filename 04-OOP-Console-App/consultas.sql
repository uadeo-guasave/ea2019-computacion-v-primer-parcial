-- SQLite
select * from alumnos;
select * from carreras;
select * from materias;
select * from docentes;
select * from calificaciones;

select a.nombre || ' ' || a.apellidos 'alumno',
       c.nombre 'carrera'
  from alumnos a
  join carreras c
    on a.carreraid = c.id;

insert into materias (nombre, periodo, horas, creditos, carreraid)
values
    ('Computacion V', 5, 4, 10, 1),
    ('Base de datos', 5, 4, 9, 1),
    ('Arquitectura de Computadoras', 5, 3, 8, 1);
select * from materias;

insert into docentes (nombre, rfc)
values
    ('Bidkar Aragon Cardenas', 'AACB791201XYZ'),
    ('Jose Luis Gaxiola Castro', 'GACA650101XYZ'),
    ('Jesus Lopez Figueroa', 'LOFJ700101XYZ');

insert into calificaciones (fecha,alumnoid,docenteid,materiaid,nota,periodo)
values
    ('2019-02-21',1,1,1,10,'Parcial1'),
    ('2019-03-21',1,1,1,10,'Parcial2'),
    ('2019-04-21',1,1,1,10,'Parcial3');