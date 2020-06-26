using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command
{
    Character character;
    Vector3 target;

    public MoveCommand(Character character, Vector3 target)
    {
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
        dir = Vector3.Normalize(target - moveAbility.transform.position);
        moveAbility.transform.Translate(dir * moveAbility.speed * Time.deltaTime);
    }
}
