using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    Vector3 mousePos2D;
    Vector3 mousePos3D;
    Vector3 mousePosAnt3D;
    Transform transform;


    [SerializeField] public int limiteX = 24;

    [SerializeField] public float velocidad = 5f;
    // Start is called before the first frame update
    void Start()
    {
        transform = this.gameObject.transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bola") {
            Vector3 direcccion = collision.contacts[0].point - transform.position;
            direcccion = direcccion.normalized;
            collision.rigidbody.velocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direcccion;
        }


    }

    // Update is called once per frame
    void Update()
    {

 
        transform.Translate(Input.GetAxis("Horizontal")*Vector3.down * velocidad * Time.deltaTime);

        Vector3 pos = transform.position;

        mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        if (mousePosAnt3D.x != mousePos3D.x)
        {
            mousePosAnt3D = mousePos3D;
            pos.x = mousePos3D.x;
        }               


        if (transform.position.x < -limiteX) {
            pos.x = -limiteX;
        }

        if (pos.x > limiteX)
        {
            pos.x = limiteX;
        }

        transform.position = pos;

}
}
