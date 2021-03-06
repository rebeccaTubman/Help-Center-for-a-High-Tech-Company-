﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HPHelpCenter.Models;
using Dal;

namespace HPHelpCenter
{
    public class User : BusinesEntity
    {
        public enum UserGender
        {
            Male=1,
            Female=2
        };
        public enum UserRole
        {
            Crew=1,
            Technician=2,
            Programmer=3
        };
        public enum UserCountry
        {
            Albania=1,
            America=2,
            Andorra=3,
            Argentina=4,
            Australia=5,
            Austria=6,
            Barbados=7,
            Belarus=8,
            Belgium=9,
            Bolivia=10,
            Brazil=11,
            Bulgaria=12,
            Canada=13,
            Chile=14,
            China=15,
            Colombia=16,
            Croatia=17,
            Cuba=18,
            Cyprus=19,
            Denmark=20,
            Ecuador=21,
            Egypt=22,
            Estonia=23,
            Fiji=24,
            Finland=25,
            France=26,
            Georgia=27,
            Germany=28,
            Ghana=29,
            Greece=30,
            Guatemala=31,
            Hungary=32,
            Iceland=33,
            India=34, 
            Ireland=35,
            Israel=36,
            Italy=37,
            Japan=38,
            Latvia=39,
            Liechtenstein=40,
            Luxembourg=41,
            Macedonia=42,
            Mexico=43,
            Moldova=44,
            Monaco=45,
            Montenegro=46,       
            Netherlands=47,
            Norway=48,
            Paraguay=49,
            Peru=50,
            Poland=51,
            Portugal=52,
            Romania=53,
            Russia=54,
            Serbia=55,
            Singapore=56,
            Slovakia=57,
            Slovenia=58,
            Spain=59,  
            Sweden=60,
            Switzerland=61,
            Ukraine=62,
            UK=63
        };

        private string firstName;
        private string lastName;
        private string userName;
        private UserRole role;
        private UserCountry country;
        private UserGender gender;
        private string email;
        private string password;
        private DateTime birthdayDate;
        private int pictureID;
        private bool isDeleted = false;

        public bool IsDeleted 
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

        public int PictureID
        {
            get { return pictureID; }
            set { pictureID = value; }
        }
        public User(int userID, string firstName, string lastName, 
            string userName, UserRole role, DateTime birthdayDate, UserCountry country, UserGender gender, 
            string email, string password, bool isDeleted, Int32 pictureID)
        {
            ID = userID;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Country = country;
            Gender = gender;
            Email = email;
            Password = password;
            BirthdayDate = birthdayDate;
            UserName = userName;
            IsDeleted = isDeleted;
            PictureID = pictureID;
        }
        //?
        public User(UserRole role, string userName)
        {
            Role = role;
            UserName = userName;
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }   
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public UserRole Role
        {
            get { return role; }
            set { role = value; }
        }
        public UserCountry Country
        {
            get { return country; }
            set { country = value; }
        }
        public UserGender Gender
        {
            get { return gender; }
            set { gender = value; }
        }        
        public string Email
        {
            get { return email; }
            set { email = value; }
        }        
        public string Password
        {
            get { return password; }
            set { password = value; }
        }        
        public DateTime BirthdayDate
        {
            get { return birthdayDate; }
            set { birthdayDate = value; }
        }      
    }
}
                                                                                                                                                                                                                                                                     �18             ����   �      ����    ����    ����                                                                                                                                                                                                                                                                                                                                                                                                                                                                        �bQ?���S �O���EK�����? �O����Zf��*  �I�`�n@�d�L��Bԁr��       ���!�Մ	ٗ˔s��                                                                                                                                                     