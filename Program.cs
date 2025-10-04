#region 
/* Bài trên lớp: Viê´t chương trình nhập vào cân nặng (kg) và chiê`u cao (m) của một
 người. Tính và in ra chỉ sô´ BMI (Body Mass Index) của người đó.
 */

//input: double weight, double height,  BMI = Cân nặng / (Chiê ̀u cao (m))^2
Console.WriteLine($@"Hãy nhập cân nặng của bạn: ");
double weight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($@"Hãy nhập chiều cao của bạn (m) (vd: 160cm = 1.6m): ");
double height = Convert.ToDouble(Console.ReadLine());

//output: double BMI
double BMI = 0;


//process:
BMI = weight / (height * height);


//xuat
Console.WriteLine($@"Chỉ số BMI của bạn là: {BMI:F1}");

if (BMI < 18.5)
{ Console.WriteLine($@"-> Bạn đang thiếu cân"); }

    else if (BMI >= 18.5 && BMI <24.9)
    { Console.WriteLine($@"-> Chúc mừng bạn, chỉ số BMI của bạn bình thường. Thoải mái làm thêm ly matcha latte nhóe");}

    else if (BMI >= 25 && BMI < 29.9)
    { Console.WriteLine($@"-> Bạn đang thừa cân"); }

    else
    { Console.WriteLine($@"-> Bạn đang bị béo phì"); }
#endregion
