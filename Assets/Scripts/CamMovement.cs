using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");

        Vector3 vect = new Vector3(horiz, 0, vert);

        transform.position += transform.TransformDirection(vect * speed * Time.deltaTime);
    }
}
