insert into drzava(idd, nazivd) values(1, 'Finland');
insert into drzava(idd, nazivd) values(2, 'Spain');
insert into drzava(idd, nazivd) values(3, 'Germany');
insert into drzava(idd, nazivd) values(4, 'Brazil');
insert into drzava(idd, nazivd) values(5, 'Great Britain');
insert into drzava(idd, nazivd) values(6, 'Italy');
insert into drzava(idd, nazivd) values(7, 'France');
commit;

insert into vozac(idv, imev, prezv, godrodj, brojtit, drzv) values (1, 'Kimmi', 'Raikkonen', '1979', 1, 1);
insert into vozac(idv, imev, prezv, godrodj, brojtit, drzv) values (2, 'Lewis', 'Hamilton', '1985', 6, 5);
insert into vozac(idv, imev, prezv, godrodj, brojtit, drzv) values (3, 'Sebastian', 'Vettel', '1987', 4, 3);
insert into vozac(idv, imev, prezv, godrodj, brojtit, drzv) values (4, 'Michael', 'Schumacher', '1969', 7, 3);
insert into vozac(idv, imev, prezv, godrodj, brojtit, drzv) values (5, 'Ayrton', 'Senna', '1960', 3, 4);
insert into vozac(idv, imev, prezv, godrodj, brojtit, drzv) values (6, 'Alain', 'Prost', '1950', 4, 7);
insert into vozac(idv, imev, prezv, godrodj, brojtit, drzv) values (7, 'Nico', 'Hulkenberg', '1987', 0, 3);
insert into vozac(idv, imev, prezv, godrodj, brojtit, drzv) values (8, 'Rubens', 'Barrichelo', '1972', 0, 4);
insert into vozac(idv, imev, prezv, godrodj, brojtit, drzv) values (9, 'Nikki', 'Lauda', '1949', 3, NULL);
commit;

INSERT INTO STAZA(IDS, NAZIVS, BROJKRUG, DUZKRUG, DRZS) VALUES (1, 'Interlagos', 54, 5.91, 4);
INSERT INTO STAZA(IDS, NAZIVS, BROJKRUG, DUZKRUG, DRZS) VALUES (2, 'Silverstone', 56, 6.4, 5);
INSERT INTO STAZA(IDS, NAZIVS, BROJKRUG, DUZKRUG, DRZS) VALUES (3, 'Monza', 60, 5.99, 6);
INSERT INTO STAZA(IDS, NAZIVS, BROJKRUG, DUZKRUG, DRZS) VALUES (4, 'Paul Ricard', 65, 5.51, 7);
INSERT INTO STAZA(IDS, NAZIVS, BROJKRUG, DUZKRUG, DRZS) VALUES (5, 'Hocnenheimring', 52, 6.22, 3);
commit;

insert into rezultat(idr, idv, ids, sezona, plasman, bodovi, maksbrzina) 
values ('R01', 3,5,2019, 1, 25, 350.67);
insert into rezultat(idr, idv, ids, sezona, plasman, bodovi, maksbrzina) 
values ('R02', 2,5,2019, 2, 18, 340.6);
insert into rezultat(idr, idv, ids, sezona, plasman, bodovi, maksbrzina) 
values ('R03', 1,5,2019, 3, 15, 361.55);
insert into rezultat(idr, idv, ids, sezona, plasman, bodovi, maksbrzina) 
values ('R04', 7,5,2019, 4, 0, 370.32);
insert into rezultat(idr, idv, ids, sezona, plasman, bodovi, maksbrzina) 
values ('R05', 4,1,1994, 1, 25, 340.5);
insert into rezultat(idr, idv, ids, sezona, plasman, bodovi, maksbrzina) 
values ('R06', 5,1,1994, 2, 18, 332.4);
insert into rezultat(idr, idv, ids, sezona, plasman, bodovi, maksbrzina) 
values ('R07', 6,1,1994, 3, 15, 333.7);
insert into rezultat(idr, idv, ids, sezona, plasman, bodovi, maksbrzina) 
values ('R08', 8,1,1994, 4, 0, 347.6);
insert into rezultat(idr, idv, ids, sezona, plasman, bodovi, maksbrzina) 
values ('R09', 3,3,2018, 1, 25, 351.67);
insert into rezultat(idr, idv, ids, sezona, plasman, bodovi, maksbrzina) 
values ('R10', 2,2,2019, 1, 25, 360.54);
insert into rezultat(idr, idv, ids, sezona, plasman, bodovi, maksbrzina) 
values ('R11', 1,2,2019, 2, 18, 367.56);
insert into rezultat(idr, idv, ids, sezona, plasman, bodovi, maksbrzina) 
values ('R12', 3,5,2005, 1, 24, 340.5);
commit;