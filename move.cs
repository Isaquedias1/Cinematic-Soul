using UnityEngine;

public class move : MonoBehaviour
{
    Vector3 m;
    public float Timer = 5f;
    private bool TimerAtivo = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m = new Vector3(2.91f, 0.711f, -2.303f);
        transform.position = m;
        m.Set(0, 0, 0);
        TimerAtivo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            m.x = 0.0075f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.A))
        {
           m.x = -0.0075f;
           transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.W))
        {
           m.z = 0.0075f;
           transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.S))
        {
            m.z = -0.0075f;
            transform.Translate(m);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m.y = -0.75f;
            transform.Rotate(m);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            m.y = 0.75f;
            transform.Rotate(m);
        }

        m.Set(0, 0, 0);

        if (TimerAtivo == true)
        {
            if (Timer > 0)
            {
                Timer -= Time.deltaTime;
            }
            else
            {
                m = new Vector3 (-40.25f, 9.853f, -7.17f);
                transform.position = m;
                m.Set(0, 0, 0);
                TimerAtivo = false;
            }
        }

    }

    
            

}

