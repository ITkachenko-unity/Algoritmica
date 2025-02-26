using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int maxHealth = 100;
        int damage = 15;
        int curHealth = maxHealth - damage;
        print("Your health: " + curHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
