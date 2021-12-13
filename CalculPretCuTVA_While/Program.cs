using System;

namespace CalculPretCuTVA_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int pret_fara_tva, tva_procent;
            float tva_valoare, pret_cu_tva;
            Boolean ok = false;

            while (!ok)
            {
                try
                {
                    ok = true; //presupun ca datele vor fi citite corect
                    Console.Write("pret = ");
                    pret_fara_tva = Int16.Parse(Console.ReadLine());
                    if (pret_fara_tva <= 0) throw new Exception("Pretul trebuie sa fie un numar pozitiv");
                    Console.Write("procentul TVA = ");
                    tva_procent = Convert.ToInt16(Console.ReadLine());
                    if (tva_procent < 0) throw new Exception("TVA trebuie sa fie un numar mai mare decat 0");
                    tva_valoare = pret_fara_tva * (float)tva_procent / 100;
                    pret_cu_tva = pret_fara_tva + tva_valoare;
                    Console.WriteLine("pret = {0}, procentul TVA = {1}, \n valoarea TVA = {2}, pretul cu TVA = {3}", pret_fara_tva, tva_procent, tva_valoare, pret_cu_tva);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    ok = false; //daca datele sunt incorecte, se reia citirea lor
                }
            }
        }
    }
}
