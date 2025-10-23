//Bài tập 6: Tính số dư sau khi rút tiền từ tài khoản
/*Yêu cầu người dùng nhập vào số dư tài khoản hiện tại và số tiền muốn rút. 
Tính và in ra số dư còn lại sau khi rút tiền (lưu ý không kiểm tra số dư âm ở bài này).*/

//input: double soDuhientai, double soTienmuonrut
Console.WriteLine($@"Nói cho tôi biết bạn đang có bao nhiêu xèng: ");
double soDuhientai = double.Parse(Console.ReadLine());
Console.WriteLine($@"Hãy nhập số tiền muốn rút để ăn chơi: ");
double soTienmuonrut = double.Parse(Console.ReadLine());

//output: double balance
double balance = soDuhientai - soTienmuonrut;

//process: balance = soDuhientai - soTienmuonrut
//xuat
Console.WriteLine($@"Số dư còn lại: {balance:N0} VND");