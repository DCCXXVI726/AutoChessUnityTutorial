using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCommand : Command
{
    Character character;
    Character target;

    public AttackCommand(Character character, Character target)
    {
        this.character = character;
        this.target = target;
        this.Execute();
    }

    public void Execute()
    {
        AttackAbility attackAbility = (AttackAbility)character.getAbility(typeof(AttackAbility));
        if (attackAbility == null)
        {
            Debug.Log("Don't have attack ability");
            return;
        }
        // добавить проверку на рендж
        if (Time.time >= attackAbility.lastAttack + attackAbility.delayAttack)
        {
            new DealDmgCommand(target, attackAbility.dmg);
        }
    }
}
