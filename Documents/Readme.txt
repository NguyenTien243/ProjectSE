Tên đề tài: Quản lý Bãi Đỗ Xe Thông Minh
Nhóm thực hiện: Nhóm 11
Thành viên nhóm : Nguyễn Như Bảo Phương 18110180
                  Hoàng Minh Quang      18110181
                  Nguyễn Quốc Tiến      18110214
Hướng dẫn sử dụng Phiên bản phầm mềm 1.0:
* Chức năng "Đăng nhập":
	- Sau chạy chương trình sẽ hiện lên form "Đăng nhập" gồm Tài khoản và Mật khẩu. Người dùng (quản lý/ nhân viên) đăng nhập theo tài khoản và mật khẩu tương ứng đã được cấp trước đó.
	- Test thử chức năng cho người quản lý (Tài khoản: "quoctien", Mật khẩu: "tien123"), sau khi đăng nhập thành công sẽ chuyển sang form quản lý (bao gồm các chức năng: "Quản lý nhân viên", "Quản lý khách hàng", "Thống kê doanh thu", "Quản lý vị trí đỗ Xe").
	- Test chức năng của Nhân viên (tài khoản: minhquang, mật khẩu: quang2k) sẽ hiện thông báo "Đăng nhập thành công với tài khoản nhân viên, giao diện nhân viên chưa hoàn thành !!".
* Chức năng "Đăng xuất":
	- 
* Chức năng "Quản lý nhân viên": chọn chức năng "nhân viên" trên giao diện dashboard.
	- "Thêm nhân viên/ Đăng ký tài khoản": 
		+ Chọn "thêm" trên giao diện Quản lý nhân viên.
		+ Nhập thông tin cho nhân viên bao gồm: Mã nhân viên, tên nhân viên, ngày sinh, giới tính, lương, cmnd, số điện thoại, địa chỉ, tài khoản, mật khẩu, mật khẩu lần 2.
		+ Nếu nhập thiếu thông tin sẽ có thông báo cần nhập đủ thông tin.
		+ Chọn "Lưu" để thêm thông tin nhân viên, khi tất cả thông tin hợp lệ sẽ thêm thành công nhân viên. 
		+ Tài khoản không được trùng với tài khoản đã có.
		+ CMND không được trùng với CMND đã có.
		+ Mật khẩu lần 2 phải trùng mật khẩu lần 1 nếu không sẽ báo lỗi .
		+ Nhấn "Hủy" để hủy bỏ thao tác thêm
	- "Xóa nhân viên": 
		+ Chọn nhân viên trên bảng hiển thị danh sách nhân viên thông tin nhân viên sẽ được đổ lên tương ứng.
		+ Chọn "Xóa" trên giao diện Quản lý nhân viên, hộp thoại xác nhận xóa hiện lên để xác nhận xóa.
		+ Chọn "Đồng ý" xóa để xóa thông tin nhân viên được chọn.
	- "Sửa nhân viên": 
		+ Chọn nhân viên trên bảng hiển thị danh sách nhân viên, thông tin nhân viên sẽ được đổ lên tương ứng.
		+ Chọn "Sửa" trên giao diện Quản lý  nhân viên, cho phép sửa thông tin cá nhân và tài khoản của nhân viên ngoại trừ mã nhân viên.
		+ Chọn "Lưu" để xác nhận chỉnh sửa, chỉnh sửa sẽ thành công khi tất cả thông tin nhập vào hợp lệ.
		+ Nhấn "Hủy" để hủy bỏ thao tác chỉnh sữa
* Chức năng quản lý vị trí đỗ xe: chọn chức năng "Bãi đỗ xe" trên giao diện dashboard.
	- "Thêm vị trí":
		+ Chọn "thêm" trên giao diện Quản lý bãi đỗ xe.
		+ Nhập thông tin cho vị trí bao gồm: Mã vị trí, tên vị trí.
		+ Nếu nhập thiếu thông tin sẽ có thông báo cần nhập đủ thông tin.
		+ Chọn "Lưu" để thêm thông tin vị trí, khi tất cả thông tin hợp lệ sẽ thêm thành công vị trí. 
		+ Mã Vị trí mà tên vị trí không được trùng với mã và tên vị trí đã có, nếu nhập trùng sẽ thông báo cho người dùng.
		+ Nhấn "Hủy" để hủy bỏ thao tác thêm
	- "Xóa vị trí": 
		+ Chọn vị trí trên bảng hiển thị danh sách vị trí sẽ được đổ lên tương ứng.
		+ Chọn "Xóa" trên giao diện Quản lý bãi đỗ xe, hộp thoại xác nhận xóa hiện lên để xác nhận xóa, nếu vị trí đang có xe đổ sex hiện thông báo "Vị trí hiện tại đang có xe, vui lòng cho xe ra khỏi vị trí trước khi xóa!".
		+ Chọn "Đồng ý" xóa để xóa vị trí được chọn.
	- "Sửa vị trí":
		+ Chọn vị trí bảng hiển thị danh sách vị trí đỗ xe, thông tin vị trí đỗ xe sẽ được đổ lên tương ứng.
		+ Chọn "Sửa" trên giao diện Quản lý bãi đỗ xe, cho phép sửa thông tin tên vị trí.
		+ Chọn "Lưu" để xác nhận chỉnh sửa, chỉnh sửa sẽ thành công khi tên vị trí không bị trùng, nếu trùng sẽ hiện thông báo "Tên vị trí bị trùng vui lòng kiểm tra lại".
		+ Nhấn "Hủy" để hủy bỏ thao tác chỉnh sửa
	- "Tìm kiếm vị trí": 
		+ Chọn loại Tìm kiếm (tìm kiếm theo mã vị trí, tìm kiếm theo tên vị trí), khi không chọn loại tìm kiếm sẽ thông báo: "Vui lòng chọn loại tìm kiếm".
		+ Nhập nội dung cần tìm kiếm vào ô "Nhập nội dung", nếu nhấn "Tìm" khi nội dung trống sẽ hiện thông báo "Vui lòng nhập nội dung tìm kiếm".
		+ Nhấn "Tìm" để tìm kiếm nội dung, kết quả trả ra tương ứng.
		+ Nhấn "Làm mới" để tải lại danh sách vị trí bãi đỗ xe.

