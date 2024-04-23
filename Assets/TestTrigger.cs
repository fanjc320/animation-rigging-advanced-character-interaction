using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrigger : MonoBehaviour
{
    public float horizontalinput;//水平参数
    public float Verticalinput;//垂直参数
    float speed = 10.0f;//声明一个参数，没有规定
    public Animator animator_boxing;
    public Animator animator_sideKick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        //AD方向控制
        Verticalinput = Input.GetAxis("Vertical");
        //WS方向控制
        this.transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * speed);
        this.transform.Translate(Vector3.forward * Verticalinput * Time.deltaTime * speed);
                        
//原文链接：https://blog.csdn.net/qq_46043095/article/details/124000108
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter new name:" +　other.name);
        if (other.name.Equals("mixamorig:LeftForeArm"))
        {
            Debug.Log("OnTriggerEnter LeftForeArm stop -------------");
            animator_boxing.speed = 0f;
            animator_sideKick.speed = 0f;
        }
    }
}
