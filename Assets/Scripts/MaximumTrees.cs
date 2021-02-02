using UnityEngine;
using UnityEngine.UI;

public class MaximumTrees : MonoBehaviour
{
    public Slider maxTrees;

    public void UpdateTrees(int trees)
    {
        maxTrees.value = trees;
    }
}
