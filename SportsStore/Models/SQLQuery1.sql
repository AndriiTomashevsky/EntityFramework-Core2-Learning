﻿USE PartyInvites
SELECT * FROM Responses

USE PartyInvites
SELECT * FROM Responses
WHERE WillAttend = 1

USE PartyInvites
SELECT Id, Name, Email FROM Responses
WHERE WillAttend = 'true'

USE PartyInvites
SELECT Id, Name, Email FROM Responses
WHERE WillAttend = 'true'
ORDER BY Email

USE PartyInvites
INSERT INTO Responses(Name, Email, Phone, WillAttend)
VALUES ('Joe Dobbs', 'joe@example.com', '555-888-1234', 1)

USE PartyInvites
UPDATE Responses
SET Phone='404-204-1234'
WHERE WillAttend = 1

USE PartyInvites
SELECT * FROM Responses

USE PartyInvites
DELETE FROM Responses
WHERE WillAttend = 0

USE PartyInvites
DROP TABLE IF EXISTS Preferences
CREATE TABLE Preferences (
Id bigint IDENTITY,
Email nvarchar(max),
NutAllergy bit,
Teetotal bit,
ResponseId bigint,
)

USE PartyInvites
INSERT INTO Responses(Name, Email, Phone, WillAttend)
VALUES ('Dave Habbs', 'dave@example.com', '555-777-1234', 1)
INSERT INTO Preferences (Email, NutAllergy, Teetotal)
VALUES ('dave@example.com', 0, 1)

USE PartyInvites
SELECT * FROM Responses
SELECT * FROM Preferences