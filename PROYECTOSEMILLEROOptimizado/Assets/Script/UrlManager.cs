using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrlManager : MonoBehaviour
{
    // Start is called before the first frame update

  
    public string web1;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            sala1();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Cursor.visible = true;
        }
        


    }

    public void sala1()
    {
        Application.OpenURL(web1);
       
    }
}
