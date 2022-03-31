using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalForce = Input.GetAxis("Horizontal");
        float verticalForce = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x += 3.0f * horizontalForce * Time.deltaTime;
        position.y += 3.0f * verticalForce * Time.deltaTime;
        transform.position = position;
    }
}
