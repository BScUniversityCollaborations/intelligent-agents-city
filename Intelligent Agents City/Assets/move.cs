using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody2D npcBody;
    public float npcSpeed;
    private int walkDirection;
    int frames = 10;

    private int zero = 0 ;

    // Start is called before the first frame update
    void Start(){
        npcBody = GetComponent<Rigidbody2D>();
        ChooseDirection();
    }

    // Update is called once per frame
    void Update(){
       int newDirection = ChooseDirection();
       

        switch (newDirection){
            case 0:
                
                npcBody.velocity = new Vector2(zero, -npcSpeed*0.5f);
                Thread.Sleep((100 / frames) * 1000);
                break;
            case 1:
               npcBody.velocity = new Vector2(-npcSpeed * 0.5f, zero);
                Thread.Sleep((100 / frames) * 1000);
                break;
            case 2:
                npcBody.velocity = new Vector2(zero, npcSpeed * 0.5f);
                Thread.Sleep((100 / frames) * 1000);
                break;
            case 3:
                npcBody.velocity = new Vector2(npcSpeed * 0.5f, zero); 
                Thread.Sleep((100 / frames) * 1000);
                break;
            default:
                npcBody.velocity = Vector2.zero;
                Update();
                break;
        }
    }


    public int ChooseDirection(){
        walkDirection = Random.Range(0, 4);

        return walkDirection;
    }
}
