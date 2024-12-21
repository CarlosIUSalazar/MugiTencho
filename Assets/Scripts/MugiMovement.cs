using UnityEngine;

public class MugiMovement : MonoBehaviour
{
    public Animator animator;
    public float speed = 2.0f;

    void Update()
    {
        // Get input for movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Pass movement values to Animator
        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);

        // Move Mugi based on input
        Vector3 movement = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);

        // Handle attack with P key
        if (Input.GetKeyDown(KeyCode.P))
        {
            animator.SetTrigger("Attack_Series");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            animator.SetTrigger("LieDown");
        }
    }
}
