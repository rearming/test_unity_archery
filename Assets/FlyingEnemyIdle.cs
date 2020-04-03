﻿using System.Collections;
using System.Collections.Generic;
using Attack;
using UnityEngine;

public class FlyingEnemyIdle : StateMachineBehaviour
{
	private ShootingWeapon _weapon;
	private Transform _playerTransform;
	private float _timePassed;
	
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		_timePassed = 0f;
		_playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
		_weapon = animator.gameObject.GetComponentInChildren<ShootingWeapon>();
	}
	
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
	    _timePassed += Time.deltaTime;
	    animator.SetFloat("Distance", Vector3.Distance(animator.transform.position, _playerTransform.position));
	    if (_timePassed > _weapon.attacksPerSecond)
	    {
		    animator.SetTrigger("Shoot");
	    }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
