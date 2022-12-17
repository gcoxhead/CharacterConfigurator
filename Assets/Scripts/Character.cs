using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]

public class Character : ScriptableObject
{
    public string name;
    public string description;

    public Sprite artwork;

    public int attack;
    public int health;
    public int jump;
    public int XP;



}

