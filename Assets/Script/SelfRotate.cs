using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotate : MonoBehaviour
{
    public GameObject germ;
    public float X;
    public float Y;
    public float Z;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        germ.transform.Rotate(X, Y, Z);
    }
}
