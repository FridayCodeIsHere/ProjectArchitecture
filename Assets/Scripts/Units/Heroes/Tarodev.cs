using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarodev : HeroUnitBase
{
    [SerializeField] private AudioClip _someSound;

    private void Start()
    {
        AudioSystem.Instance.PlaySound(_someSound);
    }

    public override void ExecuteMove()
    {
        //Perform tarodev specific animation, do damage, move etc.
        //You'll obviously need to accept the move specifics as an argument to this function.
        base.ExecuteMove();
    }
}
