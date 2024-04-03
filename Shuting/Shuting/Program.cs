using Shuting.Models;

namespace Shuting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon("akm", 30, 25, 10, "single");
            
           


            bool result = true;
            do
            {
                
                Console.Clear();
                Console.WriteLine(@"0 - İnformasiya
1 - Shoot metodu
2 - Fire metodu 
3 - Daragda gulle sayi 
4 - Reload 
5 - Ates modu 
6 - Proqrami dayandirmaq 
7 - Redakte et");
                int a=int.Parse(Console.ReadLine());
                if (a < 8)
                {

                    switch (a)
                    {
                        case 0:
                            weapon.WeaponInfo();

                            break;

                        case 1:
                            weapon.Shoot();
                            break;
                        case 2:
                            weapon.Fire();
                            break;
                        case 3:
                            weapon.GetRemainBulletCount();
                            break;
                        case 4:
                            weapon.Reload();
                            break;
                        case 5:
                            weapon.ChangeFireMode();
                            break;
                        case 6:
                            result = false;
                            break;
                        case 7:
                            Console.WriteLine(@"T - Tutumu deyis
S - Gülle sayin deyis
D - Sifirlama saniyesin deyis
N - Silahin adin deyis");
                            char Letter = char.Parse(Console.ReadLine());
                            switch (Letter)
                            {
                                case 'T':
                                    weapon.T();
                                    break;

                                case 'S':
                                    weapon.S();
                                    break;

                                case 'D':
                                    weapon.D();
                                    break;

                                case 'N':

                                    break;




                            }

                            break;

                    }
                    Console.WriteLine(@"





davam etmek ucun 'enter' duymesin basin ");
                    Console.ReadLine();













                }
                else 
                {
                    Console.WriteLine("menuda bele bir secim yoxdur,zehmet olmasa secimi duzgun edin");
                }
                Console.WriteLine("\ndavam etmek ucun 'enter' basin");
                Console.ReadLine();

            }
            while (result);














        }
    }
}