using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [Header("CONFIGURATIONS")]
    [SerializeField] private float speed = 1;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        if (horizontal == 0 && vertical == 0)
            return;

        var direction = new Vector3(horizontal, 0, vertical);
        transform.Translate(direction * speed * Time.deltaTime);
    }

}
