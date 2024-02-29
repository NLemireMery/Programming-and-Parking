using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Sets the script to be executed later than all default scripts */
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{

    TextMeshProUGUI playerName;

    /* Load the Main Scene */
    public void StartNew()
    {
        SavePlayerName();
        SceneManager.LoadScene(1);
    }

    public void SavePlayerName()
    {
        DataManager.Instance.playerName = playerName;
    }

    /* Exit the app */
    public void Exit()
    {

        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
