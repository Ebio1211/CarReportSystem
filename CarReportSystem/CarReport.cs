using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem
{
    [Serializable]
    class CarReport
    {
        [System.ComponentModel.DisplayName("作成日")]
        public DateTime CreatedDate { get; set; }
        [System.ComponentModel.DisplayName("記録者")]
        public string Author { get; set; }
        [System.ComponentModel.DisplayName("メーカー")]
        public CarMaker Maker { get; set; }
        [System.ComponentModel.DisplayName("車名")]
        public string Name { get; set; }
        [System.ComponentModel.DisplayName("レポート")]
        public string Report { get; set; }
        [System.ComponentModel.DisplayName("画像")]
        public Image Picture { get; set; }

        public enum CarMaker
        {
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外車,
            その他
        }
        
    }
}
