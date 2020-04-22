using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JOUER : MonoBehaviour
{
    public string changeSceneGame;

    public void changeScene(){          
        SceneManager.LoadScene(changeSceneGame); //On change de scène
    }

}
