using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emove : MonoBehaviour
{

    Rigidbody2D rb2d;
    Transform target;
    GameObject Player;

    [SerializeField]
    float _moveSpeed = 5.0f;


    // Use this for initialization
    void Start()
    {
         

        Player = GameObject.FindWithTag("Player"); 
        target = Player.transform;
    


        rb2d = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = target.position - transform.position;

        direction = direction.normalized;

        Vector2 velocity = direction * _moveSpeed;

        rb2d.MovePosition(rb2d.position * _moveSpeed * Time.fixedDeltaTime);


    }
}