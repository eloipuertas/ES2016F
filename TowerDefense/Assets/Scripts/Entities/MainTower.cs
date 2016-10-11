﻿using UnityEngine;
using System.Collections;

public class MainTower : Tower {

    // Use this for initialization
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.red;
        iniStates();
    }

    // Update is called once per frame
    void Update()
    {
        getTarget();
        if (target == null)
            return;
        print(target);
    }

    void iniStates()
    {
        range = 25f;
        life = 200;
        strenght = 7;
    }


    protected override void Shoot()
    {
        // TODO
    }

    protected override void Destroy()
    {
        // TODO
    }
}
