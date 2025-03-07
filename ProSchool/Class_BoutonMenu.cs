using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSchool
{
    public class BoutonMenu
    {

        //■■■■■■■■■■■■■■■■■■■■■■■■  DECLARATIONS    ■■■■■■■■■■■■■■■■■■■■■■■■

        private int m_niveau; 
        private String m_text;  
        private String m_strFormToOpen; 
        private Color m_backColor;
        private BoutonMenu m_btParent;
        private Boolean m_selected;
        private Label m_label;

        /* UNUEDS 
       
            
        private int m_id;    //  NOT in BDD
        private Color color;
        private string v1;
        private string v2;
        private String m_code;    //  NOT in BDD
        private int m_ParentBoutonMenuId;    //  NOT in BDD


            */



        //■■■■■■■■■■■■■■■■■■■■■■■■  CONSTRUCTEURS    ■■■■■■■■■■■■■■■■■■■■■■■■

        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■
        public BoutonMenu(string strFormToOpen)
        {

        }

        /**** NIVEAU 1 ****/
        public BoutonMenu(Color _backColor, string _strFormToOpen, string _text )
        {

            this.m_niveau = 1;
            this.m_text = _text;
            this.m_strFormToOpen = _strFormToOpen;
          //  this.m_btParent = xxxxxxxx;
            this.m_backColor = _backColor;
            this.m_selected = false;
            this.m_label = null;


        }


        /**** NIVEAU 2 ****/
        public BoutonMenu(BoutonMenu _btParent, string _strFormToOpen, string _text)
        {
            this.m_niveau = _btParent.Niveau+1;
            this.m_text = _text;
            this.m_strFormToOpen = _strFormToOpen;
              this.m_btParent = _btParent;
            //   this.m_backColor = _backColor;
            this.m_selected = false;
            this.m_label = null;

        }

        //■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■ ■

        public BoutonMenu(int id, int niveau, String text, String code, String strFormToOpen, int ParentBoutonMenuId)
        {
          
        }



        //■■■■■■■■■■■■■■■■■■■■■■■■  GET/SET    ■■■■■■■■■■■■■■■■■■■■■■■■


        public int Niveau { get => m_niveau; set => m_niveau = value; }
        public String Text { get => m_text; set => m_text = value; }
        public String StrFormToOpen { get => m_strFormToOpen; set => m_strFormToOpen = value; }
        public Color BackColor { get => m_backColor; set => m_backColor = value; }
        public BoutonMenu BtParent { get => m_btParent; set => m_btParent = value; }
        public bool Selected { get => m_selected; set => m_selected = value; }
        public Label Label { get => m_label; set => m_label = value; }



        //■■■■■■■■■■■■■■■■■■■■■■■■  FIN    ■■■■■■■■■■■■■■■■■■■■■■■■

    }
}
