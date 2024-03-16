using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// add scene management library 
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{   
    // level 1 to load when this func runs
    public void PlayGame(){
        SceneManager.LoadSceneAsync(1);
    }
}
