using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAI : MonoBehaviour
{
    Character character;
    public Transform prefab;

    void Start()
    {
        character = CharactersFactory.CreateSpawner();
    }

    void Update()
    {
        new SpawnCommand(character, prefab, transform.position);
    }
}
