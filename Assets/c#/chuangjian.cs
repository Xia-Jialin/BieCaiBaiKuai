using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chuangjian : MonoBehaviour {
    /// <summary>
    /// 普通模块
    /// </summary>
    public   GameObject yindao1;
    /// <summary>
    /// 地雷模块
    /// </summary>
    public GameObject yindao2;
    /// <summary>
    /// 保存初始模块
    /// </summary>
    private  static  GameObject roadGuideObj;
    /// <summary>
    /// 保存模块位置
    /// </summary>
    private  static  Transform roadGuideTrans;

    // Use this for initialization
    void Start () {
        roadGuideObj = Instantiate(yindao1);
        roadGuideTrans = roadGuideObj.transform;
        for (int i = 0; i < 4; i++)
        {
            Cj();
        }
    }

    // Update is called once per frame
    void Update () {
       

    }
   /// <summary>
   /// 创建普通块
   /// </summary>
    public  void Cj()
    {
        int randomValue = Random.Range(0, 3);
        Vector3 a;
        switch (randomValue)
        {
            case 0:
                a = new Vector3(1.2f, roadGuideTrans.position.y, roadGuideTrans.position.z);
                Instantiate(yindao1, a, roadGuideTrans.rotation,transform);
                roadGuideTrans.position += new Vector3(0, 4.8f, 0);
                break;
            case 1:
                a = new Vector3(3.6f, roadGuideTrans.position.y, roadGuideTrans.position.z);
                Instantiate(yindao1, a, roadGuideTrans.rotation,transform);
                roadGuideTrans.position += new Vector3(0, 4.8f, 0);
                break;
            case 2:
                a = new Vector3(6f, roadGuideTrans.position.y, roadGuideTrans.position.z);
                Instantiate(yindao1, a, roadGuideTrans.rotation,transform);
                roadGuideTrans.position += new Vector3(0, 4.8f, 0);
                break;
        }
    }
    /// <summary>
    /// 创建地雷块
    /// </summary>
    public void Cj2()
    {
        int randomValue = Random.Range(0, 3);
        Vector3 a;
        switch (randomValue)
        {
            case 0:
                a = new Vector3(1.2f, roadGuideTrans.position.y, roadGuideTrans.position.z);
                Instantiate(yindao2, a, roadGuideTrans.rotation, transform);
                roadGuideTrans.position += new Vector3(0, 4.8f, 0);
                break;
            case 1:
                a = new Vector3(3.6f, roadGuideTrans.position.y, roadGuideTrans.position.z);
                Instantiate(yindao2, a, roadGuideTrans.rotation, transform);
                roadGuideTrans.position += new Vector3(0, 4.8f, 0);
                break;
            case 2:
                a = new Vector3(6f, roadGuideTrans.position.y, roadGuideTrans.position.z);
                Instantiate(yindao2, a, roadGuideTrans.rotation, transform);
                roadGuideTrans.position += new Vector3(0, 4.8f, 0);
                break;
        }
    }
    /// <summary>
    /// 随机创建地雷块
    /// </summary>
    public void DiLei()
    {
        int randomValue = Random.Range(0, 5);
        if (randomValue==3)
        {
            Cj2();
        }
        else
        {
            Cj();
        }
    }
}
