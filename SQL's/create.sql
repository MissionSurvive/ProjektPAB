/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     13.12.2023 13:25:44                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HISTORIA_ZAMOWIENIA') and o.name = 'FK_HISTORIA_HISTORIA__ZAMOWIEN')
alter table HISTORIA_ZAMOWIENIA
   drop constraint FK_HISTORIA_HISTORIA__ZAMOWIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HISTORIA_ZAMOWIENIA') and o.name = 'FK_HISTORIA_KLIENT_PO_KLIENCI')
alter table HISTORIA_ZAMOWIENIA
   drop constraint FK_HISTORIA_KLIENT_PO_KLIENCI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('HISTORIA_ZAMOWIENIA') and o.name = 'FK_HISTORIA_PRACOWNIK_PRACOWNI')
alter table HISTORIA_ZAMOWIENIA
   drop constraint FK_HISTORIA_PRACOWNIK_PRACOWNI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KLIENCI') and o.name = 'FK_KLIENCI_KONTO_KLI_KONTA_KL')
alter table KLIENCI
   drop constraint FK_KLIENCI_KONTO_KLI_KONTA_KL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KONTA_KLIENTOW') and o.name = 'FK_KONTA_KL_KONTO_KLI_KLIENCI')
alter table KONTA_KLIENTOW
   drop constraint FK_KONTA_KL_KONTO_KLI_KLIENCI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KONTA_KLIENTOW') and o.name = 'FK_KONTA_KL_ROLE_KLIE_ROLE')
alter table KONTA_KLIENTOW
   drop constraint FK_KONTA_KL_ROLE_KLIE_ROLE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KONTA_PRACOWNIKOW') and o.name = 'FK_KONTA_PR_KONTO_PRA_PRACOWNI')
alter table KONTA_PRACOWNIKOW
   drop constraint FK_KONTA_PR_KONTO_PRA_PRACOWNI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('KONTA_PRACOWNIKOW') and o.name = 'FK_KONTA_PR_ROLE_PRAC_ROLE')
alter table KONTA_PRACOWNIKOW
   drop constraint FK_KONTA_PR_ROLE_PRAC_ROLE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MODELE') and o.name = 'FK_MODELE_MARKA_SAM_MARKI')
alter table MODELE
   drop constraint FK_MODELE_MARKA_SAM_MARKI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MODELE') and o.name = 'FK_MODELE_RODZAJ_NA_RODZAJE_')
alter table MODELE
   drop constraint FK_MODELE_RODZAJ_NA_RODZAJE_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRACOWNICY') and o.name = 'FK_PRACOWNI_KONTO_PRA_KONTA_PR')
alter table PRACOWNICY
   drop constraint FK_PRACOWNI_KONTO_PRA_KONTA_PR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRACOWNICY') and o.name = 'FK_PRACOWNI_PRACOWNIK_WYPOZYCZ')
alter table PRACOWNICY
   drop constraint FK_PRACOWNI_PRACOWNIK_WYPOZYCZ
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SAMOCHODY') and o.name = 'FK_SAMOCHOD_MODEL_SAM_MODELE')
alter table SAMOCHODY
   drop constraint FK_SAMOCHOD_MODEL_SAM_MODELE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SAMOCHODY') and o.name = 'FK_SAMOCHOD_RODZAJ_PA_RODZAJE_')
alter table SAMOCHODY
   drop constraint FK_SAMOCHOD_RODZAJ_PA_RODZAJE_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SAMOCHODY') and o.name = 'FK_SAMOCHOD_SAMOCHOD__WYPOZYCZ')
alter table SAMOCHODY
   drop constraint FK_SAMOCHOD_SAMOCHOD__WYPOZYCZ
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ZAMOWIENIA') and o.name = 'FK_ZAMOWIEN_HISTORIA__HISTORIA')
alter table ZAMOWIENIA
   drop constraint FK_ZAMOWIEN_HISTORIA__HISTORIA
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ZAMOWIENIA') and o.name = 'FK_ZAMOWIEN_PAKIET_W__PAKIETY')
alter table ZAMOWIENIA
   drop constraint FK_ZAMOWIEN_PAKIET_W__PAKIETY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ZAMOWIENIA') and o.name = 'FK_ZAMOWIEN_WYPOZYCZA_WYPOZYCZ')
alter table ZAMOWIENIA
   drop constraint FK_ZAMOWIEN_WYPOZYCZA_WYPOZYCZ
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ZAMOWIENIA') and o.name = 'FK_ZAMOWIEN_ZAMOWIENI_KLIENCI')
alter table ZAMOWIENIA
   drop constraint FK_ZAMOWIEN_ZAMOWIENI_KLIENCI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ZAMOWIENIA') and o.name = 'FK_ZAMOWIEN_ZAMOWIONY_SAMOCHOD')
alter table ZAMOWIENIA
   drop constraint FK_ZAMOWIEN_ZAMOWIONY_SAMOCHOD
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HISTORIA_ZAMOWIENIA')
            and   name  = 'KLIENT_POWIAZANY_FK'
            and   indid > 0
            and   indid < 255)
   drop index HISTORIA_ZAMOWIENIA.KLIENT_POWIAZANY_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HISTORIA_ZAMOWIENIA')
            and   name  = 'PRACOWNIK_POWIAZANY_FK'
            and   indid > 0
            and   indid < 255)
   drop index HISTORIA_ZAMOWIENIA.PRACOWNIK_POWIAZANY_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('HISTORIA_ZAMOWIENIA')
            and   name  = 'HISTORIA_ZDARZEN_FK'
            and   indid > 0
            and   indid < 255)
   drop index HISTORIA_ZAMOWIENIA.HISTORIA_ZDARZEN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HISTORIA_ZAMOWIENIA')
            and   type = 'U')
   drop table HISTORIA_ZAMOWIENIA
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KLIENCI')
            and   name  = 'KONTO_KLIENTA2_FK'
            and   indid > 0
            and   indid < 255)
   drop index KLIENCI.KONTO_KLIENTA2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KLIENCI')
            and   type = 'U')
   drop table KLIENCI
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KONTA_KLIENTOW')
            and   name  = 'ROLE_KLIENTOW_FK'
            and   indid > 0
            and   indid < 255)
   drop index KONTA_KLIENTOW.ROLE_KLIENTOW_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KONTA_KLIENTOW')
            and   name  = 'KONTO_KLIENTA_FK'
            and   indid > 0
            and   indid < 255)
   drop index KONTA_KLIENTOW.KONTO_KLIENTA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KONTA_KLIENTOW')
            and   type = 'U')
   drop table KONTA_KLIENTOW
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KONTA_PRACOWNIKOW')
            and   name  = 'KONTO_PRACOWNIKA_FK'
            and   indid > 0
            and   indid < 255)
   drop index KONTA_PRACOWNIKOW.KONTO_PRACOWNIKA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('KONTA_PRACOWNIKOW')
            and   name  = 'ROLE_PRACOWNIKOW_FK'
            and   indid > 0
            and   indid < 255)
   drop index KONTA_PRACOWNIKOW.ROLE_PRACOWNIKOW_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KONTA_PRACOWNIKOW')
            and   type = 'U')
   drop table KONTA_PRACOWNIKOW
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MARKI')
            and   type = 'U')
   drop table MARKI
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MODELE')
            and   name  = 'RODZAJ_NADWOZIA_FK'
            and   indid > 0
            and   indid < 255)
   drop index MODELE.RODZAJ_NADWOZIA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MODELE')
            and   name  = 'MARKA_SAMOCHODU_FK'
            and   indid > 0
            and   indid < 255)
   drop index MODELE.MARKA_SAMOCHODU_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MODELE')
            and   type = 'U')
   drop table MODELE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PAKIETY')
            and   type = 'U')
   drop table PAKIETY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PRACOWNICY')
            and   name  = 'KONTO_PRACOWNIKA2_FK'
            and   indid > 0
            and   indid < 255)
   drop index PRACOWNICY.KONTO_PRACOWNIKA2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PRACOWNICY')
            and   name  = 'PRACOWNIK_WYPOZYCZALNI_FK'
            and   indid > 0
            and   indid < 255)
   drop index PRACOWNICY.PRACOWNIK_WYPOZYCZALNI_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRACOWNICY')
            and   type = 'U')
   drop table PRACOWNICY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RODZAJE_NADWOZIA')
            and   type = 'U')
   drop table RODZAJE_NADWOZIA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('RODZAJE_PALIWA')
            and   type = 'U')
   drop table RODZAJE_PALIWA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ROLE')
            and   type = 'U')
   drop table ROLE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SAMOCHODY')
            and   name  = 'RODZAJ_PALIWA_FK'
            and   indid > 0
            and   indid < 255)
   drop index SAMOCHODY.RODZAJ_PALIWA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SAMOCHODY')
            and   name  = 'SAMOCHOD_W_WYPOZYCZALNI_FK'
            and   indid > 0
            and   indid < 255)
   drop index SAMOCHODY.SAMOCHOD_W_WYPOZYCZALNI_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SAMOCHODY')
            and   name  = 'MODEL_SAMOCHODU_FK'
            and   indid > 0
            and   indid < 255)
   drop index SAMOCHODY.MODEL_SAMOCHODU_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SAMOCHODY')
            and   type = 'U')
   drop table SAMOCHODY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('WYPOZYCZALNIE')
            and   type = 'U')
   drop table WYPOZYCZALNIE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ZAMOWIENIA')
            and   name  = 'HISTORIA_ZDARZEN2_FK'
            and   indid > 0
            and   indid < 255)
   drop index ZAMOWIENIA.HISTORIA_ZDARZEN2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ZAMOWIENIA')
            and   name  = 'WYPOZYCZALNIA_REALIZUJACA_FK'
            and   indid > 0
            and   indid < 255)
   drop index ZAMOWIENIA.WYPOZYCZALNIA_REALIZUJACA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ZAMOWIENIA')
            and   name  = 'PAKIET_W_ZAMOWIENIU_FK'
            and   indid > 0
            and   indid < 255)
   drop index ZAMOWIENIA.PAKIET_W_ZAMOWIENIU_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ZAMOWIENIA')
            and   name  = 'ZAMOWIENIE_KLIENTA_FK'
            and   indid > 0
            and   indid < 255)
   drop index ZAMOWIENIA.ZAMOWIENIE_KLIENTA_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ZAMOWIENIA')
            and   name  = 'ZAMOWIONY_SAMOCHOD_FK'
            and   indid > 0
            and   indid < 255)
   drop index ZAMOWIENIA.ZAMOWIONY_SAMOCHOD_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ZAMOWIENIA')
            and   type = 'U')
   drop table ZAMOWIENIA
go

/*==============================================================*/
/* Table: HISTORIA_ZAMOWIENIA                                   */
/*==============================================================*/
create table HISTORIA_ZAMOWIENIA (
   ID_HISTORIA          numeric              identity,
   ID_PRAC              numeric              not null,
   ID_ZAMOWIENIE        numeric              null,
   ID_KLIENT            numeric              not null,
   DATA_WYDANIE         datetime             not null,
   DATA_PRZYJECIE       datetime             not null,
   TANKOWANIE           bit                  not null,
   ILOSC_TANKOWANIE     decimal(2,0)         null,
   KOSZT_TANKOWANIE     decimal(7,2)         null,
   KOLIZJA              bit                  not null,
   DATA_KOLIZJA         datetime             null,
   KARA_KOLIZJA         decimal(7,2)         null,
   constraint PK_HISTORIA_ZAMOWIENIA primary key nonclustered (ID_HISTORIA)
)
go

/*==============================================================*/
/* Index: HISTORIA_ZDARZEN_FK                                   */
/*==============================================================*/
create index HISTORIA_ZDARZEN_FK on HISTORIA_ZAMOWIENIA (
ID_ZAMOWIENIE ASC
)
go

/*==============================================================*/
/* Index: PRACOWNIK_POWIAZANY_FK                                */
/*==============================================================*/
create index PRACOWNIK_POWIAZANY_FK on HISTORIA_ZAMOWIENIA (
ID_PRAC ASC
)
go

/*==============================================================*/
/* Index: KLIENT_POWIAZANY_FK                                   */
/*==============================================================*/
create index KLIENT_POWIAZANY_FK on HISTORIA_ZAMOWIENIA (
ID_KLIENT ASC
)
go

/*==============================================================*/
/* Table: KLIENCI                                               */
/*==============================================================*/
create table KLIENCI (
   ID_KLIENT            numeric              identity,
   iD_KON_KLIENT        numeric              null,
   IMIE_KLIENT          varchar(40)          not null,
   NAZWISKO_KLIENT      varchar(40)          not null,
   PESEL_KLIENT         decimal(11,0)        null,
   TELEFON_KLIENT       varchar(15)          not null,
   FAX                  varchar(12)          null,
   NIP                  decimal(10,0)        null,
   constraint PK_KLIENCI primary key nonclustered (ID_KLIENT)
)
go

/*==============================================================*/
/* Index: KONTO_KLIENTA2_FK                                     */
/*==============================================================*/
create index KONTO_KLIENTA2_FK on KLIENCI (
iD_KON_KLIENT ASC
)
go

/*==============================================================*/
/* Table: KONTA_KLIENTOW                                        */
/*==============================================================*/
create table KONTA_KLIENTOW (
   iD_KON_KLIENT        numeric              identity,
   ID_ROLA              numeric              not null,
   ID_KLIENT            numeric              not null,
   NAZWA_KLIENT         varchar(100)         not null,
   HASLO_KLIENT         varchar(100)         not null,
   constraint PK_KONTA_KLIENTOW primary key nonclustered (iD_KON_KLIENT)
)
go

/*==============================================================*/
/* Index: KONTO_KLIENTA_FK                                      */
/*==============================================================*/
create index KONTO_KLIENTA_FK on KONTA_KLIENTOW (
ID_KLIENT ASC
)
go

/*==============================================================*/
/* Index: ROLE_KLIENTOW_FK                                      */
/*==============================================================*/
create index ROLE_KLIENTOW_FK on KONTA_KLIENTOW (
ID_ROLA ASC
)
go

/*==============================================================*/
/* Table: KONTA_PRACOWNIKOW                                     */
/*==============================================================*/
create table KONTA_PRACOWNIKOW (
   ID_KON_PRACOWNIK     numeric              identity,
   ID_ROLA              numeric              not null,
   ID_PRAC              numeric              not null,
   NAZWA_PRACOWNIK      varchar(100)         not null,
   HASLO_PRACOWNIK      varchar(100)         not null,
   constraint PK_KONTA_PRACOWNIKOW primary key nonclustered (ID_KON_PRACOWNIK)
)
go

/*==============================================================*/
/* Index: ROLE_PRACOWNIKOW_FK                                   */
/*==============================================================*/
create index ROLE_PRACOWNIKOW_FK on KONTA_PRACOWNIKOW (
ID_ROLA ASC
)
go

/*==============================================================*/
/* Index: KONTO_PRACOWNIKA_FK                                   */
/*==============================================================*/
create index KONTO_PRACOWNIKA_FK on KONTA_PRACOWNIKOW (
ID_PRAC ASC
)
go

/*==============================================================*/
/* Table: MARKI                                                 */
/*==============================================================*/
create table MARKI (
   ID_MARKA             numeric              identity,
   NAZWA_MARKA          varchar(40)          not null,
   KRAJ                 varchar(40)          null,
   REGION               varchar(20)          null,
   constraint PK_MARKI primary key nonclustered (ID_MARKA)
)
go

/*==============================================================*/
/* Table: MODELE                                                */
/*==============================================================*/
create table MODELE (
   ID_MODEL             numeric              identity,
   ID_MARKA             numeric              not null,
   ID_NADWOZIE          numeric              not null,
   NAZWA_MODEL          varchar(20)          null,
   ROCZNIK              decimal(4,0)         not null,
   GENERACJA            decimal(2,0)         null,
   SEGMENT              varchar(20)          not null,
   constraint PK_MODELE primary key nonclustered (ID_MODEL)
)
go

/*==============================================================*/
/* Index: MARKA_SAMOCHODU_FK                                    */
/*==============================================================*/
create index MARKA_SAMOCHODU_FK on MODELE (
ID_MARKA ASC
)
go

/*==============================================================*/
/* Index: RODZAJ_NADWOZIA_FK                                    */
/*==============================================================*/
create index RODZAJ_NADWOZIA_FK on MODELE (
ID_NADWOZIE ASC
)
go

/*==============================================================*/
/* Table: PAKIETY                                               */
/*==============================================================*/
create table PAKIETY (
   ID_PAKIET            numeric              identity,
   NAZWA                varchar(40)          not null,
   ZAWARTOSC            varchar(100)         not null,
   CENA                 decimal(6,2)         not null,
   constraint PK_PAKIETY primary key nonclustered (ID_PAKIET)
)
go

/*==============================================================*/
/* Table: PRACOWNICY                                            */
/*==============================================================*/
create table PRACOWNICY (
   ID_PRAC              numeric              identity,
   ID_KON_PRACOWNIK     numeric              null,
   ID_WYPOZYCZALNIA     numeric              not null,
   IMIE_PRACOWNIK       varchar(40)          not null,
   NAZWISKO_PRACOWNIK   varchar(40)          not null,
   PESEL_PRACOWNIK      decimal(11,0)        null,
   TELEFON_PRACOWNIK    varchar(15)          not null,
   STANOWISKO           varchar(40)          null,
   DATA_ZATRUDNIENIA    datetime             not null,
   WYNAGRODZENIE        decimal(7,2)         not null,
   PREMIA               decimal(6,2)         null,
   constraint PK_PRACOWNICY primary key nonclustered (ID_PRAC)
)
go

/*==============================================================*/
/* Index: PRACOWNIK_WYPOZYCZALNI_FK                             */
/*==============================================================*/
create index PRACOWNIK_WYPOZYCZALNI_FK on PRACOWNICY (
ID_WYPOZYCZALNIA ASC
)
go

/*==============================================================*/
/* Index: KONTO_PRACOWNIKA2_FK                                  */
/*==============================================================*/
create index KONTO_PRACOWNIKA2_FK on PRACOWNICY (
ID_KON_PRACOWNIK ASC
)
go

/*==============================================================*/
/* Table: RODZAJE_NADWOZIA                                      */
/*==============================================================*/
create table RODZAJE_NADWOZIA (
   ID_NADWOZIE          numeric              identity,
   NAZWA_NADWOZIE       varchar(40)          not null,
   constraint PK_RODZAJE_NADWOZIA primary key nonclustered (ID_NADWOZIE)
)
go

/*==============================================================*/
/* Table: RODZAJE_PALIWA                                        */
/*==============================================================*/
create table RODZAJE_PALIWA (
   ID_PALIWO            numeric              identity,
   NAZWA_RODZAJ         varchar(40)          not null,
   constraint PK_RODZAJE_PALIWA primary key nonclustered (ID_PALIWO)
)
go

/*==============================================================*/
/* Table: ROLE                                                  */
/*==============================================================*/
create table ROLE (
   ID_ROLA              numeric              identity,
   ROLA                 varchar(20)          not null,
   constraint PK_ROLE primary key nonclustered (ID_ROLA)
)
go

/*==============================================================*/
/* Table: SAMOCHODY                                             */
/*==============================================================*/
create table SAMOCHODY (
   ID_SAMOCHOD          numeric              identity,
   ID_PALIWO            numeric              not null,
   ID_MODEL             numeric              not null,
   ID_WYPOZYCZALNIA     numeric              not null,
   ZDJECIE              image                null,
   KOLOR                varchar(40)          null,
   PRZEBIEG             decimal(9,0)         not null,
   VIN                  varchar(80)          not null,
   POJEMNOSC            decimal(5,0)         null,
   MOC                  decimal(4,0)         null,
   SKRZYNIA             varchar(40)          not null,
   MIEJSCA              decimal(2,0)         null,
   DOSTEPNOSC           bit                  not null,
   CENA_DZIEN           decimal(5,2)         not null,
   CENA_TYDZIEN         decimal(6,2)         null,
   CENA_MIESIAC         decimal(7,2)         null,
   KAUCJA               decimal(5,2)         null,
   constraint PK_SAMOCHODY primary key nonclustered (ID_SAMOCHOD)
)
go

/*==============================================================*/
/* Index: MODEL_SAMOCHODU_FK                                    */
/*==============================================================*/
create index MODEL_SAMOCHODU_FK on SAMOCHODY (
ID_MODEL ASC
)
go

/*==============================================================*/
/* Index: SAMOCHOD_W_WYPOZYCZALNI_FK                            */
/*==============================================================*/
create index SAMOCHOD_W_WYPOZYCZALNI_FK on SAMOCHODY (
ID_WYPOZYCZALNIA ASC
)
go

/*==============================================================*/
/* Index: RODZAJ_PALIWA_FK                                      */
/*==============================================================*/
create index RODZAJ_PALIWA_FK on SAMOCHODY (
ID_PALIWO ASC
)
go

/*==============================================================*/
/* Table: WYPOZYCZALNIE                                         */
/*==============================================================*/
create table WYPOZYCZALNIE (
   ID_WYPOZYCZALNIA     numeric              identity,
   MIASTO               varchar(40)          not null,
   ADRES                varchar(80)          not null,
   constraint PK_WYPOZYCZALNIE primary key nonclustered (ID_WYPOZYCZALNIA)
)
go

/*==============================================================*/
/* Table: ZAMOWIENIA                                            */
/*==============================================================*/
create table ZAMOWIENIA (
   ID_ZAMOWIENIE        numeric              identity,
   ID_PAKIET            numeric              null,
   ID_HISTORIA          numeric              null,
   ID_WYPOZYCZALNIA     numeric              not null,
   ID_KLIENT            numeric              not null,
   ID_SAMOCHOD          numeric              not null,
   LICZBA_DNI           decimal(3,0)         not null,
   CENA_ZAMOWIENIE      decimal(7,2)         not null,
   DATA_START           datetime             not null,
   DATA_KONIEC          datetime             not null,
   constraint PK_ZAMOWIENIA primary key nonclustered (ID_ZAMOWIENIE)
)
go

/*==============================================================*/
/* Index: ZAMOWIONY_SAMOCHOD_FK                                 */
/*==============================================================*/
create index ZAMOWIONY_SAMOCHOD_FK on ZAMOWIENIA (
ID_SAMOCHOD ASC
)
go

/*==============================================================*/
/* Index: ZAMOWIENIE_KLIENTA_FK                                 */
/*==============================================================*/
create index ZAMOWIENIE_KLIENTA_FK on ZAMOWIENIA (
ID_KLIENT ASC
)
go

/*==============================================================*/
/* Index: PAKIET_W_ZAMOWIENIU_FK                                */
/*==============================================================*/
create index PAKIET_W_ZAMOWIENIU_FK on ZAMOWIENIA (
ID_PAKIET ASC
)
go

/*==============================================================*/
/* Index: WYPOZYCZALNIA_REALIZUJACA_FK                          */
/*==============================================================*/
create index WYPOZYCZALNIA_REALIZUJACA_FK on ZAMOWIENIA (
ID_WYPOZYCZALNIA ASC
)
go

/*==============================================================*/
/* Index: HISTORIA_ZDARZEN2_FK                                  */
/*==============================================================*/
create index HISTORIA_ZDARZEN2_FK on ZAMOWIENIA (
ID_HISTORIA ASC
)
go

alter table HISTORIA_ZAMOWIENIA
   add constraint FK_HISTORIA_HISTORIA__ZAMOWIEN foreign key (ID_ZAMOWIENIE)
      references ZAMOWIENIA (ID_ZAMOWIENIE)
go

alter table HISTORIA_ZAMOWIENIA
   add constraint FK_HISTORIA_KLIENT_PO_KLIENCI foreign key (ID_KLIENT)
      references KLIENCI (ID_KLIENT)
go

alter table HISTORIA_ZAMOWIENIA
   add constraint FK_HISTORIA_PRACOWNIK_PRACOWNI foreign key (ID_PRAC)
      references PRACOWNICY (ID_PRAC)
go

alter table KLIENCI
   add constraint FK_KLIENCI_KONTO_KLI_KONTA_KL foreign key (iD_KON_KLIENT)
      references KONTA_KLIENTOW (iD_KON_KLIENT)
go

alter table KONTA_KLIENTOW
   add constraint FK_KONTA_KL_KONTO_KLI_KLIENCI foreign key (ID_KLIENT)
      references KLIENCI (ID_KLIENT)
go

alter table KONTA_KLIENTOW
   add constraint FK_KONTA_KL_ROLE_KLIE_ROLE foreign key (ID_ROLA)
      references ROLE (ID_ROLA)
go

alter table KONTA_PRACOWNIKOW
   add constraint FK_KONTA_PR_KONTO_PRA_PRACOWNI foreign key (ID_PRAC)
      references PRACOWNICY (ID_PRAC)
go

alter table KONTA_PRACOWNIKOW
   add constraint FK_KONTA_PR_ROLE_PRAC_ROLE foreign key (ID_ROLA)
      references ROLE (ID_ROLA)
go

alter table MODELE
   add constraint FK_MODELE_MARKA_SAM_MARKI foreign key (ID_MARKA)
      references MARKI (ID_MARKA)
go

alter table MODELE
   add constraint FK_MODELE_RODZAJ_NA_RODZAJE_ foreign key (ID_NADWOZIE)
      references RODZAJE_NADWOZIA (ID_NADWOZIE)
go

alter table PRACOWNICY
   add constraint FK_PRACOWNI_KONTO_PRA_KONTA_PR foreign key (ID_KON_PRACOWNIK)
      references KONTA_PRACOWNIKOW (ID_KON_PRACOWNIK)
go

alter table PRACOWNICY
   add constraint FK_PRACOWNI_PRACOWNIK_WYPOZYCZ foreign key (ID_WYPOZYCZALNIA)
      references WYPOZYCZALNIE (ID_WYPOZYCZALNIA)
go

alter table SAMOCHODY
   add constraint FK_SAMOCHOD_MODEL_SAM_MODELE foreign key (ID_MODEL)
      references MODELE (ID_MODEL)
go

alter table SAMOCHODY
   add constraint FK_SAMOCHOD_RODZAJ_PA_RODZAJE_ foreign key (ID_PALIWO)
      references RODZAJE_PALIWA (ID_PALIWO)
go

alter table SAMOCHODY
   add constraint FK_SAMOCHOD_SAMOCHOD__WYPOZYCZ foreign key (ID_WYPOZYCZALNIA)
      references WYPOZYCZALNIE (ID_WYPOZYCZALNIA)
go

alter table ZAMOWIENIA
   add constraint FK_ZAMOWIEN_HISTORIA__HISTORIA foreign key (ID_HISTORIA)
      references HISTORIA_ZAMOWIENIA (ID_HISTORIA)
go

alter table ZAMOWIENIA
   add constraint FK_ZAMOWIEN_PAKIET_W__PAKIETY foreign key (ID_PAKIET)
      references PAKIETY (ID_PAKIET)
go

alter table ZAMOWIENIA
   add constraint FK_ZAMOWIEN_WYPOZYCZA_WYPOZYCZ foreign key (ID_WYPOZYCZALNIA)
      references WYPOZYCZALNIE (ID_WYPOZYCZALNIA)
go

alter table ZAMOWIENIA
   add constraint FK_ZAMOWIEN_ZAMOWIENI_KLIENCI foreign key (ID_KLIENT)
      references KLIENCI (ID_KLIENT)
go

alter table ZAMOWIENIA
   add constraint FK_ZAMOWIEN_ZAMOWIONY_SAMOCHOD foreign key (ID_SAMOCHOD)
      references SAMOCHODY (ID_SAMOCHOD)
go

