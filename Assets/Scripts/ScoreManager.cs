using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    private int coinsValue;
    private int rubyValue;
    public Text coins;
    public Text ruby;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinsValue = GameObject.Find("Player").GetComponent<PlayerBehavior>().score;
        rubyValue = GameObject.Find("Player").GetComponent<PlayerBehavior>().items;

        coins.text = "Score : " + coinsValue;
        ruby.text = "Rubis : " + rubyValue + "/5";


    }
}
