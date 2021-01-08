using UnityEngine;

public class AppleManager : MonoBehaviour
{
    public void ChangePosition()
    {
        transform.position = new Vector3(Random.Range(-20, 20), 0.5f, Random.Range(-20, 20));
    }
}
