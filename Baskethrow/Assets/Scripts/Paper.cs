using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Paper : MonoBehaviour
{
    [SerializeField] GameObject paper;
    [SerializeField] GameObject spawn;
    [SerializeField] GameObject stpp;
    public GameObject pp;
    private bool cn;
    void Start()
    {
        cn = false;
    }

    void Update()
    {
        if(stpp.transform.position.y < 0.8f && !cn)
        {
            pp = Instantiate(paper, spawn.transform.position, spawn.transform.rotation) as GameObject;
            cn = true;
        }else if (cn)
        {
            if(pp.transform.position.y < 0.8f)
            {
                pp = Instantiate(paper, spawn.transform.position, spawn.transform.rotation) as GameObject;
                cn = true;
            }
        }
    }
}
