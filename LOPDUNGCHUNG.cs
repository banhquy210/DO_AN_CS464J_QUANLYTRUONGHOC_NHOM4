using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectTruongHoc
{
    internal class LOPDUNGCHUNG
    {
        string connect_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ProjectTruongHoc\ProjectTruongHoc\QLLH.mdf;Integrated Security=True";
        SqlConnection conn;
        public LOPDUNGCHUNG()
        {
            conn = new SqlConnection(connect_string);
        }
        public int dangNhap(string tenDangNhap, string matKhau, string bang)
        {
            string sql = "Select count(*) from " + bang + " where TenTaiKhoan = '" +
                tenDangNhap + "' and MatKhau = '" + matKhau + "';";
            SqlCommand cmm = new SqlCommand(sql,conn);

            conn.Open();
            int kq = (int)cmm.ExecuteScalar();
            conn.Close();
            return kq;
        }


        public int ketnoi(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            int kq = 0;
            conn.Open();
            try
            {
                kq = (int)comm.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi");
            }
            conn.Close();
            return kq;
        }

        public void thongbao(int kq, string text)
        {
            if (kq > 0)
            {
                MessageBox.Show(text + " thanh cong");
            }
            else { MessageBox.Show(text + " that bai"); };
        }

        public DataTable capnhapData(string table)
        {
            string sql = "Select * from " + table + ";";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }

        public string find_data(string sql)
        {
            SqlCommand cmm = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmm.ExecuteReader();
            string kq;
            if (reader.Read())
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    sb.AppendFormat("{0}: {1}\t", reader.GetName(i), reader[i]);
                }
                kq = sb.ToString();

            }
            else
            {
                 kq = "Không tìm thấy dữ liệu";

            }
            reader.Close();
            conn.Close();
            return kq;

        }

        public string find_data2(string sql)
        {
            SqlCommand cmm = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader reader = cmm.ExecuteReader();
            string kq;
            if (reader.Read())
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    sb.AppendFormat("{0}\t", reader[i]);
                }
                kq = sb.ToString();

            }
            else
            {
                kq = "Không tìm thấy dữ liệu";

            }
            reader.Close();
            conn.Close();
            return kq;

        }
        public DataTable timkiem(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
    }
}
