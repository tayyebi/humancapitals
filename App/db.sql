-- SQLite

-- People

drop table People;
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

drop table Courses;
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