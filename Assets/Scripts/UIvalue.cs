using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIvalue : MonoBehaviour
{
    static public float ogreRelaxValue{get;set;}
    static public float ogreMindValue{get;set;}
    static public float villagerRelaxValue{get;set;}
    static public float villagerMindValue{get;set;}
    static public float fieldXvalue{get;set;}
    static public float fieldYvalue{get;set;}

    public Canvas canvas;
    Scrollbar ogreRelax;
    Scrollbar ogreMind;
    Scrollbar villagerRelax;
    Scrollbar villagerMind;

    InputField Xfield;
    InputField Yfield;
    void Start(){
        ogreRelax = canvas.transform.GetChild(5).GetChild(0).gameObject.GetComponent<Scrollbar>();
        ogreMind = canvas.transform.GetChild(5).GetChild(1).gameObject.GetComponent<Scrollbar>();
        villagerRelax = canvas.transform.GetChild(5).GetChild(2).gameObject.GetComponent<Scrollbar>();
        villagerMind = canvas.transform.GetChild(5).GetChild(3).gameObject.GetComponent<Scrollbar>();
        Xfield = canvas.transform.GetChild(2).GetChild(4).gameObject.GetComponent<InputField>();
        Yfield = canvas.transform.GetChild(2).GetChild(5).gameObject.GetComponent<InputField>();
    }
    void Update() {
        ogreRelaxValue = ogreRelax.value * 100;
        ogreMindValue = ogreMind.value * 100;
        villagerRelaxValue = villagerRelax.value * 100;
        villagerMindValue = villagerMind.value * 100;
        try{
            fieldXvalue = float.Parse(Xfield.text);
            fieldYvalue = float.Parse(Yfield.text);
        }catch(System.FormatException){}
    }
}