using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeUAA14Partie2_dec23_AjdiniSefedin
{
    internal class PaintBallGun
    {
        
        private int _nombreDeBallesExterieur = 30;
        private int _nombreDeBallesInterrieur = 0;
        private string _armeVide = "";
        private int _armeDoitEtreRecharger = 14 ;
        private int _taillleChargeur = 16;

        public int NombreDeBallesExterieur
        {
            get { return _nombreDeBallesExterieur; }
            set { _nombreDeBallesExterieur = value; }
        }

        public int NombreDeBallesInterrieur
        {
            get { return _nombreDeBallesInterrieur; }
            set { _nombreDeBallesInterrieur = value; }
        }

        public string ArmeVide
        {
            get { return _armeVide; }
            set { _armeVide = value; }
        }

        public int ArmeDoitEtreRecharger
        {
            get { return _armeDoitEtreRecharger; }
            set { _armeDoitEtreRecharger = value; }
        }

        public int TaillleChargeur
        {
            get { return _taillleChargeur; }
            set { _taillleChargeur = value; }
        }

        public PaintBallGun(int nombreDeBallesExterieur, int nombreDeBallesInterrieur, string armeVide, int armeDoitEtreRecharger, int taillleChargeur)
        {
            _nombreDeBallesExterieur = nombreDeBallesExterieur;
            _nombreDeBallesInterrieur = nombreDeBallesInterrieur;
            _armeVide = armeVide;
            _armeDoitEtreRecharger = armeDoitEtreRecharger;
            _taillleChargeur = taillleChargeur;
        }

        public string Tirer()
        {
            if (_nombreDeBallesInterrieur > 0 && _nombreDeBallesInterrieur < 30)
            {
                NombreDeBallesInterrieur -= 1;
                Console.WriteLine("Tir effectuer !");
            }
            return "Vous avez un total de " + _nombreDeBallesExterieur + " balles dans votre poche et " + _nombreDeBallesInterrieur + " balles dans le chargeur";
        }

        public string Recharger()
        {
            if (_nombreDeBallesExterieur < 0)
            {
                Console.WriteLine("Plus de munitions");
            }
            else
            {
                _nombreDeBallesInterrieur = _nombreDeBallesExterieur -= _armeDoitEtreRecharger;
                _nombreDeBallesInterrieur += _nombreDeBallesInterrieur = -2;
                Console.WriteLine("Recharge effectuer");
            }
   
            return "recharge de " + _nombreDeBallesInterrieur  + " dans le chargeur";
        }
        public string ArmeSansBalle()
        {
            return "Attention votre chargeur et vide";
        }

        public string TotalBall()
        {
            return "Vous avez un total de " + _nombreDeBallesExterieur + " balles dans votre poche et " + _nombreDeBallesInterrieur + " balles dans votre chargeur";
        }

        public string ReprendreMunitions()
        {
            if (_nombreDeBallesExterieur <= 0)
            {
                _nombreDeBallesExterieur += 30;
            }
            if (_nombreDeBallesExterieur >= 0)
            {
                Console.WriteLine("Vous avez encore des munitions !");
            }
            return "Voici les munitions : " + _nombreDeBallesExterieur + " balles dans votre poche, ne les usez pas trop vite.";
        }
    }
}
