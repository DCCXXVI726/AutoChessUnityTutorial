using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command
{
    Character character;
    Vector3 pos;
    Vector3 target;

    public MoveCommand(Character character, ref Vector3 pos, Vector3 target)
    {
        this.pos = pos;
        this.target = target;
        this.character = character;
        this.Execute();
        pos = this.pos;
    }

    void Execute()
    {
        Vector3 dir;

        MoveAbility moveAbility = (MoveAbility)this.character.getAbility(typeof(MoveAbility));

        if (moveAbility == null)
        {
            return ;
        }
        dir = Vector3.Normalize(target - pos);
        pos = pos + dir * moveAbility.speed * Time.deltaTime;
    }
}
