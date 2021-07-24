using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class move : MonoBehaviour
{
    //private Rigidbody2D npcBody;
 
    [SerializeField] private Transform start;
    [SerializeField] private Transform end;

    // Start is called before the first frame update
    void Start(){
       // npcBody = GetComponent<Rigidbody2D>();
        transform.position = start.position;
    }

    // Update is called once per frame
    void Update(){
        transform.position = Vector2.Lerp(transform.position, end.position, Time.deltaTime);
    }

    private void OnDrawGizmos(){
        Gizmos.DrawCube(start.position, Vector2.one * 0.1f);
        Gizmos.DrawCube(end.position, Vector2.one * 0.1f);
    }
}
