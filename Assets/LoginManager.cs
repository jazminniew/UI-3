using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public InputField RightPassword;
    public string password = "Jaz";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void checkPassword()
    {
        if (RightPassword.text == password)
        {
            Debug.Log("La contraseña fue ingresada correctamente");
        }
        else
        {
            Debug.Log("La contraseña es incorrecta");
        }
    }
}
