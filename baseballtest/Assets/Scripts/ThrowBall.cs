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
  }
}
