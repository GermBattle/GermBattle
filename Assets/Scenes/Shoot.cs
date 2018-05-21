using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;
public class Shoot : MonoBehaviour {
	int Speed = 2;
	public Rigidbody Bullet;
	public Transform FPoint2;
    public Transform FPoint;
    public Camera m_Camera;
    private RaycastHit hitInfo;
    public Ray ray;
    public Vector3 targetPoint;
    public Button button;
   
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (Input.GetKeyDown (KeyCode.J)) {
			Rigidbody clone;
			/*clone = (Rigidbody)Instantiate (Bullet, FPoint.position, FPoint.rotation);
			clone.velocity = transform.TransformDirection (Vector3.forward * 50);

			Vector3 point = camera.ScreenToWorldPoint (new Vector3 (Screen.width/2, Screen.height/2, 0));  
			clone = (Rigidbody)Instantiate (Bullet, point,  Quaternion.identity);  
			clone.transform.forward = camera.transform.forward; 
		}
        */
        if (Input.GetKey(KeyCode.Mouse0))//按下鼠标左键  
        {
            //timer += Time.deltaTime;//计时器计时  
            if (true)//如果计时大于子弹的发射速率（rate每秒几颗子弹）  
            {
                //通过摄像机在屏幕中心点位置发射一条射线  
                ray = m_Camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

                if (Physics.Raycast(ray, out hitInfo))
                {
                    targetPoint = hitInfo.point;
                    Debug.Log("this is a test");
                }
                    //将目标点设置在摄像机自身前方1000米处  
                targetPoint = m_Camera.transform.forward * 1000;
                Rigidbody bullet, bullet2;
                //在枪口的位置实例化一颗子弹，按子弹发射点出的旋转，进行旋转  
                bullet = Instantiate(Bullet, FPoint.position, Quaternion.identity) as Rigidbody;
                bullet.transform.LookAt(targetPoint);//子弹的Z轴朝向目标  
                Destroy(bullet, 10);//在10S后销毁子弹 

                bullet2 = Instantiate(Bullet, FPoint2.position, Quaternion.identity) as Rigidbody;
                bullet2.transform.LookAt(targetPoint);//子弹的Z轴朝向目标  
                Destroy(bullet, 10);//在10S后销毁子弹   
                                    // timer = 0;//时间清零  
            }
        }
    }
}
