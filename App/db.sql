-- SQLite

drop table People;
drop table Courses;
drop table Transactions;
drop table Voluntarilies;
drop table Attendings;

-- People

create table [People] (
    Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    Firstname   TEXT NULL,
    Lastname   TEXT NOT NULL,
    Title   TEXT NULL,
    BirthDate   TEXT NULL,
    PhoneNumber   TEXT NULL,
    Email   TEXT NULL,
    Joined TEXT NULL,
    Education TEXT NULL,
    Organization TEXT NULL,
    Address TEXT NULL,
	[Group] TEXT NULL,
    ReferralMethod TEXT NULL,
    ReferralCode TEXT NULL,
    ReferralName TEXT NULL,
    Notes TEXT NULL
);

INSERT INTO People (Firstname, Lastname, Title, BirthDate, PhoneNumber,
Email, Joined, Education, Organization, [Group],
ReferralMethod, ReferralCode, ReferralName, Notes)
VALUES ('محمدرضا', 'طیبی', 'Cheif Coffee Officer', '1377-03-16',
'09120982276', 'smile@tyyi.net', '1398', null, 'www.gordarg.com', null,
'مدرسه', NULL, NULL, 'این رکورد به صورت اتوماتیک وارد شده است');

-- Courses

create table [Courses] (
    Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    Title   TEXT NULL,
    [From]   TEXT NULL,
    [To]   TEXT NULL,
    Notes TEXT NULL,
    [Plan] TEXT NULL,
    Calendar TEXT NULL,
    TeacherName TEXT NULL,
    TeacherCode TEXT NULL,
    Fee TEXT NULL
);

INSERT INTO Courses (Title, [From], [To], [Plan], Notes, TeacherCode, TeacherName, Fee, Calendar)
VALUES ('نجوم مقدماتی', '1398-01-01', '1398-12-29', '1- مقدمات اخترشناسی 2- صورت های فلکی 3- ...', 'دوره مخصوص رده سنی کودکان است', '1', 'محمدرضا طیبی',
'1000', '- شنبه ها 10 تا 12 - دو شنبه ها 13 تا 14');

-- Transactions

create table [Transactions] (
    Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    Notes TEXT NULL,
    Date TEXT NULL,
    Amount TEXT NULL,
    BankRefferalCode TEXT NULL,
    BankName TEXT NULL,
    BankAccount TEXT NULL,
    OwnerCode INTEGER NULL,
    OwnerName TEXT NULL
);

INSERT INTO [Transactions] (Notes, Date, Amount, BankRefferalCode, BankName, BankAccount, OwnerCode, OwnerName)
VALUES ('داده ی آزمایشی غیر واقعی', '1267/01/01', '1', '.', 'بانک ...', '۰۵۹۰-۹۹۵۰-۹۹۱۱-۶۰۳۷', 1, 'محمدرضا طیبی');

-- Voluntarilies

create table Voluntarilies (
    Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    Title TEXT NOT NULL,
    [From] TEXT NULL,
    [TO] TEXT NULL,
    VolunteerCode INTEGER NULL,
    VolunteerName TEXT NULL,
    Activities TEXT NULL
);

INSERT INTO [Voluntarilies] (Title, [From], [To], VolunteerName, VolunteerCode, Activities)
VALUES ('ساماندهی داوطلبان رصدخانه ابن صلاح', 'آذر 1400', 'آبان 1400', 'محمدرضا طیبی', 1, 'برنامه نویسی نرم افزار / راه اندازی صفحه رصد خانه در فضای مجازی');

-- Attendings

create table Attendings (
    Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    CourseId INTEGER NOT NULL,
    [Submit] TEXT NULL,
    ParticipantCode INTEGER NULL,
    ParticipantName TEXT NULL,
    FinalMark INTEGER NULL,
    FinalStatus TEXT NULL
);

INSERT INTO [Attendings] ([Submit], ParticipantCode, ParticipantName, FinalMark, FinalStatus, CourseId)
VALUES ('1398/04/01', 1, 'محمدرضا طیبی', '18', 'قبول', 1)
