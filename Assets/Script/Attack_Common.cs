﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EpicToonFX
{
    public class Attack_Common : MonoBehaviour
    {

        // Use this for initialization
        public Transform FPoint;
        public GameObject Bullet;
        public Camera m_Camera;
        private RaycastHit hitInfo;
        private Ray ray;
        public Vector3 targetPoint;
        public Button button;



        void Start()
        {

        }

        void Awake()
        {
            // 获取button组件
            //score.text = "0";
            //btn = this.GetComponents<Button>();
            // 下面的方法把OnButtonClick方法注册到btn上
            button.onClick.AddListener(
                delegate ()
                {
                    // 这里添加你想要监听的事件
                    this.OnCommonButtonClick();
                }
            );

        }

        // 待监听的事件
        void OnCommonButtonClick()
        {
            print("开始监听");
            if (true)//如果计时大于子弹的发射速率（rate每秒几颗子弹）  
            {
                //通过摄像机在屏幕中心点位置发射一条射线  

                /*
                ray = m_Camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
                //Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100f);
                if (Physics.Raycast(ray, out hitInfo))
                {
                    targetPoint = hitInfo.point * 1000;
                    Debug.Log("this is a test");
                    goal++;
                    //score.text = goal.ToString();
                }
                */
                //将目标点设置在摄像机自身前方1000米处  
                targetPoint = m_Camera.transform.forward * 5000;
                GameObject bullet;
                //在枪口的位置实例化一颗子弹，按子弹发射点出的旋转，进行旋转  
                bullet = Instantiate(Bullet, FPoint.position, Quaternion.identity) as GameObject;
                bullet.transform.LookAt(targetPoint);//子弹的Z轴朝向目标  
                bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * 5000);
                //bullet.GetComponent<ETFXProjectileScript>().impactNormal = hit.normal;
                Destroy(bullet, 5);//在10S后销毁子弹 

            }
        }
    }
}
