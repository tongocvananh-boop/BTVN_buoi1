//Bài tập 1: Tính số ngày trong tuần và số ngày lẻ
/*Yêu cầu người dùng nhập số ngày và tính toán bao nhiêu tuần và bao nhiêu ngày lẻ còn lại. 
Ví dụ, nếu người dùng nhập vào 10 ngày, kết quả sẽ là 1 tuần và 3 ngày.*/
//input: int soNgay
Console.WriteLine($@"Hãy nhập số ngày cần tính: ");
int soNgaycantinh = Convert.ToInt32(Console.ReadLine());


//output: int soTuan, int soNgay
int soTuan = 0;


/*process: cứ 7 ngày là một tuần 
-> cứ lấy số đó trừ cho 7 đến khi không trừ được nữa thì lấy đó làm số ngày
hoặc
-> lấy số đó chia cho 7 lấy phần nguyên, rồi lấy thương nhân lại 7, lấy số đó trừ đi tích
*/
soTuan = soNgaycantinh / 7;
int soNgayconlai = soTuan * 7;
int soNgay = soNgaycantinh - soNgayconlai;

//xuat
Console.WriteLine($@"Số tuần: {soTuan} và số ngày: {soNgay}");
