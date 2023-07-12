﻿using Timespinner.GameObjects.BaseClasses;
using TsRandomizer.Extensions;
using TsRandomizer.IntermediateObjects;
using TsRandomizer.Screens;

namespace TsRandomizer.LevelObjects.Other
{
	[TimeSpinnerType("Timespinner.GameObjects.Enemies.GyreKain")]
	class GyreKain : LevelObject<Monster>
	{
		public GyreKain(Monster typedObject, GameplayScreen gameplayScreen) : base(typedObject, gameplayScreen)
		{
		}

		//fix for enemizer to scale muschroom cloud with the mushroom tower its damage
		protected override void Initialize(Seed seed)
		{
			var scythe = (DamageArea)Dynamic._scythe;

			scythe.Power = TypedObject.Damage;
			scythe.AsDynamic()._baseDamage = TypedObject.Damage;
		}
	}
}
