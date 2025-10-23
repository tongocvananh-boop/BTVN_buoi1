//Bài tập 5: Chuyển đổi đơn vị tiền tệ
/*Yêu cầu người dùng nhập vào một số tiền bằng USD và tỷ giá chuyển đổi từ USD sang VND.
Tính và in ra số tiền tương ứng bằng VND.*/

//input:
Console.WriteLine($@"Hãy nhập số tiền USD cần chuyển đổi: ");
double USD = double.Parse(Console.ReadLine());
double tyGiaUSDSangVND = 26410;
//output:
double soTienVND = 0;

//process: 1 USD = 26.410 VND 
soTienVND = USD * tyGiaUSDSangVND;

//xuat
Console.WriteLine($@"Số tiền quy đổi là: {soTienVND:N0} VND"); 
/*N = Number format (định dạng số có dấu phân tách hàng nghìn và có phần thập phân).
0 = số chữ số thập phân muốn hiển thị.*/
