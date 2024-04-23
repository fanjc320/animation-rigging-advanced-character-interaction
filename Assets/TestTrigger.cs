using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrigger : MonoBehaviour
{
    public float horizontalinput;//ˮƽ����
    public float Verticalinput;//��ֱ����
    float speed = 10.0f;//����һ��������û�й涨
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
        //AD�������
        Verticalinput = Input.GetAxis("Vertical");
        //WS�������
        this.transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * speed);
        this.transform.Translate(Vector3.forward * Verticalinput * Time.deltaTime * speed);
                        
//ԭ�����ӣ�https://blog.csdn.net/qq_46043095/article/details/124000108
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter new name:" +��other.name);
        if (other.name.Equals("mixamorig:LeftForeArm"))
        {
            Debug.Log("OnTriggerEnter LeftForeArm stop -------------");
            animator_boxing.speed = 0f;
            animator_sideKick.speed = 0f;
        }
    }
}
