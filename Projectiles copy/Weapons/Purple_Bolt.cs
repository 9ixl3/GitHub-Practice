using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Test.Projectiles.Weapons
{
	internal class Purple_Bolt : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Book of Death"); 
			// By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
		}

		public override void SetDefaults()
		{
			Projectile.width = 20;
			Projectile.height = 20;
			Projectile.friendly = true;
			Projectile.tileCollide = false;
			Projectile.ignoreWater = true;

			Projectile.DamageType = DamageClass.Magic;
			Projectile.aiStyle = -1;
			Projectile.penetrate = -1;

		}
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
			// Add the Onfire buff to the NPC for 1 second when the weapon hits an NPC
			// 60 frames = 1 second
			target.AddBuff(BuffID.ShadowFlame, 300);
		}

		public override void AI()
		{
			Projectile.ai[0]++;
			if(Projectile.ai[0] < 60f)
			{
				Projectile.velocity *= 1.01f;
			}
			else
			{
				Projectile.velocity *= 1.05f;
				if(Projectile.ai[0] >= 180)
				{
					Projectile.Kill();
				}
			}
			float rotateSpeed = 0.35f * (float)Projectile.direction;
			Projectile.rotation += rotateSpeed;
			Lighting.AddLight(Projectile.Center, 0.75f, 0.75f, 0.75f);
			if(Main.rand.NextBool(2))
			{
				int numToSpawn = Main.rand.Next(3);
				for(int i = 0; i < numToSpawn; i++)
				{
					Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, ModContent.DustType<Purple_Dust>(),
					 Projectile.velocity.X * 0.1f, Projectile.velocity.Y * 0.1f, 0, default(Color), 1f);
				}
			}
		}

	}
}