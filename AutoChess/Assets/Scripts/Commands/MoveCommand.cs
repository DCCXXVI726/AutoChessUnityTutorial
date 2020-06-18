using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command
{
    Character character;
    Transform obj;
    Vector3 target;

    public MoveCommand(Character character, Transform obj, Vector3 target)
    {
        this.obj = obj;
        this.target = target;
        this.character = character;
        this.Execute();
    }

    public void Execute()
    {
        Vector3 dir;

        MoveAbility moveAbility = (MoveAbility)this.character.getAbility(typeof(MoveAbility));

        if (moveAbility == null)
        {
            Debug.Log("Don't have MoveAbility");
            return ;
        }
        dir = Vector3.Normalize(target - obj.position);
        obj.Translate(dir * moveAbility.speed * Time.deltaTime);
    }
}
