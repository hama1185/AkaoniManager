using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderText : MonoBehaviour
{
    public Canvas canvas;
    Slider Xslider;
    Slider Yslider;
    InputField Xinput;
    InputField Yinput;
    // Start is called before the first frame update
    void Start(){
        Xslider = canvas.transform.GetChild(3).GetChild(3).gameObject.GetComponent<Slider>();
        Yslider = canvas.transform.GetChild(3).GetChild(4).gameObject.GetComponent<Slider>();
        Xinput = canvas.transform.GetChild(3).GetChild(6).gameObject.GetComponent<InputField>();
        Yinput = canvas.transform.GetChild(3).GetChild(7).gameObject.GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update(){
        if(canvas.transform.GetChild(3).gameObject.activeSelf){
            try{
                Xslider.value = float.Parse(Xinput.text) / 100;
                Yslider.value = float.Parse(Yinput.text) / 100;
            }
            catch(System.FormatException){}
        }
    }

    public void onChangeValue(){
        Xinput.text = (Xslider.value * 100).ToString();
        Yinput.text = (Yslider.value * 100).ToString();
    }
}
