using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonJouer : MonoBehaviour
{
    public GameObject hideOptions;
    public GameObject hideJouer;
    public GameObject hideCredits;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick()
    {
        hideOptions.SetActive(false);
        hideJouer.SetActive(false);
        hideCredits.SetActive(false);
    }
}
