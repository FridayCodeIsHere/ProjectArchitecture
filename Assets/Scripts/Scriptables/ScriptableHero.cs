using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/HeroData", fileName = "New Hero Data", order = 1)]
public class ScriptableHero : ScriptableUnitBase
{
    public HeroType HeroType;
}

[Serializable]
public enum HeroType
{
    Tarodev,
    Snorlax
}
