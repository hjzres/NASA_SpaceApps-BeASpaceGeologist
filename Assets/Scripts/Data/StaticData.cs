using System.Collections.Generic;
using UnityEngine;

public static class StaticData
{
    // Scenes
    public static int TitleScreen = 0;

    public static int WorldOne = 1;

    public static int WorldTwo = 2;

    public static int WorldThree = 3;

    public static int currentScene = 0;

    // Movement Properties
    public static Vector2 mouseSensitivity = new Vector2(40, 40) * 5; 

    public static float xRotation, yRotation;

    public static int volume = 100;

    public static int fov = 60;

    // dictionary that holds string as the keyname and the rockdata as the value with some rocks being in the dictionary already
    public static Dictionary<string, RockData> worldOneRocks = new Dictionary<string, RockData>()
    {
        {"Al", new RockData("Aluminum", 2, new[] {
                                            "Aluminium has a hardness of 2.5 on the Mohs scale",
                                            "Aluminum is the most abundant metal in the Earth's crust, making up about 8% of its weight",
                                            "Aluminium is widely used in various industries, including transportation, construction, packaging, and electrical transmission lines."
        })},
        {"Cu", new RockData("Copper", 5, new[] {
                                            "Copper has a hardness of 2.5 - 3 on the Mohs scale",
                                            "Copper is a relatively common metal, and it is the third most abundant trace element in the human body",
                                            "Copper has excellent electrical and thermal conductivity, making it suitable for electrical wiring, plumbing systems, and the production of various allys like bronze and brass. It is also used in architecture, conage, and artwork"
        })},
        {"Fe", new RockData("Iron", 7, new[]{
                                            "Iron has a hardness of 4 on the Mohs scale",
                                            "Iron is the most abundant element on Earth by mass, making up 35% of the Earth's mass and the fourth most abundant element in the Earth's crust",
                                            "Iron is used in the production of steel, which is used in the construction of buildings, automobiles, and various other appliances"
        })}
    };

    public static Dictionary<string, RockData> worldTwoRocks = new Dictionary<string, RockData>()
    {
        {"Au", new RockData("Gold", 10, new[]{
                                            "Gold has a hardness of 2.5 - 3 on the Mohs scale",
                                            "Gold is the most malleable metal, meaning it can be hammered into thin sheets without breaking",
                                            "Gold is used in jewelry, coinage, and electronics"
        })},
        {"Ti", new RockData("Titanium", 10, new[]{
                                            "Titanium has a hardness of 6 on the Mohs scale",
                                            "Titanium is the ninth most abundant element in the Earth's crust",
                                            "Titanium is used in the production of aircraft, spacecraft, and various other objects that require a strong, lightweight material"
        })},
        {"Pt", new RockData("Platinum", 8, new[]{
                                            "Platinum has a hardness of 4 - 4.5 on the Mohs scale",
                                            "Platinum is the least reactive metal, meaning it does not corrode in air",
                                            "Platinum is used in the production of jewelry, laboratory equipment, and catalytic converters"
        })}
    };

    public static Dictionary<string, RockData> worldThreeRocks = new Dictionary<string, RockData>()
    {
        {"Ma", new RockData("Magnetite", 9, new[]{
                                            "Magnetite has a hardness of 5.5 - 6.5 on the Mohs scale",
                                            "Magnetite is the most magnetic mineral on Earth",
                                            "Magnetite is used in the production of iron and steel"
        })},
        {"Cr", new RockData("Chormite", 8, new[]{
                                            "Chormite has a hardness of 5.5 on the Mohs scale",
                                            "Chormite is the most important ore of chromium",
                                            "Chormite is used in the production of stainless steel"
        })},
        {"Il", new RockData("Ilmenite", 10, new[]{
                                            "Ilmenite has a hardness of 5 - 6 on the Mohs scale",
                                            "Ilmenite is the most important ore of titanium",
                                            "Ilmenite is used in the production of titanium dioxide, which is used in the production of paint, sunscreen, and food coloring"
        })}
    };
}
