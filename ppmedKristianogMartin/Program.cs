using System.Xml.Schema;

namespace ppmedKristianogMartin
{
    internal class Program
    {
        /*
         
        Forkortet: 
        Man skal kunne tjene penger for å kunne kjøpe pins rundt i Telemarkområdet.
        Man skal kunne reise fra stasjon til stasjon.

        Lag din karakter!

        Hva skal hen hete? ____ <- Legg til navn
        Hva skal den kjøre? ____ <- Legg til biltype

        Du kan velge én ting for å forbedre sjansene dine til å samle alle pinsene i hele Telemark!
        Du har en obligatorisk cowboyhatt og gitar fra før.
        1) 1 ekstra cowboyhatt (Du har den oppå den første cowboyhatten; avslag på pins)
        2) Balltre med glitter (Forsikring om at de på stasjonen gir deg avslag på drivstoff)
        3) Illeluktende cowboyboots (avslag på drivstoff men du må betale ekstra for pins)
        4) Munnspill (du får bonus i random betaling til opptredelser)


        Penger: xxx Kr (int)
        Drivstoff: xxx Liter (int)

        Stasjon: [Stasjonsnavn]

        a) Kjøp en pin
            - xx Kr
            - beskrivelse...?
        b) Kjør videre
            b.1) Stasjon A (xxx drivstoff kreves)
                > Du kom deg frem!
                > Du gikk tomt. Du må taues tilbake til forrige bensinstasjon
                og dette trekker fra pengene. Det krever å fylle på igjen.
            b.2) Stasjon B (xxx drivstoff kreves)
        c) Legg til drivstoff
        d) Opptre for penger
            > random Amount av penger man kan tjene
        e) Beundre cowboyhatten din
            > Den har xxx pins.

        while (true)
        {
            if (have enough drivstoff)
            {can continue on to next stasjon}
            else (dont have enough)
            {cannot leave}

            if (bool = true)
            {drivstoff--;} // DEN TAPPES MELLOM HVER STASJON
        }

        Per bensinstasjon så kreves det viss mengde drivstoff.

        Stasjon A  eller Stasjon B

         Du skal i denne appen samle pins - forskjellige pins finnes på forskjellige bensinstasjoner
        i forskjellige kommuner i Telemark fylke. Oppgaven din er å kjøpe dem alle!
         Du starter med å lage din pins-samler-karakter og kan velge mellom noen forskjellige
        egenskaper som gjør pins-samlingen enklere. “Balltre med glitter” for å få avslag
        i pins pris, 
        “Pins Prins” for å få en liten mulighet til å få en ekstra pins når du kjøper og
        “Wånderbævm i Ruta” som gir deg mulighet til å ta turen til én ekstra bensinstasjon
        før du er tom for bensin. Man skal bare kunne velge seg én av disse ekstra boost
        egenskapene
         Det skal koste bensin å kjøre fra stasjon til stasjon, når tanken er tom får du en
        timeout for å fylle bensin (koster penger) før du kan kjøre til neste stasjon. Pinsen
        koster også penger. 
         Pinsen skal samles på cowboyhatten din, du skal kunne ta den av og se på den for å
        se hvilke pins du har samlet og hvilke du mangler. Du tjener penger ved å spille gitar
        og synge på bensinstasjonene, det er tilfeldig hvor mye penger du tjener.

         */


        static void Main(string[] args)
        {
            List<PinsSamleren> usersList = new List<PinsSamleren>();


            bool gameActive = true;


            while (gameActive)

            {

                Console.WriteLine("Velkommen til Pinssamlerspillet!");
                Console.WriteLine("(tegning av bil)");
                Console.WriteLine("   > Lag Ny Bruker           [1]");
                Console.WriteLine("   > Avslutt                 [2]");
                Console.WriteLine("   > Vis tidligere spillere  [3]");

                var menuChoice = Console.ReadKey().KeyChar;


                switch (menuChoice)
                {
                    case '1':
                        CreateUser();
                        SecondMenu();
                        break;

                    case '2':
                        gameActive = false;
                        break;

                    case '3':
                        ShowUsers();
                        break;

                    case '4':

                        break;

                    default:
                        break;

                }

            }

            void CreateUser()
            {
                Console.Clear();
                Console.WriteLine("Type your Username!\n");
                string name = Console.ReadLine();
                double wallet = 0;
                int carFuel = 0;
                var Pins = new List<Pins>();

                Console.WriteLine("Choose your bonus item");
                string bonusItem = Console.ReadLine();




                usersList.Add(new PinsSamleren(name, wallet, carFuel, bonusItem, Pins));

            }

            void SecondMenu()
            {
                Console.Clear();

                Console.WriteLine($"Velkommen til Pinssamlerspillet, {usersList[0].Name}! Du skal samle pins fra hele Telemark. Du har en cowboyhatt, en gitar, en bil, og en {usersList[0].BonusItem}");
                Console.WriteLine("(tegning av bil)");
                Console.WriteLine("   > Start Spillet           [1]");
                Console.WriteLine("   > Avslutt                 [2]");

                //bool ActualGameActive = true;
                var menuChoice = Console.ReadKey().KeyChar;


                    switch (menuChoice)
                    {
                        case '1':
                            TheTrueGame();
                            break;

                        case '2':
                            gameActive = false;
                            break;

                        case '3':
                            break;
                        
                        default:
                            break;
                    }
            }

            void TheTrueGame()
            {
                Console.Clear();
                Console.WriteLine("Du er hjemme, rett utenfor huset ditt. Du er klar for eventyr og PINS!!");
                Console.WriteLine("Handlinger:");
                Console.WriteLine(" > Sjekk inventory                    [1]");
                Console.WriteLine(" > Kjør til nærmeste bensinstasjon!\n   (krever XX drivstoff)              [2]");

                var menuChoice = Console.ReadKey().KeyChar;

                switch (menuChoice)
                {
                    case '1':
                        inventoryCheck();
                        break;
                    
                    case '2':
                        driveToNextStation();
                        break;

                    default:
                        break;
                }
            }

            void inventoryCheck()
            {
                Console.WriteLine("Du har...");
                Console.WriteLine(" > 1 cowboyhatt\n > 1 bil\n > 1 gitar\n 1 " + usersList[0].BonusItem);
            }
            void driveToNextStation()
            {
                if (haveEnoughFuel = true)
                
                Console.WriteLine("Du har kommet deg trygt til stasjonen!");
                Console.WriteLine("Du har " + "XXXX" + "drivstoff igjen.");
            }


            void ShowUsers()
            {
                foreach (var user in usersList)

                {
                    Console.WriteLine("Spillere:");
                    Console.WriteLine($"Navn: {user.Name}; Lommebok: {user.Wallet} Kr");



                }



            }


            //void CreateUser()
            //{
            //    Console.Clear();
            //    Console.WriteLine("Type your Username");
            //    string name = Console.ReadLine();
            //    double wallet = 0;
            //    int carFuel = 0;
            //    Console.WriteLine("Choose your bonus item");
            //    string bonusItem = Console.ReadLine();
            //    usersList.Add(new PinsSamleren(name, wallet, carFuel));

            //}







        }
    }
}
