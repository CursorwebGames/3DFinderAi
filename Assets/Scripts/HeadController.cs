using UnityEngine;
using UnityEngine.AI;

public class HeadController : MonoBehaviour
{
    public Transform applePos;
    public NavMeshAgent agent;


    private void Update()
    {
        agent.SetDestination(applePos.position);
    }
}
