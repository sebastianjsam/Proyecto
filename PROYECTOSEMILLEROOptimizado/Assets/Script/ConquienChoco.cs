using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConquienChoco : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canv;
    public GameObject Content;
    public GameObject Personaje;
    public GameObject canvasPressTecla;
    public GameObject canvasPressTecla2;
    public GameObject canvasAyuda;


    bool presionoE = false;
    bool presionoX = true;
    bool estaColicionando = false;
    int contarE = 0;
    int contarX = -1;
    int contarF = 0;

    bool valer = false;
    void Start()
    {
        GameObject canvasTemporal = Instantiate(canvasAyuda, this.canvasAyuda.transform.position, this.canvasAyuda.transform.rotation);
        canvasTemporal.SetActive(true);
        Destroy(canvasTemporal, 5.0f);
        this.contarF = 1;
    }
   
    // Update is called once per frame
    void Update()
    {
        if (valer == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (Input.GetKeyDown(KeyCode.X)&&estaColicionando == true)
        {
                if (presionoX == false && contarX==0)
                {
                    this.Personaje.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().ActivarCursor();
                    // this.Personaje.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().ActivarMovimiento();
                    canv.SetActive(false);
                    print("EStado movimiento= " + this.Personaje.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().getMovimientoActivar());
                presionoE = false;
                contarE = 0;
            }
            contarX ++;
            }

        //if (GetKeyDown(KeyCode.X) &&estaColicionando==true)
        if (Input.GetKeyDown(KeyCode.E) && estaColicionando == true)
        {
            if (presionoE == false && contarE == 0)
                {
                    canv.SetActive(true);
                    this.Personaje.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().ActivarCursor();
                presionoX = false;
            }
            contarE++;
            contarX = 0;
            GameObject canvasTemporal = Instantiate(canvasPressTecla2, this.canvasPressTecla2.transform.position, this.canvasPressTecla2.transform.rotation);
            canvasTemporal.SetActive(true);
            Destroy(canvasTemporal, 0.9f);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (contarF == 0)
            {
                canvasAyuda.SetActive(true);
                this.contarF = 1;
            }else{          
                canvasAyuda.SetActive(false);
                    contarF = 0;
            }
        }

        
    }


    public void PresionarX()
    {
        if (presionoX == false && contarX == 0)
        {
            this.Personaje.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().ActivarCursor();
            // this.Personaje.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().ActivarMovimiento();
            canv.SetActive(false);
            print("EStado movimiento= " + this.Personaje.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().getMovimientoActivar());
            presionoE = false;
            contarE = 0;
        }
        contarX++;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Poster")
        {
            estaColicionando = true;
            contarE = 0;
            print("colisiono " + other.name);
            if (other != null)
            {
                this.Content.GetComponent<CambioPoster>().cambiarPoster(other.gameObject);
            }
            GameObject canvasTemporal = Instantiate(canvasPressTecla, this.canvasPressTecla.transform.position, this.canvasPressTecla.transform.rotation);

            canvasTemporal.SetActive(true);
            Destroy(canvasTemporal, 0.9f);


            //valer = true;
            // this.Personaje.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().ActivarMovimiento();
        }
    }

    private bool entrar1 = false;
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Poster"){ }
        estaColicionando = false;
        print("no****" + other.name);
        canv.SetActive(false);
        if (entrar1 == false)
        {
            //this.Personaje.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().ActivarCursor();
        } 
        


    }
}
