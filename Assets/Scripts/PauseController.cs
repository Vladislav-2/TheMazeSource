using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject panel;
    public GameObject setting;
    public GameObject miniMapCamera;
    private bool isMiniMapActive = true;

    void LateUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
          panel.SetActive(true);
          Time.timeScale = 0;
		}
        if(!panel.activeSelf && !setting.activeSelf){
          Time.timeScale = 1;
		}
    }

    public void SettingPressed(){
      setting.SetActive(true);
      panel.SetActive(false);
	}

    public void LoadFirstScene(){
      SceneManager.LoadScene("Maze");
	}

    public void LoadSecondScene(){
      SceneManager.LoadScene("Maze2");
	}

    public void ActivateMiniMap(){
      miniMapCamera.SetActive(!isMiniMapActive);
      isMiniMapActive = !isMiniMapActive;
	}
}
