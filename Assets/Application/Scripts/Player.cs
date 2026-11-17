using UnityEngine;

public class Player : MonoBehaviour
{

    [Header("Movement Details")]
    public float moveSpeed;
    public float rotationSpeed;


    [SerializeField]
    Rigidbody rb;


    private float verticalInput;
    private float horizontalInput;

  

   
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        if (rb)
            rb.linearVelocity = new Vector3(moveSpeed * horizontalInput, 0, moveSpeed * verticalInput);


        transform.Rotate(0,horizontalInput*rotationSpeed,0);
    }
}
