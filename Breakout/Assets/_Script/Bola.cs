using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Bola : MonoBehaviour
{

    public bool isGameStarted = false;
   [SerializeField] public float velocidadBola = 15f; 

    Vector3 ultimaPosicion = Vector3.zero;
    Vector3 direccion = Vector3.zero;
    Rigidbody rigidBody;
    private ControlBordes control;
    public UnityEvent BolaDestruida;
    public Opciones opciones;
    private float modificadorVelocidad = 1;
    private void Awake()
    {
        control = GetComponent<ControlBordes>();

    }
    // Start is called before the first frame update
    void Start()
    {
        Vector3 posicionInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        posicionInicial.y += 3;
        this.transform.position = posicionInicial;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
        rigidBody = this.gameObject.GetComponent<Rigidbody>();
        switch ((int)opciones.nivelDificultad) {
            case 0:
                modificadorVelocidad = 0.5f;
                break;
            case 1:
                modificadorVelocidad = 1.0f;
                break;
            case 2:
                modificadorVelocidad = 1.5f;
                break;
        }

    }



    // Update is called once per frame
    void Update()
    {
        velocidadBola = opciones.velocidadBola* modificadorVelocidad;

        if (control.salioAbajo){
            BolaDestruida.Invoke();
            Destroy(this.gameObject);

        }

        if (control.salioArriba) {
           direccion = transform.position - ultimaPosicion;
            direccion.y *= -1;
            direccion = direccion.normalized;
            rigidBody.velocity = velocidadBola * direccion;
            control.salioArriba = false;
            control.enabled=false;
            Invoke("HabilitarControl", 0.2f);
            Debug.Log("Salio Arriba");
        }
        if (control.salioDerecha)
        { 
            direccion = transform.position - ultimaPosicion;
            direccion.x *= -1;
            direccion = direccion.normalized;
            rigidBody.velocity = velocidadBola * direccion;
            control.salioDerecha = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.2f);
            Debug.Log("Salio Derecha");

        }
        if (control.salioIzquierda)
        { 
            direccion = transform.position - ultimaPosicion;
            direccion.x *= -1;
            direccion = direccion.normalized;
            rigidBody.velocity = velocidadBola * direccion;
            control.salioIzquierda = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.2f);
            Debug.Log("Salio izquierda");

        }
        if (Input.GetKey(KeyCode.Space) || Input.GetButton("Submit") || Input.GetMouseButton(0))
        {
            if (!isGameStarted) {
                isGameStarted = true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().velocity = velocidadBola * Vector3.up;
            }
        }
    }

    void HabilitarControl() {
        control.enabled = true;
    }
    void FixedUpdate()
    {
        ultimaPosicion= transform.position;
    }

    private void LateUpdate()
    {
        if (direccion != Vector3.zero) {
            direccion = Vector3.zero;
        }
    }
}
