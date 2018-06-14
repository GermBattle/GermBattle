using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GermAttack_Sharp : MonoBehaviour
{
    public Transform FPoint;
    public GameObject Bullet;
    public Camera m_Camera;
    private Vector3 targetPoint;
    private float timer = 5.0f;
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
            targetPoint = m_Camera.transform.position;
            GameObject bullet;
            //在枪口的位置实例化一颗子弹，按子弹发射点出的旋转，进行旋转  
            bullet = Instantiate(Bullet, FPoint.position, Quaternion.identity) as GameObject;
            bullet.transform.LookAt(targetPoint);//子弹的Z轴朝向目标  
            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * 5000);
            //bullet.GetComponent<ETFXProjectileScript>().impactNormal = hit.normal;
            Destroy(bullet, 5);//在10S后销毁子弹 
            timer = 5.0f;
        }
    }
}
