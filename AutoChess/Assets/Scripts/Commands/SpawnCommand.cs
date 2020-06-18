using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCommand : Command
{
    Transform prefab;
    Vector3 pos;
    Character character;

    public SpawnCommand(Character character, Transform prefab, Vector3 pos)
    {
        this.prefab = prefab;
        this.pos = pos;
        this.character = character;
        this.Execute();
    }

    public void Execute()
    {
        SpawnAbility spawnAbility = (SpawnAbility)character.getAbility(typeof(SpawnAbility));

        if (spawnAbility == null)
        {
            Debug.Log("Don't have SpawnAbility");
            return ;
        }

        if (Time.time >= spawnAbility.lastSpawn + spawnAbility.deltaTime)
        {
            Object.Instantiate(prefab, pos, Quaternion.identity);
            spawnAbility.lastSpawn = Time.time;
        }
    }
}
