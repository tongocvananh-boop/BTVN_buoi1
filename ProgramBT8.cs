//Bài tập 8: Tính tỷ lệ phần trăm
/*Yêu cầu người dùng nhập vào một số và một tổng số, sau đó tính và in ra tỷ lệ phần trăm của số đó trong tổng số.
*/

//input: double thanhPhan, double tong
Console.WriteLine($@"Hãy nhập vào tổng số: ");
double tong = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($@"Hãy nhập vào số con muốn tính: ");
double thanhPhan = Convert.ToDouble(Console.ReadLine());

//output: double tyLe
double tyLe = 0;

//process: tyLe = (thanhPhan / tong) *100
tyLe = (thanhPhan / tong) * 100;

//xuat
Console.WriteLine($@"Tỷ lệ phần trăm là: {tyLe}%");
