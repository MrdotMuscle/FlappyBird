using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject playButton;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
 
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

  

    

    
}
