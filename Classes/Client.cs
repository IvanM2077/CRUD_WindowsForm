using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

using ExelSolar.Classes;
using ExelSolar.Logica;
using Microsoft.SqlServer.Server;


namespace ExelSolar.Classes
{
    public class Client
    {



        private int IdClient { get; set; }
        private String FirstName { get; set; }
        private String MiddleName { get; set; }
        private String Email { get; set; }
        private int PhoneNumber { get; set; }


        /*
                //propertys for encapsulation

                public int idClient
                {
                    get { return IdClient; }

                    set { IdClient = value; }
                }

                public string firstName
                {
                    get { return FirstName; }
                    set { FirstName = value; }

                }

                public string middleName
                {
                    get { return MiddleName; }
                    set { MiddleName = value; }

                }

                public string email
                {
                    get { return Email; }
                    set { Email = value; }

                }

                public int phoneNumber
                {
                    get { return this.phoneNumber; }
                    set { this.phoneNumber = value; } 

                }

            }

            //para creación desde  la base de datos del objeto
            public Client(int idC, string fname, string mname, string email, int pnumb)
            {
                IdClient = idC;
            }
            //para la lectura desde la base de datos del objeto
        */
        //constructor por defecto
        public Client() { }

        public Client(int id, string fname, string mdname, string email, int phone)
        {
            IdClient = id;
            FirstName = fname;
            MiddleName = mdname;
            Email = email;
            PhoneNumber = phone;
        }



        // Constructor 



        public Client( string fname, string mdname, string email, int phone)
        {
    
            FirstName = fname;
            MiddleName = mdname;
            Email = email;
            PhoneNumber = phone;
        }

        public Client(int id)
        {
            IdClient = id;
        }






        public string FullName()
        {
            return $"{IdClient} {FirstName} {MiddleName}";
        }

        public int GetID()
        {
            return IdClient;
        }


        public string GetFN()
        {
            return FirstName;
        }

        public string GetMN()
        {
            return MiddleName;
        }

        public string GetE()
        {
            return Email;
        }

        public int GetPN()
        {
            return PhoneNumber;
        }
    }
}

