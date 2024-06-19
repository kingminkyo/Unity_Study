using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// ∞‘¿” - ¿ßƒ°∫§≈Õ, πÊ«‚∫§≈Õ 
//¿ßƒ°∫§≈Õ : xyz 
//πÊ«‚∫§≈Õ 
struct MyVector
{
    public float x;
    public float y;
    public float z;

    public float magnitude
    {
        get
        {
            return Mathf.Sqrt(x * x + y * y + z * z);
        }
    }
    public MyVector(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public static MyVector operator +(MyVector a, MyVector b)
    {
        return new MyVector(a.x + b.x, a.y + b.y, a.z + b.z);
    }
    public static MyVector operator -(MyVector a, MyVector b)
    {
        return new MyVector(a.x - b.x, a.y - b.y, a.z - b.z);
    }
    public static MyVector operator *(MyVector a, float d)
    {
        return new MyVector(a.x * d, a.y * d, a.z * d);
    }

}

public class PlayerControler : MonoBehaviour
{


    [SerializeField]
    float _speed = 10.0f;
    void Start()
    {
        MyVector from = new MyVector(10.0f, 0.0f, 0.0f);
        MyVector to = new MyVector(5.0f, 0.0f, 0.0f);
        MyVector dir = to - from;

        MyVector newpos = from + dir * _speed;
    }

    void Update()
    {

        //transform.Translate 
        //transform.position.magnitude;
        //transform.position.normalized;

        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * Time.deltaTime * _speed);

        //transform
    }
}
