using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Rank : MonoBehaviour {
    public GameObject L0;
    public GameObject[] newIndexs;
    public GameObject Panel;

    public int scoreNum; // 取出存储新分数
    public Text Ranking;

    private int[] save = new int[5];
                                    

    int num;

    string saveIntStr;

    // Use this for initialization
    void Start () {
        // 初始化
        // 获取上一个场景存储的数据
        scoreNum = PlayerPrefs.GetInt("currScore");
        print("TEST PLAYERFEBS测试静态数据: " + scoreNum);
        // test
        //Ranking = GameObject.FindObjectOfType<Text>();
        Ranking = GameObject.Find("Canvas/Ranking").GetComponent<Text>();
        //获取存储在排行榜中的数据
        for (int i = 0; i < 5; i++)
        {
            print(save[i]);
            string saveIntStrS = saveIntStr + i.ToString();
            save[i] = PlayerPrefs.GetInt(saveIntStrS);
        }

        //添加新数据并排序（从大到小）
        for (int i = 0; i < 5; i++)
        {
            if (save[i] == null || save[i] == 0)
            {
                save[i] = scoreNum;
                num = i;

                for (int m = 0; m < num + 1; ++m)
                {
                    int t = save[m];
                    int n = m;
                    while ((n > 0) && (save[n - 1] < t))
                    {
                        save[n] = save[n - 1];
                        --n;
                    }
                    save[n] = t;
                }

                break;
            }
            else
            {
                int n = 4;
                if (scoreNum > save[4])
                {
                    while (save[n - 1] < scoreNum)
                    {
                        save[n] = save[n - 1];
                        --n;
                        save[n] = scoreNum;

                        if (n == 0)
                        {
                            break;
                        }
                    }
                    break;
                }
            }
        }
       
        //把当前数据存储
        for (int j = 0; j < 5; j++)
        {
            string saveIntStrI = saveIntStr + j.ToString();
            PlayerPrefs.SetInt(saveIntStrI, save[j]);
            //PlayerPrefs.SetInt(saveIntStrI, 0);
        }

        //将数据显示到场景UI中 
        Ranking.text = "<size=36>Top Five Record</size>\n";
        for (int i = 0; i<5; i++)
        {
            string saveIntStrO = saveIntStr + i.ToString();
            Ranking.text = Ranking.text + "<size=27>"+ (i+1).ToString() + "     " + PlayerPrefs.GetInt(saveIntStrO).ToString() + "</size>\n";
        }
       /* for (int i = 0; i < newIndexs.Length; i++)
        {
            string saveIntStrO = saveIntStr + i.ToString();
            //newIndexs[i] = Instantiate(L0, transform.position, transform.rotation) as GameObject;
            //newIndexs[i].transform.SetParent(Panel.transform);
            //newIndexs[i].GetComponent<Text>().text = PlayerPrefs.GetInt(saveIntStrO).ToString();
        }*/
        Ranking.text = Ranking.text.Replace("\\n", "\n");

    }

    // Update is called once per frame
    void Update () {
		
	}
}
