using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 3f;
    public Animator animator;

    void Start()
    {
    }

    void Update()
    {
        GetInputAxis();   
    }

    private void GetInputAxis()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _speed = 5f;
        }
        else
        {
            _speed = 3f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += _speed * Time.deltaTime * transform.forward;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += _speed * Time.deltaTime * -transform.forward;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += _speed * Time.deltaTime * transform.right;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += _speed * Time.deltaTime * -transform.right;
        }
    }
}
