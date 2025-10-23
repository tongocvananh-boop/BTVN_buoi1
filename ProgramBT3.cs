//Bài tập 3: Chuyển đổi thời gian từ phút sang giờ và phút
/* Yêu cầu người dùng nhập vào một số phút và chuyển đổi số phút này thành giờ và phút. 
Ví dụ, nếu người dùng nhập vào 130 phút, kết quả sẽ là 2 giờ và 10 phút.*/
//input: int soPhut
Console.WriteLine($@"Hãy nhập số phút cần tính: ");
int soPhutbandau = int.Parse(Console.ReadLine());

//output: int soGio, int soPhut
int soGiocantinh = 0;
int soPhutconlai = 0;

/*process: một giờ có 60p, lấy số phút được nhập vào chia cho 60 ra số giờ, lấy thương nhân cho 60p, 
lấy số phút được nhập trừ tích (cách tính như bài chuyển đổi tuần)*/
soGiocantinh = soPhutbandau / 60;
soPhutconlai = soPhutbandau - (soGiocantinh * 60);

//xuat
Console.WriteLine($@"
-> Số giờ: {soGiocantinh} và số phút: {soPhutconlai}
");
