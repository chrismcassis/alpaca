using System.Collections.Generic;
using UnityEngine;

public class ShowOnHard : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> elementsList;
    void Start()
    {
        if (Difficulty.IsHard) 
        {
            foreach (GameObject element in elementsList) { 
            element.SetActive(true);
            }
        }
    }
}
