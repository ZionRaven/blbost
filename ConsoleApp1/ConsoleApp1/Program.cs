namespace main
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Diagnostics;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítej ve hře Představ Si");
            Player hrac = new Player("Hráč", 100, 10, "doma", 100);
            hrac.AddItem(new Nabytek("stůl", 100, "zde můžeš pokládat své itemy"));
            hrac.AddItem(new Nabytek("židle", 100, "zde si můžeš ukládat svůj postup"));
            hrac.AddItem(new Nabytek("knihovna", 100, "zde si můžeš přečíst manuál"));
            VypisPolohy(hrac);
            /// ////////////////////////////////////
            static void VypisPolohy(Player hrac)
            {
                Console.WriteLine($"Právě se nacházíš: {hrac.Poloha}");
                if (hrac.Poloha == "doma")
                {
                    Console.WriteLine($"Ve svém domově máš: {string.Join(", ", hrac.GetInventoryNames())}");
                }
                Console.WriteLine("Chceš otevřít dveře?");
                string volba = Console.ReadLine();
                if (volba == "ano" || volba == "Ano")
                {
                    OtevritDvere();
                }
            }
            /// ////////////////////////////////////

            //    string path = "PlayerData.csv";
            //    StreamReader readFile = new StreamReader("PlayerData.csv");
            //     string obsah = File.ReadAllText(path);
            //    Console.Write("Zadej své jméno:");
            //    string loginName = Console.ReadLine();
            //    if (obsah.Contains(loginName))
            //    {
            //      Console.Write("Zadej své heslo:");
            //      string loginPassword = Console.ReadLine();
            //        if (obsah.Contains(loginPassword))
            //        {
            //           Boolean pass = true;
            //           Console.WriteLine("byl si úspěšně přihlášen");
            //         readFile.Close();
            //        }
            //       else
            //       {
            //          Console.WriteLine("zadal si špatné heslo");
            //        }
            //  }
            //   else
            //   {
            //        readFile.Close();
            //       StreamWriter writetoFile = new StreamWriter("PlayerData.csv", true);
            //      writetoFile.WriteLine(loginName);
            //       writetoFile.Close();
            //    }





        }

        /// ////////////////////////////////////
        static void OtevritDvere()
        {
            Console.WriteLine("právě jsi otevřel dveře");
            Console.WriteLine("můžeš jít: na náměstí / na lov / na ring / do jídelny / zůstat doma");
            Console.WriteLine("Kam si přeješ jít?");
            string odchod = Console.ReadLine();
            switch (odchod)
            {
                case ("na námeěstí"):
                    Console.WriteLine("právě se nacházíš na naměstí");
                    break;
                case ("na lov"):
                    Console.WriteLine("jsi na lovu");
                    break;
                case ("na ring"):
                    Console.WriteLine("právě se nacházíš v ringu");
                    break;
                case ("do jídelny"):
                    Console.WriteLine("právě se nacházíš v jídelně");
                    break;
                default:
                    Console.WriteLine("stále se nacházíš doma");
                    break;
            }
        }
    }
    /// ////////////////////////////////////
    internal class Lokace
    {
        public string Nazev { get; private set; }
        public string Popis { get; private set; }
        public Lokace(string nazev, string popis)
        {
            Nazev = nazev;
            Popis = popis;
        }
    }
    /// ////////////////////////////////////
    internal class Nabytek
    {
        public string Nazev { get; private set; }
        public int Cena { get; private set; }
        public string Popis { get; private set; }
        public Nabytek(string nazev, int cena, string popis)
        {
            Nazev = nazev;
            Cena = cena;
            Popis = popis;
        }
        public override string ToString() => Nazev;
    }
    /// ////////////////////////////////////
    internal class Player
    {
        public string Jmeno { get; private set; }
        public int Hp { get; private set; }
        public int Attack { get; private set; }
        public string Poloha { get; private set; }
        public int Penize { get; private set; }
        private List<Nabytek> inventar = new List<Nabytek>();
        public Player(string jmeno, int hp, int attack, string poloha, int penize)
        {
            Jmeno = jmeno;
            Hp = hp;
            Attack = attack;
            Poloha = poloha;
            Penize = penize;
        }
        public void AddItem(Nabytek item) => inventar.Add(item);

        public IEnumerable<string> GetInventoryNames()
        {
            foreach (var it in inventar)
                yield return it.Nazev;
        }
    }
    /// ////////////////////////////////////
    internal class Zbrane
    {
        public string Nazev { get; private set; }
        public int Cena { get; private set; }
        public string Popis { get; private set; }
        public int Damage { get; private set; }
        public int Hmotnost { get; private set; }
        public Zbrane(string nazev, int cena, string popis, int damage, int hmotnost)
        {
            Nazev = nazev;
            Cena = cena;
            Popis = popis;
            Damage = damage;
            Hmotnost = hmotnost;

        }
    }
    /// ////////////////////////////////////
    internal class Market
    {
        public string Nazev { get; private set; }
        public int Cena { get; private set; }
        public string Popis { get; private set; }

        public Market(string nazev, int cena, string popis)
        {
            Nazev = nazev;
            Cena = cena;
            Popis = popis;
        }
        private string Nabidka (string Nazev,  int cena, string popis)
            Console.WriteLine("")
        {

        }
        private string Koupe (string Nakup, string Nazev,  int cena)
        {




        }
    }
}
/// ////////////////////////////////////
