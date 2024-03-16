create database faculty
use faculty
CREATE TABLE Departments (
  Dep_id VARCHAR(10) PRIMARY KEY,
  Dep_N VARCHAR(50),
  HeadProfessorID INT,
);

CREATE TABLE Students (
  Std_id INT PRIMARY KEY,
  Std_N VARCHAR(50),
  Std_gender VARCHAR(10),
  Std_address VARCHAR(100),
  Std_email VARCHAR(100),
  Std_phone VARCHAR(20),
  Std_date DATE,
  Dep_id VARCHAR(10),
  FOREIGN KEY (Dep_id) REFERENCES Departments (Dep_id)
);
CREATE TABLE Professors (
  Prof_id INT PRIMARY KEY,
  Prof_N VARCHAR(50),
  Prof_gender VARCHAR(10),
  Prof_address VARCHAR(100),
  Prof_email VARCHAR(100),
  Prof_phone VARCHAR(20),
  Prof_Date DATE,
  Prof_dep VARCHAR(10),
  FOREIGN KEY (Prof_dep) REFERENCES Departments (Dep_id)
);

CREATE TABLE Courses (
  C_id INT PRIMARY KEY,
  C_N VARCHAR(50),
  Dep_id VARCHAR(10),
  FOREIGN KEY (Dep_id) REFERENCES Departments (Dep_id)
);
CREATE TABLE Enrollment (
  Std_id INT,
  C_id INT,
  Grade INT,
Degree INT, 
  PRIMARY KEY (Std_id, C_id),
  FOREIGN KEY (Std_id) REFERENCES Students (Std_id),
  FOREIGN KEY (C_id) REFERENCES Courses (C_id)
);

insert into Professors;
value(