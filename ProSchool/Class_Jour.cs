using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSchool
{
    public class Jour
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private int m_id;    //  NOT in BDD
        private DateTime m_dateDT;    //  NOT in BDD
        private String m_dateStr;    //  NOT in BDD
        private String m_demiJour;    //  NOT in BDD
        private Boolean m_isWeekend;    //  NOT in BDD
        private Boolean m_isVacances;    //  NOT in BDD
        private Boolean m_isFerie;    //  NOT in BDD
        private DataGridViewColumn m_dgvColumn;

        //■■■■■■■■■■■■■■■■■■■■■■■■  CONSTRUCTEURS    ■■■■■■■■■■■■■■■■■■■■■■■■

        public Jour()
        {

        }


        public Jour(DateTime dateDT, String demiJour, Boolean isVacances, Boolean isFerie)
        {
            this.m_id = 0;
            this.m_dateDT = dateDT;
            this.m_dateStr = dateDT.ToString("yyyy-MM-dd");
            this.m_demiJour = demiJour;

            this.m_isWeekend = ((this.m_dateDT.DayOfWeek == DayOfWeek.Saturday) || (this.m_dateDT.DayOfWeek == DayOfWeek.Sunday) || (this.m_dateDT.DayOfWeek == DayOfWeek.Wednesday)) ;
            this.m_isVacances = isVacances;
            this.m_isFerie = isFerie;

         
        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  GET/SET    ■■■■■■■■■■■■■■■■■■■■■■■■


        public int Id { get => m_id; set => m_id = value; }
        public DateTime DateDT { get => m_dateDT; set => m_dateDT = value; }
        public String DateStr { get => m_dateStr; set => m_dateStr = value; }
        public String DemiJour { get => m_demiJour; set => m_demiJour = value; }
        public Boolean IsWeekend { get => m_isWeekend; set => m_isWeekend = value; }
        public Boolean IsVacances { get => m_isVacances; set => m_isVacances = value; }
        public Boolean IsFerie { get => m_isFerie; set => m_isFerie = value; }
        public DataGridViewColumn DgvColumn { get => m_dgvColumn; set => m_dgvColumn = value; }

        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■

    }
}
