using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    public TextMeshProUGUI playerName;
    public float playerTime;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    /* Serialization is the action of converting complex data into a format in which it can be stored */
    [System.Serializable]
    class SaveData
    {
        public TextMeshProUGUI playerName;
        public float playerTime;
    }

}