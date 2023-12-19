using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Schewpf.Data
{
    public class Info
    {
        public const long NO_INFO = -1;

        /// <summary>
        /// 정보마다 부여되는 고유의 ID
        /// </summary>
        public long InfoID { get; set; } = NO_INFO; 

        /// <summary>
        /// 사무실 정보
        /// </summary>
        public string Office { get; set; } = "";

        /// <summary>
        /// 이름 정보
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// 휴대전화 정보
        /// </summary>
        public string Phone { get; set; } = "";

        /// <summary>
        /// 이메일 정보
        /// </summary>
        public string Email { get; set; } = "";

        /// <summary>
        /// 부연 설명
        /// </summary>
        public string Descryption { get; set; } = "";

        public override string ToString()
        {
            return Office + " " + Name + ", " + Descryption;
        }
    }
}