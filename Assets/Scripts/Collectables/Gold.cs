using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Collectable
{
    protected override void OnCollected()
    {
        //TODO Increment player gold
        Debug.Log("Collected Gold!");
    }
}


