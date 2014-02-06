//--- Aura Script -----------------------------------------------------------
//  Wandering Creature AI
//--- Description -----------------------------------------------------------
//  Dummy AI for monsters, makes them wander around.
//---------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Aura.Channel.Network.Sending;
using Aura.Channel.Scripting.Scripts;
using Aura.Channel.World;
using Aura.Channel.World.Entities;
using Aura.Shared.Mabi;
using Aura.Shared.Util;

public class WanderingCreatureAI : AiScript
{
	protected override IEnumerable Idle()
	{
		Do(Wander());
		Do(Wait(5000, 10000));
	}
}
