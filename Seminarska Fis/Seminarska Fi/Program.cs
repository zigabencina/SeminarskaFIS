using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Seminarska_Fi
{

    class UporabniskiVmesnik
    {

        string[,] uporabniki; // = new string[100,3];
        // na indeksu 0 je tip uporabnika 
        // na indeksu 1 je uporabniško ime
        // na indeksu 2 je geslo
        int stUporabnik;
        string path = @"C:\Users\Dijak\Downloads\SeminarskaFIS-main\SeminarskaFIS-main\Seminarska Fis\Seminarska Fi\uporabniki.txt";
        public void podatki()
        {
            string[] lines = File.ReadAllLines(path);
            uporabniki = new string[lines.Length, 3];
            int st = 0;
            foreach (string i in lines)
            {
                string [] podatek = i.Split(',');

                for(int pod = 0; pod < podatek.Length; pod++)
                {
                    uporabniki[st,pod] = podatek[pod];
                }
                st++;
                stUporabnik++;
            }
        }

        


        public int stUporabnikov()
        {
            return stUporabnik;
        }


        public bool aliObstaja(string uporabnik)
        {
            for(int i = 0; i < stUporabnikov(); i++)
            {
                
                if(uporabniki[i, 1] == uporabnik)
                {
                    return false;
                }
            }


            return true;
        }

        public void registracijaUporabnika(string uporabnik, string pass)
        {
            if (aliObstaja(uporabnik) && uporabnik != "")
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(string.Format("user,{0},{1}",uporabnik,pass));
                }
                

                MessageBox.Show(String.Format("Vspesno registrirani {0}", uporabnik));

                stUporabnik += 1;
                podatki();

            }
            else
            {
                MessageBox.Show("Uporabniško ime je zasedeno oz neveljavno");
            }
        }
        public bool vpisUporabnika(string uporabnik,string pass)
        {
            
            
            if (!aliObstaja(uporabnik) && uporabnik != "admin")
            {
                for (int i = 0; i < stUporabnikov(); i++)
                {

                    if (uporabniki[i, 1] == uporabnik)
                    {
                        
                        if (uporabniki[i, 2] == pass)
                        {
                            
                            return true;
                      
                            
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else if (uporabnik == "admin" && pass == "password")
            {
                for (int i = 0; i < uporabniki.Length; i++)
                {
                    if (uporabniki[i,1] == uporabnik)
                    {
                        if (uporabniki[i,2] == pass)
                        {
                            AdminVmesnik.a();
                            return true;
                            

                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                
            }

            
            
            return false;


        }

        // po časovem okvirju
        static void iskanjePoctinic(string p)
        {

        }

    }
    class AdminVmesnik
    {
        public static void a()
        {
            MessageBox.Show("okej");
        }
    }


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
