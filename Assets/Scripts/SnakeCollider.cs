using UnityEngine;

public class SnakeCollider : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject gameOver;

    private bool shouldRun = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Segment") && shouldRun)
        {
            gameOver.SetActive(true);
            gameManager.isWon = true;
            shouldRun = false;
        }
    }
}
