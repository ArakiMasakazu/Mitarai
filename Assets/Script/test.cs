using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class test : MonoBehaviour
{
    public byte player = 0b0000_0000;
    public byte poison = 0b0000_0001;
    public byte paralysis = 0b0000_0010;
    public byte sleep = 0b0000_0100;
    public byte silnce = 0b0000_1000;
    public byte Heal = 0b0000_0000;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            player |= poison;
            Debug.Log("poison => condition" + Convert.ToString(player, 2).PadLeft(4, '0'));    
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            player &= ((byte) poison);
            Debug.Log("Heal => condition" + Convert.ToString(player, 2).PadLeft(4, '0'));
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            player |= poison;
        }
    }
}
