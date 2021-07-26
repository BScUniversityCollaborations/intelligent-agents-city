using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRandom : MonoBehaviour
{
    internal Transform thisTransform;



    // The movement speed of the object
    public float moveSpeed = 0.5f;

    // A minimum and maximum time delay for taking a decision, choosing a direction to move in
    public Vector2 decisionTime = new Vector2(1, 4);
    internal float decisionTimeCount = 0;

    // The possible directions that the object can move int, right, left, up, down, and zero for staying in place. I added zero twice to give a bigger chance if it happening than other directions
    internal Vector3[] moveDirections = new Vector3[] { Vector3.right, Vector3.left, Vector3.forward, Vector3.back, Vector3.zero, Vector3.zero };
    internal int currentMoveDirection;

    // Use this for initialization
    void Start()
    {

        // Cache the transform for quicker access
        thisTransform = this.transform;

        // Set a random time delay for taking a decision ( changing direction, or standing in place for a while )
        decisionTimeCount = Random.Range(decisionTime.x, decisionTime.y);

        // Choose a movement direction, or stay in place
        ChooseMoveDirection();
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object in the chosen direction at the set speed
        thisTransform.position += moveDirections[currentMoveDirection] * Time.deltaTime * moveSpeed;

        if (decisionTimeCount > 0) decisionTimeCount -= Time.deltaTime;
        else
        {
            // Choose a random time delay for taking a decision ( changing direction, or standing in place for a while )
            decisionTimeCount = Random.Range(decisionTime.x, decisionTime.y);

            // Choose a movement direction, or stay in place
            ChooseMoveDirection();
        }
    }

    void ChooseMoveDirection()
    {
        // Choose whether to move sideways or up/down
        currentMoveDirection = Mathf.FloorToInt(Random.Range(0, moveDirections.Length));

    }


    /*   private Rigidbody2D npcBody;
       public float npcSpeed = 2;
       private int walkDirection;

       private int zero = 0;
       private float physicVar = 0.5f;

       // Start is called before the first frame update
       void Start()
       {
           npcBody = GetComponent<Rigidbody2D>();
           ChooseDirection();
       }

       // Update is called once per frame
       void Update()
       {
           int newDirection = ChooseDirection();

           switch (newDirection)
           {
               case 0:
                   npcBody.velocity = new Vector2(zero, -npcSpeed * physicVar);
                   break;
               case 1:
                   npcBody.velocity = new Vector2(-npcSpeed * physicVar, zero);

                   break;
               case 2:
                   npcBody.velocity = new Vector2(zero, npcSpeed * physicVar);

                   break;
               case 3:
                   npcBody.velocity = new Vector2(npcSpeed * physicVar, zero);
                   break;
               default:
                   npcBody.velocity = Vector2.zero;
                   Update();
                   break;
           }
       }


       public int ChooseDirection()
       {
           walkDirection = Random.Range(0, 4);

           return walkDirection;
       }*/

}
