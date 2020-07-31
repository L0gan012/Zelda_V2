using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
using System.Collections.Generic;

namespace Sprint2
{
	public class SoundManager
	{
		private Dictionary<string, Song> musicContent;
		private Dictionary<string, SoundEffect> soundContent;

		public static SoundManager Instance { get; } = new SoundManager();

		private SoundManager()
		{
		}

		public void LoadAllSounds(ContentManager content)
		{
			soundContent = ImportContent.LoadListContent<SoundEffect>(content, "SoundFiles/SoundEffectFiles");
			musicContent = ImportContent.LoadListContent<Song>(content, "SoundFiles/MusicFiles");
		}

		public void PlayDefaultMusic()
        {
			MediaPlayer.Stop();
			MediaPlayer.Play(musicContent["04 Labyrinth"]);
			MediaPlayer.IsRepeating = true;
		}

		public void PlayIntroMusic()
		{
			MediaPlayer.Stop();
			MediaPlayer.Play(musicContent["01 Intro"]);
			MediaPlayer.IsRepeating = true;
		}

		public void PlayDungeonMusic()
        {
			MediaPlayer.Stop();
			MediaPlayer.Play(musicContent["04 Labyrinth"]);
			MediaPlayer.IsRepeating = true;
        }

		public void PlayGerudoValleyOOTMusic()
		{
			MediaPlayer.Stop();
			MediaPlayer.Play(musicContent["Gerudo Valley - The Legend of Zelda Ocarina Of Time"]);
			MediaPlayer.IsRepeating = true;
		}

		public void PlayLostWoodsOOTMusic()
		{
			MediaPlayer.Stop();
			MediaPlayer.Play(musicContent["Lost Woods - The Legend of Zelda Ocarina Of Time"]);
			MediaPlayer.IsRepeating = true;
		}

		public void PlayPrincessZeldaTimeOOTMusic()
		{
			MediaPlayer.Stop();
			MediaPlayer.Play(musicContent["Princess Zelda - The Legend of Zelda Ocarina of Time"]);
			MediaPlayer.IsRepeating = true;
		}

		public void PlayDragonRoostIslandWindWakerMusic()
		{
			MediaPlayer.Stop();
			MediaPlayer.Play(musicContent["Dragon Roost Island (Original Version) - The Legend of Zelda The Wind Waker"]);
			MediaPlayer.IsRepeating = true;
		}

		public void PlayGreatFairyFountainOOTMusic()
		{
			MediaPlayer.Stop();
			MediaPlayer.Play(musicContent["Great Fairy's Fountain - The Legend of Zelda Ocarina of Time"]);
			MediaPlayer.IsRepeating = true;
		}

		public void PlayHyruleFieldOOTMusic()
		{
			MediaPlayer.Stop();
			MediaPlayer.Play(musicContent["Hyrule Field - The Legend of Zelda Ocarina Of Time"]);
			MediaPlayer.IsRepeating = true;
		}

		public void PlayKakarikoVillageOOTMusic()
		{
			MediaPlayer.Stop();
			MediaPlayer.Play(musicContent["Kakariko Village - The Legend of Zelda Ocarina of Time"]);
			MediaPlayer.IsRepeating = true;
		}

		public void PlayLoruleCastleALinkBetweenWorldsMusic()
		{
			MediaPlayer.Stop();
			MediaPlayer.Play(musicContent["Lorule Castle - The Legend of Zelda A Link Between Worlds"]);
			MediaPlayer.IsRepeating = true;
		}

		public void PlayBOTWThemeMusic()
		{
			MediaPlayer.Stop();
			MediaPlayer.Play(musicContent["The Legend of Zelda Breath of the Wild - Theme (SoundTrack)"]);
			MediaPlayer.IsRepeating = true;
		}

		public void PlayMidnasLamentTwilightPrincessMusic()
		{
			MediaPlayer.Stop();
			MediaPlayer.Play(musicContent["Midna's Lament - The Legend of Zelda Twilight Princess"]);
			MediaPlayer.IsRepeating = true;
		}

		public void PlayWindWakerThemeMusic()
		{
			MediaPlayer.Stop();
			MediaPlayer.Play(musicContent["Wind Waker Theme [FULL]"]);
			MediaPlayer.IsRepeating = true;
		}

		public void PlayZeddLegendOfZeldaHDMusic()
		{
			MediaPlayer.Stop();
			MediaPlayer.Play(musicContent["Zedd - The Legend of Zelda (Original Mix) HD"]);
			MediaPlayer.IsRepeating = true;
		}

		public void PlayPickUpTriforcePieceMusic()
        {
			MediaPlayer.Stop();
			MediaPlayer.Play(musicContent["06 Triforce"]);
			MediaPlayer.IsRepeating = false;
        }

		public void PlayLinkDeathMusic()
        {
			MediaPlayer.Stop();
			MediaPlayer.Play(musicContent["07 Game Over"]);
			MediaPlayer.IsRepeating = false;
        }

		//Likely obsolete since multiple fx can now play simultaneously.
		public void PlaySwordSlashAndShoot()
        {
			soundContent["LOZ_Sword_Combined"].Play();
        }

		public void PlayPickUpKey()
        {
			soundContent["LOZ_Get_Heart"].Play();
        }

		public void PlayPickUpHeart()
		{
			soundContent["LOZ_Get_Heart"].Play();
		}

		public void PlaySwordSlash()
		{
			soundContent["LOZ_Sword_Slash"].Play();
		}

		public void PlaySwordShoot()
		{
			soundContent["LOZ_Sword_Shoot"].Play();
		}

		public void PlayShieldDeflect()
		{
			soundContent["LOZ_Shield"].Play();
		}

		public void PlayArrowShoot()
		{
			soundContent["LOZ_Arrow_Boomerang"].Play();
		}

		public void PlayBombPlace()
		{
			soundContent["LOZ_Bomb_Drop"].Play();
		}

		public void PlayBombExplode()
		{
			soundContent["LOZ_Bomb_Blow"].Play();
		}

		public void PlayCandleUse()
		{
			soundContent["LOZ_Candle"].Play();
		}

		public void PlayEnemyHit()
		{
			soundContent["LOZ_Enemy_Hit"].Play();
		}

		public void PlayEnemyDie()
		{
			soundContent["LOZ_Enemy_Die"].Play();
		}

		public void PlayLinkHit()
		{
			soundContent["LOZ_Link_Hurt"].Play();
		}

		//This one is tacked onto the beginning of the music file for GameOver
		public void PlayLinkDie()
		{
			//soundContent["LOZ_Link_Die"].Play();
		}

		public void PlayGetHeart()
		{
			soundContent["LOZ_Get_Heart"].Play();
		}

		public void PlayFairyAppear()
		{
			soundContent["LOZ_Get_Item"].Play();
		}

		public void PlayFairyPickUp()
		{
			soundContent["LOZ_Get_Item"].Play();
		}

		public void PlayInventoryItemPickUp()
		{
			soundContent["LOZ_Get_Item"].Play();
		}

		public void PlayEquipmentItemPickUp()
		{
			soundContent["LOZ_Fanfare"].Play();
		}

		public void PlayRupeePickUp()
		{
			soundContent["LOZ_Get_Rupee"].Play();
		}

		public void PlayKeyAppear()
		{
			soundContent["LOZ_Key_Appear"].Play();
		}

		public void PlayDoorStateChange()
		{
			soundContent["LOZ_Door_Unlock"].Play();
		}

		public void PlayAquamentusScream()
		{
			soundContent["LOZ_Boss_Scream1"].Play();
		}

		public void PlayAquamentusHurt()
		{
			soundContent["LOZ_Boss_Hit"].Play();
		}
		public void PlayUseStairs()
		{
			soundContent["LOZ_Stairs"].Play();
		}

		public void PlayFoundSecret()
		{
			soundContent["LOZ_Secret"].Play();
		}


		//The following are not yet tested.  Test them before plugging into project.
		public void PlayBoomerangFlyingLooped()
		{
			SoundEffectInstance soundEffectInstance = soundContent["LOZ_Arrow_Boomerang"].CreateInstance();
			soundEffectInstance.IsLooped = true;
			soundEffectInstance.Play();
		}

		public void PlayLowHealthBeepLooped()
		{
			SoundEffectInstance soundEffectInstance = soundContent["LOZ_LowHealth"].CreateInstance();
			soundEffectInstance.IsLooped = true;
			soundEffectInstance.Play();
		}

		public void PlayFillHeartMeterLooped()
		{
			SoundEffectInstance soundEffectInstance = soundContent["LOZ_Refill_Loop"].CreateInstance();
			soundEffectInstance.IsLooped = true;
			soundEffectInstance.Play();
		}

		public void PlayChangeRupeeCountLooped()
		{
			SoundEffectInstance soundEffectInstance = soundContent["LOZ_Refill_Loop"].CreateInstance();
			soundEffectInstance.IsLooped = true;
			soundEffectInstance.Play();
		}
	}
}
