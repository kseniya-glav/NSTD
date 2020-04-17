create table public."Банки"
(
    "Код_банка"       serial not null
        constraint "Банки_pk"
            primary key,
    "Название_банка"  varchar(20),
    "Адрес_банка"     varchar(20),
    "Реквизиты_банка" varchar(20)
);

alter table public."Банки"
    owner to postgres;

create table public."Автопрокаты"
(
    "Название_автопроката"    varchar(20),
    "Код_автопроката"         serial not null
        constraint "Автопрокаты_pk"
            primary key,
    "Собственник_автопроката" varchar(20),
    "Адрес_автопроката"       varchar(20),
    "Расчетный_счет"          varchar(20),
    "Код_банка"               integer
        constraint "Автопрокаты_Банки_Код_банка_fk"
            references public."Банки"
            on update cascade on delete cascade
);

alter table public."Автопрокаты"
    owner to postgres;

create unique index "Автопрокаты_Код_автопроката_uindex"
    on public."Автопрокаты" ("Код_автопроката");

create unique index "Банки_Код_банка_uindex"
    on public."Банки" ("Код_банка");

create table public."Диллеры"
(
    "Код_диллера"    serial not null
        constraint "Диллеры_pk"
            primary key,
    "Название_фирмы" varchar(20),
    "Адрес_фирмы"    varchar(20),
    "ФИО_владельца"  varchar(20),
    "Расчетный_код"  varchar(20),
    "Код_банка"      integer
        constraint "Диллеры_Банки_Код_банка_fk"
            references public."Банки"
            on update cascade on delete cascade
);

alter table public."Диллеры"
    owner to postgres;

create unique index "Диллеры_Код_диллера_uindex"
    on public."Диллеры" ("Код_диллера");

create table public."Типы"
(
    "Код_типа"      integer not null
        constraint "Типы_pk"
            primary key,
    "Название_типа" varchar(20)
);

alter table public."Типы"
    owner to postgres;

create unique index "Типы_Код_типа_uindex"
    on public."Типы" ("Код_типа");

create table public."Арендаторы"
(
    "Номер_паспорта"   varchar(20) not null
        constraint "Арендаторы_pk"
            primary key,
    "ФИО_арендатора"   varchar(20),
    "Адрес_арендатора" varchar(20),
    "Возраст"          integer
);

alter table public."Арендаторы"
    owner to postgres;

create unique index "Арендаторы_Номер_паспорта_uindex"
    on public."Арендаторы" ("Номер_паспорта");


create table public."Марки"
(
    "Код_марки"      serial not null
        constraint "Марки_pk"
            primary key,
    "Название_марки" varchar(20),
    "Дата_создания"  date,
    "Название_страны"  varchar(20)
);
alter table public."Марки"
    owner to postgres;

create table public."Модели"
(
    "Код_модели"      serial not null
        constraint "Модели_pk"
            primary key,
    "Код_марки"       integer
        constraint "Модели_Марки_Код_марки_fk"
            references public."Марки"
            on update cascade on delete cascade,
    "Код_типа"        integer
        constraint "Модели_Типы_Код_типа_fk"
            references public."Типы"
            on update cascade on delete cascade,
    "Название_модели" varchar(20)
);

alter table public."Модели"
    owner to postgres;

create table public."Автомобили"
(
    "Номер_автомобиля" serial not null
        constraint "Автомобили_pk"
            primary key,
    "Код_модели"       integer
        constraint "Автомобили_Модели_Код_модели_fk"
            references public."Модели"
            on update cascade on delete cascade,
    "Основной_цвет"    varchar(20),
    "Состояние"        varchar(20),
    "Код_диллера"      integer
        constraint "Автомобили_Диллеры_Код_диллера_fk"
            references public."Диллеры"
            on update cascade on delete cascade,
    "Цена_за_сутки"    integer,
    "Код_автопроката"  integer
        constraint "Автомобили_Автопрокаты_Код_автопр"
            references public."Автопрокаты"
            on update cascade on delete cascade
);

alter table public."Автомобили"
    owner to postgres;

create unique index "Автомобили_Номер_автомобиля_uindex"
    on public."Автомобили" ("Номер_автомобиля");

create unique index "Модели_Код_модели_uindex"
    on public."Модели" ("Код_модели");

create unique index "Марки_Код_марки_uindex"
    on public."Марки" ("Код_марки");

create table public."Квитанция"
(
    "Номер_автомобиля" integer not null
        constraint "Квитанция_Автомобили_Номер_автомо"
            references public."Автомобили"
            on update cascade on delete cascade,
    "Время_выдачи"     date    not null,
    "Номер_паспорта"   varchar(20)
        constraint "Квитанция_Арендаторы_Номер_паспор"
            references public."Арендаторы"
            on update cascade on delete cascade,
    "Время_сдачи"      date,
    "Залог"            integer,
    constraint "Квитанция_pk"
        primary key ("Номер_автомобиля", "Время_выдачи")
);

alter table public."Квитанция"
    owner to postgres;

create unique index "Квитанция_Номер_автомобиля_uindex"
    on public."Квитанция" ("Номер_автомобиля");

create table public."Уровни_доступа"
(
    id                serial not null
        constraint "Уровни_доступа_pk"
            primary key,
    "Уровень_доступа" varchar(10)
);

alter table public."Уровни_доступа"
    owner to postgres;

create table public.users
(
    id             serial not null
        constraint users_pk
            primary key,
    login          varchar(20),
    prefixpassword varchar(36),
    hashpassword   varchar(40),
    level          integer
        constraint "users_Уровни_доступа_id_fk"
            references public."Уровни_доступа"
            on update cascade on delete cascade,
    date           date
);

create table _fields
(
    field_name    varchar(50),
    table_name    varchar(50),
    field_type    varchar(50),
    transl_fn     varchar(50),
    category_name varchar(50)
);

alter table _fields
    owner to postgres;

create table _reltable
(
    table1    varchar(50) not null,
    table2    varchar(50),
    relations text,
    via       varchar(50)
);

alter table _reltable
    owner to postgres;


--1--Типы есть
insert into "Типы"("Код_типа","Название_типа")
values (1,'Универсал'),
       (2,'Лифтбек'),
       (3,'Седан'),
       (4,'Кроссовер'),
       (5,'Фургон'),
       (6,'Хетчбек');
--3--Марки есть
insert into "Марки" values
(1,'LADA','01-06-1966','Россия'),
(2,'ГАЗ','01-01-1932','Россия');
--4--Модели есть
insert into "Модели"
values (1,1,1,'Largus'),
       (2,1,2,'Granta'),
       (3,1,3,'Vesta'),
       (4,1,4,'X-Ray Cross'),
       (5,1,1,'Kalina'),
       (6,2,5,'Next'),
       (7,2,3,'Siber');
--5--Банки есть
insert into "Банки"
values (1,'СберБанк','Москва','00000000000000000001'),
       (2,'Урал ФД','Пермь','00000000000000000002'),
       (3,'ВТБ','Санкт-Петербург','00000000000000000003');
--6--Автопрокаты есть
insert into "Автопрокаты"
values ('Автопрокат1',1,'Иванов А.А.','Пермь','13245655345643456345',1),
       ('Автопрокат3',3,'Гордеев М.В.','Пермь','34567897654321345677',1),
       ('Прокат 1',7,'Искаков А.А.','Пермь','12345678976543234564',2),
       ('Прокат 2',8,'Петров А.А.','Уфа','23356576645334565434',3);
--7--Дилеры есть
insert into "Диллеры"
values (1,'КАМСКАЯ ДОЛИНА','Пермь','Ежков А.П.','12315656490121856789',1),
       (2,'Форвард-Авто','Екатеринбург','Бурков П.П.','5645645456234567890',2),
       (3,'ДАВ-АВТО','Березники','Петров Н.А.','09874897658895614821',3);
--8--Арендаторы есть
insert into "Арендаторы"
values ('154896','Антонов А.А.','Пермь',19),
       ('654645','Пузиков П.П.','Лысьва',25),
       ('7848547','Ковалёв К.К.','Куеда',32);
--9--Автомобили есть
insert into "Автомобили"
values (1,3,'-16777216','хорошо',1,510,7),
       (2,4,'-65536','отлично',1,500,7),
       (3,1,'-32768','хорошо',2,240,3),
       (4,6,'-8355712','хорошо',3,5000,3),
       (5,2,'-3126824','хорошо',1,2500,1),
       (6,7,'-8372160','хорошо',3,5555,8);
--10--Квитанция есть
insert into "Квитанция"
values (1,'12-03-2018','154896','14-03-2018',2000),
       (2,'12-03-2018','654645','12-03-2018',1500),
       (3,'15-06-2018','7848547','15-06-2018',2000),
       (4,'15-08-2019','7848547','18-09-2019',5000),
       (5,'08-09-2019','154896','09-12-2019',10000),
       (6,'21-01-2020','154896','08-02-2020',1000);

--13--
insert into _fields
values --(NULL,NULL,NULL,'--------Автопрокаты-----------',NULL),
       (N'Название_автопроката', N'Автопрокаты', N'varchar', N'Название автопроката', N'Автопрокаты'),
       (N'Адрес_автопроката', N'Автопрокаты',N'varchar', N'Адрес автопроката', N'Автопрокаты'),
       (N'Собственник_автопроката', N'Автопрокаты',N'varchar', N'Собственник автопроката', N'Автопрокаты'),
       (N'Расчетный_счет', N'Автопрокаты', N'varchar', N'Расчетный счет автопроката', N'Автопрокаты'),
      -- (NULL,NULL,NULL,'--------Автомобили-----------',NULL),
       (N'Состояние', N'Автомобили', N'varchar', N'Состояние', N'Автопрокаты'),
       (N'Цена_за_сутки', N'Автомобили', N'int', N'Цена за сутки', N'Автомобили'),
      -- (NULL,NULL,NULL,'--------Модели-----------',NULL),
       (N'Название_модели', N'Модели',N'varchar', N'Название модели', N'Модели'),
      -- (NULL,NULL,NULL,'--------Марки-----------',NULL),
       (N'Название_марки', N'Марки',N'varchar', N'Название марки', N'Марки'),
       (N'Название_страны', N'Марки', N'varchar', N'Название страны производителя', N'Марки'),
       (N'Дата_создания', N'Марки', N'Date', N'Дата создания', N'Марки');

--14--
insert into _reltable values
(N'Автопрокаты ', N'Автомобили', N'Автопрокаты.Код_автопроката=Автомобили.Код_автопроката', NULL),
(N'Автопрокаты', N'Модели', NULL, N'Автомобили'),
 (N'Автомобили', N'Модели', N'Автомобили.Код_модели  = Модели.Код_модели', NULL),
(N'Автомобили', N'Марки', NULL, N'Модели'),
 (N'Модели', N'Марки', N'Модели.Код_марки = Марки.Код_марки', NULL),
 (N'Модели ', N'Автопрокаты', NULL, N'Автомобили'),
 (N'Автомобили', N'Автопрокаты', N'Автопрокаты.Код_автопроката=Автомобили.Код_автопроката', NULL),
(N'Автопрокаты', N'Марки', NULL, N'Автомобили'),
(N'Марки ', N'Автопрокаты', NULL, N'Модели');


delete from "Автомобили";
delete from "Автопрокаты";
delete from "Арендаторы";
delete from "Банки";
delete from "Диллеры";
delete from "Квитанция";
delete from "Марки";
delete from "Модели";
delete from "Типы";
delete from _reltable;
delete from _fields;