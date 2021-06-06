using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventManager.DataAccess;

namespace EventManager.Utilities
{
    class StaticClass
    {
        /// <summary>
        /// Người dùng đang đăng nhập hệ thống
        /// </summary>
        public static NguoiDung User;

        /// <summary>
        /// Cho biết đang đăng nhập hay đã đăng xuất.
        /// </summary>
        public static bool DangNhap = false;
    }
}
