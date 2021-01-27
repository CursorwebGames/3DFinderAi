using UnityEngine;

public class AppleManager : MonoBehaviour
{
    public Transform head; // snake head

    private void Start()
    {
        ChangePosition();
    }

    public void ChangePosition()
    {
        do
        {
            transform.position = new Vector3(Random.Range(-20, 20), 0.5f, Random.Range(-20, 20));
        } while (IsTouching());
    }

    private bool IsTouching()
    {
        GameObject[] trees = GameObject.FindGameObjectsWithTag("Tree");

        bool touching = Vector3.Distance(head.position, transform.position) < 3;
        foreach (GameObject tree in trees)
        {
            if (Vector3.Distance(tree.transform.position, transform.position) < 3)
            {
                touching = true;
                break;
            }
        }
        return touching;
    }
}
