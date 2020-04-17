using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculatorManager : MonoBehaviour
{
    public enum OperationType {ADD, SUB, MULT, DIV,};

    public OperationType m_currentOperation = OperationType.ADD;

    public float m_a = 0f;
    public float m_b = 0f;
    public float m_result = 0f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        switch (m_currentOperation)
        {

            case OperationType.ADD:
                m_result = ADD(m_a, m_b); 
                break;

            case OperationType.SUB:
                m_result = SUB(m_a, m_b);
                break;

            
            case OperationType.MULT:
                m_result = MULT(m_a, m_b);
                break;


            case OperationType.DIV:
                m_result = DIV(m_a, m_b);        
                break;


            default:
                break;
        }



    }


    float ADD(float x , float y)
    {
        return x + y;
    }
     
     float MULT(float x , float y)
    {
        return x * y;
    }

     float SUB(float x , float y)
    {
        return x - y;
    }
     
     float DIV(float x , float y)
    {
        return x / y;
    }
}
