Create database College_DB2509;
 
USE [College_DB2509]; -- College_DB2509

if (OBJECT_ID('Staff')) is null -- Check if the 'Staff' table exists in the college database before creating it

	CREATE TABLE [dbo].[Staff]

	(

		[StaffID] [varchar](15) NOT NULL primary key,

		[Names] [varchar](150) NOT NULL,

		[BirthDate] [datetime] NOT NULL,

		[Gender] [nchar](1) NOT NULL,

		[Email] [varchar](80) NOT NULL,

		[Nationality] [varchar](100) NOT NULL,

		[EmploymentDate] [datetime] NOT NULL,

		[Designation] [varchar](100) NOT NULL,

		[PhoneNo] [varchar](20) NOT NULL

	) ON [PRIMARY]

else

	print 'The Staff Table already exists and will not be recreated!'

-- Add some records in the staff table

insert into staff values

('S0001', 'James Ngash', '1985-05-18', 'M', 'j.ngash@email.com', 'Kenyan','2021-03-14','IT Lecturer','0751235698'),

('S0002', 'Mary Mueni', '1988-07-21', 'F','m.mueni@email.co.ke', 'Kenyan','2020-04-08','Marketing Officer','0723287448'),

('S0003','Peter Otieno','1983-02-11','M','peter.otieno@email.com','Kenyan','2019-06-12','Finance Officer','0712345671'),

('S0004','Lucy Wanjiku','1990-09-25','F','lucy.wanjiku@email.com','Kenyan','2022-01-10','HR Manager','0712345672'),

('S0005','Daniel Kiptoo','1986-11-03','M','daniel.kiptoo@email.com','Kenyan','2018-08-21','Lecturer','0712345673'),

('S0006','Ann Njeri','1992-04-17','F','ann.njeri@email.com','Kenyan','2021-05-14','Receptionist','0712345674'),

('S0007','Joseph Kamau','1984-12-30','M','joseph.kamau@email.com','Kenyan','2017-03-19','Administrator','0712345675'),

('S0008','Grace Achieng','1989-06-08','F','grace.achieng@email.com','Kenyan','2020-10-11','Accountant','0712345676'),

('S0009','Samuel Mwangi','1981-01-22','M','samuel.mwangi@email.com','Kenyan','2016-07-23','Security Officer','0712345677'),

('S0010','Esther Chebet','1993-03-15','F','esther.chebet@email.com','Kenyan','2023-02-01','Lab Technician','0712345678'),

('S0011','David Ochieng','1987-08-19','M','david.ochieng@email.com','Kenyan','2019-09-05','IT Support','0712345679'),

('S0012','Ruth Nyambura','1991-10-10','F','ruth.nyambura@email.com','Kenyan','2021-11-18','Secretary','0712345680'),

('S0013','Michael Kiprono','1982-05-27','M','michael.kiprono@email.com','Kenyan','2015-04-09','Driver','0712345681'),

('S0014','Faith Wambui','1994-07-13','F','faith.wambui@email.com','Kenyan','2022-06-20','Counselor','0712345682'),

('S0015','George Mutiso','1980-09-09','M','george.mutiso@email.com','Kenyan','2014-12-01','Procurement Officer','0712345683'),

('S0016','Mercy Atieno','1988-02-28','F','mercy.atieno@email.com','Kenyan','2018-03-30','Nurse','0751345684'),

('S0017','Patrick Karanja','1985-11-11','M','patrick.karanja@email.com','Kenyan','2017-08-15','Lecturer','0711345685'),

('S0018','Irene Jepkorir','1992-12-05','F','irene.jepkorir@email.com','Kenyan','2020-01-25','Librarian','0722345686'),

('S0019','Kevin Odhiambo','1989-03-03','M','kevin.odhiambo@email.com','Kenyan','2021-09-12','ICT Officer','0713345687'),

('S0020','Naomi Wairimu','1995-06-29','F','naomi.wairimu@email.com','Kenyan','2023-03-18','Clerk','0712345688'),

('S0021','Brian Kipchoge','1987-04-04','M','brian.kipchoge@email.com','Kenyan','2019-11-27','Sports Coach','0734345689'),

('S0022','Jane Naliaka','1990-01-14','F','jane.naliaka@email.com','Kenyan','2022-04-05','Registrar','0712345690'),

('S0023','Collins Musyoka','1983-07-07','M','collins.musyoka@email.com','Kenyan','2016-02-14','Maintenance Officer','077345691'),

('S0024','Beatrice Akinyi','1991-08-18','F','beatrice.akinyi@email.com','Kenyan','2021-07-22','Cashier','0727345692'),

('S0025','Eric Muriithi','1986-10-26','M','eric.muriithi@email.com','Kenyan','2018-05-17','Systems Analyst','0735345693'),

('S0026', 'Dennis Kimani', '1988-04-12', 'M', 'dennis.kimani@email.com', 'Kenyan', '2020-02-15', 'Lecturer', '0714567801'),

('S0027', 'Caroline Wanjiru', '1991-09-03', 'F', 'caroline.wanjiru@email.com', 'Kenyan', '2021-06-01', 'Admissions Officer', '0722567802'),

('S0028', 'Stephen Njoroge', '1984-11-29', 'M', 'stephen.njoroge@email.com', 'Kenyan', '2018-09-10', 'Senior Lecturer', '0733567803'),

('S0029', 'Lilian Awuor', '1993-01-19', 'F', 'lilian.awuor@email.com', 'Kenyan', '2022-08-14', 'Assistant Accountant', '0711567804'),

('S0030', 'Victor Barasa', '1987-07-08', 'M', 'victor.barasa@email.com', 'Kenyan', '2019-03-22', 'Network Administrator', '0720567805'),

('S0031', 'Eunice Muthoni', '1990-12-11', 'F', 'eunice.muthoni@email.com', 'Kenyan', '2020-11-05', 'Student Welfare Officer', '0715567806'),

('S0032', 'Anthony Wafula', '1982-03-24', 'M', 'anthony.wafula@email.com', 'Kenyan', '2016-05-18', 'Head of Department', '0724567807'),

('S0033', 'Sharon Cherono', '1994-05-30', 'F', 'sharon.cherono@email.com', 'Kenyan', '2023-01-09', 'Administrative Assistant', '0716567808'),

('S0034', 'Francis Mutua', '1985-08-16', 'M', 'francis.mutua@email.com', 'Kenyan', '2017-10-30', 'Estates Manager', '0731567809'),

('S0035', 'Rosemary Nyokabi', '1989-02-14', 'F', 'rosemary.nyokabi@email.com', 'Kenyan', '2021-04-12', 'Exams Officer', '0725567810'),

('S0036', 'Kelvin Onyango', '1992-06-25', 'M', 'kelvin.onyango@email.com', 'Kenyan', '2022-03-07', 'IT Technician', '0717567811'),

('S0037', 'Joyce Mwikali', '1986-10-02', 'F', 'joyce.mwikali@email.com', 'Kenyan', '2019-07-19', 'Catering Manager', '0726567812'),

('S0038', 'Bernard Korir', '1981-04-27', 'M', 'bernard.korir@email.com', 'Kenyan', '2015-08-24', 'Chief Security Officer', '0732567813'),

('S0039', 'Winfred Makena', '1993-11-08', 'F', 'winfred.makena@email.com', 'Kenyan', '2022-09-15', 'Public Relations Officer', '0718567814'),

('S0040', 'Geoffrey Gitau', '1983-01-31', 'M', 'geoffrey.gitau@email.com', 'Kenyan', '2017-02-11', 'Internal Auditor', '0727567815'),

('S0041', 'Millicent Adhiambo', '1990-07-17', 'F', 'millicent.adhiambo@email.com', 'Kenyan', '2020-06-28', 'Assistant Librarian', '0719567816'),

('S0042', 'Alex Simiyu', '1988-09-21', 'M', 'alex.simiyu@email.com', 'Kenyan', '2019-12-02', 'Lecturer', '0728567817'),

('S0043', 'Dorcas Chepkoech', '1995-03-09', 'F', 'dorcas.chepkoech@email.com', 'Kenyan', '2023-05-16', 'Records Clerk', '0710567818'),

('S0044', 'Kennedy Omwenga', '1984-06-13', 'M', 'kennedy.omwenga@email.com', 'Kenyan', '2018-01-29', 'Transport Coordinator', '0734567819'),

('S0045', 'tabitha Ndungu', '1991-12-23', 'F', 'tabitha.ndungu@email.com', 'Kenyan', '2021-08-09', 'Quality Assurance Officer', '0729567820'),

('S0046', 'Pauline Moraa', '1987-05-04', 'F', 'pauline.moraa@email.com', 'Kenyan', '2019-04-17', 'Lecturer', '0713567821'),

('S0047', 'Simon Macharia', '1980-11-15', 'M', 'simon.macharia@email.com', 'Kenyan', '2014-09-01', 'Dean of Students', '0721567822'),

('S0048', 'Agnes Kavata', '1992-08-26', 'F', 'agnes.kavata@email.com', 'Kenyan', '2022-02-14', 'Hostel Warden', '0712567823'),

('S0049', 'Harrison Koech', '1986-02-07', 'M', 'harrison.koech@email.com', 'Kenyan', '2018-11-19', 'Database Administrator', '0735567824'),

('S0050', 'Veronica Nekesa', '1994-10-19', 'F', 'veronica.nekesa@email.com', 'Kenyan', '2023-04-03', 'Office Assistant', '0714567825'),

('S0051', 'Martin Mwenda', '1989-01-28', 'M', 'martin.mwenda@email.com', 'Kenyan', '2020-09-14', 'Graphic Designer', '0722567826'),

('S0052', 'Florence Wangari', '1985-07-02', 'F', 'florence.wangari@email.com', 'Kenyan', '2017-06-21', 'Legal Officer', '0736567827'),

('S0053', 'Charles Ouma', '1983-04-10', 'M', 'charles.ouma@email.com', 'Kenyan', '2016-10-12', 'Electrician', '0715567828'),

('S0054', 'Jackline Kendi', '1991-03-22', 'F', 'jackline.kendi@email.com', 'Kenyan', '2021-12-06', 'Clinical Officer', '0723567829'),

('S0055', 'Elijah Bett', '1988-12-01', 'M', 'elijah.bett@email.com', 'Kenyan', '2020-05-25', 'Assistant Registrar', '0737567830');
 


if (OBJECT_ID('Student')) is null -- Check if the 'Student' table exists in the college database before creating it

	CREATE TABLE [dbo].[Student]

	(

		[StudentNo] [varchar](15) NOT NULL primary key,

		[Names] [varchar](150) NOT NULL,

		[BirthDate] [datetime] NOT NULL,

		[Gender] [nchar](1) NOT NULL,

		[Email] [varchar](80) NOT NULL,

		[Nationality] [varchar](100) NOT NULL,

		[Course] [varchar](100) NOT NULL,

		[CurrentSem] int NOT NULL

	) ON [PRIMARY]

else

	print 'The Student Table already exists and will not be recreated!'

-- Add some records in the student table

insert into student

values

('Student1000001', 'Mary Muindi' , '2005-05-21','F','mary_di@ymail.com','Kenyan','Data Science',2),

('Student1000002', 'Alisha Mwanaidi' , '2004-10-12','F','swit_lisha@email.com','Kenyan','Beauty & Hairdressing',4),

('Student1000003', 'John Kamau', '2003-03-15','M','john.kamau@email.com','Kenyan','Computer Science',3),

('Student1000004', 'Faith Wambui', '2005-07-22','F','faith.wambui@student.com','Kenyan','Business Administration',1),

('Student1000005', 'Peter Odhiambo', '2004-11-30','M','peter.odhiambo@student.com','Kenyan','Mechanical Engineering',4),

('Student1000006', 'Ann Njeri', '2005-02-05','F','ann.njeri@student.com','Kenyan','Psychology',2),

('Student1000007', 'Samuel Mwangi', '2003-06-18','M','samuel.mwangi@student.com','Kenyan','Economics',5),

('Student1000008', 'Esther Chebet', '2004-09-12','F','esther.chebet@student.com','Kenyan','Nursing',3),

('Student1000009', 'David Ochieng', '2005-01-25','M','david.ochieng@student.com','Kenyan','Information Technology',2),

('Student1000010', 'Ruth Nyambura', '2003-12-17','F','ruth.nyambura@student.com','Kenyan','Law',5),

('Student1000011', 'Michael Kiprono', '2004-04-21','M','michael.kiprono@student.com','Kenyan','Accounting',4),

('Student1000012', 'Grace Achieng', '2005-08-30','F','grace.achieng@student.com','Kenyan','Education',1),

('Student1000013', 'Kevin Odhiambo', '2003-11-09','M','kevin.odhiambo@student.com','Kenyan','Civil Engineering',5),

('Student1000014', 'Naomi Wairimu', '2004-03-03','F','naomi.wairimu@student.com','Kenyan','Biology',3),

('Student1000015', 'Brian Kipchoge', '2005-05-14','M','brian.kipchoge@student.com','Kenyan','Sports Science',2),

('Student1000016', 'Jane Naliaka', '2004-07-28','F','jane.naliaka@student.com','Kenyan','Journalism',4),

('Student1000017', 'Collins Musyoka', '2003-02-19','M','collins.musyoka@student.com','Kenyan','Agriculture',5),

('Student1000018', 'Beatrice Akinyi', '2005-06-10','F','beatrice.akinyi@student.com','Kenyan','Graphic Design',1),

('Student1000019', 'Eric Muriithi', '2004-12-05','M','eric.muriithi@student.com','Kenyan','Information Systems',4),

('Student1000020', 'Irene Jepkorir', '2003-09-17','F','irene.jepkorir@student.com','Kenyan','Pharmacy',5),

('Student1000021', 'Daniel Kiptoo', '2005-01-09','M','daniel.kiptoo@student.com','Kenyan','Statistics',2),

('Student1000022', 'Lucy Wanjiku', '2004-08-21','F','lucy.wanjiku@student.com','Kenyan','Hospitality Management',3),

('Student1000023','Charles Mwangi','2004-02-14','M','charles.mwangi@student.com','Kenyan','Computer Science',3),

('Student1000024','Susan Wanjiru','2005-04-19','F','susan.wanjiru@student.com','Kenyan','Business Administration',2),

('Student1000025','Francis Otieno','2003-08-11','M','francis.otieno@student.com','Kenyan','Information Technology',5),

('Student1000026','Caroline Chepkemoi','2004-06-23','F','caroline.chepkemoi@student.com','Kenyan','Nursing',3),

('Student1000027','Anthony Musau','2005-01-16','M','anthony.musau@student.com','Kenyan','Mechanical Engineering',2),

('Student1000028','Janet Akoth','2003-11-27','F','janet.akoth@student.com','Kenyan','Law',5),

('Student1000029','Robert Kibet','2004-09-08','M','robert.kibet@student.com','Kenyan','Data Science',4),

('Student1000030','Catherine Muthoni','2005-03-12','F','catherine.muthoni@student.com','Kenyan','Education',2),

('Student1000031','Dennis Barasa','2003-05-21','M','dennis.barasa@student.com','Kenyan','Civil Engineering',5),

('Student1000032','Alice Moraa','2004-12-07','F','alice.moraa@student.com','Kenyan','Psychology',3),

('Student1000033','Stephen Njoroge','2005-07-18','M','stephen.njoroge@student.com','Kenyan','Accounting',1),

('Student1000034','Rose Atieno','2003-04-25','F','rose.atieno@student.com','Kenyan','Journalism',5),

('Student1000035','Vincent Kiplangat','2004-10-30','M','vincent.kiplangat@student.com','Kenyan','Statistics',4),

('Student1000036','Pauline Wekesa','2005-02-09','F','pauline.wekesa@student.com','Kenyan','Pharmacy',2),

('Student1000037','Edward Mwiti','2003-09-14','M','edward.mwiti@student.com','Kenyan','Agriculture',5),

('Student1000038','Diana Nasimiyu','2004-01-28','F','diana.nasimiyu@student.com','Kenyan','Graphic Design',3),

('Student1000039','Martin Githinji','2005-06-16','M','martin.githinji@student.com','Kenyan','Information Systems',2),

('Student1000040','Elizabeth Auma','2003-12-03','F','elizabeth.auma@student.com','Kenyan','Economics',5),

('Student1000041','Christopher Muli','2004-05-17','M','christopher.muli@student.com','Kenyan','Electrical Engineering',4),

('Student1000042','Hellen Jepchirchir','2005-08-22','F','hellen.jepchirchir@student.com','Kenyan','Biology',1),

('Student1000043','Nicholas Were','2003-07-10','M','nicholas.were@student.com','Kenyan','Sports Science',5),

('Student1000044','Agnes Wairimu','2004-03-26','F','agnes.wairimu@student.com','Kenyan','Hospitality Management',3),

('Student1000045','Benjamin Kiptoo','2005-09-05','M','benjamin.kiptoo@student.com','Kenyan','Computer Science',2),

('Student1000046','Veronica Akinyi','2003-10-19','F','veronica.akinyi@student.com','Kenyan','Marketing',5),

('Student1000047','Philip Kamau','2004-07-13','M','philip.kamau@student.com','Kenyan','Information Technology',4),

('Student1000048','Monica Nyokabi','2005-11-24','F','monica.nyokabi@student.com','Kenyan','Human Resource Management',1),

('Student1000049','George Ouma','2003-01-31','M','george.ouma@student.com','Kenyan','Finance',5),

('Student1000050','Christine Mumbi','2004-04-08','F','christine.mumbi@student.com','Kenyan','Environmental Science',3),

('Student1000051','Richard Mutua','2005-12-15','M','richard.mutua@student.com','Kenyan','Software Engineering',2),

('Student1000052','Esther Naliaka','2003-06-20','F','esther.naliaka@student.com','Kenyan','Project Management',5);
 
-- Display all staff records

Select * from Staff;
 
-- Display all staff records

Select * from Student;
 
-- Count the total number of staff

Select count(*) as TotalStaff from staff
 
-- Count the total number of staff

Select count(*) as TotalStudent from student
 
 
 
 