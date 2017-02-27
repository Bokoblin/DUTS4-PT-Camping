using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PT_Camping.Model
{
    /// <summary>
    /// This class provides a sha256 conversion 
    /// and a checkConnection method to use before each request
    /// 
    /// </summary>
    /// Authors : Alexandre
    /// Since : 15/02/17
    public class LoginTools
    {
        public String Login { get; set; }

        public String HashedPassword { get; set; }

        public Personne Person { get; set; }

        public bool checkConnection()
        {
            try
            {
                DataBase db = new DataBase();
                bool exist = (db.Employe.Where(u => u.Login == Login && u.Password == HashedPassword).Count() >= 1);
                if (exist)
                {
                    Person = db.Personne.FirstOrDefault(p => p.Code_Personne == db.Employe.FirstOrDefault(l => l.Login == this.Login).Code_Personne);
                }
                db.Dispose();
                return exist;
            } catch (Exception)
            {
                MessageBox.Show("Erreur lors de la connexion à la base de données");
                Application.Exit();
            }
            return false;
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
