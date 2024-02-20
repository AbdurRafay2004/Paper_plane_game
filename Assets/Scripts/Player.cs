using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

public float speed = 10f;

public Rigidbody2D rb;
public Camera cam;
Vector2 movement;
Vector2 mousePos; 
void Update() 
{
    //simple movement 
    //float x = Input.GetAxisRaw("Horizontal");
    //float y = Input.GetAxisRaw("Vertical");     
    //gameObject.transform.Translate(new Vector2(x,y) * speed * Time.deltaTime);

    //Input
    movement.x = Input.GetAxisRaw("Horizontal");
    movement.y = Input.GetAxisRaw("Vertical");
    
    //mouse pointer position 
    mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

}

void FixedUpdate() 
{
    //movement
    rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

    //rotation work
    Vector2 lookDir = mousePos - rb.position;
    float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
    rb.rotation = angle;
}

}
