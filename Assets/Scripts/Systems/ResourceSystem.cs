using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSystem : Singleton<ResourceSystem>
{
    public List<ScriptableHero> Heroes { get; private set; }
    private Dictionary<HeroType, ScriptableHero> _heroesDict;

    protected override void Awake()
    {
        base.Awake();
        AssembleResources();
    }

    private void AssembleResources()
    {
        Heroes = Resources.LoadAll<ScriptableHero>("Heroes").ToList();
        _heroesDict = Heroes.ToDictionary(x => x.HeroType, x => x);
    }

    public ScriptableHero GetHero(HeroType type)
    {
        return _heroesDict[type];
    }

    public ScriptableHero GetRandomHero(HeroType type)
    {
        int randomIndex = Random.Range(0, Heroes.Count);
        return Heroes[randomIndex];
    }
}
