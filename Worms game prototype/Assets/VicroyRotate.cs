using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VicroyRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var newAngles = new Vector3(60f * Time.deltaTime, 0f, 0f);
        transform.Rotate(newAngles, Space.Self);
    }
}
