INSERT INTO MARKI(NAZWA_MARKA, KRAJ, REGION) 
VALUES
('Fiat', 'Wlochy', 'Europa'),
('Vw', 'Niemcy', 'Europa'),
('Ford', 'USA', 'Stany Zjednoczone'),
('Toyota', 'Japonia', 'Azja'),
('Daewoo', 'Korea Poludniowa', 'Azja');

INSERT INTO RODZAJE_NADWOZIA(NAZWA_NADWOZIE) 
VALUES
('Sedan'),
('Hatchback'),
('Suv'),
('Van'),
('Pickup');

INSERT INTO MODELE(ID_MARKA, ID_NADWOZIE, NAZWA_MODEL, ROCZNIK, GENERACJA, SEGMENT) 
VALUES
(2, 2, 'Golf', 2004, 4, 'C'),
(1, 1, 'Tipo', 2016, 2, 'D'),
(3, 5, 'F150', 2018, 3, 'F'),
(5, 1, 'Lanos', 1997, 1, 'C'),
(4, 3, 'CH-R', 2015, 2, 'E');

INSERT INTO RODZAJE_PALIWA(NAZWA_RODZAJ) 
VALUES
('Benzyna'),
('Diesel'),
('Benzyna + LPG'),
('Elektryczny'),
('Hybryda');

INSERT INTO PAKIETY(NAZWA, ZAWARTOSC, CENA) 
VALUES
('Komfort', 'Podgrzewane fotele', 50),
('Przyczepnosc', 'Opony semi slick', 500),
('Moc', 'Wiecej mocy', 750),
('Cargo', 'Przyczepa', 250),
('Paliwo', 'Darmowe tankowanie', 1500);

INSERT INTO ROLE(ROLA) 
VALUES
('Administrator'),
('Pracownik_wydajacy'),
('Pracownik_mechanik'),
('Prezes'),
('Klient');

INSERT INTO WYPOZYCZALNIE(MIASTO, ADRES) 
VALUES
('Koszalin', 'Szczecinska 15'),
('Gdansk', 'Koszalinska 30'),
('Szczecin', 'Swinoujska 43'),
('Poznan', 'Bydgoska 32'),
('Pila', 'Koszalinska 99');

INSERT INTO SAMOCHODY(ID_PALIWO, ID_MODEL, ID_WYPOZYCZALNIA, KOLOR, PRZEBIEG, VIN, POJEMNOSC, MOC, SKRZYNIA, MIEJSCA, DOSTEPNOSC, CENA_DZIEN, CENA_TYDZIEN, CENA_MIESIAC, KAUCJA) 
VALUES
(1, 1, 2, 'Zielony', 300000, 'nfoiewjkcw', 1599, 100, 'Manualna', 5, 1, 60, 400, 0, 0),
(5, 5, 1, 'Bialy', 125000, 'vfnkjdsifds', 1499, 180, 'CVT', 5, 1, 90, 0, 0, 300),
(2, 3, 3, 'Czerwony', 500000, 'mlkcslkjks', 3000, 220, 'Automatyczna', 3, 1, 110, 700, 0, 500),
(5, 5, 1, 'Szary', 75000, 'vfnkfdsfs', 1499, 180, 'CVT', 5, 1, 90, 0, 0, 300),
(1, 1, 2, 'Niebieski', 140000, 'fdsmosesasca', 1699, 150, 'Manualna', 5, 1, 70, 450, 2100, 100);

/*GIT*/

INSERT INTO KLIENCI(IMIE_KLIENT, NAZWISKO_KLIENT, PESEL_KLIENT, TELEFON_KLIENT, FAX, NIP) 
VALUES
('Jan', 'Kowalski', 12345678901, '123-456-789', null, null),
('Dawid', 'Nowak', 10987654321, '987-654-321', null, 1234567890),
('Marek', 'Ciesla', 13579246801, '135-791-357', '123-45678901', null),
('Cezary', 'Cebula', 83820456021, '643-432-543', null, null),
('Zbigniew', 'Mul', 04328943217, '590-432-521', null, null);

INSERT INTO KONTA_KLIENTOW(ID_ROLA, ID_KLIENT, NAZWA_KLIENT, HASLO_KLIENT) 
VALUES
(5, 1, 'jan_kowalski', 'haslo1'),
(5, 2, 'dawid_nowak', 'haslo2'),
(5, 3, 'marek_ciesla', 'haslo3'),
(5, 4, 'cezary_cebula', 'haslo4'),
(5, 5, 'zbigniew_mul', 'haslo5');

UPDATE KLIENCI SET iD_KON_KLIENT = 1 WHERE ID_KLIENT = 1;
UPDATE KLIENCI SET iD_KON_KLIENT = 2 WHERE ID_KLIENT = 2;
UPDATE KLIENCI SET iD_KON_KLIENT = 3 WHERE ID_KLIENT = 3;
UPDATE KLIENCI SET iD_KON_KLIENT = 4 WHERE ID_KLIENT = 4;
UPDATE KLIENCI SET iD_KON_KLIENT = 5 WHERE ID_KLIENT = 5;

INSERT INTO PRACOWNICY(ID_WYPOZYCZALNIA, IMIE_PRACOWNIK, NAZWISKO_PRACOWNIK, PESEL_PRACOWNIK, TELEFON_PRACOWNIK, STANOWISKO, DATA_ZATRUDNIENIA, WYNAGRODZENIE, PREMIA) 
VALUES
(1, 'Arek', 'Arkowski', 12345678901, '123-456-789', 'Wydajacy', '1.1.2023', 4200, 300),
(2, 'Bartosz', 'Bartkowski', 10987654321, '987-654-321', 'Wydajacy', '2.1.2023', 4500, 0),
(3, 'Cezar', 'Cezarowski', 93947294851, '653-321-654', 'Mechanik', '3.1.2023', 3900, 0),
(4, 'Dariusz', 'dariuszowski', 93832949531, '754-865-432', 'Prezes', '12.31.2022', 10000, 1000),
(5, 'Ernest', 'Ernetowski', 84309043283, '754-321-542', 'Inspektor', '4.1.2023', 4300, 100);

INSERT INTO KONTA_PRACOWNIKOW(ID_ROLA, ID_PRAC, NAZWA_PRACOWNIK, HASLO_PRACOWNIK) 
VALUES
(2, 1, 'arek_arkowski', 'haslo1'),
(2, 2, 'bartosz_bartkowski', 'haslo2'),
(3, 3, 'cezar_cezarowski', 'haslo3'),
(1, 4, 'dariusz_dariuszowski', 'haslo4'),
(4, 5, 'ernest_ernetowski', 'haslo5');

UPDATE PRACOWNICY SET iD_KON_PRACOWNIK = 1 WHERE ID_PRAC = 1;
UPDATE PRACOWNICY SET iD_KON_PRACOWNIK = 2 WHERE ID_PRAC = 2;
UPDATE PRACOWNICY SET iD_KON_PRACOWNIK = 3 WHERE ID_PRAC = 3;
UPDATE PRACOWNICY SET iD_KON_PRACOWNIK = 4 WHERE ID_PRAC = 4;
UPDATE PRACOWNICY SET iD_KON_PRACOWNIK = 5 WHERE ID_PRAC = 5;

INSERT INTO ZAMOWIENIA(ID_PAKIET, ID_WYPOZYCZALNIA, ID_KLIENT, ID_SAMOCHOD, LICZBA_DNI, CENA_ZAMOWIENIE, DATA_START, DATA_KONIEC) 
VALUES
(1, 2, 1, 1, 7, 450, '01.01.2024', '01.07.2024'),
(3, 1, 2, 4, 14, 2410, '02.01.2024', '02.14.2024'),
(2, 1, 4, 2, 4, 1160, '03.01.2024', '03.04.2024'),
(NULL, 3, 1, 3, 31, 34600, '04.01.2024', '05.01.2024'),
(4, 2, 1, 5, 7, 700, '06.01.2024', '06.07.2024');

INSERT INTO HISTORIA_ZAMOWIENIA (ID_PRAC, ID_ZAMOWIENIE, ID_KLIENT, DATA_WYDANIE, DATA_PRZYJECIE, TANKOWANIE, KOSZT_TANKOWANIE, KOLIZJA, KARA_KOLIZJA)
VALUES
(1, 1, 2, '01.01.2024', '01.07.2024', 0, 0, 0, 0),
(2, 2, 1, '02.01.2024', '02.14.2024', 1, 250, 0, 0),
(1, 3, 4, '03.01.2024', '03.04.2024', 0, 0, 1, 300),
(2, 4, 3, '04.01.2024', '05.01.2024', 1, 500, 0, 0),
(1, 5, 5, '06.01.2024', '06.07.2024', 1, 100, 1, 1250);

UPDATE ZAMOWIENIA SET ID_HISTORIA = 1 WHERE ID_ZAMOWIENIE = 1;
UPDATE ZAMOWIENIA SET ID_HISTORIA = 2 WHERE ID_ZAMOWIENIE = 2;
UPDATE ZAMOWIENIA SET ID_HISTORIA = 3 WHERE ID_ZAMOWIENIE = 3;
UPDATE ZAMOWIENIA SET ID_HISTORIA = 4 WHERE ID_ZAMOWIENIE = 4;
UPDATE ZAMOWIENIA SET ID_HISTORIA = 5 WHERE ID_ZAMOWIENIE = 5;