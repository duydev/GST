using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
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

        public HocVien[] hocVien;
        private Random random;

        public LopHoc()
        {
            random = new Random();
            hocVien = new HocVien[25];
            for (int i = 0; i < 25; i++)
            {
                hocVien[i] = new HocVien();
            }
        }

        public void ghepTen()
        {
            List<string> tenDaDung = new List<string>();
            string ten;
            for (int i = 0; i < 25; i++)
            {
                do
                {
                    ten = mangTen[random.Next(0, 49)];
                } while (tenDaDung.IndexOf(ten) >= 0);
                hocVien[i].hoTen = mangHo[random.Next(0, 15)] + " " + mangDem[random.Next(0, 30)] + " " + ten;
                tenDaDung.Add(ten);
            }
        }

        public void sinhID()
        {
            List<string> ids = new List<string>();
            string id;
            for (int i = 0; i < 25; i++)
            {
                do
                {
                    id = "hv";
                    for (int j = 0; j < 7; j++)
                    {
                        id += random.Next(0, 9);
                    }
                } while (ids.IndexOf(id) >= 0);
                hocVien[i].ID = id;
                ids.Add(id);
            }
        }

        public void sinhDiem()
        {
            for(int i = 0; i < 5; i++)
            {
                int j;
                int[] idx = shuffleIntArray();
                for(j = 0; j < 3; j++)
                {
                    hocVien[idx[j]].diem[i] = (float)random.Next(8, 10); 
                }
                for (j = 3; j < 16; j++)
                {
                    hocVien[idx[j]].diem[i] = (float)random.Next(5, 7);
                }
                for (j = 16; j < 22; j++)
                {
                    hocVien[idx[j]].diem[i] = (float)random.Next(3, 4);
                }
                for (j = 22; j < 24; j++)
                {
                    hocVien[idx[j]].diem[i] = (float)random.Next(1, 2);
                }
                hocVien[idx[24]].diem[i] = 0;
            }
        }

        public void inHocVien()
        {
            Console.WriteLine("{0,10}{1,30}{2,10}{3,10}{4,10}{5,10}{6,10}",
                    "ID",
                    "Ho Ten",
                    "Diem RA",
                    "Diem SD",
                    "Diem CS",
                    "Diem CU",
                    "Diem FT"
                    );
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("{0,10}{1,30}{2,10}{3,10}{4,10}{5,10}{6,10}",
                    hocVien[i].ID,
                    hocVien[i].hoTen,
                    hocVien[i].diem[0],
                    hocVien[i].diem[1],
                    hocVien[i].diem[2],
                    hocVien[i].diem[3],
                    hocVien[i].diem[4]
                    );
            }
        }

        private int[] shuffleIntArray()
        {
            int i;
            int[] idx = new int[25];
            for (i = 0; i < 25; i++)
            {
                idx[i] = i;
            }
            i = 25;
            while (i > 1)
            {
                i--;
                int newPos = random.Next(i + 1);
                int v = idx[newPos];
                idx[newPos] = idx[i];
                idx[i] = v;
            }
            return idx;
        }

    }
}
