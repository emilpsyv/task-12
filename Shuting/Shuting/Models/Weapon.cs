using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Shuting.Models
{
    internal class Weapon
    {
        public string WeaponName;
        private int _bulletCapacity;
        private int _bulletInComb;
        private double _dechargeTime;
        private string _fireMode;


        public int BulletCapacity 
        {
            get
            { 
                return _bulletCapacity;
            }
            set
            {
                if (value > 0) 
                {
                    _bulletCapacity = value;
                }
                else { Console.WriteLine("gulle menfi ola bilmez"); }

            }
        
        
        }

        public int BulletInComb 
        {
            get
            {
                return _bulletInComb;
            }
                
            set
            {  
                if (value > 0 && value < BulletCapacity)
                
                {
                    _bulletInComb = value;
                }
                else { Console.WriteLine("gulle sayi daragin tutumunnan cox ola bilmez"); }
            }
        }

        public double DechargeTime 
        {
            get
            {
                return _dechargeTime;
            }
            
            
            set
            {
                if (value > 0) 
                {
                    double time =  (_bulletCapacity / _bulletInComb);//bu hisse tam duz islemir 
                    _dechargeTime = time*(value);
                }
                else { Console.WriteLine("vaxt menvi ve ya 0 ola bilmez"); }
            }
        
        }

        public string FireMode 
        {
            get { return _fireMode; }


          
            set {
                if (value == "single")
                {
                    _fireMode = value;
                }
                else if (value == "auto")
                {
                    _fireMode = value;
                }
                else { Console.WriteLine("bele bir mod movcud deyil"); }
            
            }

            //buda ChangeFireModeki commite aiddir
            //set
            //{
            //  ChangeFireMode(value);
            //}


        }


        public Weapon(string name,int bulletCapacity, int bulletInComb, double dechargeTime, string fireMode)
        {
            WeaponName= name;
            BulletCapacity= bulletCapacity;
            BulletInComb= bulletInComb;
            DechargeTime = dechargeTime;
            FireMode = fireMode;
                

        }



        public void WeaponInfo() 
        {
            Console.WriteLine($"silah adi: {WeaponName}\ngulle tutumu: {_bulletCapacity}\nqalmis gulle sayi: {_bulletInComb}\ndaragin tam bosalma vaxti: {_dechargeTime} saniye\nates modu: {FireMode}    " );
        }
    
        public void Shoot()
        {
            if (_bulletInComb >0) 
            {
                _bulletInComb--;
                Console.WriteLine($"piu piu\nqalan gulle sayi: {_bulletInComb}");


            }
            else
            {
                Console.WriteLine("darag bosdur");
            }
        }

        public void Fire() 
        {
            if (_bulletInComb>0) 
            { 
                _bulletInComb=0;
                Console.WriteLine($"daragda qalmis gulle sayi: {_bulletInComb}\ndaragin bosalma vaxti: {_dechargeTime} saniye " );
                
            }
            else
            { Console.WriteLine("darag bosdur"); }
        }
        
        public int GetRemainBulletCount()
        {

            return _bulletCapacity - _bulletInComb;
        }

        public void Reload()
        {
            _bulletInComb= _bulletCapacity;
            Console.WriteLine(_bulletInComb);

        }

        public void ChangeFireMode()
        {
            Console.WriteLine("1.single\n2.auto\n1 veya 2 daxil edin");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {

                case 1:
                    Console.WriteLine("single ates modu secildi");
                    _fireMode = "single";
                    break;
                case 2:
                    Console.WriteLine("auto ates modu secildi");
                    _fireMode = "auto";
                    break;
            }



            //bunu tam duz qos ede bilmedim 
            //if (FireMode=="single")
            //{
            //    Shoot();
            //    Console.WriteLine($"Firing mode changed to {FireMode}.");
            //}
            //else if (FireMode=="auto")
            //{
            //    Fire();
            //    Console.WriteLine($"Firing mode changed to {FireMode}.");
            //}
            //else 
            //{
            //    Console.WriteLine("not correct mode");
            //}
        }

        public void T()
        {
            Console.WriteLine("yeni darag tutumun daxil edin");
            BulletCapacity = int.Parse(Console.ReadLine());
        }

        public void S()
        {
            Console.WriteLine("yeni gulle sayin daxil edin");
            BulletInComb= int.Parse(Console.ReadLine());

        }

        public void D()
        {
            Console.WriteLine("yeni gulle sifirlanma vaxtin daxil edin");
            DechargeTime = int.Parse(Console.ReadLine());
        }
        public void N()
        {
            Console.WriteLine("silahin yeni adin daxil edin");
            WeaponName = Console.ReadLine();
        }
























    }
    
}
