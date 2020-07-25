using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSystem : MonoBehaviour
{
    public float BPM;
    public GameObject bar;
    public GameObject bar2;

    private void Start()
    {
        InvokeRepeating("spawnFourthNote", 0.0f, 60.0f/BPM);
        InvokeRepeating("spawnEigthNote", (60.0f/BPM)/2.0f, 60.0f/BPM);
    }

    private void spawnFourthNote()
    {
        Instantiate(bar, bar.transform.position, Quaternion.identity);
    }

    private void spawnEigthNote() 
    {
        Instantiate(bar2, bar.transform.position, Quaternion.identity);
    }
}
