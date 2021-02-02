using UnityEngine;

public class RayCasterManager : MonoBehaviour
{
    public Camera cam;

    public Renderer markerRend; // material for marker

    public MaximumTrees maximum;

    public GameObject markerVisible;
    public GameObject tree;

    public Transform posMarker;
    public Transform apple;

    public Material validMat;
    public Material invalidMat;

    public int applesMade; // this must be less than maxApples
    public int maxApples; // not quite sure why this is called apples when it is clearly pertaining to trees

    private Vector3 pos;


    private void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            pos = new Vector3(hit.point.x, 2.5f, hit.point.z);

            if (Input.GetMouseButtonDown(0))
            {
                if (NotTouching() && applesMade < maxApples)
                {
                    Instantiate(tree, pos, Quaternion.identity);
                    applesMade++;
                    maximum.UpdateTrees(applesMade);
                }
            }

            if (Input.GetMouseButton(1))
            {
                if (hit.collider.CompareTag("Tree"))
                {
                    Destroy(hit.collider.gameObject);
                    applesMade--;
                    maximum.UpdateTrees(applesMade);
                }
            }

            if (NotTouching()) markerRend.material = validMat;
            else markerRend.material = invalidMat;

            markerVisible.SetActive(true);
            posMarker.position = new Vector3(hit.point.x, posMarker.position.y, hit.point.z);
        }
        else
        {
            markerVisible.SetActive(false);
        }
    }

    private bool NotTouching()
    {
        if (Vector3.Distance(pos, apple.position) < 3) return false;

        GameObject[] trees = GameObject.FindGameObjectsWithTag("Tree");
        bool touching = true;
        foreach (GameObject tree in trees)
        {
            if (Vector3.Distance(tree.transform.position, pos) < 2)
            {
                touching = false;
                break;
            }
        }
        return touching;
    }
}
