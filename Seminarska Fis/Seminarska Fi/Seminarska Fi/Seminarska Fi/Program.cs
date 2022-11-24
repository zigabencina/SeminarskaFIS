using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminarska_Fi
{

    class UporabniskiVmesnik
    {

        string[,] uporabniki = new string[100,100];
        // na indeksu 0 je tip uporabnika 
        // na indeksu 1 je uporabniško ime
        // na indeksu 2 je geslo
        int stUporabnik;
        


        string[,,] pocitnice = new string[100, 100, 100];

        public int stUporabnikov()
        {
            return stUporabnik;
        }


        public void append()
        {
            uporabniki[0, 0] = "admin";
            uporabniki[0, 1] = "user";
            uporabniki[0, 2] = "user";
            uporabniki[1, 0] = "admin";
            stUporabnik +=1;
            uporabniki[1, 1] = "benzig";
            stUporabnik += 1;
            uporabniki[1, 2] = "aljazm";
            stUporabnik += 1;
            uporabniki[2, 0] = "password";
            uporabniki[2, 1] = "zigben";
            uporabniki[2, 2] = "maljaz";
        }

        public bool aliObstaja(string uporabnik)
        {
            for(int i = 0; i < uporabniki.GetUpperBound(1); i++)
            {
                if(uporabniki[1, i] == uporabnik || uporabniki[1, 0] == uporabnik)
                {
                    return false;
                }
            }


            return true;
        }

        public void registracijaUporabnika(string uporabnik, string pass)
        {
            if (aliObstaja(uporabnik))
            {

                uporabniki[0, stUporabnikov()] = "user";
                uporabniki[1, stUporabnikov()] = uporabnik;
                uporabniki[2, stUporabnikov()] = pass;

                MessageBox.Show(String.Format("Vspesno registrirani {0}", uporabnik));
           

                
            }
            else
            {
                MessageBox.Show("Uporabniško ime je zasedeno");
            }
        }
        public bool vpisUporabnika(string uporabnik,string pass)
        {
            if (!aliObstaja(uporabnik) && uporabnik != "admin")
            {
                for (int i = 0; i < uporabniki.Length; i++)
                {
                    if (uporabniki[1, i] == uporabnik)
                    {
                        if (uporabniki[2, i] == pass)
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
                    if (uporabniki[1, i] == uporabnik)
                    {
                        if (uporabniki[2, i] == pass)
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
