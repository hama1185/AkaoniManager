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
    static public float spawnXvalue{get;set;}
    static public float spawnYvalue{get;set;}
    static public float PlayareaSizeX{get;set;}
    static public float PlayareaSizeY{get;set;}


    public Canvas canvas;
    Scrollbar ogreRelax;
    Scrollbar ogreMind;
    Scrollbar villagerRelax;
    Scrollbar villagerMind;

    InputField SpawnInputX;
    InputField SpawnInputY;

    InputField fieldX;
    InputField fieldY;
    void Start(){
        ogreRelax = canvas.transform.GetChild(5).GetChild(0).gameObject.GetComponent<Scrollbar>();
        ogreMind = canvas.transform.GetChild(5).GetChild(1).gameObject.GetComponent<Scrollbar>();
        villagerRelax = canvas.transform.GetChild(5).GetChild(2).gameObject.GetComponent<Scrollbar>();
        villagerMind = canvas.transform.GetChild(5).GetChild(3).gameObject.GetComponent<Scrollbar>();
        SpawnInputX = canvas.transform.GetChild(2).GetChild(4).gameObject.GetComponent<InputField>();
        SpawnInputY = canvas.transform.GetChild(2).GetChild(5).gameObject.GetComponent<InputField>();
        fieldX = canvas.transform.GetChild(3).GetChild(6).gameObject.GetComponent<InputField>();
        fieldY = canvas.transform.GetChild(3).GetChild(7).gameObject.GetComponent<InputField>();
    }
    void Update() {
        ogreRelaxValue = ogreRelax.value * 100;
        ogreMindValue = ogreMind.value * 100;
        villagerRelaxValue = villagerRelax.value * 100;
        villagerMindValue = villagerMind.value * 100;
        try{
            PlayareaSizeX = float.Parse(fieldX.text);
            PlayareaSizeY = float.Parse(fieldY.text);
        }catch(System.FormatException){}
        try{
            spawnXvalue = float.Parse(SpawnInputX.text);
            spawnYvalue = float.Parse(SpawnInputY.text);
        }catch(System.FormatException){}
    }
}