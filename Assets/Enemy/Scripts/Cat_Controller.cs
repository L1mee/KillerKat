using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat_Controller : MonoBehaviour
{
    [SerializeField] public float Speed = 5f;
    [SerializeField] public float UpdatePathfinding = 1f;
    [SerializeField] public float DistToJump = 100f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveTowards(Vector3 target)
    {
        //Speed mit delta time usw usw
        //ganz basic muss einfach zum target walken
    }

    public void PathfindTowards(Vector3 target)
    {
        //komplizierter, falls zeit da ist. Sonst nur MoveTowards :)
    }
}
