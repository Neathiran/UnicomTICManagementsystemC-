using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementsystem.Data
{
    internal class Migrations
    {
        public static void create_table()
        {
            using (var getDbconfing = Dbconfing.GetConnection())
            {
                string create_table = @"
 CREATE TABLE IF NOT EXISTS Courses (
            ID INTEGER PRIMARY KEY AUTOINCREMENT,
            CourseName TEXT NOT NULL
        );

        CREATE TABLE IF NOT EXISTS Users (
            UserID TEXT NOT NULL,
            Password TEXT NOT NULL,
            Role TEXT NOT NULL
        );

        CREATE TABLE IF NOT EXISTS Rooms (
            ID INTEGER PRIMARY KEY AUTOINCREMENT,
            RoomType TEXT NOT NULL,
            RoomName TEXT NOT NULL
        );

        CREATE TABLE IF NOT EXISTS Subjects (
             ID INTEGER PRIMARY KEY AUTOINCREMENT,
             SubjectName TEXT NOT NULL,
             CoursesID INTEGER NOT NULL,
             CoursesName TEXT NOT NULL,
           FOREIGN KEY (CoursesID) REFERENCES Courses(ID)
        );

       CREATE TABLE IF NOT EXISTS Exams_01 (
            ID INTEGER PRIMARY KEY AUTOINCREMENT,
            Date TEXT NOT NULL,
             Time TEXT NOT NULL,
             ExamName TEXT NOT NULL,
            SubjectsID INTEGER NOT NULL,
            SubjectName TEXT NOT NULL,
             FOREIGN KEY (SubjectsID) REFERENCES Subjects(ID)


        );
        CREATE TABLE IF NOT EXISTS Marks (
            ID INTEGER PRIMARY KEY AUTOINCREMENT,
            Mark INTEGER NOT NULL,
            UserID INTEGER NOT NULL,
             ExamsID INTEGER NOT NULL,
            FOREIGN KEY (UserID) REFERENCES Users(ID),
            FOREIGN KEY (ExamsID) REFERENCES Exams(ID)
        );

        CREATE TABLE IF NOT EXISTS TimeTable (
            ID INTEGER PRIMARY KEY AUTOINCREMENT,
            TimeSlot TEXT NOT NULL,
            RoomsID INTEGER NOT NULL,
            SubjectsID INTEGER NOT NULL,
            FOREIGN KEY (RoomsID) REFERENCES Rooms(ID),
            FOREIGN KEY (SubjectsID) REFERENCES Subjects(ID)
        );

        CREATE TABLE IF NOT EXISTS Lecturers_1234 (
            ID INTEGER PRIMARY KEY AUTOINCREMENT,
            LecturerName TEXT NOT NULL,
            CoursesID INTEGER NOT NULL,
            UserID TEXT NOT NULL,
             FOREIGN KEY (UserID) REFERENCES Users_123(UserID),
            FOREIGN KEY (CoursesID) REFERENCES Courses(ID)

        );
        CREATE TABLE IF NOT EXISTS Students_1234567 (
            ID INTEGER PRIMARY KEY AUTOINCREMENT,
             Name TEXT NOT NULL,
             Age INTEGER NOT NULL,
            Gender TEXT NOT NULL,
            Address TEXT NOT NULL,           
            CoursesName TEXT NOT NULL,
            UserID TEXT NOT NULL,
            NICNumber TEXT NOT NULL,
            CoursesID INTEGER NOT NULL,
            FOREIGN KEY (UserID) REFERENCES Users_123(UserID),
             FOREIGN KEY (CoursesID) REFERENCES Courses(ID)
        
        );
        CREATE TABLE IF NOT EXISTS Student_and_Teacher_1234 (
            ID INTEGER PRIMARY KEY AUTOINCREMENT,
            StudentsID INTEGER NOT NULL,
            LecturersID INTEGER NOT NULL,
            FOREIGN KEY (StudentsID) REFERENCES Students(ID),
            FOREIGN KEY (LecturersID) REFERENCES Lecturers(ID)
        );
        CREATE TABLE IF NOT EXISTS Staffs_1234 (
            ID INTEGER PRIMARY KEY AUTOINCREMENT,
            StaffName TEXT NOT NULL,
            PhoneNumber TEXT NOT NULL,
             UserID TEXT NOT NULL,
            FOREIGN KEY (UserID) REFERENCES Users_123(UserID)
        );
    
        CREATE TABLE IF NOT EXISTS Admin_1234 (
            ID INTEGER PRIMARY KEY AUTOINCREMENT,
            AdminID TEXT NOT NULL,
             UserID TEXT NOT NULL,
            FOREIGN KEY (UserID) REFERENCES Users_123(UserID)
             
        );
        
            
        ";

                SQLiteCommand command = new SQLiteCommand(create_table, getDbconfing);
                command.ExecuteNonQuery();
            }
        }

    }
}
