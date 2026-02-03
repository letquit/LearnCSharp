using System;
using UnityEngine;

public class Records : MonoBehaviour
{
    private void Start()
    {
        Person person = new ("Code", "Monkey");
        Person person3 = new ("Code", "Monkey");
        Debug.Log(person == person3);
        // person.FirstName = "Iron"; 
        Person person2 = person3 with { LastName = "Corilla" };
        
        Debug.Log(person3);
        Debug.Log(person2);
    }

    public record Person(string FirstName, string LastName);
    // public record class Person(string FirstName, string LastName);
    // public record struct Person(string FirstName, string LastName);
    // public record Person(string FirstName, string LastName)
    // {
    //     public string FirstName { get; set;} = FirstName;
    // }

    // public class PersonClass
    // {
    //     public string FirstName { get; init; }
    //     public string LastName { get; init; }
    // }

    public record Unit(float Speed);

    public record Player(string PlayerName, float Speed) : Unit(Speed);
}

namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit {}
}