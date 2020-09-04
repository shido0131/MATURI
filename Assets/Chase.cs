using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    float dis;
    public GameObject target;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        dis = Vector3.Distance(transform.position, target.transform.position);
        if (dis > 50)
        {
            GetComponent<NavMeshAgent>() .isStopped = true;//stop
        }
        if (dis < 50)
        {
            GetComponent<NavMeshAgent>().isStopped = false;//go
            //次回一定の時間でランダムに空のオブジェクトにワープする
            //次回空のオブジェクトを10個くらい設置する
        }
        //agent.destination = target.transform.position;
        agent.SetDestination(target.transform.position);
    }
}
