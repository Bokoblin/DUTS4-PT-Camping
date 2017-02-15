using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PT_Camping.Model
{
    public class UserLoged
    {
        private String _login;
        public String Login {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
                DataBase db = new DataBase();
                Person = db.Personne.FirstOrDefault(p => p.Code_Personne == db.Employe.FirstOrDefault(l => l.Login == this.Login).Code_Personne); 
            }
        }
        public String HashedPassword { get; set; }

        public Personne Person { get; set; }

        public bool checkConnection()
        {
            DataBase db = new DataBase();
            return (db.Employe.Where(u => u.Login == Login && u.Password == HashedPassword).Count() >= 1);
        }

        public static String sha256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                {
                    Sb.Append(b.ToString("x2"));
                }
            }

            return Sb.ToString();
        }
    }
}
