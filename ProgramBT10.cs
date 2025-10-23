//Bài tập 10: Tính lượng calo tiêu thụ
/*Yêu cầu người dùng nhập vào số phút đã tập thể dục và loại hình tập thể dục 
(chọn từ các giá trị đã định trước như chạy, đạp xe, bơi lội). Tính và in ra lượng calo tiêu thụ
dựa trên số phút và loại hình tập thể dục (sử dụng hệ số calo tiêu thụ giả định cho mỗi loại hình).
*/

//input: double thoiGianDaTap, double loaiHinhTheDuc, double chay (100 kcal/1p), double dapXe (500 kcal/1p), double boiLoi (1000 kcal/1p)

Console.WriteLine($@"Hãy nhập vào thời gian bạn đã tập: ");
double thoiGianDaTap = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($@"Thời gian bạn đã nhập là phút chọn 1, giờ chọn 2: ");
double thoiGianChuyenDoi1 = 0;
double thoiGianChuyenDoi2 = 0;
double thoiGianChuyenDoi = Convert.ToDouble(Console.ReadLine());
if (thoiGianChuyenDoi == 1)
{
    thoiGianChuyenDoi1 = thoiGianDaTap;
}
else
{
    thoiGianChuyenDoi2 = thoiGianDaTap * 60;
}

Console.WriteLine($@"Hãy nhập vào loại hình thể dục bạn đã tập (chạy - 1, đạp xe - 2, bơi lội - 3): ");
double loaiHinhTheDuc = Convert.ToDouble(Console.ReadLine());
double chay = 100;
double dapXe = 500;
double boiLoi = 1000;

//output: double luongCaloTieuThu
double luongCaloTieuThu = 0;


//process: sử dụng cấu trúc điều kiện như trên kia, tùy theo người dùng chọn cái nào

if (loaiHinhTheDuc == 1 && thoiGianChuyenDoi == 1)
{
    luongCaloTieuThu = chay * thoiGianChuyenDoi1;
}
else if (loaiHinhTheDuc == 1 && thoiGianChuyenDoi == 2)
{
    luongCaloTieuThu = chay * thoiGianChuyenDoi2;
}
else if (loaiHinhTheDuc == 2 && thoiGianChuyenDoi == 1)
{
    luongCaloTieuThu = dapXe * thoiGianChuyenDoi1;
}
else if (loaiHinhTheDuc == 2 && thoiGianChuyenDoi == 2)
{
    luongCaloTieuThu = dapXe * thoiGianChuyenDoi2;
}
else if (loaiHinhTheDuc == 3 && thoiGianChuyenDoi == 1)
{
    luongCaloTieuThu = boiLoi * thoiGianChuyenDoi1;
}
else
{
    luongCaloTieuThu = boiLoi * thoiGianChuyenDoi2;
}

//xuat
Console.WriteLine($@"Lượng calo đã tiêu thụ là: {luongCaloTieuThu:N0} kcal");
