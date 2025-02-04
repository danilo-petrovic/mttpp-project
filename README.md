# mttpp-project
Projekt iz kolegija "Metode i tehnike testiranja programske podrške"

1. Izrada testova u Katalon Recorderu
Za testiranje željene web-stranice koristi se Katalon Recorder (by Selenium).

    Prvo je potrebno preuzeti i otvoriti Katalon Recorder.
    Unutar aplikacije pronaći direktorij "Test Suites" i započeti izradu testova klikom na "Record".
    Nakon što se test snimi, može se pokrenuti pritiskom na "Play test case".
    Kada su svi testovi kreirani, mogu se izvesti klikom na opciju "Export", koja se nalazi u donjem lijevom kutu aplikacije.
    Za izvođenje testova u C# aplikaciji, potrebno je izabrati format "Export - C# (WebDriver + NUnit)".

2. Izrada aplikacije u Visual Studiu
    Nakon što su testovi kreirani i izvezeni, potrebno je napraviti aplikaciju u Visual Studiu za njihovo izvođenje.
    
    Pokrenuti Visual Studio i kreirati novi projekt putem opcija:
    File -> New -> Templates -> NUnit Test Project.
    Nakon kreiranja projekta, potrebno je dodati nužne pakete kako bi aplikacija ispravno izvršavala testove. To se radi putem Project -> Manage NuGet Packages, a potrebno je instalirati sljedeće pakete:
        NUnit framework
        Selenium WebDriver
        Selenium Support
        NUnit3 Test Adapter
        Selenium WebDriver – Gecko Driver (za izvođenje testova u Firefoxu)
    Nakon instalacije, provjeriti jesu li svi paketi uspješno dodani.

3. Integracija i izvršavanje testova
    Unutar UnitTest klase dodati testove prethodno izvezene iz Katalon Recordera u C# (WebDriver + NUnit) formatu.
    Provjeriti sadrži li klasa potrebne metode za ispravno izvođenje testova:
        [SetUp] – metoda koja se izvodi prije svakog testa
        [Test] – metoda koja predstavlja pojedini test
        [TearDown] – metoda koja se izvodi nakon svakog testa
    Po potrebi se mogu dodati novi testovi, mijenjati postojeći kod ili proširiti funkcionalnosti.

4. Pokretanje i provjera testova
    Kada su testovi spremni, odabrati opciju Build -> Build Solution kako bi se provjerila ispravnost koda.
    Ako je build uspješan, otvoriti Test Explorer putem:
    Test -> Windows -> Test Explorer i pokrenuti testove klikom na "Run Tests".
    Ako testovi prođu bez grešaka, postupak je završen.
    Ako se pojave greške, potrebno ih je ispraviti prema porukama iz Test Explorer-a, ponoviti Build Solution i ponovno pokrenuti testove.
