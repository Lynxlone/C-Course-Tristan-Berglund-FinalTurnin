using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viktory : MonoBehaviour
{
    private Vector3 targetDir;
    private float offset = 10f;
    private Vector3 cameraPos;

    // Start is called before the first frame update
    void Start()
    {
        cameraPos = Camera.main.transform.position;
        InvokeRepeating("SwapDir", 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        targetDir = (transform.position - cameraPos).normalized;
        transform.position = Vector3.Lerp(transform.position, transform.position + (targetDir * offset), 10f * Time.deltaTime);
        transform.LookAt(cameraPos);
    }

    void SwapDir()
    {
        offset = -offset;
    }
}
