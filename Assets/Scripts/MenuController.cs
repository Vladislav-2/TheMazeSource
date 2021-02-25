using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void PlayPressed(){
      SceneManager.LoadScene("Maze");
	}

    public void MenuPressed(){
      SceneManager.LoadScene("MainMenu");
	}
    
    public void ExitPressed(){
    Debug.Log("Exit pressed!");
      Application.Quit();
	}
}
