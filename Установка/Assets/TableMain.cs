using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TableMain : MonoBehaviour
{
  public double metall;
  [SerializeField]
    InputField InputVatt;
     [SerializeField]
    InputField InputMetall;


    public TextMesh внешняятемп;

       public TextMesh внутренняятемп;



    [SerializeField]
    Text Мощность11;
     [SerializeField]
    Text Мощность12;
     [SerializeField]
    Text Мощность13;
    [SerializeField]
    Text Мощность21;
     [SerializeField]
    Text Мощность22;
     [SerializeField]
    Text Мощность23;

     [SerializeField]
    Text t2Внутр11;
      [SerializeField]
    Text t2Внутр12;
     [SerializeField]
    Text t2Внутр13;
    [SerializeField]
    Text t2Внутр21;
      [SerializeField]
    Text t2Внутр22;
     [SerializeField]
    Text t2Внутр23;
    
    [SerializeField]
    Text t4Внутр11;
      [SerializeField]
    Text t4Внутр12;
     [SerializeField]
    Text t4Внутр13;
    [SerializeField]
    Text t4Внутр21;
      [SerializeField]
    Text t4Внутр22;
     [SerializeField]
    Text t4Внутр23;

    [SerializeField]
    Text t6Внутр21;
      [SerializeField]
    Text t6Внутр22;
     [SerializeField]
    Text t6Внутр23;
[SerializeField]
    Text t6Внутр11;
      [SerializeField]
    Text t6Внутр12;
     [SerializeField]
    Text t6Внутр13;

       [SerializeField]
    Text t1Внешн21;
      [SerializeField]
    Text t1Внешн22;
     [SerializeField]
    Text t1Внешн23;
   [SerializeField]
    Text t1Внешн11;
      [SerializeField]
    Text t1Внешн12;
     [SerializeField]
    Text t1Внешн13;


   [SerializeField]
    Text t3Внешн21;
      [SerializeField]
    Text t3Внешн22;
     [SerializeField]
    Text t3Внешн23;
    [SerializeField]
    Text t3Внешн11;
      [SerializeField]
    Text t3Внешн12;
     [SerializeField]
    Text t3Внешн13;

       [SerializeField]
    Text t5Внешн21;
      [SerializeField]
    Text t5Внешн22;
     [SerializeField]
    Text t5Внешн23;
[SerializeField]
    Text t5Внешн11;
      [SerializeField]
    Text t5Внешн12;
     [SerializeField]
    Text t5Внешн13;


     [SerializeField]
    Text td1Внутр11;
      [SerializeField]
    Text td1Внутр12;
     [SerializeField]
    Text td1Внутр13;
    [SerializeField]
    Text td1Внутр21;
      [SerializeField]
    Text td1Внутр22;
     [SerializeField]
    Text td1Внутр23;
    
    [SerializeField]
    Text td2Внешн11;
      [SerializeField]
    Text td2Внешн12;
     [SerializeField]
    Text td2Внешн13;
    [SerializeField]
    Text td2Внешн21;
      [SerializeField]
    Text td2Внешн22;
     [SerializeField]
    Text td2Внешн23;
[SerializeField]
    Text теплопр1;


    
    // Start is called before the first frame update
    void Start()
    {
   Close();
   Clean();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Close(){
    gameObject.SetActive(false);
   }
   public void Open(){
    gameObject.SetActive(true);
   }



    public void  WriteValue(){
        if(Мощность11.text=="-" && Мощность12.text=="-" && Мощность13.text=="-" &&  Мощность21.text=="-" && Мощность22.text=="-" &&Мощность23.text=="-" ){
            Мощность11.text = InputVatt.text.ToString();
                                    Мощность12.text = InputVatt.text.ToString();
                        Мощность13.text = InputVatt.text.ToString();
                        Мощность21.text = InputVatt.text.ToString();
                        Мощность22.text = InputVatt.text.ToString();
                        Мощность23.text = InputVatt.text.ToString();

        }
        if(t2Внутр11.text=="-" && t2Внутр12.text=="-" && t2Внутр13.text=="-" &&  t2Внутр21.text=="-" && t2Внутр22.text=="-" &&t2Внутр23.text=="-" &&
        t4Внутр11.text=="-" && t4Внутр12.text=="-" && t4Внутр13.text=="-" &&  t4Внутр21.text=="-" && t4Внутр22.text=="-" &&t4Внутр23.text=="-"  &&
        t6Внутр11.text=="-" && t6Внутр12.text=="-" && t6Внутр13.text=="-" &&  t6Внутр21.text=="-" && t6Внутр22.text=="-" &&t6Внутр23.text=="-"){

t2Внутр11.text=(20+((Convert.ToInt32( InputVatt.text) * 8*60)/(7.8*110*0.49))).ToString();
t2Внутр12.text=(20+((Convert.ToInt32( InputVatt.text) * 16*60)/(7.8*110*0.49))).ToString();
t2Внутр13.text=(20+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();
t2Внутр21.text=(20+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();
t2Внутр22.text=(20+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();
t2Внутр23.text=(20+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();

t4Внутр11.text=(18+((Convert.ToInt32( InputVatt.text) * 8*60)/(7.8*110*0.49))).ToString();
t4Внутр12.text=(18+((Convert.ToInt32( InputVatt.text) * 16*60)/(7.8*110*0.49))).ToString();
t4Внутр13.text=(18+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();
t4Внутр21.text=(18+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();
t4Внутр22.text=(18+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();
t4Внутр23.text=(18+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();

t6Внутр11.text=(21+((Convert.ToInt32( InputVatt.text) * 8*60)/(7.8*110*0.49))).ToString();
t6Внутр12.text=(21+((Convert.ToInt32( InputVatt.text) * 16*60)/(7.8*110*0.49))).ToString();
t6Внутр13.text=(21+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();
t6Внутр21.text=(21+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();
t6Внутр22.text=(21+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();
t6Внутр23.text=(21+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();



td1Внутр11.text=(((20+((Convert.ToInt32( InputVatt.text) * 8*60)/(7.8*110*0.49))) + (18+((Convert.ToInt32( InputVatt.text) * 8*60)/(7.8*110*0.49))) + (21+((Convert.ToInt32( InputVatt.text) * 8*60)/(7.8*110*0.49)))) /3).ToString() ;
td1Внутр12.text=(((20+((Convert.ToInt32( InputVatt.text) * 16*60)/(7.8*110*0.49))) + (18+((Convert.ToInt32( InputVatt.text) * 16*60)/(7.8*110*0.49))) + (21+((Convert.ToInt32( InputVatt.text) * 16*60)/(7.8*110*0.49)))) /3 ).ToString() ;
td1Внутр13.text=(((20+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (18+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (21+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49)))) /3 ).ToString() ;
td1Внутр21.text=(((20+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (18+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (21+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49)))) /3 ).ToString() ;
td1Внутр22.text=(((20+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (18+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (21+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49)))) /3 ).ToString() ;
td1Внутр23.text=(((20+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (18+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (21+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))))/3 ).ToString() ;

внутренняятемп.text=((((20+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (18+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (21+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))))/3 ).ToString()).Substring(0,5);





 if(InputMetall.text.ToString()=="медь"){
metall = 397;
    }
    else if(InputMetall.text.ToString() == "керамзитобетон"){
      metall=24;
    }
    else if(InputMetall.text.ToString() == "серебро"){
      metall=428;
    }else if(InputMetall.text.ToString() == "пеностекло"){
      metall=26;
    }
    else if(InputMetall.text.ToString() == "свинец"){
      metall=40;
    }else if(InputMetall.text.ToString() == "пенобетон"){
      metall=23;
    }
    else{
        InputMetall.text = "свинец";
         metall=40;
    }
  

t1Внешн11.text=((20+((Convert.ToDouble( InputVatt.text) * 8*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *8*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)).ToString();

t1Внешн12.text=((20+((Convert.ToDouble( InputVatt.text) * 16*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *16*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)).ToString();
t1Внешн13.text=((20+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)).ToString();
t1Внешн21.text=((20+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)).ToString();
t1Внешн22.text=((20+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)).ToString();
t1Внешн23.text=((20+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)).ToString();

t3Внешн11.text=((18+((Convert.ToDouble( InputVatt.text) * 8*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *8*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)).ToString();
t3Внешн12.text=((18+((Convert.ToDouble( InputVatt.text) * 16*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *16*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)).ToString();
t3Внешн13.text=((18+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)).ToString();
t3Внешн21.text=((18+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)).ToString();
t3Внешн22.text=((18+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)).ToString();
t3Внешн23.text=((18+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)).ToString();

t5Внешн11.text=((21+((Convert.ToDouble( InputVatt.text) * 8*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *8*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)).ToString();
t5Внешн12.text=((21+((Convert.ToDouble( InputVatt.text) * 16*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *16*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)).ToString();
t5Внешн13.text=((21+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)).ToString();
t5Внешн21.text=((21+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)).ToString();
t5Внешн22.text=((21+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)).ToString();
t5Внешн23.text=((21+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)).ToString();



td2Внешн11.text=(( ((20+((Convert.ToDouble( InputVatt.text) * 8*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *8*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)) + ((18+((Convert.ToDouble( InputVatt.text) * 8*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *8*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)) + ((21+((Convert.ToDouble( InputVatt.text) * 8*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *8*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336))) /3).ToString() ;
td2Внешн12.text=(( ((20+((Convert.ToDouble( InputVatt.text) * 16*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *16*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)) + ((18+((Convert.ToDouble( InputVatt.text) * 16*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *16*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)) + ((21+((Convert.ToDouble( InputVatt.text) * 16*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *16*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336))) /3 ).ToString() ;
td2Внешн13.text=(( ((20+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)) + ((18+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)) + ((21+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336))) /3 ).ToString() ;
td2Внешн21.text=(( ((20+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)) + ((18+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)) + ((21+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336))) /3 ).ToString() ;
td2Внешн22.text=(( ((20+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)) + ((18+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)) + ((21+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336))) /3 ).ToString() ;
td2Внешн23.text=(( ((20+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)) + ((18+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)) + ((21+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336))) /3 ).ToString() ;

внешняятемп.text = ((( ((20+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)) + ((18+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336)) + ((21+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336))) /3 ).ToString()).Substring(0,5) ;

     //     теплопр1.text= ((36.318 - ((20 + 40 * 24 * 60) / (7.8 * 110 * 0.49))) / ((40 * 24 * 60) * 0.336) / (2 * 3.14)).ToString();
    //     double x = (40 * 24 * 60 / (2 * 3.14 * ((40 * 24 * 60) / (7.8 * 110 * 0.49) - 36.618 / 0.336 - 20)));

//((20+((Convert.ToDouble( InputVatt.text) * 8*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *8*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336))

    теплопр1.text = (metall).ToString();// ((-((20+((Convert.ToDouble( InputVatt.text) * 8*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *8*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336))+ ((20+( ( (Convert.ToDouble( InputVatt.text)*24*60) / (7.8*110*0.49) ))))/(+ ( ((Convert.ToDouble( InputVatt.text)*8*60) / ( (2*3.14) * )) *0.336)))).ToString();

//(20+((Convert.ToDouble( InputVatt.text) * 8*60)/(7.8*110*0.49)))   -   ((20+((Convert.ToDouble( InputVatt.text) * 24*60)/(7.8*110*0.49)))- Convert.ToDouble((((Convert.ToDouble(InputVatt.text) *24*60))/(Convert.ToDouble(2* 3.14*metall)))* 0.336))
/*
td1Внутр11.text=((Convert.ToInt32(t6Внутр11.text) + Convert.ToInt32(t4Внутр11.text) + Convert.ToInt32(t2Внутр11.text)) /3).ToString() ;
td1Внутр12.text=((Convert.ToInt32(t6Внутр12.text) + Convert.ToInt32(t4Внутр12.text) + Convert.ToInt32(t2Внутр12.text)) /3 ).ToString() ;
td1Внутр13.text=((Convert.ToInt32(t6Внутр13.text) + Convert.ToInt32(t4Внутр13.text) + Convert.ToInt32(t2Внутр13.text)) /3 ).ToString() ;
td1Внутр21.text=((Convert.ToInt32(t6Внутр21.text) + Convert.ToInt32(t4Внутр21.text) + Convert.ToInt32(t2Внутр21.text)) /3 ).ToString() ;
td1Внутр22.text=((Convert.ToInt32(t6Внутр22.text) + Convert.ToInt32(t4Внутр22.text) + Convert.ToInt32(t2Внутр22.text)) /3 ).ToString() ;
td1Внутр23.text=((Convert.ToInt32(t6Внутр23.text) + Convert.ToInt32(t4Внутр23.text) + Convert.ToInt32(t2Внутр23.text)) /3 ).ToString() ;
*/
        }
     /*
        if(t1Внутр11.text=="-" && t1Внутр12.text=="-" && t1Внутр13.text=="-" &&  t1Внутр21.text=="-" && t1Внутр22.text=="-" &&t1Внутр23.text=="-" &&
        t3Внутр11.text=="-" && t3Внутр12.text=="-" && t3Внутр13.text=="-" &&  t3Внутр21.text=="-" && t3Внутр22.text=="-" &&t3Внутр23.text=="-"  &&
        t5Внутр11.text=="-" && t5Внутр12.text=="-" && t5Внутр13.text=="-" &&  t5Внутр21.text=="-" && t5Внутр22.text=="-" &&t5Внутр23.text=="-"){

t1Внутр11.text=(20+((Convert.ToInt32( InputVatt.text) * 8*60)/(7.8*110*0.49))).ToString();
t1Внутр12.text=(20+((Convert.ToInt32( InputVatt.text) * 16*60)/(7.8*110*0.49))).ToString();
t1Внутр13.text=(20+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();
t1Внутр21.text=(20+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();
t1Внутр22.text=(20+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();
t1Внутр23.text=(20+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();

t3Внутр11.text=(18+((Convert.ToInt32( InputVatt.text) * 8*60)/(7.8*110*0.49))).ToString();
t3Внутр12.text=(18+((Convert.ToInt32( InputVatt.text) * 16*60)/(7.8*110*0.49))).ToString();
t3Внутр13.text=(18+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();
t3Внутр21.text=(18+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();
t3Внутр22.text=(18+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();
t3Внутр23.text=(18+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();

t5Внутр11.text=(21+((Convert.ToInt32( InputVatt.text) * 8*60)/(7.8*110*0.49))).ToString();
t5Внутр12.text=(21+((Convert.ToInt32( InputVatt.text) * 16*60)/(7.8*110*0.49))).ToString();
t5Внутр13.text=(21+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();
t5Внутр21.text=(21+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();
t5Внутр22.text=(21+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();
t5Внутр23.text=(21+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))).ToString();



td2Внешн11.text=(((20+((Convert.ToInt32( InputVatt.text) * 8*60)/(7.8*110*0.49))) + (18+((Convert.ToInt32( InputVatt.text) * 8*60)/(7.8*110*0.49))) + (21+((Convert.ToInt32( InputVatt.text) * 8*60)/(7.8*110*0.49)))) /3).ToString() ;
td2Внешн12.text=(((20+((Convert.ToInt32( InputVatt.text) * 16*60)/(7.8*110*0.49))) + (18+((Convert.ToInt32( InputVatt.text) * 16*60)/(7.8*110*0.49))) + (21+((Convert.ToInt32( InputVatt.text) * 16*60)/(7.8*110*0.49)))) /3 ).ToString() ;
td2Внешн13.text=(((20+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (18+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (21+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49)))) /3 ).ToString() ;
td2Внешн21.text=(((20+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (18+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (21+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49)))) /3 ).ToString() ;
td2Внешн22.text=(((20+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (18+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (21+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49)))) /3 ).ToString() ;
td2Внешн23.text=(((20+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (18+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))) + (21+((Convert.ToInt32( InputVatt.text) * 24*60)/(7.8*110*0.49))))/3 ).ToString() ;


td1Внутр11.text=((Convert.ToInt32(t6Внутр11.text) + Convert.ToInt32(t4Внутр11.text) + Convert.ToInt32(t2Внутр11.text)) /3).ToString() ;
td1Внутр12.text=((Convert.ToInt32(t6Внутр12.text) + Convert.ToInt32(t4Внутр12.text) + Convert.ToInt32(t2Внутр12.text)) /3 ).ToString() ;
td1Внутр13.text=((Convert.ToInt32(t6Внутр13.text) + Convert.ToInt32(t4Внутр13.text) + Convert.ToInt32(t2Внутр13.text)) /3 ).ToString() ;
td1Внутр21.text=((Convert.ToInt32(t6Внутр21.text) + Convert.ToInt32(t4Внутр21.text) + Convert.ToInt32(t2Внутр21.text)) /3 ).ToString() ;
td1Внутр22.text=((Convert.ToInt32(t6Внутр22.text) + Convert.ToInt32(t4Внутр22.text) + Convert.ToInt32(t2Внутр22.text)) /3 ).ToString() ;
td1Внутр23.text=((Convert.ToInt32(t6Внутр23.text) + Convert.ToInt32(t4Внутр23.text) + Convert.ToInt32(t2Внутр23.text)) /3 ).ToString() ;

        }*/
     
    } 
    
    public void Clean(){
Мощность11.text="-";
Мощность12.text="-";
Мощность13.text="-";
Мощность21.text="-";
Мощность22.text="-";
Мощность23.text="-";

t2Внутр11.text="-";
t2Внутр12.text="-";
t2Внутр13.text="-";
t2Внутр21.text="-";
t2Внутр22.text="-";
t2Внутр23.text="-";

t4Внутр11.text="-";
t4Внутр12.text="-";
t4Внутр13.text="-";
t4Внутр21.text="-";
t4Внутр22.text="-";
t4Внутр23.text="-";

t6Внутр11.text="-";
t6Внутр12.text="-";
t6Внутр13.text="-";
t6Внутр21.text="-";
t6Внутр22.text="-";
t6Внутр23.text="-";

t1Внешн11.text="-";
t1Внешн12.text="-";
t1Внешн13.text="-";
t1Внешн21.text="-";
t1Внешн22.text="-";
t1Внешн23.text="-";

t3Внешн11.text="-";
t3Внешн12.text="-";
t3Внешн13.text="-";
t3Внешн21.text="-";
t3Внешн22.text="-";
t3Внешн23.text="-";

t5Внешн11.text="-";
t5Внешн12.text="-";
t5Внешн13.text="-";
t5Внешн21.text="-";
t5Внешн22.text="-";
t5Внешн23.text="-";

td1Внутр11.text="-";
td1Внутр12.text="-";
td1Внутр13.text="-";
td1Внутр21.text="-";
td1Внутр22.text="-";
td1Внутр23.text="-";

td2Внешн11.text="-";
td2Внешн12.text="-";
td2Внешн13.text="-";
td2Внешн21.text="-";
td2Внешн22.text="-";
td2Внешн23.text="-";
    }

   
}
