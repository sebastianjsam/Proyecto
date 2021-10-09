using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioPoster : MonoBehaviour
{
    // Start is called before the first frame update



    public  string web1;
    RawImage m_Renderer;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.R))
        {
            DescargarPoster();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Cursor.visible = true;
        }

       
    }
    public void cambiarPoster(GameObject chocoCon)
    {
        if (chocoCon != null)
        {
            m_Renderer = GetComponent<RawImage>();
            m_Renderer.texture = chocoCon.GetComponent<Renderer>().material.mainTexture;
            web1 = "https://github.com/sebastianjsam/PDF/raw/main/pdf/" + chocoCon.GetComponent<Renderer>().material.name+ ".pdf";
            web1 = web1.Replace(" (Instance)", "");
            print(web1);
        }
    }
    public void DescargarPoster()
    {
        Application.OpenURL(web1);

    }

}
