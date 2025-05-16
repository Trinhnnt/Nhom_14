
I.	KẾT QUẢ CHI TIẾT MÀ CHƯƠNG TRÌNH THỰC THI ĐƯỢC.
PHẦN 1. Quản lý sinh viên
-	Giao diện:
 ![image](https://github.com/user-attachments/assets/73c6af7b-51c1-49b2-ab00-de5665fc2446)

-	Đọc nội dung file theo dòng và tách chuỗi lên datagridview
 ![image](https://github.com/user-attachments/assets/f4f9a7e1-1ccc-4e07-85c8-dc1ca8801e29)

-	Khi chọn 1 dòng trên ListView/DataTable, nội dung của dòng đang chọn hiển thị lên các TextBox
![image](https://github.com/user-attachments/assets/32d647c7-ccf2-4dad-b417-063b15974aa1)

-	Nút Thêm - khi người dùng nhấn nút Thêm thì nút Thêm biến thành nút Hủy và nút Lưu sẽ enable. Đang ở nút Hủy nếu nhấn sẽ quay lại tình trạng ban đầu. 
 
![image](https://github.com/user-attachments/assets/e2126492-a093-4e3b-814a-a952796da06a)
![image](https://github.com/user-attachments/assets/856b0e14-0a75-4224-8ce7-67e871497a31)
-	Nút Lưu sẽ thêm mới nhân viên vào danh sách. 
 ![image](https://github.com/user-attachments/assets/7f7b66ea-f084-4634-9bc3-10e38c92cc3f)

![image](https://github.com/user-attachments/assets/b6c67368-23d1-44d2-b108-ab7e5da68ea3)
-	Khi đóng chương trình, dữ liệu sẽ tự động lưu xuống file.
 ![image](https://github.com/user-attachments/assets/ca76c7da-28da-493c-a02a-659e44147f57)
Phần 2: 
-	Phần front-end:
+ Giao điện đăng nhập:
![image](https://github.com/user-attachments/assets/11855a2f-910d-494a-bd7d-46b76daa0cfb)
 
+ Cửa sổ hiển thị thông tin tài khoản: 
![image](https://github.com/user-attachments/assets/9f00342e-7579-428b-8ed5-73aca9ceb66d)

+ Khi nhấn nút “Deposit” sẽ hiện ra một dialog cho nhập số tiền cần nộp vào tài 
khoản và nộp tiền nếu số tiền nộp là hợp lệ.
![image](https://github.com/user-attachments/assets/8d9e2113-24a8-4a47-9bcb-7eef44f9be76)

 + Khi nhấn nút “Display Transaction” sẽ liệt kê tất cả các giao dịch của tài khoản 
đó lên một listview(hoặc datatable) bên dưới. 

+ Nếu loại tài khoản là Saving thì hiển thị một cửa sổ bao gồm thông tin về số tài khoản, họ tên, địa chỉ và số điện thoại. Một nút ”Back” để đóng cửa sổ và quay lại màn hình trước đó.
 ![image](https://github.com/user-attachments/assets/d141f078-5efb-4985-89fd-07b570219537)
+ Nếu đăng nhập thất bại thì sẽ thông báo cụ thể sai username hoặc password. Việc đăng nhập không thể thực hiện quá 3 lần.
 ![image](https://github.com/user-attachments/assets/bb36cd37-a4b3-4382-ae1b-77721991efa6)

