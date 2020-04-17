using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public float m_speed = 1000f;    
    public Rigidbody2D m_rb2D;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.up); 
    }
}
