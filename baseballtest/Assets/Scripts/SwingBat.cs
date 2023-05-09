using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingBat : MonoBehaviour
{
    private Rigidbody rb;
    public float SwingSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(Vector3.right * SwingSpeed * -1 * Time.deltaTime);
        }
    }
}
