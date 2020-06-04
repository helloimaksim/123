using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaplya : MonoBehaviour
{
    public Transform kap;
    public Rigidbody2D r2D;
    float x;
    
 
    void Start()

    {
 
    }

    // Update is called once per frame
    void Update()
    {

        Random rand = new Random();
        x = Random.Range(-8, 8);

        if (transform.position.y < -6)
        {
            transform.position = new Vector2(x, 6);
            r2D.velocity = new Vector2(0, 0);
        }
        
    }
}
   