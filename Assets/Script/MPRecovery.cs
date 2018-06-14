using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPRecovery : MonoBehaviour
{
    private float timer = 1.0f;
    public ProgressBarPro Mpbar;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Mpbar.SetValue((float)(Mpbar.Value + 0.02));
            timer = 1.0f;
        }
    }
}
