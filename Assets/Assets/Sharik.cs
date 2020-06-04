using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sharik : MonoBehaviour
{
    float x;
    public Rigidbody2D r2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Random rand = new Random();
        x = Random.Range(-8, 8);

        if (transform.position.y > 8)
        {
            transform.position = new Vector2(x, -64);
            r2D.velocity = new Vector2(0, 0);
        }
    }
}
