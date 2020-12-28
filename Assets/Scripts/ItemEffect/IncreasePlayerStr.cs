using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class IncreasePlayerStr : UsableItem.UsageEffect
{
    public override bool Use(CharacterData user)
    {
        //StatModifier strUp = new StatModifier(2);

        //user.Stats.AddModifier(strUp);
        return true;
    }
}
