//Bài tập 9: Chuyển đổi từ km/h sang m/s
/*Yêu cầu người dùng nhập vào vận tốc bằng km/h và chuyển đổi nó sang m/s theo công thức: m/s = km/h ÷ 3.6. 
In ra kết quả sau khi chuyển đổi.
*/

//input: double km, double h
Console.WriteLine($@"Hãy nhập vào quãng đường (km): ");
double km = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($@"Hãy nhập vào thời gian đi quãng đường (h): ");
double h = Convert.ToDouble(Console.ReadLine());

//output: double metTrengiay
double metTrengiay = 0;

//process: m/s = km/h ÷ 3.6
metTrengiay = (km / h) / 3.6;

//xuat
Console.WriteLine($@"Vận tốc sau khi chuyển đổi là: {metTrengiay:F2} m/s");
