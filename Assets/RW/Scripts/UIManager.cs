using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Animator startButton;
    public Animator settingsButton;
    public Animator dialog;

    
    public void OpenSettings()
    {
        startButton.SetBool("isHidden", true);
        settingsButton.SetBool("isHidden", true);
        dialog.SetBool("isHidden", false);
    }
    public void CloseSettings()
        {
            startButton.SetBool("isHiiden", false);
            settingsButton.SetBool("isHiiden", false);
            dialog.SetBool("isHiiden", true);
        }
    public void StartGame()
        {
            SceneManager.LoadScene("RocketMouse");
        }
    }
   


