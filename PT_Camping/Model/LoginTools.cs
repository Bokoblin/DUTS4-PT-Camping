using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using PT_Camping.Properties;

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
        public string Login { get; set; }

        public string HashedPassword { get; set; }

        public Employe Employee { get; set; }

        public bool CheckConnection()
        {
            try
            {
                DataBase db = new DataBase();
                bool exist = (db.Employe.Any(u => u.Login == Login && u.Password == HashedPassword));
                if (exist)
                {
                    Employee = db.Employe.FirstOrDefault(e => e.Code_Personne == db.Employe.FirstOrDefault(l => l.Login == Login).Code_Personne);
                    if (Employee != null)
                        Employee.Personne = db.Personne.FirstOrDefault(p => p.Code_Personne == db.Employe.FirstOrDefault(l => l.Login == Login).Code_Personne);
                }
                db.Dispose();
                return exist;
            } catch (Exception)
            {
                MessageBox.Show(Resources.database_connection_error);
                Application.Exit();
            }
            return false;
        }

        public static string Sha256_hash(string value)
        {
            StringBuilder sb = new StringBuilder();

            using (SHA256 hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                var result = hash.ComputeHash(enc.GetBytes(value));

                foreach (byte b in result)
                {
                    sb.Append(b.ToString("x2"));
                }
            }

            return sb.ToString();
        }
    }
}
