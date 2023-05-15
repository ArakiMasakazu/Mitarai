using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject EndTextObject;
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        EndTextObject.SetActive(true);
        Debug.Log("Goal");
    }
}