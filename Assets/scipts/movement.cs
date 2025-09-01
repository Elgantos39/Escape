using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody2d;
    public float speed;
    [SerializeField]private float horizontal;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal");
        transform.position = new Vector2(transform.position.x + horizontal * speed * Time.deltaTime, transform.position.y);
       
    }


}