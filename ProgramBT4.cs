//Bài tập 4: Tính tổng số tiền sau khi cộng thêm thuế VAT
/*Yêu cầu người dùng nhập vào số tiền gốc và tỷ lệ thuế VAT (ví dụ: 10%). 
Tính và in ra tổng số tiền sau khi đã cộng thêm thuế.*/
//input: double soTiengoc, double tyLethueVAT
Console.WriteLine($@"Hãy nhập vào số tiền trước thuế: ");
double soTiengoc = double.Parse(Console.ReadLine());
Console.WriteLine($@"Hãy nhập tỷ lệ thuế VAT (%)");
double tyLethueVAT = double.Parse(Console.ReadLine());

//output: double tongTiensauVAT
double tongTiensauVAT = 0;

//process: tongTiensauVAT = soTiengoc * tyLethueVAT
tongTiensauVAT = soTiengoc + (soTiengoc * (tyLethueVAT/100));

//xuat
Console.WriteLine($@"Số tiền sau thuế là: {tongTiensauVAT:N0} VND");
