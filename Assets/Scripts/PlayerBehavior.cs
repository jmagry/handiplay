using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    public float speed = 100f;
    public Rigidbody2D rb2D; 

    public int score = 0;
    public int items = 0;

    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void FixedUpdate()

    {

    transform.Translate(Vector3.up * speed * Time.deltaTime * 3, Space.Self); // 3 = débridage de la bécane   


    // Left
    if(Input.GetAxis("Horizontal") < 0){
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * speed * 1.5f, Space.Self); // 1.5f = le frein a main pour les drifts
    }
    // Right
     if(Input.GetAxis("Horizontal") > 0){
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * -speed * 1.5f, Space.Self); // 1.5f = le frein a main pour les drifts
    }
     

    }

        void OnCollisionEnter2D(Collision2D collision){    
            if (collision.gameObject.tag == "Coin"){   
                Destroy(collision.gameObject);    
                score += 1;
            } 
        
           if (collision.gameObject.tag == "Ball"){
                Destroy(collision.gameObject);    
                items += 1;
            } 

        }

    

}
