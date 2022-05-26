using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityChan;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public Text timeText;
    public float limit = 30.0f;
    public GameObject text;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        timeText.text = "残り時間:" + limit + "秒";
    }
    
    // Update is called once per frame
    void Update()
    {
  
    }


}
