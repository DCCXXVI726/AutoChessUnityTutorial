using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAI : MonoBehaviour
{
    public Character character;
    public Transform way;
    
    void Start()
    {
        character = CharactersFactory.CreateCaravan();
    }

    void FixedUpdate()
    {
        foreach(Transform child in way.GetComponentsInChildren<Transform>())
        {
            while(Vector3.Distance(child.position, transform.position) > 0.1f)
            {
                new MoveCommand(character, ref transform.position, child.position);
            }
        }
    }
}
