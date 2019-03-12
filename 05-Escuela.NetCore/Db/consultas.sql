-- SQLite
select * from carreras;
pragma table_info('carreras');

insert into carreras (nombre, plan) values
    ('Sistemas Computacionales', 'Trimestral'),
    ('Ingenieria Civil', 'Trimestral'),
    ('Administracion', 'Semestral');