using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch : MonoBehaviour
{
    public Rigidbody2D r2D;
    void Start()
    {
        r2D.GetComponent<Rigidbody2D>();
    }
    public Vector2 vector;
    void Update()
    {
      float x = Input.GetAxis("Horizontal");
      float y = Input.GetAxis("Vertical");
        r2D.velocity = new Vector2(x, y)*5;
    }
}
