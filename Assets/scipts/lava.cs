using UnityEngine;

public class lava : MonoBehaviour
{
    public Transform destino;
    public float speed;
    public float moreSpeed;

    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, destino.position, speed * Time.deltaTime);


        if (Vector3.Distance(transform.position, destino.position) < 0.1f)
        {
            enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("turbo"))
        {
            speed += moreSpeed;
            Debug.Log("¡Turbo activado! Velocidad: " + speed);
        }
    }

   

}