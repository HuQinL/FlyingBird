using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rank : MonoBehaviour
{
    public GameObject[] newRankIndex;

    private int indexM;
    private int[] save = new int[3];

    private string first = "first";
    private string second = "second";
    private string third = "third";

    private int num;
    // Use this for initialization
    void Start()
    {
        ////获取数据
        //indexM = PlayerPrefs.GetInt("index");
        //for (int i = 0; i < 3; i++)
        //{
        //    string saveIntStrS = saveIntStr + i.ToString();
        //    save[i] = PlayerPrefs.GetInt(saveIntStrS);
        //}

        ////添加新数据并排序（从小到大）
        //for (int i = 0; i < 3; i++)
        //{
        //    if (save[i] == null || save[i] == 0)
        //    {
        //        save[i] = indexM;
        //        num = i;
        //        for (int m = 0; m < num + 1; m++)
        //        {
        //            int t = save[m];
        //            int n = m;
        //            while ((n > 0) && (save[n - 1] > t))
        //            {
        //                save[n] = save[n - 1];
        //                --n;
        //            }
        //        }

        //        break;
        //    }
        //    else
        //    {
        //        int n = 2;
        //        if (indexM < save[i])
        //        {
        //            while (save[n - 1] > indexM)
        //            {
        //                save[n] = save[n - 1];
        //                --n;
        //                save[n] = indexM;
        //                if (n == 0)
        //                {
        //                    break;
        //                }
        //            }
        //            break;
        //        }
        //    }
        //}
        ////保存数据
        //for (int j = 0; j < 3; j++)
        //{
        //    string saveIntStrI = saveIntStr + j.ToString();
        //    PlayerPrefs.SetInt(saveIntStrI, save[j]);
        //}
        //UI显示
        //PlayerPrefs.SetInt(first, 3);
        //PlayerPrefs.SetInt(second, 2);
        //PlayerPrefs.SetInt(third, 1);
        for (int i = 0; i < newRankIndex.Length; i++)
        {
            switch (i)
            {
                case 0:
                    newRankIndex[i].GetComponent<Text>().text = first + ":" + PlayerPrefs.GetInt(first).ToString();
                    break;
                case 1:
                    newRankIndex[i].GetComponent<Text>().text = second + ":" + PlayerPrefs.GetInt(second).ToString();
                    break;
                case 2:
                    newRankIndex[i].GetComponent<Text>().text = third + ":" + PlayerPrefs.GetInt(third).ToString();
                    break;
                default:
                    break;
            }
            //string saveIntStr0 = saveIntStr + i.ToString();
            //newRankIndex[i] = GameObject.Instantiate( transform.position, transform.rotation) as GameObject;
            newRankIndex[i].transform.SetParent(transform);
            //newRankIndex[i].GetComponent<Text>().text = PlayerPrefs.GetInt(saveIntStr0).ToString();

        }
    }


    private void UpdateData()
    {

    }
}
