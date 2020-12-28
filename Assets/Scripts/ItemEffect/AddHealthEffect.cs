using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class AddHealthEffect : UsableItem.UsageEffect
{
    public int HP_Increase;

    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(HP_Increase);

        return true;
    }
}
