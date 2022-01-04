using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeTimer
{
    class UserStatement
    {
        /**
         * 本次使用者的資料
         */ 
        private static string USERNAME;
        private static string PASSWORD;
        private static string EMAILADDRESS;
        private static int PHONENUMBER;
        private static int SCORINGTIMES;
        private static double[] PLAYTIMES = new double[1000];

        /**
         * 以下皆是和這些資料連結的函式
         */ 
        
        /************************inserts************************/
        public void inUser(string input)
        {
            USERNAME = input;
        }

        public void inPassword(string input)
        {
            PASSWORD = input;
        }

        public void inEmail(string input)
        {
            EMAILADDRESS = input;
        }

        public void inPhone(int input)
        {
            PHONENUMBER = input;
        }

        public void inTimes(int input)
        {
            SCORINGTIMES = input;
        }

        public void inPlayTime(int space, double num)
        {
            PLAYTIMES[space] = num;
        }

        /************************upudates************************/
        public void updateTimes()
        {
            SCORINGTIMES++;
        }

        /************************gets************************/
        public string getUser()
        {
            return USERNAME;
        }

        public string getPassword()
        {
            return PASSWORD;
        }

        public string getEmail()
        {
            return EMAILADDRESS;
        }

        public int getPhone()
        {
            return PHONENUMBER;
        }

        public int getTimes()
        {
            return SCORINGTIMES;
        }

        public double[] getPlayTime()
        {
            return PLAYTIMES;
        }
    }
}
