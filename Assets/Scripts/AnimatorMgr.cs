using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimatorMgr : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator_boxing;
    public Animator animator_sideKick;
    bool bBeginFight;
    //public InputAction inputAction;
    void Start()
    {

        //...

        //if (inputAction != null)
        //{

        //    inputAction.performed += OnFight;

        //    inputAction.Enable();

        //}

    }
    //作者：YouSing https://www.bilibili.com/read/cv2951845/ 出处：bilibili
    static int tmp = 0;
    // Update is called once per frame
    void Update()
    {
        
        //if (tmp++%1000 == 0)
        //{
        //    Debug.Log("Update ----------");
        //}

        if (Input.GetButtonDown("Jump"))
        {
            //Debug.Log("Update ---------- Jump");
            animator_boxing.speed = 1.0f;
            animator_sideKick.speed = 1.0f;
            //animator_boxing.StartPlayback();
            animator_boxing.Play("Base Layer.mixamo_boxing", 0, 0);
            //animator_sideKick.Play("Base Layer.mixamo_com", 0, 0.25f);
            animator_sideKick.Play("Base Layer.mixamo_com", 0, 0.0f);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter old name:" + other.name);
        animator_boxing.speed = 0f;
        animator_sideKick.speed = 0f;
        Animation animBox = animator_boxing.GetComponent<Animation>();
        animBox.Stop();
    }

    

    public void OnFight(InputAction.CallbackContext callback)
    {
        Debug.Log("OnFight==========>>>>>>>>>> ");
        switch(callback.phase)
        {
            case InputActionPhase.Performed:
                Debug.Log("Fighting !!!!!!!!!");
                break;
            default:
                break;
        }
    }

    public void OnFight(InputValue value)
    {
        Debug.Log("OnFight1 <<<<<<<<<<<<<<<<<>>>>>>>>> ");
    }

    public void OnSpace(InputValue value)
    {
        Debug.Log("OnSpace <<<<<<<<<<<<<<<<<>>>>>>>>> ");
    }
}
