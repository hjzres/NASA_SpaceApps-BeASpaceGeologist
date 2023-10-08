using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class RockData
{
    public string name;
    public float durability;
    public string[] facts;

    public RockData(string rockName, float durability, string[] facts)
    {
        this.name = rockName;
        this.durability = durability;
        this.facts = facts;
    }



}
