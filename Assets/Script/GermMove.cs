using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GermMove : MonoBehaviour {
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //float translation = Time.deltaTime * 10;

        //移动的方向
        //transform.Translate(translation, 0, 0);
        //transform.Translate(0, translation, 0);
        //transform.Translate(0, 0, 0.001);


        // rotate
        transform.Rotate(2, 0, 0);

        //以模型Y轴旋转，单位为2.
        transform.Rotate(0, 2, 0);

        //以模型Z轴旋转，单位为2.
        transform.Rotate(0, 0, 2);
    }

}
