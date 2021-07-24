using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody2D npcBody;
    public RectTransform rectangle;

    [SerializeField] private Transform start;
    [SerializeField] private Transform end;
   
    [SerializeField] private Transform newStart;

    // Start is called before the first frame update
    void Start()
    {
        npcBody = GetComponent<Rigidbody2D>();
        transform.position = start.position;
     
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector2.Lerp(transform.position, end.position, Time.deltaTime);
        rectangle = GetComponent<RectTransform>();
        if (rectangle.rect.Contains(Input.GetTouch(0).deltaPosition))
        {

            transform.position = Vector2.Lerp(rectangle.position, start.position, Time.deltaTime);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawCube(start.position, Vector2.one * 0.1f);
        Gizmos.DrawCube(end.position, Vector2.one * 0.1f);
    }

    void FixedUpdate(){
        

    }

    private void MoveNpc()
    {
        npcBody.velocity = Vector2.Lerp(transform.position, end.position, Time.deltaTime);
    }
}
