using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public Button playButton;
    private void Start()
    {
       
    }

    public void play()
    {
        SceneManager.LoadScene(0);
    }
}
