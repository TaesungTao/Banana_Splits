using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsCog : MonoBehaviour
{
   public GameObject SettingsCanvas;
   private bool SettingShowing = false;
   void Start(){
    SettingsCanvas.SetActive(SettingShowing);
   }
   public void Settings(){
        SettingShowing = !SettingShowing;
        SettingsCanvas.SetActive(SettingShowing);

    }
   }
   

