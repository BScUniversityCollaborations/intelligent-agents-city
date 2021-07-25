using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRandom : MonoBehaviour
{
    private Rigidbody2D npcBody;
    public float npcSpeed;
    private int walkDirection;
    int frames = 10;

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
    }

}
