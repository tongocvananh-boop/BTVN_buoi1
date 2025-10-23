//Bài tập 7: Tính tốc độ trung bình
/*Yêu cầu người dùng nhập vào quãng đường đã đi (km) và thời gian đã đi (giờ). 
Tính và in ra tốc độ trung bình (km/h).*/

//input: double quangDuong, double thoiGian
//hmm nếu người dùng nhập m thì sao, hardcore tí
double quangDuong1 = 0;
double quangDuong2 = 0;
double thoiGian1 = 0;
double thoiGian2 = 0;
Console.WriteLine($@"Hãy nhập quãng đường đã đi: ");
double quangDuong = double.Parse(Console.ReadLine());
Console.WriteLine($@"Bạn đã nhập đơn vị: m chọn 1 hoặc km chọn 2");
double kieuDonVi = double.Parse(Console.ReadLine());
if (kieuDonVi == 1)
{
    Console.WriteLine($@"Bạn đã nhập {quangDuong} m");
    quangDuong1 = (quangDuong / 1000);
}
else
{
    Console.WriteLine($@"Bạn đã nhập {quangDuong} km");
    quangDuong2 = quangDuong;
}

Console.WriteLine($@"Hãy nhập thời gian bạn đã đi: ");
double thoiGian = double.Parse(Console.ReadLine());
Console.WriteLine($@"Bạn đã nhập đơn vị: phút chọn 1 hoặc giờ chọn 2");
double kieuThoiGian = double.Parse(Console.ReadLine());

if (kieuThoiGian == 1)
{
    Console.WriteLine($@"Bạn đã nhập {thoiGian} phút");
    thoiGian1 = thoiGian / 60;
}
else
{
    Console.WriteLine($@"Bạn đã nhập {thoiGian} giờ");
    thoiGian2 = thoiGian;
}

//output: double tocDoTrungBinh
double tocDoTrungBinh = 0;

//process: tocDoTrungBinh = quangDuong / thoiGian
if (kieuDonVi == 1 && kieuThoiGian == 1)
{
   tocDoTrungBinh = quangDuong1 / thoiGian1;
}
else if (kieuDonVi == 1 && kieuThoiGian == 2)
{
    tocDoTrungBinh = quangDuong1 / thoiGian2;
}
else if (kieuDonVi == 2 && kieuThoiGian == 1)
{
   tocDoTrungBinh = quangDuong2 / thoiGian1;
}
else
    tocDoTrungBinh = quangDuong2 / thoiGian2;

//xuat
Console.WriteLine($@"Tốc độ trung bình là: {tocDoTrungBinh:F1} km/h");
