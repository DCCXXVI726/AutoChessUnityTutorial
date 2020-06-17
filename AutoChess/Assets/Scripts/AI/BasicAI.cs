using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAI : MonoBehaviour
{
    public Character    character;
    public Transform    way;
    public Transform[]  wayPoints;
    public int          wayCounter;
    
    void Start()
    {
        character = CharactersFactory.CreateCaravan();
        wayPoints = way.GetComponentsInChildren<Transform>();
        wayCounter = 1;
        if (wayPoints.Length < 2)
        {
            Debug.Log("don't have way's points");
            Destroy(gameObject);
            Destroy(this);
        }
    }

    void FixedUpdate()
    {
        
         if (Vector3.Distance(wayPoints[wayCounter].position, transform.position) < 0.3f)
         {
            if (++wayCounter == wayPoints.Length)
            {
                Destroy(gameObject);
                Destroy(this);
                return ;
            }
         }
         new MoveCommand(character, transform, wayPoints[wayCounter].position);
    }
}