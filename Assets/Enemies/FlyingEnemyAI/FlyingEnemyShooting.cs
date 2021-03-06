﻿using Attack;
using UnityEngine;

namespace Enemies.FlyingEnemyAI
{
	public class FlyingEnemyShooting : StateMachineBehaviour
	{
		private Transform _playerTransform; 
		private SingleShootingWeapon _weapon;

		private bool _componentsCached;
	
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			if (!_componentsCached)
			{
				_weapon = animator.gameObject.GetComponentInChildren<SingleShootingWeapon>();
				_playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
				_componentsCached = true;
			}
			_weapon.Shoot(_playerTransform.position);
		}
	}
}
