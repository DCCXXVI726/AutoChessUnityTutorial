using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDmgCommand : Command
{
    Character   target;
    float       dmg;
    public DealDmgCommand(Character target, float dmg)
    {
        this.target = target;
        this.dmg = dmg;
    }

    public void Execute()
    {
        HealthAbility healthAbility = (HealthAbility)target.getAbility(typeof(HealthAbility));

        if (healthAbility == null)
        {
            Debug.Log("Don't have HealthAbility");
            return ;
        }
        healthAbility.health--;
        healthAbility.health = Mathf.Max(0, healthAbility.health);
    }
    //Придумать куда засунуть смерть
}
