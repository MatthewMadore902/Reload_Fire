using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reload_Fire
{
	class Program
	{
		int weapon = 0;
		static int[] ammo = new int[4];
		static string[] weaponName = new string[4];
		static int[] maxAmmo = new int[4];

		static void Main(string[] args)
		{
			Console.WriteLine("Reload and Fire");
			Console.WriteLine("-----------------------");
			Console.WriteLine();


			ammo[0] = 12;
			ammo[1] = 20;
			ammo[2] = 150;
			ammo[3] = 50;

			maxAmmo[0] = 6;
			maxAmmo[1] = 4;
			maxAmmo[2] = 50;
			maxAmmo[3] = 25;

			weaponName[0] = "pistol";
			weaponName[1] = "shotGun";
			weaponName[2] = "miniGun";
			weaponName[3] = "Lazer";

			Fire();
			Reload();
			Console.ReadKey();

		}

		static void Reload()
		{
			if (ammo[0] == 0)
			{
				ammo[0] = ammo[0] + 6;
				maxAmmo[0] = maxAmmo[0] - 6;

			}
			if (ammo[1] == 0)
			{
				ammo[1] = ammo[1] + 4;
				maxAmmo[1] = maxAmmo[1] - 4;
			}
			if (ammo[2] == 0)
			{
				ammo[2] = ammo[2] + 50;
				maxAmmo[2] = maxAmmo[2] - 50;
			}
			if (ammo[3] == 0)
			{
				ammo[3] = ammo[3] + 25;
				maxAmmo[3] = maxAmmo[3] - 25;
			}
		}


		static void Fire()
		{

			ammo[0] = ammo[0] - 1;

		}

/*		static void ChangeWeapon()
		{
			//System.Random random = new System.Random();
			//currentWeapon = Convert.ToString(random.Next(1, 6));
			Console.WriteLine("You Find  Weapon Box What Will You Pick?, Pick a number from 1 to 6 : ");
			string Weapon = Console.ReadLine();

			if (Weapon == "1")
			{
				currentWeapon = Pistol;
			}
			if (Weapon == "2")
			{
				currentWeapon = ShotGun;
			}
			if (Weapon == "3")
			{

				currentWeapon = Rocket;
			}

		}
*/
}
