CREATE TABLE sklep (
    id INT IDENTITY PRIMARY KEY,
    miasto VARCHAR(40),
    ulica VARCHAR(50)
    );
	
CREATE TABLE produkt (
    id INT IDENTITY PRIMARY KEY,
    nazwa VARCHAR(40),
    cena MONEY,
    zdjecie IMAGE,
    lokalizacja_id INT NOT NULL REFERENCES sklep(id)
    );

INSERT INTO sklep (miasto, ulica) 
VALUES 
('Gdañsk', 'Wojska Polskiego'), 
('Sopot', 'Al. Niepodleg³oœci'),
('Gdynia', 'Poziomkowa');

INSERT INTO produkt (nazwa, cena, lokalizacja_id) 
VALUES 
('Arbuz', 12.50, 1),
('Banan', 13, 1),
('Cebula', 0.5, 3),
('Dynia', 5, 3),
('Ekler', 123, 2),
('Fl¹dra', 23.4, 3);

UPDATE produkt SET zdjecie=(SELECT BulkColumn FROM OPENROWSET (BULK 'E:\WSB\P.NET\Zadanie 4\images\a.jpg', SINGLE_BLOB) a) WHERE id=1;
UPDATE produkt SET zdjecie=(SELECT BulkColumn FROM OPENROWSET (BULK 'E:\WSB\P.NET\Zadanie 4\images\b.jpg', SINGLE_BLOB) a) WHERE id=2;
UPDATE produkt SET zdjecie=(SELECT BulkColumn FROM OPENROWSET (BULK 'E:\WSB\P.NET\Zadanie 4\images\c.jpg', SINGLE_BLOB) a) WHERE id=3;
UPDATE produkt SET zdjecie=(SELECT BulkColumn FROM OPENROWSET (BULK 'E:\WSB\P.NET\Zadanie 4\images\d.jpg', SINGLE_BLOB) a) WHERE id=4;
UPDATE produkt SET zdjecie=(SELECT BulkColumn FROM OPENROWSET (BULK 'E:\WSB\P.NET\Zadanie 4\images\e.jpg', SINGLE_BLOB) a) WHERE id=5;
UPDATE produkt SET zdjecie=(SELECT BulkColumn FROM OPENROWSET (BULK 'E:\WSB\P.NET\Zadanie 4\images\f.jpg', SINGLE_BLOB) a) WHERE id=6;