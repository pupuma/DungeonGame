﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathState : State
{
    float _rotate = 0.0f;

    public override void Start()
    {
        base.Start();
        _character.GainExp();
        _character.SetCanMove(true);


        //_character.gameObject.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 90.0f);
    }

    override public void Update()
    {
        base.Update();

        _rotate += (180.0f * Time.deltaTime);
        _character.gameObject.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, _rotate);
    }
}
