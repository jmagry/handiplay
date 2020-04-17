using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public float m_chrono = 0f;
    public string m_message = "i love pizza";

    // Start is called before the first frame update
    void Start()
    {
      m_chrono = 0f;  
    }

    // Update is called once per frame
    void Update()
    {
        m_chrono = m_chrono + Time.deltaTime;
        if (m_chrono > 5f)
        {
        //afficher le message dans la console)
        Debug.Log(m_message);
        //remettre le chrono à zéro
        m_chrono = 0f;
        }
    }
}
