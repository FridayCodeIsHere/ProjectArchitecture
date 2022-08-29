using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleUnitManager : Singleton<ExampleUnitManager>
{
    public void SpawnHeroes()
    {
        SpawnUnit(HeroType.Tarodev, new Vector3(1, 0, 0));
    }

    public void SpawnEnemies()
    {

    }

    public void SpawnUnit(HeroType type, Vector3 pos)
    {
        ScriptableHero tarodevScriptable = ResourceSystem.Instance.GetHero(type);
        UnitBase spawned = Instantiate(tarodevScriptable.Prefab, pos, Quaternion.identity, transform);

        Stats stats = tarodevScriptable.BaseStats;
        stats.Health += 20;

        spawned.SetStats(stats);
    }
}
