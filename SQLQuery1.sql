CREATE TABLE Users
(
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(50) NOT NULL,
    Role NVARCHAR(30) NOT NULL
);

CREATE TABLE Apartments
(
    ApartmentID INT IDENTITY(1,1) PRIMARY KEY,
    HotelName NVARCHAR(100) NOT NULL,
    ApartmentNumber NVARCHAR(30) NOT NULL,
    Location NVARCHAR(150) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Description NVARCHAR(500) NOT NULL,
    MainImagePath NVARCHAR(300)
);

CREATE TABLE ApartmentImages
(
    ImageID INT IDENTITY(1,1) PRIMARY KEY,
    ApartmentID INT NOT NULL,
    ImagePath NVARCHAR(300) NOT NULL,

    FOREIGN KEY (ApartmentID) REFERENCES Apartments(ApartmentID)
);

CREATE TABLE Bookings
(
    BookingID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    ApartmentID INT NOT NULL,

    BookingDate DATE NOT NULL,
    CheckInDate DATE NOT NULL,
    NumberOfNights INT NOT NULL,
    TotalPrice DECIMAL(10,2) NOT NULL,

    Status NVARCHAR(30) NOT NULL,

    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (ApartmentID) REFERENCES Apartments(ApartmentID)
);