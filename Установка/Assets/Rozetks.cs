using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                 
public class Rozetks : MonoBehaviour
{
  [SerializeField] 
   private Text message;  // объявить переменную и связать ее с на текстовым окном
   private Transform rozetka;
    // Start is called before the first frame update
    void Start()
    {
        
    }
public void OnPointerRozetka () {  
message.text = "Розетку требуется включить для подачи напряжения";  
} 
public void OnPointerHeader () {  
message.text = "Печатающая головка позволяет сменить красящую ленту, для этого достаньте крепеж ленты, смените ленту и поставьте деталь обратно";  
} 
public void OnPointerSwitch () {  
message.text = "Переключатель позволяет управлять питанием, нажмите на него, чтобы принтер включился";  
} 
public void OnPointerCover () {  
message.text ="Акустическое покрытие закрывает валик и печатающую головку от внешнего загрязнения";  
} 
public void OnPointerLever () {  
message.text = "Рычаг для подачи бумаги, переведите его в вертикальное положение, чтобы была возможность загружать бумагу";  
} 
public void OnPointerValik () {  
message.text = "Позволяет вращать валиком, не вращайте его при работе принтера!";  
} 
public void OnPointerPoyasnenie () {  
message.text = "Подаем напряжение, после чего указываем напряжение, а так же выбираем материал цилиндра и после нагрева цилиндра по его температуре находим теплопроводность материала";  
} 
public void OnPointer1stage () {  
message.text = "1 этап - нажмите на розетку, чтобы подать электричество";  
} 
public void OnPointer2stage () {  
message.text = "2 этап - Выберите металл из списка, введя его в строку, а так же укажите 30-40 Ватт для розетки";  
} 
public void OnPointer3stage () {  
message.text = "3 этап - переключите рычаг на On";  
} 
public void OnPointer4stage () {  
message.text = "4 этап - нажмите на кнопку 'Таблица' для открытия таблицы и 'Запись' для вывод результатов в таблицу";  
} 
public void OnPointer5stage () {  
message.text = "5 этап - определите теплоизолятор этот цилиндр или теплопроводник, если теплоизолятор должен иметь значение меньше, чем 30 Вт/м²К2";

} 
public void OnPointer6stage () {  
message.text = "6 этап - переключите рычаг на Off";

} 
public void OnPointer7stage () {  
message.text = "7 этап - выньте розетку";

} 
public void OnExit () {  
message.text = "";  
} 

    // Update is called once per frame
    void Update()
    {
        
    }
}
