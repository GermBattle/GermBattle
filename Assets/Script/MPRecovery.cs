using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPRecovery : MonoBehaviour
{
    private float timer = 2.0f;
    public GameObject Mpbar;
    private float InitialRight;
    private float InitialLeft;
    private float InitialTop;
    private float InitialBottom;
    private float width;
    public float ValueOfRecovery;
    // Use this for initialization
    void Start()
    {
        InitialRight = Mpbar.GetComponent<RectTransform>().offsetMax.x;
        InitialBottom = Mpbar.GetComponent<RectTransform>().offsetMax.y;
        InitialLeft = Mpbar.GetComponent<RectTransform>().offsetMin.x;
        width = InitialRight - InitialLeft;
        ValueOfRecovery = ValueOfRecovery;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            var right = Mpbar.GetComponent<RectTransform>().offsetMax.x;
            if (right + ValueOfRecovery*width < InitialRight)
            {
                Mpbar.GetComponent<RectTransform>().offsetMax = new Vector2(right + ValueOfRecovery * width, InitialBottom);
            } else
            {
                Mpbar.GetComponent<RectTransform>().offsetMax = new Vector2(InitialRight, InitialBottom);
            }
            //Mpbar.SetValue((float)(Mpbar.Value + 0.02));
            timer = 2.0f;
        }
    }
}
