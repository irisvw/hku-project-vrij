using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenCamera : MonoBehaviour
{
    [SerializeField] private Animator anim;
    void Start()
    {
        EventSystem<int>.Subscribe(EventType.TASK_NUMBER, KitchenCutscne);
    }
    
    void KitchenCutscne(int taskNumber)
    {
        if (taskNumber == 1)
        {
            GetComponent<Camera>().enabled = true;
            anim.SetBool("IsActive", true);
        }
    }
}
