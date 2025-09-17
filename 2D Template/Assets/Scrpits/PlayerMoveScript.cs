using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float playerSpeed;
    public float jumpForce = 5f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
        //Controls Player Movement
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.MovePosition(rb.position + movement * playerSpeed * Time.fixedDeltaTime);
     
        
        
    }
    private void Update()
    //Player Jump
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        }
    }


}




