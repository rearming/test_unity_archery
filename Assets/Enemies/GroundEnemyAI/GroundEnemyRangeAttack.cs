﻿using Attack;
using UnityEngine;

namespace Enemies.GroundEnemyAI
{
    public class GroundEnemyRangeAttack : StateMachineBehaviour
    {
        private Transform _playerTransform;
    
        private SingleShootingWeapon _weapon;
        private float _timePassed;
        private bool _shootDone;

        private bool _componentsCached;
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            _timePassed = 0f;
            _shootDone = false;
            if (!_componentsCached)
            {
                _weapon = animator.gameObject.GetComponentInChildren<SingleShootingWeapon>();
                _playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
                _componentsCached = true;
            }
        }

        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            _timePassed += Time.deltaTime;
            if (_timePassed > stateInfo.length / 3 && !_shootDone)
            {
                _weapon.Shoot(GameObject.FindGameObjectWithTag("Player").transform.position);
                _shootDone = true;
            }
        }
    }
}
