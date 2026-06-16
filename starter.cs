using System;
using System.Collections.Generic;

public class Contact
{
    public string Naam { get; set; }
    public string Telefoonnummer { get; set; }
    public string Email { get; set; }
}

public class ContactenLijst
{
    private List<Contact> _contacten = new List<Contact>();

    public void VoegContactToe(Contact contact)
    {
        // Implementeer hier de logica om een contact toe te voegen
    }

    public List<Contact> HaalAlleContactenOp()
    {
        // Implementeer hier de logica om alle contacten op te halen
        return _contacten;
    }

    public void VerwijderContact(string naam)
    {
        // Implementeer hier de logica om een contact te verwijderen op basis van naam
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Hier kun je de ContactenLijst klasse testen
        Console.WriteLine("Contactenlijst Manager");
    }
}