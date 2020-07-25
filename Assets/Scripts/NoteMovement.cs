using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMovement : MonoBehaviour
{
    private float BPM;

    // Start is called before the first frame update
    void Start()
    {
        BPM = GameObject.Find("NoteSpawner").GetComponent<NoteSystem>().BPM;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position -= new Vector3(0,((60.0f/BPM)/6.5f)/2f,0);
        if (this.transform.position.y < -5.0f) 
        {
            Destroy(this.gameObject);
        }
    }
}
