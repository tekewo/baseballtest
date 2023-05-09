using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
  private Rigidbody rb;
  public float BallSpedd;
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
      Vector3 force = new Vector3(0, 0, BallSpedd*-1);
      rb.AddForce(force);
      Debug.Log("ok");
    }
  }
}
