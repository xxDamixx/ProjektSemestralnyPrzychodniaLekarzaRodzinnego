using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

// Grafik
public class Grafik
{
    [Key]
    public int Id_Grafik { get; set; }
    public string Imię { get; set; }
    public string Nazwisko { get; set; }
    public string Poniedziałek { get; set; }
    public string Wtorek { get; set; }
    public string Środa { get; set; }
    public string Czwartek { get; set; }
    public string Piątek { get; set; }
    public string Sobota { get; set; }
    public string godz_rozpoczęcia { get; set; }
    public string godz_zakończenia { get; set; }
}

// Lekarz
public class Lekarz
{
    [Key]
    public int Id_Dane_Lekarz { get; set; }
    public string Imię { get; set; }
    public string Nazwisko { get; set; }
    public string Telefon_Kontakt { get; set; }
    public string Dzielnica { get; set; }
    
}
// wizyta
public class Wizyta
{
    [Key]
    public int Id_wizyty { get; set; }
    public string data_wizyty { get; set }
    public string godzina_wizyty { get; set; }
    public string id_pacjenta { get; set; }
    public string id_lekarza { get; set; }
    public string diagnoza { get; set; }
    public string zalecenia { get; set; }
    public string opis { get; set; }
    public string skierowanie { get; set; }
    public string jednostka_chorobowa { get; set; }

}

// pacjent
public class Pacjent
{
    [Key]
    public int id_pacjenta { get; set; }
    public string imię { get; set; }
    public string nazwisko { get; set; }
    public string pesel { get; set; }
    public string data_ur { get; set; }
    public string telefon { get; set; }
    public string dzielnica { get; set; }
}

// rejestracja
public class Rejestracja
{
    [Key]
    public int id_rejestracji { get; set; }
    public int id_lekarza { get; set; }
    public int id_pacjenta { get; set; }
    public string data_wizyty { get; set; }
    public string godzina_wizyty { get; set; }
    public string telefon_pacjenta { get; set; }
}
public class PrzychodniaContext : DbContext
{
    public DbSet<Grafik> Grafiki { get; set; }
    public DbSet<Lekarz> Lekarze { get; set; }
    public DbSet<Wizyta> Lekarzy { get; set; }
    public DbSet<Pacjent> Pacjenci { get; set; }
    public DbSet<Rejestracja> Rejestracja { get; set; }
    public PrzychodniaContext() : base("name=PrzychodniaConnectionString")
    {
    }
    //lekarz
    public void DodajLekarza(Lekarz lekarz)
    {
        Lekarze.Add(lekarz);
        SaveChanges();
    }
    public Lekarz PobierzLekarza(int id)
    {
        return Lekarze.Find(id);
    }
    public void AktualizujLekarza(Lekarz lekarz)
    {
        Entry(lekarz).State = EntityState.Modified;
        SaveChanges();
    }
    public void UsunLekarza(Lekarz lekarz)
    {
        Lekarze.Remove(lekarz);
        SaveChanges();
    }
    //Grafik
    public void DodajGrafik(Grafik grafik)
    {
        Grafiki.Add(grafik);
        SaveChanges();
    }

    public Grafik PobierzGrafik(int id)
    {
        return Grafiki.Find(id);
    }

    public void AktualizujGrafik(Grafik grafik)
    {
        Entry(grafik).State = EntityState.Modified;
        SaveChanges();
    }

    public void UsunGrafik(Grafik grafik)
    {
        Grafiki.Remove(grafik);
        SaveChanges();
    }
    //wizyta
    public void DodajWizyte(Wizyta wizyta)
    {
        Wizyta.Add(wizyta);
        SaveChanges();
    }

    public Wizyta PobierzWizyte(int id)
    {
        return Wizyta.Find(id);
    }

    public void AktualizujWizyte(Wizyta wizyta)
    {
        Entry(wizyta).State = EntityState.Modified;
        SaveChanges();
    }

    public void UsunWizyte(Wizyta wizyta)
    {
        Wizyta.Remove(wizyta);
        SaveChanges();
    }
    //Pacjent
    public void DodajPacjenta(Pacjent pacjent)
    {
        Pacjenci.Add(pacjent);
        SaveChanges();
    }

    public Pacjent PobierzPacjenta(int id)
    {
        return Pacjenci.Find(id);
    }

    public void AktualizujPacjenta(Pacjent pacjent)
    {
        Entry(pacjent).State = EntityState.Modified;
        SaveChanges();
    }

    public void UsunPacjenta(Pacjent pacjent)
    {
        Pacjenci.Remove(pacjent);
        SaveChanges();
    }
    //Rejestracja
    public void DodajRejestracje(Rejestracja rejestracja)
    {
        Rejestracja.Add(rejestracja);
        SaveChanges();
    }

    public Rejestracja PobierzRejestracje(int id)
    {
        return Rejestracja.Find(id);
    }

    public void AktualizujRejestracje(Rejestracja rejestracja)
    {
        Entry(rejestracja).State = EntityState.Modified;
        SaveChanges();
    }

    public void UsunRejestracje(Rejestracja rejestracja)
    {
        Rejestracja.Remove(rejestracja);
        SaveChanges();
    }
}

