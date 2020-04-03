﻿using System.Collections;
using System.Collections.Generic;
using Attack;
using UnityEngine;

public class GroundEnemyRangeAttack : StateMachineBehaviour
{
    private ShootingWeapon _weapon;
    private float _timePassed;
    private bool _shootDone;

    private bool _componentsCached;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _timePassed = 0f;
        _shootDone = false;
        if (!_componentsCached)
        {
            _weapon = animator.gameObject.GetComponentInChildren<ShootingWeapon>();
            _componentsCached = true;
        }
        _weapon.Shoot(GameObject.FindGameObjectWithTag("Player").transform.position);
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _timePassed += Time.deltaTime;
        if (_timePassed > stateInfo.length && !_shootDone)
        {
            Debug.Log("shoot!");
            // _weapon.Shoot(GameObject.FindGameObjectWithTag("Player").transform.position);
            _shootDone = true;
        }
    }
}
