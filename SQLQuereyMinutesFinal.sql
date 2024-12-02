USE DiyaMinuteFinal;
GO

CREATE TABLE MeetingType (
    MeetingTypeID INT PRIMARY KEY IDENTITY(1,1),
    TypeName VARCHAR(50) NOT NULL
);
GO

INSERT INTO MeetingType (TypeName) VALUES ('Finance'), ('MANCO'), ('Team Project Leaders');
GO

CREATE TABLE Meeting (
    MeetingID INT PRIMARY KEY IDENTITY(1,1),
    MeetingTypeID INT FOREIGN KEY REFERENCES MeetingType(MeetingTypeID),
    MeetingDateTime DATETIME NOT NULL
);
CREATE TABLE MeetingItem (
    MeetingItemID INT PRIMARY KEY IDENTITY(1,1),
    Description VARCHAR(255) NOT NULL
);
GO
CREATE TABLE MeetingItemStatus (
    MeetingItemStatusID INT PRIMARY KEY IDENTITY(1,1),
    MeetingID INT FOREIGN KEY REFERENCES Meeting(MeetingID),
    MeetingItemID INT FOREIGN KEY REFERENCES MeetingItem(MeetingItemID),
    Status VARCHAR(50),
    ResponsiblePerson VARCHAR(100)
);
GO
