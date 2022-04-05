using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Cat_Run : StateMachineBehaviour
{
    private Transform _player;
    //private Rigidbody _rb;
    private Cat_Controller _cat;

    //Update Vars
    private Vector3 _targetPos;
    private float _dist;
    private float _updatePath;
    private float _distToJump;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
        //_rb = animator.GetComponent<Rigidbody>();
        _cat = GameObject.FindObjectOfType<Cat_Controller>();
        _updatePath = _cat.UpdatePathfinding;
        _distToJump = _cat.DistToJump;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //MovePathfinder();
        MostBasicMove();
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    //Updates every x seconds to not update pathfinder the entire time
    private void MovePathfinder()
    {
        if (Time.time % _updatePath == 0)
        {
            Debug.Log("Update Pathfinding");

            _targetPos = _player.position;
            _dist = Vector3.Distance(_targetPos, _cat.gameObject.transform.position);

            if (_dist > _distToJump) //or cant reach Player
            {
                //switch to State Jump
            }
            else
            {
                _cat.PathfindTowards(_targetPos);
            }
        }
    }

    //No pathfinder, just walks towards x
    private void MostBasicMove()
    {
        _targetPos = _player.position;
        _cat.MoveTowards(_targetPos);
    }
}
