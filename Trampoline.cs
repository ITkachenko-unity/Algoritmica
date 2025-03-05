using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jumpPower;


    void OnTriggerEnter(Collider other) 
    {
        other.GetComponent<Jump>().jumpStrength *= jumpPower;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= jumpPower;
    }
}
