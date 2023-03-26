using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab_3.Errors;
using System.Windows.Controls;

namespace lab_3
{
   
        class Person
        {
            private string name = "noname";
            private string lastname = "nolastname";
            private string email = "noemail";
            private DateTime birthdate = DateTime.Now;
            private bool isAd = false;
            private bool isBirthday = false;
            private string sunSign = "nosign";
            private string chineseSign = "nosign";
            public Person(string name, string lastname, string email, DateTime birthdate)
            {
                this.name = name;
                this.lastname = lastname;
                this.email = email;
                this.birthdate = birthdate;
                if (DateTime.Now.Year - this.BirthDate.Year > 135)
                {
                    throw new EarlyDateError();
                }
            if ((DateTime.Now.Year - this.BirthDate.Year) < 0) { 
            throw new LateDateError();
            }
            if ((DateTime.Now.Year - this.BirthDate.Year) == 0) {
                if ((DateTime.Now.Month - this.BirthDate.Month) < 0) {
                    throw new LateDateError();
                }
                if ((DateTime.Now.Month - this.BirthDate.Month) == 0) {
                    if ((DateTime.Now.Day - this.BirthDate.Day) < 0) {
                        throw new LateDateError();
                    }
                }
            }
            if (!(this.Email.Contains('@'))) { 
            throw new EmailFormat();
            }
            if (!(this.Email.Contains(".com")))
            {
                throw new EmailFormat();
            }
            if (this.Name.Contains(' ')) { 
            throw new NameFormat();
            }
            if (this.Name.Any(char.IsDigit)) {
                throw new NameFormat();
            }
            if (this.LastName.Any(char.IsDigit))
            {
                throw new LastNameFormat();
            }
            CalIsAdult();
                CalIsBirthday();
                this.chineseSign = China_Sign(birthdate);
                this.sunSign = West_Sign(birthdate);
            }
            public Person(string name, string lastname, string email)
            {
                this.name = name;
                this.lastname = lastname;
                this.email = email;
            }
            public Person(string name, string lastname, DateTime birthdate)
            {
                this.name = (string)name;
                this.lastname = (string)lastname;
                this.birthdate = (DateTime)birthdate;
                CalIsAdult();
                CalIsBirthday();
                this.chineseSign = China_Sign(birthdate);
                this.sunSign = West_Sign(birthdate);
            }

            private void CalIsAdult()
            {
                int age = DateTime.Now.Year - this.birthdate.Year;

                if (DateTime.Now.Month < this.birthdate.Month)
                {
                    age -= 1;

                }
                if (DateTime.Now.Month == this.birthdate.Month)
                {
                    if (DateTime.Now.Day < this.birthdate.Day)
                    {
                        age -= 1;
                    }
                }
                this.isAd = NewMethod(age);

                static bool NewMethod(int age)
                {
                    if (age >= 18)
                    {
                        return true;
                    }
                    return false;
                }
            }
            private void CalIsBirthday()
            {
                DateTime date = DateTime.Now;
                if ((this.birthdate.Day == date.Day) && (this.birthdate.Month == date.Month))
                {
                    this.isBirthday = true;
                }


            }
            private string China_Sign(DateTime date)
            {
                if (date.Year % 12 == 0)
                {
                    return "Monkey";
                }
                if (date.Year % 12 == 1)
                {
                    return "Cock";
                }
                if (date.Year % 12 == 2)
                {
                    return "Dog";
                }
                if (date.Year % 12 == 3)
                {
                    return "Pig";
                }
                if (date.Year % 12 == 4)
                {
                    return "Rat";
                }
                if (date.Year % 12 == 5)
                {
                    return "Bull";

                }
                if (date.Year % 12 == 6)
                {
                    return "Tiger";
                }
                if (date.Year % 12 == 7)
                {
                    return "Rabbit";
                }
                if (date.Year % 12 == 8)
                {
                    return "Dragon";
                }
                if (date.Year % 12 == 9)
                {
                    return "Snake";
                }
                if (date.Year % 12 == 10)
                {
                    return "Horse";
                }
                if (date.Year % 12 == 11)
                {
                    return "Goat";
                }
                return "something went wrong";
            }

            private string West_Sign(DateTime date)
            {
                if ((date.Month == 1) && (date.Day < 20))
                {
                    return "Capricon";
                }
                if ((date.Month == 1) && (date.Day >= 20))
                {
                    return "Aquarius";
                }
                if ((date.Month == 2) && (date.Day < 19))
                {
                    return "Aquarius";
                }
                if ((date.Month == 2) && (date.Day >= 19))
                {
                    return "Pisces";
                }
                if ((date.Month == 3) && (date.Day < 21))
                {
                    return "Pisces";
                }
                if ((date.Month == 3) && (date.Day >= 21))
                {
                    return "Aries";
                }
                if ((date.Month == 4) && (date.Day < 20))
                {
                    return "Aries";
                }
                if ((date.Month == 4) && (date.Day >= 20))
                {
                    return "Taurus";
                }
                if ((date.Month == 5) && (date.Day < 21))
                {
                    return "Taurus";
                }
                if ((date.Month == 5) && (date.Day >= 21))
                {
                    return "Gemini";
                }
                if ((date.Month == 6) && (date.Day < 21))
                {
                    return "Gemini";
                }
                if ((date.Month == 6) && (date.Day >= 21))
                {
                    return "Cancer";
                }
                if ((date.Month == 7) && (date.Day < 23))
                {
                    return "Cancer";
                }
                if ((date.Month == 7) && (date.Day >= 23))
                {
                    return "Leo";
                }
                if ((date.Month == 8) && (date.Day < 23))
                {
                    return "Leo";
                }
                if ((date.Month == 8) && (date.Day >= 23))
                {
                    return "Virgo";
                }
                if ((date.Month == 9) && (date.Day < 23))
                {
                    return "Virgo";
                }
                if ((date.Month == 9) && (date.Day >= 23))
                {
                    return "Libra";
                }
                if ((date.Month == 10) && (date.Day < 23))
                {
                    return "Libra";
                }
                if ((date.Month == 10) && (date.Day >= 23))
                {
                    return "Scorpio";
                }
                if ((date.Month == 11) && (date.Day < 22))
                {
                    return "Scorpio";
                }
                if ((date.Month == 11) && (date.Day >= 22))
                {
                    return "Sagittarius";
                }
                if ((date.Month == 12) && (date.Day < 22))
                {
                    return "Sagittarius";
                }
                if ((date.Month == 12) && (date.Day >= 22))
                {
                    return "Capricon";
                }
                else
                {
                    return "something went wrong";
                }
            }


            public string Name
            {

                get { return name; }
            }
            public string LastName
            {

                get { return lastname; }
            }
            public string Email
            {

                get { return email; }
            }
            public DateTime BirthDate
            {

                get { return birthdate; }
            }
            public bool IsAdult
            {

                get { return isAd; }
            }
            public bool IsBirthday
            {

                get { return isBirthday; }
            }
            public string SunSign
            {

                get { return sunSign; }
            }
            public string ChineseSign
            {

                get { return chineseSign; }
            }

        }
    

    }

