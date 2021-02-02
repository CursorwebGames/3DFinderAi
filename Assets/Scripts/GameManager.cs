using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isWon = false;

    private void Update()
    {
        if (!isWon) Cursor.lockState = CursorLockMode.Locked;
        else Cursor.lockState = CursorLockMode.None;
    }
}
