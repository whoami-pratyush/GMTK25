using UnityEngine;

public class Moving_0 : MonoBehaviour
{

    public float movespeed = 3f;
    public float deadzone = -50f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + ((Vector3.left * movespeed)* Time.deltaTime);
        if(transform.position.x < deadzone)
        {
            Destroy(gameObject);
        }
    }
}
