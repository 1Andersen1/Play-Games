using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int Score_Player;
    private float timer;
    public Text txt;
    public bool onDeath;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Score " + Score_Player;
        if (onDeath == false)
        {
            timer += 1 * Time.deltaTime;
            if (timer > 1)
            {
                Score_Player += 1;
                timer = 0;
            }
        }

    }

}
