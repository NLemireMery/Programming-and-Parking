
using TMPro;
using UnityEngine;

public class UITimer : MonoBehaviour
{	
    public TextMeshProUGUI TimerText; 
    public bool playing;
    private float Timer;

    void Start()
    {
        playing = true;
    }

    void Update () {
        if(playing == true){

            Timer += Time.deltaTime;
            int minutes = Mathf.FloorToInt(Timer / 60F);
            int seconds = Mathf.FloorToInt(Timer % 60F);
            int milliseconds = Mathf.FloorToInt(Timer * 100F % 100F);
            TimerText.text = minutes.ToString ("00") + ":" + seconds.ToString ("00") + ":" + milliseconds.ToString("00");
        }
    }
}
