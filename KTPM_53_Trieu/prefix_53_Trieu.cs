using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTPM_53_Trieu
{
   public class prefix_53_Trieu
    {
        private string a_53_Trieu, b_53_Trieu, c_53_Trieu, d_53_Trieu;
        public prefix_53_Trieu(string a_53_Trieu, string b_53_Trieu, string c_53_Trieu, string d_53_Trieu)
        {
            this.a_53_Trieu = a_53_Trieu;
            this.b_53_Trieu = b_53_Trieu;
            this.c_53_Trieu = c_53_Trieu;
            this.d_53_Trieu = d_53_Trieu;
        }
        public string LongestCommonPrefix_53_Trieu()
        {
            if (string.IsNullOrEmpty(this.a_53_Trieu) || string.IsNullOrEmpty(this.b_53_Trieu) || string.IsNullOrEmpty(this.c_53_Trieu) || string.IsNullOrEmpty(this.d_53_Trieu))
                return "Error";

            string prefix53_Trieu = this.a_53_Trieu;

            for (int i_53_Trieu = 0; i_53_Trieu < prefix53_Trieu.Length; i_53_Trieu++)
            {
                char currentChar = prefix53_Trieu[i_53_Trieu];
                if (this.b_53_Trieu.Length <= i_53_Trieu || this.c_53_Trieu.Length <= i_53_Trieu || this.d_53_Trieu.Length <= i_53_Trieu)
                {
                    // Nếu bất kỳ chuỗi nào kết thúc trước, dừng lại
                    prefix53_Trieu = prefix53_Trieu.Substring(0, i_53_Trieu);
                    break;
                }
                if (this.b_53_Trieu[i_53_Trieu] != currentChar || this.c_53_Trieu[i_53_Trieu] != currentChar || this.d_53_Trieu[i_53_Trieu] != currentChar)
                {
                    // Nếu có bất kỳ ký tự nào khác, dừng lại
                    prefix53_Trieu = prefix53_Trieu.Substring(0, i_53_Trieu);
                    break;
                }
            }

            if (string.IsNullOrEmpty(prefix53_Trieu))
            {
                return "No result";
            }
            else
            {
                return prefix53_Trieu;
            }
        }
    }
}
