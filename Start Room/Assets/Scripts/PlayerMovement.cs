using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{

    [Header("Stats")]
    public float speed;

    [Header("Component")]
    private Animator anim;
    private Rigidbody2D rb2d;
    private Vector2 movement;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotation();
    }

    private void Move()
    {
        if (Input.GetMouseButton(1))
        {
            movement = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            direction = new Vector2(movement.x - transform.position.x, movement.y - transform.position.y);
            direction.Normalize();

            Vector2 velocity = direction * speed;

            rb2d.velocity = velocity;

            anim.SetBool("IsMoving", true);
        }
        else
        {
            rb2d.velocity = Vector2.zero;

            anim.SetBool("IsMoving", false);
        }
    }
    private void Rotation()
    {
        transform.localScale = new Vector3(direction.x > 0 ? 5 : -5, transform.localScale.y);
        // transform.localScale = Vector3.Scale(transform.localScale, new Vector3(-1,1,1));
    }

}
