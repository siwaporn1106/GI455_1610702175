using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HW01 : MonoBehaviour
{
    public InputField ad;
    public Text sa;
    string info;

    public void node()
    {
        if (info == "Aston Martin One") //InputField 1
        {
            found();
        }
        else if (info == "Kawasaki") //InputField 2
        {
            found();
        }
        else if (info == "Lamborghini") //InputField 3
        {
            found();
        }
        else if (info == "Mercedes - Benz") //InputField 4
        {
            found();
        }
        else if (info == "Porsche") //InputField 5
        {
            found();
        }
        else 
        {
            sa.text = "[ " + info + " ]" + " is not found.";
        }
    }//node

    void Update()
    {
        info = ad.text;

    }// Update

    void found()
    {
        sa.text = "[ "+ info + " ]" + " is found.";
    }//found

    public void ClearForm()
    {
        ad.text = "";
    }//ClearForm

    public void Cleartext()
    {
        sa.text = "";
    }//Cleartext

}//hw01