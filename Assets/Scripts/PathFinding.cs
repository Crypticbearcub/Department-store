using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PathFinding : MonoBehaviour
{
    [SerializeField] Transform destination;
    [SerializeField] Transform npc;
    [SerializeField] float speed =

    private bool isInDestination = false;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        if (isInDestination == false)
        {
            
        }
    }
}
