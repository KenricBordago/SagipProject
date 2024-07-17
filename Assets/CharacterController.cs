using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Animator animator;
    private float speed;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Example input handling
        float move = Input.GetAxis("Vertical"); // or however you handle movement
        speed = Mathf.Abs(move);

        // Set the speed parameter in the animator
        animator.SetFloat("Speed", speed);
    }
}