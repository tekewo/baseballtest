using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
  private Rigidbody rb;
  public float BallSpeed;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      Vector3 force = new Vector3(0, 0, BallSpeed * -1);
      rb.AddForce(force, ForceMode.Impulse);
    }
    if (Input.GetMouseButtonDown(1))
    {
      Vector3 defaultposition = new Vector3(0, 1.8f, 9.22f);
      transform.position = defaultposition;
      rb.velocity = new Vector3(0,0,0);
    }
  }
}
