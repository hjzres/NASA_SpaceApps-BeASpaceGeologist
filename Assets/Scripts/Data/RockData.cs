using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class RockData
{
    public string name;
    public float durability;
    public Rarity rarity;

    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary
    }

    public RockData(string rockName, float durability, int rarity)
    {
        this.name = rockName;
        this.durability = durability;
        this.rarity = (Rarity)rarity;
    }



}
