using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public string Name;
    public string Description;

    public int ProtectionClass;
    public int Hits;
    public string HitsFormula;
    public int Speed;

    //Dictionary<string,int> Characteristics;

    public int Strength;
    public int Dexterity;
    public int BodyType;
    public int Intelligence;
    public int Wisdom;
    public int Charisma;

    public string[] Skills;
    public string Senses;
    public string[] Languages;
    public string Danger;

    public string[] Actions;
}
