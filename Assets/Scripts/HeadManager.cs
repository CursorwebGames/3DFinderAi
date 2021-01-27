using UnityEngine;

public class HeadManager : MonoBehaviour
{
    public GameObject prefab;
    public Transform tail;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Apple"))
        {
            FindObjectOfType<AppleManager>().ChangePosition();
            AddSegment();
        }
    }


    private void AddSegment()
    {
        GameObject segment = Instantiate(prefab, tail.position, Quaternion.identity);
        PlayerFollower comp = segment.GetComponent<PlayerFollower>();
        comp.head = tail;
        tail = segment.transform;
    }
}
