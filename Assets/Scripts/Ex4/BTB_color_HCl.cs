using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTB_color_HCl : MonoBehaviour
{
    GameObject textd;
    ExDtextchange script;
    public Material[] _material;
    // Start is called before the first frame update
    void Start()
    {
        textd=GameObject.Find("textd");
        script = textd.GetComponent<ExDtextchange>();
    }

    // Update is called once per frame
    void Update()
    {
        if(script.state_BTB_color=="green_HCl"){
            this.GetComponent<Renderer>().material=_material[0];
        }
        if(script.state_BTB_color=="yellow_HCl"){
            this.GetComponent<Renderer>().material=_material[1];
        }
        if(script.state_BTB_color=="semi_yellow_HCl"){
            this.GetComponent<Renderer>().material=_material[2];
        }
        if(script.state_BTB_color=="initial"){
            this.GetComponent<Renderer>().material=_material[3];
        }
    }
}
