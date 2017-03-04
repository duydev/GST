using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass03
{
    class LopHoc
    {
        public string[] mangTen = {
                                    "Tran", "Nguyen", "Ly", "Truong", "Ho", "Do", "Dao", "Van", "Bui", "Luu", "Tao", "Doan", "Kieu", "Vuu", "To",
                                    "Nhat", "Tinh", "Tan", "Tuan", "Hoan", "Long", "Lam", "Ly", "Thuan", "Thao",
                                    "Nguyen", "Phuong", "Chi", "Bich", "Van", "Tin", "Tien", "Quang", "Son", "Vy",
                                    "Tu", "Quyen", "Anh", "Cuong", "Ty", "Suu", "Dan", "Meo", "Thin", "Ngo",
                                    "Mui", "Than", "Dau", "Tuat", "Hoi", "Huyen", "Ngoc", "Duong", "Trung", "Hai"
                                  };

        public string[] mangDem = {
                                    "Tran", "Nguyen", "Ly", "Truong", "Ho", "Do", "Dao", "Van", "Bui", "Luu", "Tao", "Doan", "Kieu", "Vuu", "To",
                                    "Nhat", "Tinh", "Tan", "Tuan", "Hoan", "Long", "Lam", "Ly", "Thuan", "Thao",
                                    "Nguyen", "Phuong", "Chi", "Bich", "Van", "Tin", "Tien", "Quang", "Son", "Vy"
                                  };

        public string[] mangHo = {
                                    "Tran", "Nguyen", "Ly", "Truong", "Ho",
                                    "Do", "Dao", "Van", "Bui", "Luu",
                                    "Tao", "Doan", "Kieu", "Vuu", "To"
                                 };

        public void ghepTen()
        {
            List<string> tenDaSuDung = new List<string>();
            Random random = new Random();
            string ten;
            for (int i = 0; i < 25; i++)
            {
                do
                {
                    ten = mangTen[random.Next(0, 50)];
                } while (tenDaSuDung.IndexOf(ten) >= 0);
                tenDaSuDung.Add(ten);
                Console.WriteLine(mangHo[random.Next(0, 15)] + " " + mangDem[random.Next(0, 30)] + " " + ten);
            }
        }

        public void sinhID()
        {
            List<string> ids = new List<string>();
            Random random = new Random();
            string id;
            for (int i = 0; i < 25; i++)
            {
                do
                {
                    id =  mangTen[random.Next(0, 50)];
                } while (tenDaSuDung.IndexOf(ten) >= 0);
                tenDaSuDung.Add(ten);
                Console.WriteLine(mangHo[random.Next(0, 15)] + " " + mangDem[random.Next(0, 30)] + " " + ten);
            }
        }

    }
}
