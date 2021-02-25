using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public Dropdown dropdawn;
    public AudioMixer audioMixer;
    private bool isFullScreen = true;
    Resolution[] resolutions;
    List<string> resolutionList;

    public void Awake(){
       resolutionList = new List<string>();
       resolutions = Screen.resolutions;
       foreach (var i in resolutions){
         resolutionList.Add(i.width + "x" + i.height);
	   }
       dropdawn.ClearOptions();
       dropdawn.AddOptions(resolutionList);
	}

    public void FullScreenToggle(){
       isFullScreen = !isFullScreen;
       Screen.fullScreen = isFullScreen;
       Debug.Log(isFullScreen);
	}

    public void AudioVolume(float sliderValue){
       audioMixer.SetFloat("masterVolume", sliderValue);
	}

    public void Quality(int quality){
       QualitySettings.SetQualityLevel(quality);
	}

    public void Resolution(int res){
       Screen.SetResolution(resolutions[res].width, resolutions[res].height, isFullScreen);
	}
}
