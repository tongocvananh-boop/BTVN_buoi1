//Bài tập 2: Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá
/* Yêu cầu người dùng nhập vào giá trị của một đơn hàng và phần trăm giảm giá. 
Tính toán số tiền giảm giá và tổng số tiền phải thanh toán sau khi áp dụng giảm giá.
*/
//input: double giaBandau, double phanTramgiam
Console.WriteLine($@"Hãy nhập giá đơn hàng (VND): ");
double giaBandau = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($@"Hãy nhập phần trăm được giảm (%): ");
double phanTramgiam = Convert.ToDouble(Console.ReadLine());

//output: double soTienduocgiam, double tongSotiensaugiamgia
double soTienduocgiam = 0;
double tongSotiensaugiamgia = 0;

//process: soTienduocgiam = giaBandau * phanTramgiam, tongSotiensaugiamgia = giaBandau - soTienduocgiam
soTienduocgiam = giaBandau * (phanTramgiam/100);
tongSotiensaugiamgia = giaBandau - soTienduocgiam;

//xuat
Console.WriteLine($@"
Số tiền được giảm: {soTienduocgiam:N0} VND
Tổng số tiền phải thanh toán sau khi áp dụng giảm giá: {tongSotiensaugiamgia:N0} VND
");
