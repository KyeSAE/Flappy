using UnityEngine;
using UnityEngine.InputSystem;

public class FlappyScript : MonoBehaviour
{
    private Rigidbody rigidbody;
    public PlayerInput playerInput;
    private bool isDead = false;
    public bool hasStarted = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void Jump()
    {
        if (!hasStarted)
        {
            hasStarted = true;
            rigidbody.useGravity = true;
        }
        rigidbody.linearVelocity = Vector3.zero;
        rigidbody.AddForce(new Vector3(0, 4, 0), ForceMode.Impulse);
    }

    public void OnJumpAction(InputValue inputValue)
    {
        if (inputValue.isPressed == true && !isDead)
        {
            Jump();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isDead = true;
        Debug.Log("YOU DIED BRO NOOOOOOOOOOOOOOO turn it off and on again :3");
    }
}
